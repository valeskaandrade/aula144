using System;
using aula142TratExcecao.Entities;

namespace aula142TratExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 142 - Programa de reserva de quarto sem tratamento de exceção 

            Console.WriteLine("Informe os dados da reserva");

            Console.Write("Número do Quarto: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Data de entrada (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de saída (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());
            if (checkout <= checkin)
            {
                Console.WriteLine("Erro na reserva: A data da saída deve ser posterior à entrada");
            }
            else
            {
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
                if (novoCheckin < now || novoCheckout < now)
                {
                    Console.WriteLine("Erro na reserva: As novas datas de chegada e saída devem ser posteriores à hoje");
                }
                else if (novoCheckout <= novoCheckin)
                {
                    Console.WriteLine("Erro na reserva: A data da saída deve ser posterior à entrada");
                }
                else
                {
                    reserva.UpdateDates(novoCheckin, novoCheckout);
                    Console.WriteLine(reserva.ToString());
                }
            }


        }
    }
}
