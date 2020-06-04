using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionare
{
    public partial class MainWindowForm : Form
    {
        MainModel mainmodel;
        public event EventHandler<EventArgs> OnStart;
        public event EventHandler<EventArgs> OnAnswer;
        public event EventHandler<EventArgs> OnNextLevel;
        public event EventHandler<EventArgs> OnTips;
        public MainWindowForm(MainModel mainModel)
        {
            InitializeComponent();
            mainmodel = mainModel;
            labelTip.BackColor = Color.FromArgb(200, Color.MidnightBlue);
            labelA.BackColor = Color.FromArgb(200, Color.MidnightBlue);
            labelB.BackColor = Color.FromArgb(200, Color.MidnightBlue);
            labelC.BackColor = Color.FromArgb(200, Color.MidnightBlue);
            labelD.BackColor = Color.FromArgb(200, Color.MidnightBlue);
            OnStopGame();
            if (File.Exists(@"sound\begin.wav"))
            {
                var soundPlayer = new System.Media.SoundPlayer(@"sound\begin.wav");
                soundPlayer.Play();
            }   
            
        }
        public int Score { get; set; }
        const int ScorePositionY = 322;
        static int Yshift = 0;

        public string Question
        {
            get { return buttonStartQuestion.Text; }
            set { buttonStartQuestion.Text = value; }
        }
        public string Answer_A
        {
            get { return buttonA.Text; }
            set { buttonA.Text = value; }
        }

        public string Answer_B
        {
            get { return buttonB.Text; }
            set { buttonB.Text = value; }
        }

        public string Answer_C
        {
            get { return buttonC.Text; }
            set { buttonC.Text = value; }
        }
        public string Answer_D
        {
            get { return buttonD.Text; }
            set { buttonD.Text = value; }
        }

        public int AnswerIndex { get; set; }
        public int Tipsindex { get; set; }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            if (form.ShowDialog(this) == DialogResult.OK)
                form.Close();
        }

         
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdminForm adminForm = new AdminForm();
            AdminEditPresenter aepresenter = new AdminEditPresenter(adminForm, mainmodel);
            
            LoginForm login = new LoginForm();
            LoginPresenter loginPresenter = new LoginPresenter(login, mainmodel);
            if (login.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Поздравляю вы администратор", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminForm.ShowDialog(this);
                if (adminForm.DialogResult == DialogResult.OK)
                    adminForm.Close();
            }
         
        }

        private void StartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonStartQuestion_Click(sender, e);
        }

        private void StopGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonExitGame_Click(sender, e);
        }

        private void TakeMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonTakeMoney_Click(sender, e);
        }

        private void button5050_Click(object sender, EventArgs e)
        {
            button5050.BackgroundImage = Properties.Resources.marksmall;
            button5050.Enabled = false;
            Tipsindex = 1;
            if (File.Exists(@"sound\tip5050.wav"))
                new System.Media.SoundPlayer(@"sound\tip5050.wav").Play();            
            OnTips?.Invoke(this, EventArgs.Empty);
            Thread.Sleep(1500);
            if (File.Exists(@"sound\duma2.wav"))
                new System.Media.SoundPlayer(@"sound\duma2.wav").Play();
        }

        private void buttonZal_Click(object sender, EventArgs e)
        {
            buttonZal.BackgroundImage = Properties.Resources.marksmall;
            buttonZal.Enabled = false;
            if (File.Exists(@"sound\zal.wav"))
                new System.Media.SoundPlayer(@"sound\zal.wav").Play();
            Thread.Sleep(3500);
            Tipsindex = 2;
            OnTips?.Invoke(this, EventArgs.Empty);
            Thread.Sleep(2500);
            if (File.Exists(@"sound\duma2.wav"))
                new System.Media.SoundPlayer(@"sound\duma2.wav").Play();
        }

       
        

        private void buttonZvonok_Click(object sender, EventArgs e)
        {
            buttonZvonok.BackgroundImage = Properties.Resources.marksmall;
            buttonZvonok.Enabled = false;
            if (File.Exists(@"sound\zvonok.wav"))
                new System.Media.SoundPlayer(@"sound\zvonok.wav").Play();
            Tipsindex = 3;
            Thread.Sleep(2500);
            OnTips?.Invoke(this, EventArgs.Empty);
            Thread.Sleep(1500);
            if (File.Exists(@"sound\duma2.wav"))
                new System.Media.SoundPlayer(@"sound\duma2.wav").Play();
        }

        private void buttonTakeMoney_Click(object sender, EventArgs e)
        {
            TakeMoney takemoneyform;
            if (Gameisrun && Score > 0)
            { takemoneyform = new TakeMoney();
                if (File.Exists(@"sound\winner.wav"))
               new System.Media.SoundPlayer(@"sound\winner.wav").Play();
                OnStopGame();
            }
            else
                takemoneyform = new TakeMoney(false);
            takemoneyform.Money = Score;
            TakeMoneyPresenter moneyPresenter = new TakeMoneyPresenter(takemoneyform);
            takemoneyform.ShowDialog(this);         

        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            if (Gameisrun)
            {
                if (File.Exists(@"sound\summa.wav"))
                    new System.Media.SoundPlayer(@"sound\summa.wav").Play();
                OnStopGame();
            }
        }
        private void buttonA_Click(object sender, EventArgs e)
        {            
            OnAnswerpress('A');            
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            OnAnswerpress('B');
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            OnAnswerpress('C');
        }

       

        private void buttonD_Click(object sender, EventArgs e)
        {
            OnAnswerpress('D');
        }

        bool Gameisrun = false;
        private void buttonStartQuestion_Click(object sender, EventArgs e)
        {
            if (!Gameisrun)
            {
                if (File.Exists(@"sound\duma.wav"))
                    new System.Media.SoundPlayer(@"sound\duma.wav").Play();
                OnStartGame();
            }
        }

        

        
   
        private void OnAnswerpress(char press)
        {
            

            if (AnswerButtonsEnabled)
            {
                AnswerButtonsEnabled = false;
                
                switch (press)
                {
                    case 'A':
                        buttonA.BackgroundImage = Properties.Resources.TryA;
                        buttonA.Refresh();
                        AnswerIndex = 1;
                        break;
                    case 'B':
                        buttonB.BackgroundImage = Properties.Resources.TryB;
                        buttonB.Refresh();
                        AnswerIndex = 2;
                        break;
                    case 'C':
                        buttonC.BackgroundImage = Properties.Resources.TryC;
                        buttonC.Refresh();
                        AnswerIndex = 3;
                        break;
                    case 'D':
                        buttonD.BackgroundImage = Properties.Resources.TryD;
                        buttonD.Refresh();
                        AnswerIndex = 4;              
                        
                        break;
                }
                if (File.Exists(@"sound\gong.wav"))
                    new System.Media.SoundPlayer(@"sound\gong.wav").Play();
                Thread.Sleep(3000);
                OnAnswer?.Invoke(this, EventArgs.Empty);
            }
        }

        public void ShowRightAnswer(int idx, bool isright)
        {
            if (isright)
            {
                if (File.Exists(@"sound\true.wav"))
                    new System.Media.SoundPlayer(@"sound\true.wav").Play();
            }
            else if (File.Exists(@"sound\false.wav"))
                new System.Media.SoundPlayer(@"sound\false.wav").Play();

            for (int i = 0; i < 3; ++i)
            {
                Thread.Sleep(500);
                switch (idx)
                {
                    case 1:
                        buttonA.BackgroundImage = Properties.Resources.RightA;
                        buttonA.Refresh();
                        break;
                    case 2:
                        buttonB.BackgroundImage = Properties.Resources.RightB;
                        buttonB.Refresh();
                        break;
                    case 3:
                        buttonC.BackgroundImage = Properties.Resources.RightC;
                        buttonC.Refresh();
                        break;
                    case 4:
                        buttonD.BackgroundImage = Properties.Resources.RightD;
                        buttonD.Refresh();
                        break;
                }
                Thread.Sleep(500);
                buttonA.BackgroundImage = null;  buttonA.Refresh();
                buttonB.BackgroundImage = null;  buttonB.Refresh();
                buttonC.BackgroundImage = null;  buttonC.Refresh();
                buttonD.BackgroundImage = null;  buttonD.Refresh();

            }
            Thread.Sleep(500);
            if (isright)
                OnRight();
        }

        bool AnswerButtonsEnabled = false;
        public void OnStartGame()
        {
            Gameisrun = true;
            Score = 0;
            button5050.Enabled = true;
            buttonZvonok.Enabled = true;
            buttonZal.Enabled = true;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            AnswerButtonsEnabled = true;
            StartGameToolStripMenuItem.Enabled = false;
            StopGameToolStripMenuItem.Enabled = true;
            AdminToolStripMenuItem.Enabled = false;
            labelScore.BackColor = System.Drawing.Color.FromArgb(50, 0, 255, 0);
            labelScore.Location = new System.Drawing.Point(787, ScorePositionY + Yshift);
            Yshift -= 20;
            OnStart?.Invoke(this, EventArgs.Empty);
        }

        public void OnStopGame()
        {
            Gameisrun = false;
            buttonStartQuestion.Text = "Для начала игры тыкните здесь";
            buttonA.Text = null; buttonB.Text = null; buttonC.Text = null; buttonD.Text = null;
            button5050.BackgroundImage = null; buttonZvonok.BackgroundImage = null; buttonZal.BackgroundImage = null;
            AnswerButtonsEnabled = false;
            buttonZal.Enabled = false;
            button5050.Enabled = false;
            buttonZvonok.Enabled = false;
            TipsShow(false);
            AdminToolStripMenuItem.Enabled = true;
            StartGameToolStripMenuItem.Enabled = true;
            StopGameToolStripMenuItem.Enabled = false;
            labelScore.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            Yshift = 0;
        }

        public void OnRight()
        {           
            TipsShow(false);
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            if (Score != 1000000)
            {
                labelScore.Enabled = true;
                labelScore.Location = new System.Drawing.Point(787, ScorePositionY + Yshift);
                Yshift -= 20;
                OnNextLevel?.Invoke(this, EventArgs.Empty);
                if (File.Exists(@"sound\duma.wav"))
                    new System.Media.SoundPlayer(@"sound\duma.wav").Play();
                AnswerButtonsEnabled = true;
            }
            else
            {
                buttonTakeMoney_Click(this, EventArgs.Empty);
                OnStopGame(); }           

        }

        public void OnWrong()
        {            
            Thread.Sleep(1000);
            if (Score >= 1000)
                buttonTakeMoney_Click(this, EventArgs.Empty);
            OnStopGame();
        }

        public void On5050(int[] remove)
        {
            for (int i = 0; i < 2; i++)
            {
                switch (remove[i])
                {
                    case 1:
                        buttonA.Text = null;
                        buttonA.Enabled = false;
                        break;
                    case 2:
                        buttonB.Text = null;
                        buttonB.Enabled = false;
                        break;
                    case 3:
                        buttonC.Text = null;
                        buttonC.Enabled = false;
                        break;
                    case 4:
                        buttonD.Text = null;
                        buttonD.Enabled = false;
                        break;
                }
            }
        }

        public void OnFriendCall()
        {
            if (Tipsindex != 0)
            {
                char answer = 'A';
                switch(Tipsindex)
                {
                    case 1:
                        answer = 'A';
                        break;
                    case 2:
                        answer = 'B';
                        break;
                    case 3:
                        answer = 'C';
                        break;
                    case 4:
                        answer = 'D';
                        break;
                }
                switch (new Random().Next(1, 4))
                {
                    case 1:
                        labelTip.Text = "Я считаю это ответ " + answer;
                        break;
                    case 2:
                        switch(answer)
                        {
                            case 'A':
                                labelTip.Text = "Думаю это " + Answer_A;
                                break;
                            case 'B':
                                labelTip.Text = "Думаю это " + Answer_B;
                                break;
                            case 'C':
                                labelTip.Text = "Думаю это " + Answer_C;
                                break;
                            case 'D':
                                labelTip.Text = "Думаю это " + Answer_D;
                                break;
                        }                       
                        break;
                    case 3:
                        labelTip.Text = "Наверно вариант " + answer;
                        break;
                    case 4:
                        labelTip.Text = "Скорее всего будет " + answer;
                        break;
                }

            }
            else
                switch(new Random().Next(1, 4))
                {
                    case 1:
                        labelTip.Text = "Я подумал но я не знаю";
                        break;
                    case 2:
                        labelTip.Text = "Первый раз слышу";
                        break;
                    case 3:
                        labelTip.Text = "Не могу подсказать";
                        break;
                    case 4:
                        labelTip.Text = "Кто его знает";
                        break;
                }
            labelTip.Visible = true;
        }

        void TipsShow(bool show)
        {
            labelTip.Visible = show;
            progressBarA.Visible = show;
            progressBarB.Visible = show;
            progressBarC.Visible = show;
            progressBarD.Visible = show;
            labelA.Visible = show;
            labelB.Visible = show;
            labelC.Visible = show;
            labelD.Visible = show;            
        }
        public void OnAuditoryHelp(int[] help)
        {
            labelTip.Text = "Помощь зала";
            progressBarA.Value = help[0];
            progressBarB.Value = help[1];
            progressBarC.Value = help[2];
            progressBarD.Value = help[3];
            labelA.Text = Answer_A;
            labelB.Text = Answer_B;
            labelC.Text = Answer_C;
            labelD.Text = Answer_D;
            TipsShow(true);
        }

        public void AdminModeOnly()
        {
            StartGameToolStripMenuItem.Enabled = false;
            buttonStartQuestion.Enabled = false;
            MessageBox.Show("Отсутсвует база данных вопросов millionare.bin  в папке с игрой! Игра будет в режиме администратора!");
            Text = "Как стать миллионером - Только Режим Администратора";
        }
    }
}
