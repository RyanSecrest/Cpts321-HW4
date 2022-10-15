using SpreadsheetEngine;
using System.Data;
using System.Globalization;

namespace Spreadsheet_Ryan_Secrest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        
        
        private BindingSource bindingSource1 = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            

            DataTable table = new DataTable();

            int a = 65; // there may have been a more effecient way to write this but i saved 20+ lines of code so whatever
            char c = (char)a;
            string s = Char.ToString(c);

            for(int i = 65; i < 91; i++)
            {
                a = i;
                c = (char)a;
                s = Char.ToString(c);

                table.Columns.Add(s, typeof(String));
            }

            int j = 1;
            
            for(int i = 1; i < 51; i++)
            {
                _ = new string[26];
                table.Rows.Add(j, typeof(String));
                j++;
            }
   
            dataGridView1.DataSource = table;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                dataGridView1.Rows[row.Index].HeaderCell.Value = (row.Index+1).ToString();

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].Cells[1].Value = "This is cell B" + count;
                count++;
            }

            for(int i= 0; i< 26; i++)
            {
                int b = i + 65;
                char d = (char)b ;
                string t = Char.ToString(d);
                dataGridView1.Rows[5].Cells[i].Value = "This is cell " + t + "6";
            }

            Random rnd = new Random();
            

            for(int i = 1; i < 51; i++)
            {              
                dataGridView1.Rows[rnd.Next(1, 50)].Cells[rnd.Next(1, 26)].Value = "HelloWorld!";
            }
        }
    }
}