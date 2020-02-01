namespace AcademiaPCD
{
    public class Aluno
    {
        private string nome_inerno;        
        public string Nome { 
            get { return nome_inerno; }
            set { nome_inerno = value; } 
        }
        public int Idade { get; set; }

        public int QtdCaracteres()
        {
            return this.nome_inerno.Length;
        }

        public string NomeMaiusculo()
        {
            return this.nome_inerno.ToUpper();
        }
    }
}
