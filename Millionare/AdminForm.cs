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
    
    public partial class AdminForm : Form
    {
        public int Index { get; set; }
        public int Group { get; set; }
        public string[] TextFieldsData { get; set; }
        public AdminForm()
        {
            InitializeComponent();
            QlistView.FullRowSelect = true;
        }

        public event EventHandler<EventArgs> UpdateData;
        public event EventHandler<EventArgs> AddData;
        public event EventHandler<EventArgs> DeleteData;

        public void OnDeleteUpdate()
        {
            //QlistView.Items.RemoveAt(QlistView.SelectedItems[0].Index);
            QlistView.Items.Clear();
        }
        public void OnAddUpdate()
        {
            ListViewItem item = new ListViewItem(TextFieldsData);
            item.Group = QlistView.Groups[Group];
           // item.SubItems.Add(Index.ToString());
            QlistView.Items.Add(item);
        }

        public void OnEditUpdate()
        {
            //QlistView.Clear();
            //ListViewItem item = new ListViewItem(TextFieldsData);
            //QlistView.SelectedItems[0].Remove();
            //QlistView.Items.Insert(Index, item);
            QlistView.Items.Clear();
            //QlistView.SelectedItems[0].SubItems[0].Text = TextFieldsData[0];
            //QlistView.SelectedItems[0].SubItems[1].Text = TextFieldsData[1];
            //QlistView.SelectedItems[0].SubItems[2].Text = TextFieldsData[2];
            //QlistView.SelectedItems[0].SubItems[3].Text = TextFieldsData[3];
            //QlistView.SelectedItems[0].SubItems[4].Text = TextFieldsData[4];
            //QlistView.SelectedItems[0].Group = QlistView.Groups[Group];
            
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {     
            AdminAddForm addform = new AdminAddForm(QlistView);
                addform.Text = "Ввод новых вопросов";
            if (addform.ShowDialog(this) == DialogResult.OK)
            {
                Group = addform.button;
                TextFieldsData = addform.textdata;
               // QlistView.Items.Clear();
                AddData?.Invoke(this, EventArgs.Empty);
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (QlistView.SelectedItems.Count == 0) return;
            AdminAddForm addform = new AdminAddForm(QlistView, QlistView.SelectedItems[0].Index);
            Index = int.Parse(QlistView.SelectedItems[0].SubItems[5].Text);
            //Index = int.Parse(QlistView.SelectedItems[0].SubItems[5].Text);
            addform.Text = "Редактирование вопроса";
            if (addform.ShowDialog(this) == DialogResult.OK)
            {
                Group = addform.button;
                TextFieldsData = addform.textdata;
                UpdateData?.Invoke(this, EventArgs.Empty);
            }       

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (QlistView.SelectedItems.Count == 0) return;
            if(MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               // MessageBox.Show(QlistView.Items.Count.ToString());
                Index = int.Parse(QlistView.SelectedItems[0].SubItems[5].Text);
                //Index = int.Parse(QlistView.SelectedItems[0].SubItems[5].Text);
                DeleteData?.Invoke(sender, EventArgs.Empty);
                
            }
            
        }
                
        private void QlistView_DoubleClick(object sender, EventArgs e)
        {
            buttonEdit_Click(sender, e);
        }
    }
}
