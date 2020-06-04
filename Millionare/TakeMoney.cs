using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionare
{
    public partial class TakeMoney : Form
    {
        bool isSave = true;
        public TakeMoney()
        {
            InitializeComponent();            
        }

        public TakeMoney(bool flag)
        {
            InitializeComponent();
            textBoxB.Visible = false;
            textBoxC.Visible = false;
            textBoxA.Visible = false;
            isSave = false;
        }
        public event EventHandler<EventArgs> OnTakeMoney;

        public string[] WinnersData { get; set; }
        public int Money { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            WinnersData = new string[] { textBoxA.Text, textBoxB.Text, textBoxC.Text };
            OnTakeMoney?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        public void OnStartList()
        {
            listView1.Items.Add(new ListViewItem(WinnersData));
        }

        public void OnAddRecord()
        {
            if (isSave)
            {
                textBoxA.Text = DateTime.Now.ToString();
                textBoxC.Text = Money.ToString();
            }
        }

        private void TakeMoney_Shown(object sender, EventArgs e)
        {
            if(isSave)
            textBoxB.Focus();
        }

        private void textBoxB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, EventArgs.Empty);
        }
    }
}
