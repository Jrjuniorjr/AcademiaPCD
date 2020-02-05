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
        public DataTable tbl;
        public DataRowState stt;
        public int CounterContatos;
        public int CounterEventos;
        public int CounterLembretes;
        private List<Contact> contatos;
        private List<Note> lembretes;
        private List<Event> eventos;
        private EnumAbaAtual enumAbaAtual;
        public frmSchedule()
        {
            InitializeComponent();
            Load += ApplicationLoad;
            KeyDown += ApplicationKeyDown;
            this.contatos = new List<Contact>();
            this.lembretes = new List<Note>();
            this.eventos = new List<Event>();
            this.enumAbaAtual = EnumAbaAtual.CONTATOS;
            PopulateContacts();
            PopulateEvents();
            PopulateNotes();
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
           tbl = new DataTable();
           tbl.Columns.Clear();
           tbl.Columns.Add("Id", typeof(Int32));
           tbl.Columns.Add("Nome", typeof(string));
           tbl.Columns.Add("Fone", typeof(long));
           tbl.Columns.Add("Endereco", typeof(string));
           tbl.PrimaryKey = new DataColumn[] { tbl.Columns["Id"] };

            grwContatos.DataSource = tbl;
            grwContatos.Columns[0].Width = 40;
            grwContatos.Columns[1].Width = 350;
            grwContatos.Columns[2].Width = 150;
            grwContatos.Columns[3].Width = 600;

            foreach (Contact contact in contatos)
            {
                DataRow row = tbl.NewRow();
                row["Id"] = contact.Id;
                row["Nome"] = contact.Name;
                row["Fone"] = contact.Phone;
                row["Endereco"] = contact.Adress;
                tbl.Rows.Add(row);
                CounterContatos++;
            }

            bdsContacts.DataSource = grwContatos.DataSource;
        }


        private void FormatEvent()
        {
            tbl = new DataTable();
            tbl.Columns.Clear();
            tbl.Columns.Add("Id", typeof(Int32));
            tbl.Columns.Add("Descrição", typeof(string));
            tbl.Columns.Add("Data/Hora(dd/mm/aaaa HH:mm)", typeof(DateTime));
            tbl.Columns.Add("Local", typeof(string));
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["Id"] };

            grwContatos.DataSource = tbl;
            grwContatos.Columns[0].Width = 40;
            grwContatos.Columns[1].Width = 350;
            grwContatos.Columns[2].Width = 200;
            grwContatos.Columns[3].Width = 600;

            foreach (Event evento in eventos)
            {
                DataRow row = tbl.NewRow();
                row["Id"] = evento.Id;
                row["Descrição"] = evento.Description;
                row["Data/Hora(dd/mm/aaaa HH:mm)"] = evento.Date;
                row["Local"] = evento.Local;
                tbl.Rows.Add(row);
                CounterEventos++;
            }

            bdsContacts.DataSource = grwContatos.DataSource;
        }

        private void FormatNote()
        {
            tbl = new DataTable();
            tbl.Columns.Clear();
            tbl.Columns.Add("Id", typeof(Int32));
            tbl.Columns.Add("Texto", typeof(string));
            tbl.Columns.Add("Data/Hora(dd/mm/aaaa HH:mm)", typeof(DateTime));
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["Id"] };

            grwContatos.DataSource = tbl;
            grwContatos.Columns[0].Width = 40;
            grwContatos.Columns[1].Width = 350;
            grwContatos.Columns[2].Width = 600;

            foreach (Note note in lembretes)
            {
                DataRow row = tbl.NewRow();
                row["Id"] = note.Id;
                row["Texto"] = note.Text;
                row["Data/Hora(dd/mm/aaaa HH:mm)"] = note.DateHour;
                tbl.Rows.Add(row);
                CounterEventos++;
            }

            bdsContacts.DataSource = grwContatos.DataSource;
        }
        private void PopulateEvents()
        {
            Event e0 = new Event();
            e0.Id = eventos.Count;
            e0.Description = "Academia PCD C#";
            e0.Date = Convert.ToDateTime("2019-05-05 13:00");
            e0.Local = "Armazem 13";
            eventos.Add(e0);
        }

        private void PopulateNotes()
        {
            Note n0 = new Note();
            n0.Id = lembretes.Count;
            n0.Text = "Lembrar do evento: Academia PCD C#";
            n0.DateHour = Convert.ToDateTime("2019-05-04 13:00");
            lembretes.Add(n0);
        }

        private void PopulateContacts()
        {
            Contact contact0 = new Contact();
            contact0.Id = eventos.Count;
            contact0.Name = "Pedro Lucas de Souza";
            contact0.Phone = 81988034578;
            contact0.Adress = "Rua Agamenom Magalhães, 1034";
            contatos.Add(contact0);

            Contact contact1 = new Contact();
            contact1.Id = contatos.Count;
            contact1.Name = "Fernanda Figueiredo";
            contact1.Phone = 81997661203;
            contact1.Adress = "Avenida Norte, 232";
            contatos.Add(contact1);

            Contact contact2 = new Contact();
            contact2.Id = contatos.Count;
            contact2.Name = "Germano Francisco Gomes de Sá";
            contact2.Phone = 81999712308;
            contact2.Adress = "Avenida Recife, 1000";
            contatos.Add(contact2);

            Contact contact3 = new Contact();
            contact3.Id = contatos.Count;
            contact3.Name = "Maria Luiza Andrade";
            contact3.Phone = 81997402301;
            contact3.Adress = "Avenida Conselheiro Aguiar, 519";
            contatos.Add(contact3);

            Contact contact4 = new Contact();
            contact4.Id = contatos.Count;
            contact4.Name = "Antônio Henrique de Lima";
            contact4.Phone = 81999770148;
            contact4.Adress = "Estrada de Belém, 134";
            contatos.Add(contact4);

            Contact contact5 = new Contact();
            contact5.Id = contatos.Count;
            contact5.Name = "Marcos Ferreira dos Santos";
            contact5.Phone = 81979340098;
            contact5.Adress = "Av. Carlos de Lima Cavalcanti, 14";
            contatos.Add(contact5);

            Contact contact6 = new Contact();
            contact6.Id = contatos.Count;
            contact6.Name = "Juliana Marcella Domingos";
            contact6.Phone = 81988103487;
            contact6.Adress = "Av. José Rufino, 110";
            contatos.Add(contact6);

            Contact contact7 = new Contact();
            contact7.Id = contatos.Count;
            contact7.Name = "Carla Vanessa Alencar";
            contact7.Phone = 81997412090;
            contact7.Adress = "Rua Jean Ermille Favre, 348";
            contatos.Add(contact7);

            Contact contact8 = new Contact();
            contact8.Id = contatos.Count;
            contact8.Name = "Guilherme Dantas de Melo";
            contact8.Phone = 81998732086;
            contact8.Adress = "Avenida Domingos Ferreia, 28";
            contatos.Add(contact8);

            Contact contact9 = new Contact();
            contact9.Id = contatos.Count;
            contact9.Name = "Luciana Yeda de Franca Dias";
            contact9.Phone = 81998712051;
            contact9.Adress = "Rua da Concórdia, 184";
            contatos.Add(contact9);

        }

        private void InserirClick(object sender, EventArgs e)
        {
            HabilitarClick(sender, e);
            stt = DataRowState.Added;
            textBox1.Focus();            
        }

        private void AlterarClick(object sender, EventArgs e)
        {            
            if (tbl.Rows.Count > 0)
            {
                HabilitarClick(sender, e);
                stt = DataRowState.Modified;

                DataRow row = SelecionarRow();
                if (enumAbaAtual.Equals(EnumAbaAtual.CONTATOS)) {
                    textBox1.Text = row.Field<string>("Nome");
                    textBox2.Text = row.Field<long>("Fone").ToString();
                    textBox3.Text = row.Field<string>("Endereco");
                }
                else if (enumAbaAtual.Equals(EnumAbaAtual.EVENTOS))
                {
                    textBox1.Text = row.Field<string>("Descrição");
                    textBox2.Text = row.Field<DateTime>("Data/Hora(dd/mm/aaaa HH:mm)").ToString();
                    textBox3.Text = row.Field<string>("Local");
                }
                else
                {
                    textBox1.Text = row.Field<string>("Texto");
                    textBox2.Text = row.Field<DateTime>("Data/Hora(dd/mm/aaaa HH:mm)").ToString();
                }
            }
            textBox1.Focus();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            if (enumAbaAtual.Equals(EnumAbaAtual.CONTATOS))
            {
                salvarContatos(sender, e);
            }
            else if (enumAbaAtual.Equals(EnumAbaAtual.EVENTOS))
            {
                salvarEventos(sender, e);
            }
            else
            {
                salvarLembretes(sender, e);
            }
        }

        private void salvarContatos(object sender, EventArgs e)
        {
            if (stt.Equals(DataRowState.Added))
            {
                int id = RetornarIdContatos();
                DataRow row = tbl.NewRow();
                row["Id"] = id;
                row["Nome"] = textBox1.Text;
                row["Fone"] = textBox2.Text;
                row["Endereco"] = textBox3.Text;
                tbl.Rows.Add(row);
                Contact c = new Contact();
                c.Id = id;
                c.Name = textBox1.Text;
                c.Phone = long.Parse(textBox2.Text);
                c.Adress = textBox3.Text;
                contatos.Add(c);

            }
            else if (stt.Equals(DataRowState.Modified))
            {
                int idx = SelecionarIndex();
                int indexLista = int.Parse(tbl.Rows[idx]["Id"].ToString());
                tbl.Rows[idx]["Nome"] = textBox1.Text;
                tbl.Rows[idx]["Fone"] = textBox2.Text;
                tbl.Rows[idx]["Endereco"] = textBox3.Text;
                foreach(Contact c in contatos)
                {
                    if (c.Id == indexLista) {
                        c.Name = textBox1.Text;
                        c.Phone = long.Parse(textBox2.Text);
                        c.Adress = textBox3.Text;
                    }
                }
                
            }
            HabilitarClick(sender, e);
            LimparCampos();
        }

        private void salvarLembretes(object sender, EventArgs e)
        {
            if (stt.Equals(DataRowState.Added))
            {
                int id = RetornarIdLembretes();
                DataRow row = tbl.NewRow();
                row["Id"] = id;
                row["Texto"] = textBox1.Text;
                row["Data/Hora(dd/mm/aaaa HH:mm)"] = textBox2.Text;
                tbl.Rows.Add(row);

                Note n = new Note();
                n.Id = RetornarIdLembretes();
                n.Text = textBox1.Text;
                n.DateHour = Convert.ToDateTime(textBox2.Text);
                lembretes.Add(n);
            }
            else if (stt.Equals(DataRowState.Modified))
            {
                int idx = SelecionarIndex();
                int indexLista = int.Parse(tbl.Rows[idx]["Id"].ToString());
                tbl.Rows[idx]["Texto"] = textBox1.Text;
                tbl.Rows[idx]["Data/Hora(dd/mm/aaaa HH:mm)"] = textBox2.Text;
                foreach (Note n in lembretes)
                {
                    if (n.Id == indexLista)
                    {
                        n.Text = textBox1.Text;
                        n.DateHour = Convert.ToDateTime(textBox2.Text);
                    }
                }
            }

            HabilitarClick(sender, e);
            LimparCampos();
        }

        private void salvarEventos(object sender, EventArgs e)
        {
            if (stt.Equals(DataRowState.Added))
            {
                int id = RetornarIdEventos();
                DataRow row = tbl.NewRow();
                row["Id"] = id;
                row["Descrição"] = textBox1.Text;
                row["Data/Hora(dd/mm/aaaa HH:mm)"] = textBox2.Text;
                row["Local"] = textBox3.Text;
                tbl.Rows.Add(row);

                Event e0 = new Event();
                e0.Id = RetornarIdEventos();
                e0.Description = textBox1.Text;
                e0.Date = Convert.ToDateTime(textBox2.Text);
                e0.Local = textBox3.Text;
                eventos.Add(e0);

            }
            else if (stt.Equals(DataRowState.Modified))
            {
                int idx = SelecionarIndex();
                int indexLista = int.Parse(tbl.Rows[idx]["Id"].ToString());
                tbl.Rows[idx]["Descrição"] = textBox1.Text;
                tbl.Rows[idx]["Data/Hora(dd/mm/aaaa HH:mm)"] = textBox2.Text;
                tbl.Rows[idx]["Local"] = textBox3.Text;
                foreach (Event e0 in eventos)
                {
                    if (e0.Id == indexLista)
                    {
                        e0.Description = textBox1.Text;
                        e0.Date = Convert.ToDateTime(textBox2.Text);
                        e0.Local = textBox3.Text;
                    }
                }
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
            if (tbl.Rows.Count > 0)
            {
                int idx = SelecionarIndex();
                tbl.Rows.RemoveAt(idx);
                removerObjetoLista(idx);
            }
            grwContatos.Focus();
        }

        private void removerObjetoLista(int index)
        {
            if (enumAbaAtual.Equals(EnumAbaAtual.CONTATOS))
            {
                contatos.RemoveAt(index);
            }
            else if (enumAbaAtual.Equals(EnumAbaAtual.LEMBRETES))
            {
                lembretes.RemoveAt(index);
            }
            else
            {
                eventos.RemoveAt(index);
            }
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
            DataRow row = tbl.Rows[idx];
            return row;
        }

        public int RetornarIdContatos()
        {
            return contatos.Count;
        }

        public int RetornarIdLembretes()
        {
            return lembretes.Count;
        }
        public int RetornarIdEventos()
        {
            return eventos.Count;
        }
        public void LimparCampos()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            grwContatos.Focus();
        }

        private void btn_contatos_Click(object sender, EventArgs e)
        {
            this.lblTextBox3.Visible = true;
            this.textBox3.Visible = true;
            enumAbaAtual = EnumAbaAtual.CONTATOS;
            this.lblTextBox1.Text = "Nome";
            this.lblTextBox2.Text = "Fone";
            this.lblTextBox3.Text = "Endereço";

            FormatContacts();

        }

        private void btn_lembretes_Click(object sender, EventArgs e)
        {

            enumAbaAtual = EnumAbaAtual.LEMBRETES;
            this.lblTextBox3.Visible = false;
            this.textBox3.Visible = false;
            this.lblTextBox1.Text = "Texto";
            this.lblTextBox2.Text = "Data/Hora(yyyy-mm-dd HH:mm)";

            FormatNote();
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            this.lblTextBox3.Visible = true;
            this.textBox3.Visible = true;
            enumAbaAtual = EnumAbaAtual.EVENTOS;
            this.lblTextBox1.Text = "Nome";
            this.lblTextBox2.Text = "Data/Hora(yyyy-mm-dd HH:mm)";
            this.lblTextBox3.Text = "Local";
            FormatEvent();
        }
    }
}
