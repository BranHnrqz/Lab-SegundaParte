using LabSegundaParte.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte.Negocio
{
    class NClsPersona
    {

        ClsPersona per = new ClsPersona();
        public string calcularIMC()
        {
          double pro = per.Peso / Math.Pow(per.Altura, 2);

          if (pro < 20)
            {
                return "Peso Ideal";
            }
        
          if(pro > 25)
             {
                return "Tiene Sobrepeso";
             }
          return "";
         
        }

        public string esMayorDeEdad()
        {
            if (per.Edad > 18)
            {
                return "Es mayor de edad";
            }
            else
                return "Es menor de edad";
        }

    }
}
