namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (suite != null && hospedes.count <= suite.capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes != null ? Hospedes.count : 0;
        }

        public decimal CalcularValorDiaria()
        {
         
         decimal valorDiaria = Suite != null ? suite.valorDiaria : 0;
         decimal valorTotal = valorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valorTotal *= 0.9m;


            }

            return valorTotal;
        }
    }
}