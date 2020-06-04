using System;
using System.Collections.Generic;

namespace Millionare
{
    public class MainWindowPresenter
    {
        private readonly MainModel _model;
        private readonly MainWindowForm _view;
        private GameLogics gameLogics;

        public List<MainModel.Gamedata> Gamedata
        {
            get { return _model.GetListgamedata(); }
        }

        public MainWindowPresenter(MainWindowForm view, MainModel model)
        {
            _model = model;
            _view = view;
            _view.OnStart += new EventHandler<EventArgs>(OnStart);
            _view.OnAnswer += new EventHandler<EventArgs>(OnAnswer);
            _view.OnNextLevel += new EventHandler<EventArgs>(OnNextLevel);
            _view.OnTips += new EventHandler<EventArgs>(OnTipsEvent);
            if (_model.GetListgamedata().Count < 15)
                _view.AdminModeOnly();
        }

        private void OnTipsEvent(object sender, EventArgs e)
        {
            gameLogics.TipsDo(_view.Tipsindex);
            switch(_view.Tipsindex)
            {
                case 1:
                    _view.On5050(gameLogics.tip5050);
                    break;
                case 2:
                    _view.OnAuditoryHelp(gameLogics.TipZalHelp);
                    break;
                case 3:
                    _view.Tipsindex = gameLogics.Tip501;
                    _view.OnFriendCall();
                    break;
            }            
        }

        private void OnStart(object sender, EventArgs e)
        {  
                gameLogics = new GameLogics(_model.GetListgamedata());
                _view.Score = 0;            
            OnNextLevel(sender, e);   
        }


        private void OnNextLevel(object sender, EventArgs e)
        {
            gameLogics.GetLevel();
            UpdateView();
        }

        private void OnAnswer(object sender, EventArgs e)
        {
            if (gameLogics.QuestionsCurrentPlace[0] == _view.AnswerIndex)
            {
                gameLogics.CurrentMoneyCalc();
                _view.Score = gameLogics.CurrentMoneyCount;
                _view.ShowRightAnswer(gameLogics.QuestionsCurrentPlace[0], true); }
            else
            {
                gameLogics.CurrentMoneyCalc();
                _view.Score = gameLogics.NonDeletedMoney;
                _view.ShowRightAnswer(gameLogics.QuestionsCurrentPlace[0], false);
                _view.OnWrong();
            }
        }

        private void UpdateView()
        {
            _view.Question = gameLogics.GetCurrentQuestion[0];
           for(int i = 0; i < 4; i++)
            {
                switch (gameLogics.QuestionsCurrentPlace[i])
                {
                    case 1:
                        _view.Answer_A = gameLogics.GetCurrentQuestion[i + 1];
                        break;
                    case 2:
                        _view.Answer_B = gameLogics.GetCurrentQuestion[i + 1];
                        break;
                    case 3:
                        _view.Answer_C = gameLogics.GetCurrentQuestion[i + 1];
                        break;
                    case 4:
                        _view.Answer_D = gameLogics.GetCurrentQuestion[i + 1];
                        break;
                }
            }
        }
    }

    class GameLogics
    {
        
        private List<MainModel.Gamedata> Gamedatalist;
        private List<MainModel.Gamedata> CurrentLevellist;
        private List<int> currentquestions;

        public string[] GetCurrentQuestion { get; set; }
        public int currentQuestionLevel { get; set; }
        public int currentquestionIndex { get; set; }
        public int[] QuestionsCurrentPlace { get; private set; }
        public int[] tip5050 { get; private set; }
        public int CurrentMoneyCount { get; set; }
        public int NonDeletedMoney { get; set; }
        public int Tip501 { get; private set; }
        public int[] TipZalHelp { get; private set; }
        Random random;
        public GameLogics(List<MainModel.Gamedata> glist)
        {
            Gamedatalist = glist;
            CurrentLevellist = new List<MainModel.Gamedata>();
            currentquestions = new List<int>();
            currentquestionIndex = 0;
            currentQuestionLevel = 0;
            QuestionsCurrentPlace = new int[4];
            tip5050 = new int[3] { 0, 0, 0 };
            TipZalHelp = new int[] { 0, 0, 0, 0 };
            random = new Random();
        }

        public void TipsDo(int idx)
        {
            if(idx == 1)
            {//make 50/50
                int one = 0;
                int two = 0;
                while(one == two)
                {
                    one = random.Next(1, 3);
                    two = random.Next(1, 3);
                }
                tip5050[0] = QuestionsCurrentPlace[one];
                tip5050[1] = QuestionsCurrentPlace[two];
                tip5050[2] = currentquestionIndex;
            }
            else if(idx == 2)
            {//make auditory help
                for(int i = 0; i < 4; i++)
                TipZalHelp[i] = random.Next(3, 90);
                TipZalHelp[QuestionsCurrentPlace[0] - 1] = (80 + random.Next(1, 20));                
                if (currentquestionIndex > 5 && currentquestionIndex <= 10)
                {
                    if(random.Next(0, 1) == 0)//may right chance 50/50
                    for (int i = 0; i < 4; i++)
                        TipZalHelp[i] = random.Next(0, random.Next(30, 70));
                }
                else if(currentquestionIndex > 10)
                    if(random.Next(0, 5) != 2)//may right answer, chance 1 of 4
                        for (int i = 0; i < 4; i++)
                            TipZalHelp[i] = random.Next(5, random.Next(10, 60));
                if (tip5050[2] != 0 && tip5050[2] == currentquestionIndex)
                {//if was 50/50
                    TipZalHelp[tip5050[0] - 1] = 0;
                    TipZalHelp[tip5050[1] - 1] = 0;
                }
            }
            else if(idx == 3)
            {//make friend call
                if (currentquestionIndex <= 5)
                    Tip501 = QuestionsCurrentPlace[0]; //right answer
                else
                {
                    Tip501 = QuestionsCurrentPlace[random.Next(0, 3)];
                    if (tip5050[2] != 0 && tip5050[2] == currentquestionIndex)//if was 50/50
                        while (tip5050[0] == Tip501 || tip5050[1] == Tip501)                        
                            Tip501 = QuestionsCurrentPlace[random.Next(0, 3)];
                        
                    if(currentquestionIndex >= 10)                    
                        if (random.Next(0, 4) != 2)//right answer chance one of 4
                        { Tip501 = 0; return; }                    
                }
            }
        }

        public void GetLevel()
        {
            currentquestionIndex++;
            SetCurrentQuestionLevel();
            GetcurrentQuestionLevelList();
            GenerateCurrentQuestion();
            GenerateQuestionsPlace();
        }

        public void CurrentMoneyCalc()
        {
            switch (currentquestionIndex)
            {
                case 1:
                    CurrentMoneyCount = 100;
                    break;
                case 2:
                    CurrentMoneyCount = 200;
                    break;
                case 3:
                    CurrentMoneyCount = 300;
                    break;
                case 4:
                    CurrentMoneyCount = 500;
                    break;
                case 5:
                    CurrentMoneyCount = 1000;
                    NonDeletedMoney = 1000;
                    break;
                case 6:
                    CurrentMoneyCount = 2000;
                    break;
                case 7:
                    CurrentMoneyCount = 4000;
                    break;
                case 8:
                    CurrentMoneyCount = 8000;
                    break;
                case 9:
                    CurrentMoneyCount = 16000;
                    break;
                case 10:
                    CurrentMoneyCount = 32000;
                    NonDeletedMoney = 32000;
                    break;
                case 11:
                    CurrentMoneyCount = 64000;
                    break;
                case 12:
                    CurrentMoneyCount = 128000;
                    break;
                case 13:
                    CurrentMoneyCount = 256000;
                    break;
                case 14:
                    CurrentMoneyCount = 500000;
                    break;
                case 15:
                    CurrentMoneyCount = 1000000;
                    NonDeletedMoney = 1000000;
                    break;
            }
        }
        public  void GetcurrentQuestionLevelList()
        {
            CurrentLevellist.Clear();
            foreach (MainModel.Gamedata item in Gamedatalist)
            {
                if (currentQuestionLevel == int.Parse(item.GroupList))
                    CurrentLevellist.Add(item);
            }
        }

        void SetCurrentQuestionLevel()
        {
            if (currentquestionIndex >= 0 && currentquestionIndex <= 3)
                currentQuestionLevel = 0;
            else if (currentquestionIndex >= 4 && currentquestionIndex <= 6)
                currentQuestionLevel = 1;
            else if (currentquestionIndex >= 7 && currentquestionIndex <= 10)
                currentQuestionLevel = 2;
            else if (currentquestionIndex >= 11 && currentquestionIndex <= 13)
                currentQuestionLevel = 3;
            else if (currentquestionIndex >= 14 && currentquestionIndex <= 15)
                currentQuestionLevel = 4;
            if (currentquestionIndex == 4 || currentquestionIndex == 7 || currentquestionIndex == 11 || currentquestionIndex == 14)
                currentquestions.Clear();
        }

        void  GenerateCurrentQuestion()
        {
            bool isExistquestion = false;

            while (true)
            {
                int rnd = random.Next(0, CurrentLevellist.Count - 1);
                foreach(int item in currentquestions)
                {
                    if (rnd == item)
                        isExistquestion = true;
                }
                if (!isExistquestion)
                { currentquestions.Add(rnd); GetCurrentQuestion = new string[] { CurrentLevellist[rnd].Question, CurrentLevellist[rnd].VarA, CurrentLevellist[rnd].VarB, CurrentLevellist[rnd].VarC, CurrentLevellist[rnd].VarD }; return; }
                else
                    isExistquestion = false;
            }
        }

        void GenerateQuestionsPlace()
        {
            QuestionsCurrentPlace = new int[] { 0,0,0,0};
            int rnd = 0, index = 0, max = 4;
            while(index < 4)
            {
                bool isExist = false;
                rnd = random.Next(max) + 1;
                for (int i = 0; i < max; i++)
                    if (QuestionsCurrentPlace[i] == rnd)
                        isExist = true;
                if(!isExist)
                {                    
                    QuestionsCurrentPlace[index] = rnd;
                    index++;                    
                }
            }            
        }


    }

}
