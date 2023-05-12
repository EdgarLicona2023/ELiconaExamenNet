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
			string leer;

			Console.WriteLine("Numero de Personas");
			edad = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese las Edades:");


			int[] ed = new int[edad + 1];


			for (int i = 1; i <= edad; i++)

			{
				leer = Console.ReadLine();
				ed[i] = int.Parse(leer);

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
			string txLargo;

			Console.WriteLine("INGRESE LA PALABRA:");
			txLargo = Console.ReadLine();

			
			string palabraMasLarga = "";

			string[] palabras = txLargo.Split(' ');
			

			foreach(var palabra in palabras)
			{
				if(palabra.Length > palabraMasLarga.Length)
				{
					palabraMasLarga = palabra;
				}
					
			}

			Console.WriteLine("La Palabra mas Larga de la Oracion es: " + palabraMasLarga);	
			Console.ReadLine();
		}

		public static void SopaDeLetras()
		{
			
			string palabra;

			Console.WriteLine("INGRESE LA PALABRA:");
			palabra = Console.ReadLine();

			palabra = string.Concat(palabra.OrderBy(ch => ch));

			Console.WriteLine("Palabra Ordenada: " + palabra);
		}

		public static void Empleado()
		{
			
			string nombre;
			string apellido;
			double diasTrabajados;
			double pagoPorDia;

	
			Console.WriteLine("Salario\n");
			Console.WriteLine("Nombre Empleado: ");
			nombre = Console.ReadLine();
			
			Console.WriteLine("Apellido Empleado:");
			apellido = Console.ReadLine();

			Console.WriteLine("Dias Trabajados:");
			diasTrabajados = double.Parse(Console.ReadLine());

			
			Console.WriteLine("Pago Por Dia:");
			pagoPorDia = double.Parse(Console.ReadLine());

			// Realizar cálculos
			double calculaSueldo = diasTrabajados * pagoPorDia;
			
			// Restamos al salario bruto
			double sueldoNeto = calculaSueldo;
		
			
			// Imprimir los valores
		
			Console.WriteLine("Nombre Empleado: " + nombre);
			Console.WriteLine("Apelldio Empleado: " + apellido);
			//Console.WriteLine("Dias Trabajados: " + diasTrabajados);
			//Console.WriteLine("Sueldo Diario: " + pagoPorDia);
			Console.WriteLine("Sueldo: " + sueldoNeto);
			
		
		}

	}
}
