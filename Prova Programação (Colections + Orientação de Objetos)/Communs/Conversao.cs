using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Programação__Colections___Orientação_de_Objetos_.Communs
{
    class Conversao
    {
        static public float ConvertFloat(String Valor)
        {
            try
            {
                return float.Parse(Valor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        static public DateTime ConvertDate(String Valor)
        {
            try
            {
                return Convert.ToDateTime(Valor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
