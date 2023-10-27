using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class CLSmenu
    {
        static int opcion = 0;
        

        public static void desplegar()
        {


            do
            {
                Console.Clear();
                Console.WriteLine(CLSempleado.alerta);
                CLSempleado.alerta = "";
                Console.WriteLine("***Menu Principal***");
                Console.WriteLine("1-Agregar empleados");
                Console.WriteLine("2-Consultar empleados");
                Console.WriteLine("3-Modificar empleados");
                Console.WriteLine("4-Borrar empleados");
                Console.WriteLine("5-Inicializar Arreglos");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("7-Salir");
                Console.WriteLine("Digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: CLSempleado.agregar(); break;
                    case 2: CLSempleado.Consultar(); break;
                    case 3: CLSempleado.Modificar(); break;
                    case 4: CLSempleado.Eliminar(); break;
                    case 5: CLSempleado.Inicializar(); break;
                    case 6: reportes(); break;
                    case 7: break;
                    default:
                        break;

                }

            } while (opcion != 7);


        }

        public static void reportes()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("***Menu de reportes***");
                Console.WriteLine("1-Consultar empleados por numero de cedula");
                Console.WriteLine("2-Lista Organizada de empleados");
                Console.WriteLine("3-Promedio de salarios");
                Console.WriteLine("4-Salario mas alto y mas bajo");
                Console.WriteLine("5-Salir");

                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: CLSreportes.ReportesConsultar(); break;
                    case 2: break;//Pendiente
                    case 3: CLSreportes.ReportesPromedio(); break;
                    case 4: CLSreportes.ReportesMayorMenor(); break;
                    case 5: break;

                    default:
                        break;

                }

            } while (opcion != 5);


        }

    }
}
