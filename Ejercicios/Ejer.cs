using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios
{
    public class Ejer
    {

		public static void Edad()
        {
			int edad, mayor, menor, suma=0,SUMA=0;
			string cad;

			Console.WriteLine("Numero de Personas");
			edad = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese las Edades:");


			int[] ed = new int[edad + 1];


			for (int i = 1; i <= edad; i++)

			{
				cad = Console.ReadLine();
				ed[i] = int.Parse(cad);

				if (ed[i] >= 18)
				{
					mayor = 1;
					suma += mayor;
					Console.WriteLine("MAYOR DE EDAD");
				}
				else
				{
					menor = 1;
					SUMA += menor;
					Console.WriteLine("NO ES MAYOR DE EDAD");
				}

			

			}
			Console.WriteLine("Cantidad de Personas Mayores: " + suma);
			Console.WriteLine("Cantidad de Personas Menores: " + SUMA);

			Console.ReadLine();


		}


		public static void Factorial()
		{
			

			Console.WriteLine("Introduce El Numero");
			int num = Convert.ToInt32(Console.ReadLine());
			int factorial = 1;
			for (int i = 1; i <= num; i++)
			{
				factorial = factorial * i;
			}
			Console.WriteLine("El Factorial de " + num + " es:" + factorial);
			Console.ReadLine();
		}

		public static void PalabraMasLarga()
		{
			string textoLargo = "Despues de bañar a mi perro este se revuelca en la tierra";
			string palabraMasLarga = "";
			string[] palabras = textoLargo.Split(' ');
			Console.WriteLine("Palabra: " + "Despues de bañar a mi perro este se revuelca en la tierra");

			foreach(var palabra in palabras)
			{
				if(palabra.Length > palabraMasLarga.Length)
				{
					palabraMasLarga = palabra;
				}
					
			}

			Console.WriteLine("La palabra mas larga de la oracios es: " + palabraMasLarga);	
			Console.ReadLine();
		}

	}
}
