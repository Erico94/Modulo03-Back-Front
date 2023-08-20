using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03.Exercicio02.Hotel
{
    public static class Hotel
    {
        //Para evitar repetições nessa classe e também facilitar a manutenção caso haja alguma alteração dos valores,
        //sugiro a criação de algumas variáveis globais buscando valores em banco de dados, tais como para taxa de serviço,
        //café e almoço. Hospedagem também, atentando-se que a classe D tem esse valor diferente das outras classes.
        //Uma outra solução seria criar uma função chamada serviçoDeHotel, que recebe como parâmetro uma string, essa string seria 
        //a classe do serviço, dentro desta função teria um shitch case com as possibilidades e seus devidos valores retornados em cada caso.


        static int ServClasseA()
        {
            return 10 + 350 + 30 + 70 + 80 + 500;
        }


        static int ServClasseB()
        {
            //TaxaServ + Hosp + Cafe + Almoço + Janta
            return 10 + 350 + 30 + 70 + 80;
        }


        static int ServClasseC()
        {
            //TaxaServ + Hosp + Cafe + Almoço
            return 10 + 350 + 30 + 70;
        }

        static int ServClasseD()
        {
            //TaxaServ + Hosp
            return 10 + 200;
        }

        public static int ServicoHotel(string classe)
        {
            switch (classe)
            {
                case "A": return 10 + 350 + 30 + 70 + 80 + 500;
                case "B": return 10 + 350 + 30 + 70 + 80;
                case "C": return 10 + 350 + 30 + 70;
                case "D": return 10 + 200;
                default: return 999999;
            }
        }


    }
}
