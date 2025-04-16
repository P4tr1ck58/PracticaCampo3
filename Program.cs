using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCampo3_PatrickMallqui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  Ejercicio 1 – Clasificador de pacientes según riesgo de salud Solicitar los datos de 5
             *  pacientes:
             *   Edad
             *   Presión sistólica
             *   Presión diastólica
             *   Nivel de glucosa en sangre (mg/dL)
             *  Clasificar a cada paciente en:
             *   Alto riesgo: Edad > 60 y presión > 140 o glucosa > 180
             *   Riesgo moderado: Edad entre 40 y 60 o presión entre 120-139 o glucosa entre 140-
             *  180
             *   Bajo riesgo: Todo dentro de rangos normales
             *  Mostrar:
             *   Tabla con los datos y la clasificación
             *   Total por categoría
             */
            string paciente, clasificacion;
            int edad, presionSis, presionDias, nivelGlu;
            int altoRiesgo = 0, riesgoModerado = 0, bajoRiesgo = 0;
            Console.WriteLine("Clasificador de Pacientes");
            Console.Write("Ingrese el número de pacientes: ");
            int pacientes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pacientes; i++)
            {
                Console.Write("Nombre del Paciente: ");
                paciente = Console.ReadLine();

                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Presion Sistolica: ");
                presionSis = int.Parse(Console.ReadLine());

                Console.Write("Presion Diastolica: ");
                presionDias = int.Parse(Console.ReadLine());

                Console.Write("Nivel glucosa: ");
                nivelGlu = int.Parse(Console.ReadLine());

                if (edad > 60 && (presionSis > 140 && presionDias > 90 )|| nivelGlu > 180)
                {
                    clasificacion = "Alto riesgo";
                    Console.WriteLine("Paciente en riesgo alto");
                    altoRiesgo++;
                }
                else if ((edad >= 40 && edad <= 60) || (presionSis >= 120 && presionDias <=139) ||(nivelGlu >140 && nivelGlu < 180) )
                {
                    clasificacion = "Riesgo moderado";
                    Console.WriteLine("Paciente en riesgo moderado");
                    riesgoModerado++;
                }
                else
                {
                    clasificacion = "Bajo riesgo";
                    Console.WriteLine("Paciente bajo riesgo");
                    bajoRiesgo++;
                }
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine($"----  Nombre: {paciente}                ----");
                Console.WriteLine($"----  Edad: {edad}                      ----");
                Console.WriteLine($"----  Presion Sistolica: {presionSis}   ----");
                Console.WriteLine($"----  Presion Diastolica: {presionDias} ----");
                Console.WriteLine($"----  Nivel Glucosa: {nivelGlu}         ----");
                Console.WriteLine($"----  Clasificacion: {clasificacion}    ----");
                Console.WriteLine("---------------------------------------------");
            }
            
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("---- Riesgo Alto: " + altoRiesgo + " --------");
            Console.WriteLine("---- Riesgo Moderado: " + riesgoModerado + " -------");
            Console.WriteLine("---- Riesgo Bajo: " + bajoRiesgo + " ----------");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
