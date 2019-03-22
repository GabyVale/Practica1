using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando
{
    public delegate void MiDelegado(int i);
    public class Program
    {
        static void Main(string[] args)
        {
            MiClase miClase = new MiClase(); //Creamos un nuevo objeto de clase MiClase

            MiDelegado delegado = new MiDelegado(miClase.MiMetodo); //Instanciamos un delegado
            delegado(83); //Llamamos al delegado
        }
    }
}

public class MiClase 
{
    public void MiMetodo(int i)
    {
        Console.WriteLine("El valor pasado como parámetro es: {0}", i);
        Console.ReadKey();
    }
}
