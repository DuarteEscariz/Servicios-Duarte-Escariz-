using System;
using System.Threading;

namespace Ej3
{
    public delegate void Operation();
   
    class Program
    {
        static readonly object l = new object();
        static int cont = 0;
        static Boolean running = true;
        static void Main(string[] args)
        {
            Operation op = () => cont--;
            Thread threadResta = new Thread(operacion);
            threadResta.Start(op);
            op = () => cont++;
            Thread threadSuma = new Thread(operacion);
            threadSuma.Start(op);
            
        }
        
        static void operacion(Object op)
        {

            Operation opAux = (Operation)op;
            while (running)
            {
                lock (l)
                {
                    if (cont < 1000 && cont > -1000)
                    {
                        opAux();
                        Console.WriteLine(cont);
                    }
                    else
                    {
                        running = false;
                    }
                }
            }
        }

    }
}
