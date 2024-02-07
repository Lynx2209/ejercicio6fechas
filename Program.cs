using System.Net.Http.Headers;

namespace ejercicio6fecha
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Que mes desea (en numero) : ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos dias tiene tu mes");
            int diasQueTieneElMes = int.Parse(Console.ReadLine());
            int anyo = 2024;
            Console.WriteLine("Que dia desea (en ingles) : ");
            string diaDeLaSemana = Console.ReadLine();

            for (int i = 1; i <= diasQueTieneElMes; i++)
            {
                DateTime fecha = new DateTime(anyo, mes, i);
                if (fecha.DayOfWeek.Equals(diaDeLaSemana))
                {
                    Console.WriteLine(fecha);
                }
            }

        }
    }
}