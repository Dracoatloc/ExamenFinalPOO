using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3ExamenFinal.Classes
{
    class PreguntarNombres
    {
        public static void CapturarNombres()
        {
            int verificador = 2;

            try
            {
                Console.WriteLine("Por favor ingresa tu nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Por favor ingresa tu apellido: ");
                string apellido = Console.ReadLine();

                if(nombre.Length <= 2 || apellido.Length <= 2)
                {
                    verificador = verificador / 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nombre/apellido no válido. ");
                Console.ReadKey();
            }
        }
    }
}
