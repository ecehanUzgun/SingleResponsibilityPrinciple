namespace SRP_Validate
{
    public class OrderService
    {
        //OrderService varolan sınıfları koordine etmekle sorumlu

        private readonly Order _order;
        private readonly OrderCalculator _orderCalculator;
        private readonly EmailService _emailService;
        private readonly InvoiceGenerator _invoiceGenerator;

        //Dependency Injection
        public OrderService(OrderCalculator orderCalculator, Order order, EmailService emailService, InvoiceGenerator invoiceGenerator)
        {
            _orderCalculator = orderCalculator;
            _order = order;
            _emailService = emailService;
            _invoiceGenerator = invoiceGenerator;
        }

        public void ProcessOrder()
        {
            //Toplam sipariş tutarını hesapla
            _orderCalculator.CalculateOrderTotal();

            //Siparişi oluştur
            _order.PlaceOrder();

            //Fatura oluştur
            _invoiceGenerator.GenerateInvoice();

            //E-posta gönder
            _emailService.SendOrderConfirmationEmail();
        }
    }
}
