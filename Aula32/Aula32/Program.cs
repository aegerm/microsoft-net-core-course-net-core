using Aula32.Entities;
using Aula32.Entities.Enums;
using System;

namespace Aula32
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.Id = 1;
            order.Moment = DateTime.Now;
            order.Status = OrderStatus.PENDING_PAYMENT;

            Console.WriteLine(order);

            string value = OrderStatus.PENDING_PAYMENT.ToString();
            Console.WriteLine(value);

            OrderStatus os = Enum.Parse<OrderStatus>("DELIVERED");
            Console.WriteLine(os);
        }
    }
}
