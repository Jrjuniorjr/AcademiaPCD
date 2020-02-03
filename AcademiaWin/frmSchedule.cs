using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AcademiaWin
{
    public partial class frmSchedule : Form
    {
        public DataTable tblContatos;
        public DataRowState sttContato;
        public int Counter;
        public frmSchedule()
        {
            InitializeComponent();
            Load += ApplicationLoad;
            KeyDown += ApplicationKeyDown;
        }

        private void ApplicationLoad(object sender, EventArgs e)
        {
            FormatContacts();
            HabilitarClick(btnSalvar, e);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            txtTitulo.ReadOnly = true;
            txtProprietario.ReadOnly = true;
            txtComentario.ReadOnly = true;
            txtTitulo.Text = "Agenda 2020";
            txtProprietario.Text = "João da Silva";
            txtComentario.Text = "Comentários afins";
            btnAgenda.Click += ScheduleClick;
            btnInserir.Click += InserirClick;
            btnAlterar.Click += AlterarClick;
            btnSalvar.Click += SalvarClick;
            btnCancelar.Click += CancelarClick;
            btnRemover.Click += RemoverClick;
        }

        private void ApplicationKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ScheduleClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            if (button.Tag.ToString() == "0")
            {                
                string dir = Path.Combine(projectDirectory, "Resource", "padlock-filled.png");                
                button.Image = Image.FromFile(dir);                                               
                button.UseVisualStyleBackColor = true;
                button.Tag = 1;
            } else if (button.Tag.ToString() == "1")
            {
                string dir = Path.Combine(projectDirectory, "Resource", "key-filled.png");
                button.Image = Image.FromFile(dir);
                button.UseVisualStyleBackColor = true;
                button.Tag = 0;
            }
            txtTitulo.ReadOnly = button.Tag.ToString() == "0";
            txtProprietario.ReadOnly = button.Tag.ToString() == "0";
            txtComentario.ReadOnly = button.Tag.ToString() == "0";
            txtTitulo.Focus();
        }

        private void FormatContacts()
        {
            tblContatos = new DataTable();
            tblContatos.Columns.Clear();
            tblContatos.Columns.Add("Id", typeof(Int32));
            tblContatos.Columns.Add("Nome", typeof(string));
            tblContatos.Columns.Add("Fone", typeof(long));
            tblContatos.Columns.Add("Endereco", typeof(string));
            tblContatos.PrimaryKey = new DataColumn[] { tblContatos.Columns["Id"] };

            grwContatos.DataSource = tblContatos;
            grwContatos.Columns[0].Width = 40;
            grwContatos.Columns[1].Width = 350;
            grwContatos.Columns[2].Width = 150;
            grwContatos.Columns[3].Width = 600;

            List<Contact> contactRows = PopulateContacts();
            foreach (Contact contact in contactRows)
            {
                DataRow row = tblContatos.NewRow();
                row["Id"] = contact.Id;
                row["Nome"] = contact.Name;
                row["Fone"] = contact.Phone;
                row["Endereco"] = contact.Adress;
                tblContatos.Rows.Add(row);
                Counter++;
            }

            bdsContacts.DataSource = grwContatos.DataSource;
        }       

        private List<Contact> PopulateContacts()
        {
            List<Contact> contacts = new List<Contact>();
            Contact contact0 = new Contact();
            contact0.Id = 1;
            contact0.Name = "Pedro Lucas de Souza";
            contact0.Phone = 81988034578;
            contact0.Adress = "Rua Agamenom Magalhães, 1034";
            contacts.Add(contact0);

            Contact contact1 = new Contact();
            contact1.Id = 2;
            contact1.Name = "Fernanda Figueiredo";
            contact1.Phone = 81997661203;
            contact1.Adress = "Avenida Norte, 232";
            contacts.Add(contact1);

            Contact contact2 = new Contact();
            contact2.Id = 3;
            contact2.Name = "Germano Francisco Gomes de Sá";
            contact2.Phone = 81999712308;
            contact2.Adress = "Avenida Recife, 1000";
            contacts.Add(contact2);

            Contact contact3 = new Contact();
            contact3.Id = 4;
            contact3.Name = "Maria Luiza Andrade";
            contact3.Phone = 81997402301;
            contact3.Adress = "Avenida Conselheiro Aguiar, 519";
            contacts.Add(contact3);

            Contact contact4 = new Contact();
            contact4.Id = 5;
            contact4.Name = "Antônio Henrique de Lima";
            contact4.Phone = 81999770148;
            contact4.Adress = "Estrada de Belém, 134";
            contacts.Add(contact4);

            Contact contact5 = new Contact();
            contact5.Id = 6;
            contact5.Name = "Marcos Ferreira dos Santos";
            contact5.Phone = 81979340098;
            contact5.Adress = "Av. Carlos de Lima Cavalcanti, 14";
            contacts.Add(contact5);

            Contact contact6 = new Contact();
            contact6.Id = 7;
            contact6.Name = "Juliana Marcella Domingos";
            contact6.Phone = 81988103487;
            contact6.Adress = "Av. José Rufino, 110";
            contacts.Add(contact6);

            Contact contact7 = new Contact();
            contact7.Id = 8;
            contact7.Name = "Carla Vanessa Alencar";
            contact7.Phone = 81997412090;
            contact7.Adress = "Rua Jean Ermille Favre, 348";
            contacts.Add(contact7);

            Contact contact8 = new Contact();
            contact8.Id = 9;
            contact8.Name = "Guilherme Dantas de Melo";
            contact8.Phone = 81998732086;
            contact8.Adress = "Avenida Domingos Ferreia, 28";
            contacts.Add(contact8);

            Contact contact9 = new Contact();
            contact9.Id = 10;
            contact9.Name = "Luciana Yeda de Franca Dias";
            contact9.Phone = 81998712051;
            contact9.Adress = "Rua da Concórdia, 184";
            contacts.Add(contact9);

            return contacts;
        }

        private void InserirClick(object sender, EventArgs e)
        {
            HabilitarClick(sender, e);
            sttContato = DataRowState.Added;
            txtNome.Focus();            
        }

        private void AlterarClick(object sender, EventArgs e)
        {            
            if (tblContatos.Rows.Count > 0)
            {
                HabilitarClick(sender, e);
                sttContato = DataRowState.Modified;

                DataRow row = SelecionarRow();

                txtNome.Text = row.Field<string>("Nome");
                txtFone.Text = row.Field<long>("Fone").ToString();
                txtEndereco.Text = row.Field<string>("Endereco");
            }
            txtNome.Focus();
        }

        private void SalvarClick(object sender, EventArgs e)
        {            
            if (sttContato.Equals(DataRowState.Added))
            {
                int id = RetornarId();              
                DataRow row = tblContatos.NewRow();
                row["Id"] = id;
                row["Nome"] = txtNome.Text;
                row["Fone"] = txtFone.Text;
                row["Endereco"] = txtEndereco.Text;
                tblContatos.Rows.Add(row);

            } else if (sttContato.Equals(DataRowState.Modified))
            {
                int idx = SelecionarIndex();
                tblContatos.Rows[idx]["Nome"] = txtNome.Text;
                tblContatos.Rows[idx]["Fone"] = txtFone.Text;
                tblContatos.Rows[idx]["Endereco"] = txtEndereco.Text;
            }

            HabilitarClick(sender, e);
            LimparCampos();
        }

        private void CancelarClick(object sender, EventArgs e)
        {
            HabilitarClick(sender, e);
            LimparCampos();
        }

        private void RemoverClick(object sender, EventArgs e)
        {
            HabilitarClick(sender, e);
            if (tblContatos.Rows.Count > 0)
            {
                int idx = SelecionarIndex();
                tblContatos.Rows.RemoveAt(idx);
            }
            grwContatos.Focus();
        }

        private void HabilitarClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            bool flag = ! (button.Name.Equals(btnInserir.Name) || (button.Name.Equals(btnAlterar.Name)));
            btnInserir.Enabled = flag;
            btnAlterar.Enabled = flag;
            btnSalvar.Enabled = !flag;
            btnCancelar.Enabled = !flag;
            btnRemover.Enabled = flag;

            btnInserir.Visible = flag;
            btnAlterar.Visible = flag;
            btnSalvar.Visible = !flag;
            btnCancelar.Visible = !flag;
            btnRemover.Visible = flag;

            pnlAcao.Enabled = !flag;
            pnlAcao.Visible = !flag;

            grwContatos.Enabled = flag;
        }

        public int SelecionarIndex()
        {
            DataRowView selectedRow = (DataRowView)grwContatos.CurrentRow.DataBoundItem;
            int index = selectedRow.Row.Table.Rows.IndexOf(selectedRow.Row);            
            return index;
        }
        public DataRow SelecionarRow()
        {
            int idx = SelecionarIndex();
            DataRow row = tblContatos.Rows[idx];
            return row;
        }

        public int RetornarId()
        {
            Counter = Counter + 1;
            return Counter;
        }

        public void LimparCampos()
        {
            txtNome.Text = String.Empty;
            txtFone.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            grwContatos.Focus();
        }

    }
}
