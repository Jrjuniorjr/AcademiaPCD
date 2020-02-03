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
        public delegate void DelegateGrid();        
        public frmSchedule()
        {
            InitializeComponent();
            Load += ApplicationLoad;
            KeyDown += ApplicationKeyDown;


            DelegateGrid LoadContacts = new DelegateGrid(FormatContacts);
            LoadContacts();
        }

        private void ApplicationLoad(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            txtTitulo.ReadOnly = true;
            txtProprietario.ReadOnly = true;
            txtComentario.ReadOnly = true;
            txtTitulo.Text = "Agenda 2020";
            txtProprietario.Text = "João da Silva";
            txtComentario.Text = "Comentários afins";
            btnAgenda.Click += ScheduleClick;
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
            DataTable table = new DataTable();
            table.Columns.Clear();
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Fone", typeof(long));
            table.Columns.Add("Endereço", typeof(string));

            grwContatos.DataSource = table;
            grwContatos.Columns[0].Width = 250;
            grwContatos.Columns[1].Width = 110;
            grwContatos.Columns[2].Width = 500;

            List<Contact> contactRows = PopulateContacts();
            foreach (Contact contact in contactRows)
            {
                DataRow row = table.NewRow();
                row["Nome"] = contact.Name;
                row["Fone"] = contact.Phone;
                row["Endereço"] = contact.Adress;
                table.Rows.Add(row);
            }

            bdsContacts.DataSource = grwContatos.DataSource;
        }       

        private List<Contact> PopulateContacts()
        {
            List<Contact> contacts = new List<Contact>();
            Contact contact0 = new Contact();
            contact0.Name = "Pedro Lucas de Souza";
            contact0.Phone = 81988034578;
            contact0.Adress = "Rua Agamenom Magalhães, 1034";
            contacts.Add(contact0);

            Contact contact1 = new Contact();
            contact1.Name = "Fernanda Figueiredo";
            contact1.Phone = 81997661203;
            contact1.Adress = "Avenida Norte, 232";
            contacts.Add(contact1);

            Contact contact2 = new Contact();
            contact2.Name = "Germano Francisco Gomes de Sá";
            contact2.Phone = 81999712308;
            contact2.Adress = "Avenida Recife, 1000";
            contacts.Add(contact2);

            Contact contact3 = new Contact();
            contact3.Name = "Maria Luiza Andrade";
            contact3.Phone = 81997402301;
            contact3.Adress = "Avenida Conselheiro Aguiar, 519";
            contacts.Add(contact3);

            Contact contact4 = new Contact();
            contact4.Name = "Antônio Henrique de Lima";
            contact4.Phone = 81999770148;
            contact4.Adress = "Estrada de Belém, 134";
            contacts.Add(contact4);

            Contact contact5 = new Contact();
            contact5.Name = "Marcos Ferreira dos Santos";
            contact5.Phone = 81979340098;
            contact5.Adress = "Av. Carlos de Lima Cavalcanti, 14";
            contacts.Add(contact5);

            Contact contact6 = new Contact();
            contact6.Name = "Juliana Marcella Domingos";
            contact6.Phone = 81988103487;
            contact6.Adress = "Av. José Rufino, 110";
            contacts.Add(contact6);

            Contact contact7 = new Contact();
            contact7.Name = "Carla Vanessa Alencar";
            contact7.Phone = 81997412090;
            contact7.Adress = "Rua Jean Ermille Favre, 348";
            contacts.Add(contact7);

            Contact contact8 = new Contact();
            contact8.Name = "Guilherme Dantas de Melo";
            contact8.Phone = 81998732086;
            contact8.Adress = "Avenida Domingos Ferreia, 28";
            contacts.Add(contact8);

            Contact contact9 = new Contact();
            contact9.Name = "Luciana Yeda de Franca Dias";
            contact9.Phone = 81998712051;
            contact9.Adress = "Rua da Concórdia, 184";
            contacts.Add(contact9);

            return contacts;
        }


    }
}
