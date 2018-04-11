using System;

namespace Proyecto_Pesajes
{
    class Program
    {
        static void Main(string[] args)
        //Ivan Ruzbel Feliz Romero 16-MIIN-1-178
        //Francis Alvarez Luna 17-SIIN-1-117
        //Darwin Arias Peña 16-EIIT-1-043
        //Otoniel Hernandez 16-SIIN-1-100
        //Raquel Fortuna 16-MIIT-1-031
        {
            //Declaracion de Variales a utilizar 
            float[] peso_inicial = new float[5];
            float[] peso_basculas = new float[10];
            float promedio;
            float sumatoria = 0;
            float[] peso_promedios = new float[5];

            //Inicio 
            Console.WriteLine("\t\tProyecto Pesajes Grupo Ciberneticos\n\n");
            Console.WriteLine("\t\tIvan Ruzbel Feliz Romero 16-MIIN-1-178\n\n");
            Console.WriteLine("\t\tFrancis Alvarez Luna 17-SIIN-1-117\n\n");
            Console.WriteLine("\t\tDarwin Arias Peña 16-EIIT-1-043\n\n");
            Console.WriteLine("\t\tOtoniel Hernandez 16-SIIN-1-100\n\n");
            Console.WriteLine("\t\tRaquel Fortuna 16-MIIT-1-031\n\n");

            //Loop para Insertar Pesos Iniciales
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Inserte el Peso Inicial Para el Miembro #" + (i + 1) + ": ");
                peso_inicial[i] = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine();
            }


            //Loop Anidado Para Insertar Pesos de Las Basculas 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("Inserte el peso para el miembro " + (i + 1) + " en la bascula " + (j + 1) + " : ");
                    peso_basculas[j] = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine();
                    sumatoria = sumatoria + peso_basculas[j];
                }

                promedio = sumatoria / 10;
                sumatoria = 0;
                peso_promedios[i] = promedio;
                Console.WriteLine("\n####################################################\n");
            }

            Console.WriteLine("\n####################################################\n");


            //Resultados
            Console.WriteLine("\t\tResultados");
            Console.WriteLine("####################################################\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Miembro #" + (i + 1) + "\n");
                Console.WriteLine("Peso Inicial: " + peso_inicial[i] + "\n");
                Console.WriteLine("Peso Promedio: " + peso_promedios[i] + "\n\n");
                if (peso_promedios[i] > peso_inicial[i])
                    Console.WriteLine("SUBIO " + (peso_promedios[i] - peso_inicial[i]) + " Kilos");
                else
                    Console.WriteLine("BAJO " + (peso_inicial[i] - peso_promedios[i]) + " Kilos");
                Console.WriteLine("\n####################################################\n");
                Console.ReadKey();
            }


        }
    }
}
