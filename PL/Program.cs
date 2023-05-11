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

					Console.WriteLine("1. Edades");
					Console.WriteLine("2. Update");
					Console.WriteLine("3. Delete");
					Console.WriteLine("4. GetAll");
					Console.WriteLine("5. GetById");
					Console.WriteLine("6. SALIR");
					Console.WriteLine("SELECCIONA UNA OPCION");
					int opcion = Convert.ToInt32(Console.ReadLine());

					switch (opcion)
					{
						case 1:
							Ejercicios.Ejer.Edad();
							break;

						//case 2:
						//	PL.Producto.UpdateEF();
						//	break;

						//case 3:
						//	PL.Producto.DeleteEF();
						//	break;

						//case 4:
						//	PL.Producto.GetAllEF();
						//	break;

						//case 5:
						//    PL.Producto.GetByIdEF();
						//    break;  

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
