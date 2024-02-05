using System.Globalization;
using System.Reflection;

namespace edu.PR.Ejercicio1._2901
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                        
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine("fecha actual: " + fechaActual);

            DateTimeFormatInfo infoFormatoCulturaEspecifica = CultureInfo.GetCultureInfo("es-SP").DateTimeFormat;
            Type tipo = infoFormatoCulturaEspecifica.GetType();
            PropertyInfo[] propiedadesFormatos = tipo.GetProperties();
            
            foreach (var propiedad in propiedadesFormatos)
            {
                
                if (propiedad.Name.Contains("Pattern"))
                {
                    string formato = propiedad.GetValue(infoFormatoCulturaEspecifica, null).ToString();
                    Console.WriteLine(propiedad.Name + ": " + formato + " " +
                                      fechaActual.ToString(formato));
                }
            }

            Console.WriteLine(fechaActual.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")) ;





        }


    }



}



