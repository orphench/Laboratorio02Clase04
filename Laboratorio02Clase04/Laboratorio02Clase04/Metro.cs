using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase04
{
    class Metro
    {
        public float cantidadDeMetros;

        private Metro(float cantidadDeMetros)
        {
            this.cantidadDeMetros = cantidadDeMetros;
        }

        private Metro()
        { 

        }

        //unoM = unoM + unoC;
        public static Metro operator +(Metro unoM, Centimetro unoC)
        {
            Metro resultM = new Metro();
            unoC.cantidadDeCentimetros = unoM.cantidadDeMetros / 10;
            resultM.cantidadDeMetros = unoM.cantidadDeMetros + unoC.cantidadDeCentimetros;
            return resultM;
        }

        //public static explicit operator Metro(float num)
        //{
        //    Metro retorno = new Metro();
            
        //    retorno.cantidadDeMetros =  num;

        //    return retorno;
        //}

        public static implicit operator Metro(float num)
        {
            
            return new Metro(num);
        }
    }
}
