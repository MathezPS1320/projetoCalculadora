using System;

namespace Calculadora
{
    class ProfessorCLT : ProfessorPessoa
    {
        private string? regimeProfessor;
        private double? valorHorasTrablhadas;
        private double? horasTrabalhadas; 

        public ProfessorCLT(string regimeProfessor)
        {
            this.regimeProfessor = regimeProfessor;
        }
        
        public ProfessorCLT(string regimeProfessor, string nomeCompleto, int matricula, double salarioProfessor)
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

            Console.WriteLine("Informe o valor do salário trabalhadas: ");
            double? salarioProfessorCLT = double.Parse(Console.ReadLine());

            calcularRegimeHorista(salarioProfessorCLT);
        }

        public void calcularRegimeHorista(double? salarioProfessorCLT)
        {            
            salarioProfessor = salarioProfessorCLT;
        }

        public void  toString()
        {
            Console.WriteLine( 
            "Nome do Professor:         "         + nomeCompleto      + "\n" +
            "Matricula do Professor:    "         + matricula         + "\n" + 
            "Salario do Professor     R$"         + salarioProfessor  + "\n" +
            "Tipo de Contrato Professor "         + regimeProfessor   + "\n");
        }
    }
}