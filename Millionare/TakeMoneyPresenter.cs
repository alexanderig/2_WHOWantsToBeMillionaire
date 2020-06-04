using System;

namespace Millionare
{
    class TakeMoneyPresenter
    {
        private readonly TakeMoneyModel tmodel;
        private readonly TakeMoney viewtm;

        public TakeMoneyPresenter(TakeMoney take)
        {
            viewtm = take;
            tmodel = new TakeMoneyModel();
            viewtm.OnTakeMoney += new EventHandler<EventArgs>(OnWrite);
            OnRead();
            viewtm.OnAddRecord();
        }

        private void OnRead()
        {
            foreach(HistoryData item in tmodel.GetWinners())
            {
                viewtm.WinnersData = new string[] { item.Time, item.Name, item.Money };
                viewtm.OnStartList();
            }
        }

        private void OnWrite(object sender, EventArgs e)
        {
            tmodel.SavetoHallofWinners(viewtm.WinnersData);
        }

    }
}