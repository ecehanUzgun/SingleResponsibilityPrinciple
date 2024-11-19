namespace SRP_Validate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderCalculator calculator = new OrderCalculator();
            calculator.CalculateOrderTotal();

            Order order = new Order();
            order.PlaceOrder();

            EmailService emailService = new EmailService();
            emailService.SendOrderConfirmationEmail();
                
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            invoiceGenerator.GenerateInvoice();
        }
    }
}
