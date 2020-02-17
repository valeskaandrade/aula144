using System;
using aula144TratExcecaoParte3.Entities;
using aula144TratExcecaoParte3.Entities.Exceptions;

namespace aula144TratExcecaoParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 144 - Programa de reserva de quarto com tratamento de exceção 
            try
            {
                Console.WriteLine("Informe os dados da reserva");

                Console.Write("Número do Quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Data de entrada (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de saída (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reserva;
                reserva = new Reservation(roomNumber, checkin, checkout);

                Console.WriteLine(reserva.ToString());
                Console.WriteLine();
                
                Console.WriteLine("Informe os dados da reserva para atualização");
                Console.Write("Nova Data de entrada (dd/MM/yyyy): ");

                DateTime novoCheckin = DateTime.Parse(Console.ReadLine());
                Console.Write("Nova Data de saída (dd/MM/yyyy): ");
                DateTime novoCheckout = DateTime.Parse(Console.ReadLine());
                DateTime now = DateTime.Now;
                
                reserva.UpdateDates(novoCheckin, novoCheckout);
                Console.WriteLine(reserva.ToString());
                
            }
            catch (FormatException e)
            { Console.WriteLine(e.Message); }
            catch (DomainException e)
            { Console.WriteLine(e.Message); }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

        }
    }
}
