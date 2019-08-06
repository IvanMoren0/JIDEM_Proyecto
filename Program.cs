using System;

namespace JIDEM_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e = new Estudiante();
            Console.WriteLine(----------"Ingrese Datos"------------);
            e.IngresarDatosEstudiante();
            e.ImprimirDatos();

            Console.ReadLine();

        }
    }
}

