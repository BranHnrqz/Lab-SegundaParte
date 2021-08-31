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
        public string calcularIMC(ClsPersona per)
        {
          double pro = (per.Peso / Math.Pow(per.Altura, 2));

          if (pro < 20)
            {
                return "Peso Ideal";
            }
          else
                return "Tiene Sobrepeso";    
         
        }

        public string esMayorDeEdad(ClsPersona per)
        {
            if (per.Edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            { 
                return "Es menor de edad";
            }
            
        }

    }
}
