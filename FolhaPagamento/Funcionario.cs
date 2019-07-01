namespace FolhaPagamento
{
    class Funcionario
    {
        public int Codigo { get; set; }
        public double Salario { get; set; }
        public double Percentual {
            get
            {
                if (Salario < 1000) return 15;
                else if (Salario < 1500) return 10;
                else
                    return 5;
            }            
        }
        public double NovoSalario
        {
            get
            {
                return (Salario * Percentual / 100) + Salario;
            }
        }

    }
}