using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaWin
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();

            PopulateGridContacts();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //panel1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

        }



        private void PopulateGridContacts()
        {
            DataTable table = new DataTable();
            //table = grwContacts.DataSource as DataTable;
            table.Columns.Clear();           
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Fone", typeof(long));
            table.Columns.Add("Endereço", typeof(string));

            grwContacts.DataSource = table;
            grwContacts.Columns[0].Width = 200;
            grwContacts.Columns[1].Width = 120;
            grwContacts.Columns[2].Width = 400;
            
        }
    }
}
