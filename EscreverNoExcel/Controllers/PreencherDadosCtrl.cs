using EscreverNoExcel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscreverNoExcel.Controllers
{
    public class PreencherDadosCtrl
    {
        public static Usuario preencheDados()
        {

            Console.Write("Digite o documento do usuário: ");
            string documento = Console.ReadLine();

            Console.Write("Digite a data de nascimento: ");
            string dt_nasc = Console.ReadLine();

            Console.Write("Digite o numero de telefone do usuário: ");
            string ani = Console.ReadLine();

            var usuario = new Usuario()
            {
                Documento = documento,
                Dt_nasc = dt_nasc,
                Ani = ani
            };


            return usuario;
        }

       



    }
}
