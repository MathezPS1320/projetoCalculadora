using System;

namespace Calculadora
{
    class ProfessorHorista : ProfessorPessoa
    {
        private string? regimeProfessor;
        private double? valorHorasTrablhadas;
        private double? horasTrabalhadas; 

        public ProfessorHorista(string regimeProfessor)
        {
            this.regimeProfessor = regimeProfessor;
        }
        
        public ProfessorHorista(string regimeProfessor, string nomeCompleto, int matricula, double salarioProfessor)
        {
            this.regimeProfessor = regimeProfessor;
            this.nomeCompleto = nomeCompleto;
            this.matricula = matricula;
            this.salarioProfessor = salarioProfessor;
        }

         public  void solicitarRegimeDeContratacao()
        {
            

            Console.WriteLine("Informe o seu nome completo: ");
            this.nomeCompleto = Console.ReadLine();

            Console.WriteLine("Informe a sua matricula: ");
            this.matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da hora trabalhadas: ");
            double? valorDasHorasTrabalhadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de horas trabalhadas");
            double horasTrabalhadas =   double.Parse(Console.ReadLine());

            calcularRegimeHorista((double)valorDasHorasTrabalhadas, horasTrabalhadas);
        }

        public void calcularRegimeHorista(double valorDasHorasTrabalhadas, double horasTrabalhadas)
        {            
            salarioProfessor = valorDasHorasTrabalhadas * horasTrabalhadas ;
        }

        public void  toString()
        {
            Console.WriteLine( 
            "Nome do Professor:            "         + nomeCompleto      + "\n" +
            "Matricula do Professor:       "         + matricula         + "\n" + 
            "Salario do Professor:      R$ "         + salarioProfessor  + "\n" +
            "Tipo de Contrato Professor:   "         + regimeProfessor   + "\n");
        }
    }
}