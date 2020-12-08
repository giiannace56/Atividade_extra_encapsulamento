namespace calculo_salario.classes
{
    public class Funcionario
    {
        public string nome;

        private string cpf;
        public string CPF{
            get{return cpf;}
            set{cpf = value;}
        }
        private string rg;
        public string RG{
            get{return rg;}
            set{rg = value;}
        }
        private float valorhora = 40;
        public float ValorHora{
            get{return valorhora;}
            set{valorhora = value;}
        }
        private float salario;

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public float CalcSalario(float horas)
        {
            return horas * this.valorhora;
        }
    }
    // metodos
}