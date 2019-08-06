using System;
using System.Collections.Generic;
using System.Text;

namespace JIDEM_Proyecto
{
    class Estudiante
    {

        #region Atributos 
        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NDocumento { get; set; }
        public int Curso { get; set; }
        #endregion

        #region Metodos 
        public void IngresarDatosEstudiante()
        {

            Console.WriteLine("Ingrese Nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Apellido");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese numero documento");
            NDocumento = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Curso");
            Curso  = int.Parse(Console.ReadLine());
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("INSCRITO");
            Console.WriteLine();

            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Apellido:{Apellido}");
            Console.WriteLine($"NDocumento:{NDocumento}");
            Console.WriteLine($"Curso:{Curso}");


        }
        #endregion
    }
}