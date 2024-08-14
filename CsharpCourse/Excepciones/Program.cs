using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Manuel\Desktop\2V4NRGO2.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\Manuel\Desktop\TELETRABAJO ESPAÑA.txt");
                Console.WriteLine(content2);

                throw new Exception("Ocurrio algo raro");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Aqui me he ejecutado, pase lo que pase");
            }

            Console.WriteLine("Aqui se sigue ejecutando");
        }
    }
}