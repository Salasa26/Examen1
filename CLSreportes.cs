using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class CLSreportes
    {

        public static void ReportesConsultar()
        {   

            int y = 0;

            while (y != 1)
            {
                int x = 0;
                Console.Clear();
                Console.WriteLine("Digite el numero de cedula del empleado el cual desea encontrar");
                string buscar = Console.ReadLine();


                for (int i = 0; i < CLSempleado.infoCed.Length; i++)
                {
                    if (CLSempleado.infoCed[i] == buscar)
                    {
                        Console.WriteLine("*Empleado encontrado.");
                        Console.WriteLine("Seq/ Cedula/  Nombre/             Direccion/                       Telefono/   Salario/");
                        Console.WriteLine("*****************************************************************************************");
                        Console.WriteLine(i + "     " + CLSempleado.infoCed[i] + "  " + CLSempleado.infoNom[i] + "  " + CLSempleado.infoDirec[i] + "  " + CLSempleado.infoTel[i] + "  $" + CLSempleado.infoSal[i]);
                        Console.WriteLine("_____________________________________________________________________________________________");

                        Console.WriteLine("Digite 1 para volver al menu de reportes o cualquier otra tecla para hacer otra busqueda");
                        int.TryParse(Console.ReadLine(), out y);
                        x = -1;


                    }

                    x++;

                }

                if (x == CLSempleado.infoCed.Length)
                {
                    Console.WriteLine("*ID: " + buscar + " No encontrado.");
                    Console.WriteLine("Digite 1 para volver al menu de reportes o cualquier otra tecla para hacer ");
                    int.TryParse(Console.ReadLine(), out y);
                }


            }

        }

        public static void ReportesPromedio()
        {
            Console.Clear();
            float sumaSalarios = 0.0f;
            int x = 0;
            for (int i = 0; i < CLSempleado.frec; i++)
            {


                sumaSalarios = sumaSalarios + CLSempleado.infoSal[i];
            }

            Console.WriteLine("Sumatoria de salarios: $" + sumaSalarios);

            ReportesPromedioCalc(sumaSalarios,CLSempleado.frec); //Funcion con parametros 1

            while (x != 1)
            {
                Console.WriteLine("Digite 1 y luego la tecla enter para volver al menu principal:");
                int.TryParse(Console.ReadLine(), out x);
            }


        }

        static float ReportesPromedioCalc(float n1, int n2) //Funcion con parametros 1

        {
            float resultado = n1 / n2;

            Console.WriteLine("El promedio de salarios es: $"+resultado);
            return resultado;

        }

        public static void ReportesMayorMenor()
        {
            int i = 0;

            Console.WriteLine(ReportesMayorCalc(i));
            Console.WriteLine(ReportesMenorCalc(i));


            i = 0;
            while (i != 1)
            {
                Console.WriteLine("Digite 1 y luego la tecla enter para volver al menu principal:");
                int.TryParse(Console.ReadLine(), out i);
            }

        }

        static string ReportesMayorCalc(int n1) 

        {
            float resultadoMayor = CLSempleado.infoSal[0];
            

            for (n1 = 0; n1 < (CLSempleado.frec); n1++)
            {
                if (resultadoMayor < CLSempleado.infoSal[n1])
                { resultadoMayor = CLSempleado.infoSal[n1];
                    
                }   

            }

            string resultado = ("El mayor salario es: $" + resultadoMayor);



            return resultado;

        }

        static string ReportesMenorCalc(int n1)

        {
            float resultadoMenor = CLSempleado.infoSal[0];
            

            for (n1 = 0; n1 < (CLSempleado.frec); n1++)
            {
                if (resultadoMenor > CLSempleado.infoSal[n1])
                {
                    resultadoMenor = CLSempleado.infoSal[n1];
                    
                }

            }

            string resultado = ("El menor salario es: $" + resultadoMenor);



            return resultado;

        }







    }
}
