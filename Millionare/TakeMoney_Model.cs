using System;
using System.IO;
using System.Collections.Generic;

namespace Millionare
{
    class HistoryData
    {
        public HistoryData(string t, string n, string m)
        {
            Name = n;
            Money = m;
            Time = t;
        }
        public string Time { get; set; }

        public string Name { get; set; }
        public string Money { get; set; }

    }
    class TakeMoneyModel
    {
        List<HistoryData> winners;
        public TakeMoneyModel()
        {
            winners = new List<HistoryData>();
            LoadWinners();
        }
        public List<HistoryData> GetWinners()
        {
            return winners;
        }

        public void SavetoHallofWinners(string[] datas)
        {
            winners.Add(new HistoryData(datas[0], datas[1], datas[2]));
            SaveWinners();
        }
        private void SaveWinners()
        {
            try
            {
                BinaryWriter writer = new BinaryWriter(File.Create("winners.bin"));

                foreach (HistoryData item in winners)
                {
                    writer.Write(item.Time);
                    writer.Write(item.Name);
                    writer.Write(item.Money);
                }
                writer.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        private void LoadWinners()
        {
            try
            {
                if (File.Exists("winners.bin"))
                {
                    BinaryReader reader = new BinaryReader(File.Open("winners.bin", FileMode.Open));
                    while (reader.PeekChar() >= 0)
                    {
                        winners.Add(new HistoryData(reader.ReadString(), reader.ReadString(), reader.ReadString()));
                    }
                    reader.Close();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}