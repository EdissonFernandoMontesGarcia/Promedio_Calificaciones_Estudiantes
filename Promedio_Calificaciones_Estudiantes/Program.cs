/* La Universidad UNAD requiere un programa que promedie las calificaciones de un grupo de estudiantes así:
 * Por teclado se debe solicitar la cantidad de estudiantes a valorar. (ejemplo si digita 5 deberá repetir los pasos siguientes 5 veces).
 * Se requiere captura por teclado de nombre y nota (siendo la notas un número flotante).
 * Se debe calcular e imprimir en consola el valor de la notas promedio de los estudiantes.
 * Nombre: Edisson Fernando Montes García
 * Programa: Ingeniería de Sistemas
 * Grupo:213022_71
 * Código Fuente: autoría Propia: Edisson Fernando Montes García*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificacion_Promedio_Estudiantes
{
    internal class Program
    {
        struct Datos
        {
            public float nota1, nota2, nota3, nota4, nota5, promedioNota;
            public string nombreCompleto;

        }
        static void Main(string[] args)
        {

            Console.Write("Bienvenidos, descubra el promedio de los estudiantes del Colegio Suarez\n\n");
            Console.Write("Nota: Las calificaciones van de 1 a 10\n\n");
            Console.Write("Cuantos estudiantes va a evaluar ? :");

            int cantidad = int.Parse(Console.ReadLine());
            Datos[] estudiante = new Datos[cantidad];
            Datos[] nota = new Datos[cantidad];

            for (int i = 0; i < cantidad; i++) //ciclo 
            {
                
                Console.Write("Escriba Nombre Completo del estudiante:");
                estudiante[i].nombreCompleto = Console.ReadLine();
                Console.Write("Digite primera nota: ");
                nota[i].nota1 = float.Parse(Console.ReadLine());
                if (nota[i].nota1 > 10) //condicional
                {
                    Console.WriteLine("La nota no coincide con el rango de calificación.");
                }
                Console.Write("Digite segunda nota: ");
                nota[i].nota2 = float.Parse(Console.ReadLine());
                if (nota[i].nota2 > 10) //condicional
                {
                    Console.WriteLine("La nota no coincide con el rango de calificación.");
                }
                Console.Write("Digite tercera nota: ");
                nota[i].nota3 = float.Parse(Console.ReadLine());
                if (nota[i].nota3 > 10)
                {
                    Console.Write("La nota no coincide con el rango de calificación.");
                }
                Console.Write("Digite cuarta nota: ");
                nota[i].nota4 = float.Parse(Console.ReadLine());
                if (nota[i].nota4 > 10)
                {
                    Console.WriteLine("La nota no coincide con el rango de calificación.");
                }
                Console.Write("Digite quinta nota: ");
                nota[i].nota5 = float.Parse(Console.ReadLine());
                if (nota[i].nota5 > 10)
                {
                    Console.WriteLine("La nota no coincide con el rango de calificación.");
                }
                nota[i].promedioNota = (nota[i].nota1 + nota[i].nota2 + nota[i].nota3 + nota[i].nota4 + nota[i].nota5) / 5;
            }
            for (int i = 0; i < cantidad; i++) //ciclo
            {
                Console.WriteLine("Nombre: " + estudiante[i].nombreCompleto);
                Console.WriteLine("Promedio Final: " + nota[i].promedioNota);
                if (nota[i].promedioNota > 6 && nota[i].promedioNota <= 10)
                {
                    Console.WriteLine("Aprobó");
                }
                else
                {
                    Console.WriteLine("Reprobó");
                }
            }   
            Console.ReadKey();
        }
    }
}

