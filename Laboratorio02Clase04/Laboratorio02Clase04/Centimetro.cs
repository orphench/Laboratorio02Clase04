using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase04
{
    class Centimetro
    {
        public float cantidadDeCentimetros;

        private Centimetro(float cantidadDeCentimetros)
        {
            this.cantidadDeCentimetros = cantidadDeCentimetros;
        }

        private Centimetro()
        {
            //this.cantidadDeCentimetros = cantidadDeCentimetros;
        }

        //unoC = unoC + dosC;
        public static Centimetro operator +(Centimetro unoC, Centimetro dosC)
        {
            Centimetro result = new Centimetro(); 
            result.cantidadDeCentimetros = unoC.cantidadDeCentimetros + dosC.cantidadDeCentimetros;

            return result;
        }

        //unoC = unoC + unoM;
        public static Centimetro operator +(Centimetro unoC, Metro unoM)
        {
            Centimetro resultC = new Centimetro();
            resultC.cantidadDeCentimetros = unoC.cantidadDeCentimetros + (unoM.cantidadDeMetros * 100);
            return resultC;
        }

        //unoC++;
        public static Centimetro operator ++(Centimetro unoC)
        {
            unoC.cantidadDeCentimetros = unoC.cantidadDeCentimetros++;

            return unoC;
        }

        public static bool operator ==(Centimetro dosC, Metro unoM)
        {
            
            bool comparacion = dosC.cantidadDeCentimetros == unoM.cantidadDeMetros;

            return comparacion;
        }

        public static bool operator !=(Centimetro dosC, Metro unoM)
        {

            return !(dosC == unoM);
        }

        //
        public static implicit operator Centimetro(float num)
        {
            return new Centimetro(num);
        }

        //metodo estatico que devuelve una instancia, puedo acceder al objeto
        public static Centimetro devolverUnCentimetro()
        {
            return new Centimetro();
        }
    }
}
