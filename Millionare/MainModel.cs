using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Millionare
{

    public class MainModel
    {
        List<Gamedata> gamedatas;
        string mypath = "millionare.bin";
        BinaryFormatter binaryFormatter;

        public List<Gamedata> GetListgamedata()
        {
            return gamedatas;
        }
        public enum Action { Add, Delete, Update };
        public MainModel()
        {
            gamedatas = new List<Gamedata>();
            DeserializeListview();
        }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsLoginCorrect()
        {
            return UserName == "admin" && Password == "admin";
        }


        public void ModelUpdate(string[] item, Action action, int idx)
        {
            Gamedata newitem;
            switch (action)
            {
                case Action.Add:
                    newitem = new Gamedata(item, GetUniqindex());
                    gamedatas.Add(newitem);
                    break;
                case Action.Delete:
                    RemoveByUniqIndex(idx);
                    break;
                case Action.Update:
                    RemoveByUniqIndex(idx);
                    newitem = new Gamedata(item, GetUniqindex());
                    gamedatas.Add(newitem);
                    break;
            }
            SerializeListview();
        }

        [Serializable]
        public class Gamedata
        {
            public Gamedata(string[] data, int next)
            {
                Question = data[0];
                VarA = data[1];
                VarB = data[2];
                VarC = data[3];
                VarD = data[4];
                GroupList = data[5];
                Uniqindex = next;
            }
            public string Question { get; set; }
            public string VarA { get; set; }
            public string VarB { get; set; }
            public string VarC { get; set; }
            public string VarD { get; set; }
            public string GroupList { get; set; }
            public int Uniqindex { get; set; }
        }

        
        private void SerializeListview()
        {
            FileStream mystream = new FileStream(mypath, FileMode.Create);
            binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(mystream, gamedatas);
            mystream.Close();
        }

        private void DeserializeListview()
        {
            if (File.Exists(mypath))
            {
                FileStream mystream = new FileStream(mypath, FileMode.Open);
                binaryFormatter = new BinaryFormatter();
                gamedatas = (List<Gamedata>)binaryFormatter.Deserialize(mystream);
                mystream.Close();
            }
        }

        private int GetUniqindex()
        {
            int temp = 1;
            foreach(Gamedata item in gamedatas)
            {
                if (item.Uniqindex > temp)  temp = item.Uniqindex;
            }
            return temp + 1;
        }
        private void RemoveByUniqIndex(int idx)
        {
            for (int i = 0; i < gamedatas.Count; i++)
                if (gamedatas[i].Uniqindex == idx)
                    gamedatas.RemoveAt(i);
        }
    }


}