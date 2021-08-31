using LabSegundaParte.Entidades;
using LabSegundaParte.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clspersona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            Console.WriteLine("-- Ingreso de Datos --");

            Console.WriteLine("Porfavor, Ingresa tu Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecciona tu Género: (H - Hombre, M - Mujer)");
            string sexo = Console.ReadLine();

            Console.WriteLine("Ingrese su Peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su Altura: ");
            double altura = double.Parse(Console.ReadLine());

            ClsPersona persona = new ClsPersona(nombre, edad, sexo, peso, altura);
            ClsPersona persona1 = new ClsPersona(nombre, edad, sexo);

            Console.WriteLine(nclspersona.calcularIMC(persona));
            Console.WriteLine(nclspersona.esMayorDeEdad(persona1));
            Console.WriteLine(persona.ToString());

            Console.ReadLine();

        }
    }
}
