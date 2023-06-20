using System;

namespace Calculadora
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            solicitarRegimeDeContratacao();
        }

        public static void solicitarRegimeDeContratacao()
        {
            Console.WriteLine("Informe o seu Regime de contratação: ");
            string? tipoDeRegimeDeContratacao = Console.ReadLine();
            validarRegimeDeContratacao(tipoDeRegimeDeContratacao);
        }

        public static void validarRegimeDeContratacao(string regimeContratacao)
        {
            switch(regimeContratacao.ToUpper())
            {
                case "CLT":
                    ProfessorCLT professorCLT = new ProfessorCLT(regimeContratacao);
                    professorCLT.solicitarRegimeDeContratacao();
                    professorCLT.toString();
                    
                break;
                case "PJ":
                    ProfessorPJ professorPJ = new ProfessorPJ(regimeContratacao);
                    professorPJ.solicitarRegimeDeContratacao();
                    professorPJ.toString();
                break; 
                case "HORISTA":
                    ProfessorHorista professorHorista = new ProfessorHorista(regimeContratacao);
                    professorHorista.solicitarRegimeDeContratacao();
                    professorHorista.toString();
                break;
                default:
                    Console.WriteLine("Regime de Contratação Inválido digite - CLT - PJ - HORISTA");
                break;
            }
        }
    }

}
