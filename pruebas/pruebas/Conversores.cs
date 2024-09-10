using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Conversores
    {
        double[][] valores = new double[][]{
        new double[] {1, 7.73,24.76,36.80, 517.04,8.75}, //monedas
        new double[] {1,100,39.37,3.28084,1.196308,1.09361,0.001}, //longi
        new double[] {1,453.592,16,0.453592, 0.000446429},//masa
        new double[] {1, 86400, 1440, 24, 0.142857, 0.032876643423, 0.0027397232876831892345},

        };
        public string[][] etiquetas = new string[][]{
            new string[] {"Dolar", "Quetzal","Lempira","Cordoba","Peso CR","Colon","Euro"},//monedas
            new string[]{"Metro","CM","Pulgadas","pie","vara","Yarda","KM"},
            new string[]{"Gramo","onza","kilogramo","tonelada","larga"},
            new strimg[]{"sg","minuto","horas","semana","mes","año"},

};
        public double convertir(int de, int a, double cantidad, int opcion){
            return valores[opcion][a] / valores[opcion][de] * cantidad;

        }
    }
}
