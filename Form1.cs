namespace DS_Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown_PriceNout.Controls[0].Visible = false;    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть анкету?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) 
                 e.Cancel = true;
            else e.Cancel = false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Family.Text))
            {
                errorProvider1.SetError(textBox_Family, "Введите фамилию");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox_Family, String.Empty);
            }
            ListViewItem listviewitem = new ListViewItem(textBox_Family.Text);
            listviewitem.SubItems.Add(textBox_Name.Text);
            listviewitem.SubItems.Add(maskTextBox_DateBirth.Text);
            if (radioButton_M.Checked) listviewitem.SubItems.Add(radioButton_M.Text);
            else if (radioButton_J.Checked) listviewitem.SubItems.Add(radioButton_J.Text);
            listviewitem.SubItems.Add(textBox_Work.Text);
            listviewitem.SubItems.Add(comboBox_HomeComp.Text);
            listviewitem.SubItems.Add(textBox_NoutBrand.Text);
            listviewitem.SubItems.Add(maskTextBox_DateBuy.Text);
            listviewitem.SubItems.Add(numericUpDown_PriceNout.Text);
            listviewitem.SubItems.Add(comboBox_GoodNout.Text);
            listView1.Items.Add(listviewitem);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить список?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            else listView1.Items.Clear();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                    listView1.Items.Remove(item);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string str = "";
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            str += item.SubItems[i].Text + " ";
                        }
                        sw.WriteLine(str);
                    }
                           
                }
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                using StreamReader sr = new StreamReader(openFileDialog1.FileName);
                {
                    string[] strItem = File.ReadAllLines(openFileDialog1.FileName);                 
                    for (int i = 0; i < strItem.Length; i++)
                    {
                        var str = strItem[i].Split(' ');
                        ListViewItem item = new ListViewItem(str[0].ToString());
                        for (int j = 1; j < str.Length; j++)
                        {
                            item.SubItems.Add(str[j]);
                        }
                        listView1.Items.Add(item);
                    }                    
                }                
            }
        }
    }
}