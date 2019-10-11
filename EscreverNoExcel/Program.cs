using EscreverNoExcel.Controllers;
using EscreverNoExcel.Dao;
using EscreverNoExcel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscreverNoExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Inserir no excel atraves do banco de dados");
            Console.Write(" 2-Inserir manual no excel \n--------->");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    BancoToExcel.JogaDadosDoBancoNoExcel(AplicacaoBD.selectAll());
                    FormataExcelCtrl.formatarPlanilha();
                    break;

                case "2":
                    EscreveNoExcel.EscreverNoExcelManual(PreencherDadosCtrl.preencheDados());
                    FormataExcelCtrl.formatarPlanilha();
                    break;
               
                default:
                    Console.WriteLine("Opcao invalida");
                    break;

            }

           


            



            

         



           
           







        }
    }
}
