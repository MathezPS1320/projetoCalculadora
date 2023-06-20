using System;

namespace Calculadora
{
    class ProfessorPJ : ProfessorPessoa
    {
        private string? regimeProfessor;
        

        public ProfessorPJ(string regimeProfessor)
        {
            this.regimeProfessor = regimeProfessor;
        }
        
        public ProfessorPJ(string regimeProfessor, string nomeCompleto, int matricula, double salarioProfessor)
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

            Console.WriteLine("Informe o seu salário: ");
            double? salarioPJ = double.Parse(Console.ReadLine());

            calcularRegimeHorista(salarioPJ);
        }

        public void calcularRegimeHorista(double? salarioPJ)
        {            
            salarioProfessor = salarioPJ;
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