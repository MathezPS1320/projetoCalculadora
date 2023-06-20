using System;

namespace Calculadora
{
    class ProfessorPessoa
    {
        protected String? nomeCompleto {get; set;} 
        protected int? matricula {get; set;}       
        protected double? salarioProfessor{get; set;}     
      

        public string toString()
        {
            return 
            "Nome do Professor:         "         + nomeCompleto      + "\n" +
            "Matricula do Professor:    "         + matricula         + "\n";
        }
    }
}
