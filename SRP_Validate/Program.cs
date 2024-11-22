namespace SRP_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            OrderCalculator orderCalculator = new OrderCalculator();
            EmailService emailService = new EmailService();
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

            OrderService orderService = new OrderService(orderCalculator, order, emailService, invoiceGenerator);

            orderService.ProcessOrder();
        }
    }
}
