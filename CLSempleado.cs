using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class CLSempleado
    {

        public static int frec = new int();
        public static int Cap = 5; //La capacidad maxima sera Cap-1
        public static string[] infoCed = new string[Cap];
        public static string[] infoNom = new string[Cap];
        public static string[] infoDirec = new string[Cap];
        public static string[] infoTel = new string[Cap];
        public static float[] infoSal = new float[Cap];
        public static string alerta = "";


        CLSempleado[] empl = new CLSempleado[20];

        public string cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public float salario { get; set; }

        public CLSempleado(string Cedula, string Nombre, string Direccion, string Telefono, float Salario)
        {
            this.cedula = Cedula;
            this.nombre = Nombre;
            this.direccion = Direccion;
            this.telefono = Telefono;
            this.salario = Salario;
        }


        //Metodos
        public static void agregar()
        {
            int x = 1;

            Console.Clear();
            Console.WriteLine("***Agregando empleado***");
            Console.WriteLine("Empleados en el sistema: " + frec);
            Console.WriteLine("Capacidad maxima de empleados: " + (Cap-1));

            Console.WriteLine("Cuantos empleados desea agregar?");
            int.TryParse(Console.ReadLine(), out x);
            

            if ((frec+(x-1)) < (Cap - 1) )
            {
                
                for (int i = 0; i < x; i++)
                {
                    Console.Clear();
                    Console.WriteLine("*Agregando empleado #" + (i + 1));
                    
                    
                    
                    Console.WriteLine("Digite la cedula:");
                    string cedula = Console.ReadLine();
                    Console.WriteLine("Digite el nombre:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Digite la direccion:");
                    string direccion = Console.ReadLine();
                    Console.WriteLine("Digite el numero de telefono:");
                    string telefono = Console.ReadLine();
                    Console.WriteLine("Digite el salario ($):");
                    float salario = float.Parse(Console.ReadLine());

                    CLSempleado empleado1 = new CLSempleado(cedula, nombre, direccion, telefono, salario);
                    Console.WriteLine("Agregando empleado: " + (frec + 1) + " " + empleado1.cedula + " " + empleado1.nombre + " " + empleado1.direccion + " " + empleado1.telefono + " $" + empleado1.salario);
                    Console.WriteLine(frec + 1);

                    infoCed[frec] = (empleado1.cedula);
                    infoNom[frec] = (empleado1.nombre);
                    infoDirec[frec] = (empleado1.direccion);
                    infoTel[frec] = (empleado1.telefono);
                    infoSal[frec] = empleado1.salario;
                    frec++;

                }
            }
            if ((frec+ (x - 1)) >= (Cap - 1))
            { alerta = "*La cantidad seleccionada sobrepasa la cantidad maxima de empleados permitida."; }

        }
        public static void Consultar()
        {
            Console.Clear();
            int x = 0;
            Console.WriteLine("                              ***Consulta Reporte General***");
            Console.WriteLine("Seq/ Cedula/  Nombre/             Direccion/                       Telefono/   Salario/");
            Console.WriteLine("*****************************************************************************************");
            for (int i = 0; i < frec; i++)
            {
                Console.WriteLine(i + "     " + infoCed[i] + "  " + infoNom[i] + "  " + infoDirec[i] + "  " + infoTel[i] + "  $" + infoSal[i]);
                Console.WriteLine("_____________________________________________________________________________________________");

            }
            Console.WriteLine("                       ***Fin del reporte general***");

            while (x != 1)
            {
                Console.WriteLine("Digite 1 y luego la tecla enter para volver al menu principal:");
                int.TryParse(Console.ReadLine(), out x);
            }


            Console.ReadLine();
        }


        public static void Modificar() //Opcion 3
        {

            int x = 0;

            int z = 0;
            while (x != 1)
            {

                Console.Clear();

                Console.WriteLine("Digite el numero de cedula del empleado el cual desea modificar");
                string buscar = Console.ReadLine();
                int y = 0;
                for (int i = 0; i < infoCed.Length; i++)
                {
                    if (infoCed[i] == buscar)
                    {

                        Console.WriteLine(buscar + " fue encontrado en la sequencia: " + i);
                        Console.WriteLine("Digite (1) para SI o cualquier otro digito para NO:");
                        Console.WriteLine("Desea modificar el nombre?:");
                        int.TryParse(Console.ReadLine(), out z);
                        if (z == 1)
                        { Console.WriteLine("Ingrese el nuevo dato:"); infoNom[i] = Console.ReadLine(); z = 0; Console.WriteLine("*Dato modificado."); }

                        Console.WriteLine("Desea modificar la direccion?:");
                        int.TryParse(Console.ReadLine(), out z);
                        if (z == 1)
                        { Console.WriteLine("Ingrese el nuevo dato:"); infoDirec[i] = Console.ReadLine(); z = 0; Console.WriteLine("*Dato modificado."); }

                        Console.WriteLine("Desea modificar el telefono?:");
                        int.TryParse(Console.ReadLine(), out z);
                        if (z == 1)
                        { Console.WriteLine("Ingrese el nuevo dato:"); infoTel[i] = Console.ReadLine(); z = 0; Console.WriteLine("*Dato modificado."); }

                        Console.WriteLine("Desea modificar el salario?:");
                        int.TryParse(Console.ReadLine(), out z);
                        if (z == 1)
                        { Console.WriteLine("Ingrese el nuevo dato:"); infoSal[i] = float.Parse(Console.ReadLine()); z = 0; Console.WriteLine("*Dato modificado."); }


                        Console.WriteLine("Digite cualquier otra numero si desea agregar otro usuario o (1) para salir: ");
                        int.TryParse(Console.ReadLine(), out x);

                        alerta = "";
                        i = infoCed.Length;
                    }

                    y++;
                }

                if (y == infoCed.Length)
                {
                    Console.WriteLine("*" + buscar + " no fue encontrado en la base de datos.");
                    Console.WriteLine("Digite cualquier otro numero para realizar otra busqueda o (1) para salir: ");
                    int.TryParse(Console.ReadLine(), out x);


                }


            }

        }

        public static void Eliminar() //Opcion 4
        {
            Console.Clear();
            int y = 0;
            int x = 0;
            Console.WriteLine("Digite el numero de cedula del empleado que desea eliminar:");
            string buscar = Console.ReadLine();

            while (x != 1)
            {
                for (int i = 0; i < infoCed.Length; i++)
                {
                    if (infoCed[i] == buscar)
                    {
                        Console.WriteLine("Eliminando datos del ID: " + infoCed[i]);
                        int z = 0;
                        for (z = i; z < frec; z++)
                        {

                            infoCed[z] = infoCed[z + 1];
                            infoNom[z] = infoNom[z + 1];
                            infoDirec[z] = infoDirec[z + 1];
                            infoTel[z] = infoTel[z + 1];
                            infoSal[z] = infoSal[z + 1];

                        }
                        frec--;

                        Console.WriteLine("*Datos eliminados");
                        Console.WriteLine("Digite cualquier otro numero para realizar otra busqueda o (1) para salir: ");
                        int.TryParse(Console.ReadLine(), out x);
                        
                    }

                    y++;

                }


                if (y == infoCed.Length && x != 1)
                {
                    Console.WriteLine("*" + buscar + " no fue encontrado en la base de datos.");
                    Console.WriteLine("Digite cualquier otro numero para realizar otra busqueda o (1) para salir: ");
                    int.TryParse(Console.ReadLine(), out x);


                }




            }

        }

        public static void Inicializar() //Opcion 5
        {


            for (int i = 0; i < infoCed.Length; i++)
            {

                infoCed[i] = "";
                infoNom[i] = "";
                infoDirec[i] = "";
                infoTel[i] = "";
                infoSal[i] = 0;

            }
            Console.WriteLine("*Datos incializados");
            frec = 0;
            int x = 0;
            while (x != 1)
            {
                Console.WriteLine("Digite 1 y luego la tecla enter para volver al menu principal:");
                int.TryParse(Console.ReadLine(), out x);
            }


        }

    }
}
