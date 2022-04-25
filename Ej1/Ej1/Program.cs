using System;

namespace Ej1
{
    public class RadioNegativoException : Exception
    {

    }
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
                return nombre;
            }
        }
        public String get_Nombre(Char c)
        {
            String final="";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (i == 0)
                {
                    final= final + nombre[i];
                }
                else
                {
                    final = final + c + nombre[i];
                }
            }
            return final;
        }
        private int radio;
        public int Radio
        {
            set
            {
                if (value > 0)
                {
                    radio = value;
                } 
                else throw new RadioNegativoException();
            }
            get
            {
                return radio;
            }
        }
        public override string ToString()
        {
            String salida = nombre + " Radio: " + radio.ToString("F2");
            return salida;
        }
        //public override bool Equals(object obj){} TODO
        public override 
    }
    class Planeta : Astro
    {
        private bool gaseoso;
        public bool Gaseoso
        {
            get
            {
                return gaseoso;
            }
            set
            {
                gaseoso = value;
            }
        }
        public Astro[] Satelites;
        public Planeta(String nombre, int radio, bool gaseoso)
        {
            this.Nombre = nombre;
            this.Radio = radio;
            this.gaseoso = gaseoso;
            this.Satelites = new Astro[0] ;
        }
        public Planeta()
        {
            new Planeta("", 0, false);
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
