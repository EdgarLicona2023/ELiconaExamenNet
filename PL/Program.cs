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
			
		    int edad=0;
			string cad;
			
			Console.WriteLine("Numero de Personas");
		    edad = int.Parse(Console.ReadLine());
				
			Console.WriteLine("Ingrese las Edades:");
	

			int[] ed = new int[edad + 1];


			for (int i=1; i<=edad; i++)
			
			{
				cad = Console.ReadLine();	
				ed[i] = int.Parse(cad);

				if (ed[i] >= 18 )
					{
						Console.WriteLine("MAYOR DE EDAD");
					}
					else
					{
						Console.WriteLine("NO ES MAYOR DE EDAD");
					}
                    
			Console.ReadLine();	

			}

		}
	}
}
