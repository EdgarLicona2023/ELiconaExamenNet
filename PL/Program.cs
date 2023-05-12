using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
	public class Program
	{
		static void Main(string[] args)
		{
			
			bool salir = false;

			while (!salir)
			{

				try
				{
					Console.WriteLine("SELECCIONA UNA OPCION\n");
					Console.WriteLine("1. Edades");
					Console.WriteLine("2. Empleado");
					Console.WriteLine("3. Factorial");
					Console.WriteLine("4. Palabra Mas Larga");
					Console.WriteLine("5. Sopa de Letras");
					Console.WriteLine("6. SALIR\n");
					//Console.WriteLine("SELECCIONA UNA OPCION");
					int opcion = Convert.ToInt32(Console.ReadLine());

					switch (opcion)
					{
						case 1:
							Ejercicios.Ejer.Edad();
							break;

						case 2:
							Ejercicios.Ejer.Empleado();
							break;

						case 3:
							Ejercicios.Ejer.Factorial();
							break;

						case 4:
							Ejercicios.Ejer.PalabraMasLarga();
							break;

						case 5:
							Ejercicios.Ejer.SopaDeLetras();
							break;

						case 6:
							Console.WriteLine("SELECCIONASTE SALIR");
							salir = true;
							break;
						default:
							Console.WriteLine("ELIGE UNA OPCION");
							break;
					}

				}
				catch (FormatException e)
				{
					Console.WriteLine(e.Message);
				}
			}

			Console.ReadLine();

		}
	}
}
