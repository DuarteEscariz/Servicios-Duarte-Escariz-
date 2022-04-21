using System;

namespace Ej1
{
    class Astro
    {
        private String nombre;
        public String Nombre
        {
            set
            {
                nombre = value.ToUpper().Trim();
            }
            get
            {

            }
        }
        public String get_Nombre(String c)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
