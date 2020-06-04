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
    public partial class AdminAddForm : Form
    {
        ListView parentlist;
        public string[] textdata;
        public int button;

        public AdminAddForm(ListView listitem, int index)
        {
            parentlist = listitem;
            InitializeComponent();
            textBoxQuestion.Text = parentlist.SelectedItems[0].SubItems[0].Text;
            textBoxAnswer.Text = parentlist.SelectedItems[0].SubItems[1].Text;
            textBoxA.Text = parentlist.SelectedItems[0].SubItems[2].Text;
            textBoxB.Text = parentlist.SelectedItems[0].SubItems[3].Text;
            textBoxC.Text = parentlist.SelectedItems[0].SubItems[4].Text;
            switch(parentlist.SelectedItems[0].Group.Name
                )
            {

                case "listQgroup1":
                    radioButton1.Select();
                    break;
                case "listQgroup2":
                    radioButton2.Select();
                    break;
                case "listQgroup3":
                    radioButton3.Select();
                    break;
                case "listQgroup4":
                    radioButton4.Select();
                    break;
                case "listQgroup5":
                    radioButton5.Select();
                    break;
            }
            buttonRec.Enabled = false;
            button = 0;
        }

        public AdminAddForm(ListView listView)
        {
            InitializeComponent();
            parentlist = listView;
            buttonRec.Enabled = false;
            button = 0;
        }
        private void buttonRec_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                button = 0;
            else if (radioButton2.Checked)
                button = 1;
            else if (radioButton3.Checked)
                button = 2;
            else if (radioButton4.Checked)
                button = 3;
            else if (radioButton5.Checked)
                button = 4;
            textdata  = new string[] { textBoxQuestion.Text, textBoxAnswer.Text, textBoxA.Text, textBoxB.Text, textBoxC.Text, button.ToString()};
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            buttonRec.Enabled = textBoxQuestion.Text.Length >= 5 && textBoxAnswer.Text.Length >= 3 &&
                textBoxA.Text.Length >= 3 && textBoxB.Text.Length >= 3 && textBoxC.Text.Length >= 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxes_TextChanged(sender, e);
        }
    }
}


