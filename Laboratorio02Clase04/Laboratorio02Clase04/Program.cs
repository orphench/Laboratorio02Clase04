using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Centimetro unoC = new Centimetro(10f);

            Centimetro unoC = 10f;
            Metro unoM = 1f;
            Centimetro dosC = 110f;

            //Centimetro dosC = new Centimetro(110f);

            //Metro unoM = new Metro(1f);
            //Metro dosM = new Metro();

            //unoC = unoC + dosC;

            unoM = unoM + unoC;

            unoC = unoC + unoM;

            //unoC++;

            if (dosC == unoM)
            {
                Console.WriteLine("Son iguales");
            }

            //OPERADOR DE CASTEO EXPLICITO
            //unoM = (Metro)9f;
            //CON IMPLICIT
            //unoM = 9f; 

            //Crear objetos con constructores privador atraves de un metodo estatico
            //
        }
    }
}
