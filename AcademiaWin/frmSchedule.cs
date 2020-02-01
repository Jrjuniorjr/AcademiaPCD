using System;
using System.Data;
using System.Windows.Forms;

namespace AcademiaWin
{
    public partial class frmSchedule : Form
    {
        public delegate void DelegateGrid();
        
        public frmSchedule()
        {
            InitializeComponent();
            DelegateGrid LoadContacts = new DelegateGrid(FormatContacts);

            LoadContacts();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //panel1.Enabled = false;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

            textBox1.Text = "Agenda 2020";
            textBox2.Text = "João da Silva";
            textBox3.Text = "Comentários afins";

        }

        private void FormatContacts()
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
