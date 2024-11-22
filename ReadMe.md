# Single Responsibility Principle

## Her sýnýf tek bir sorumluluða sahiptir:
 - OrderCalculator.cs: Sipariþ toplamýný hesaplama iþlemlerinden sorumludur.
 - Order.cs: Sipariþ oluþturma iþlemlerinden sorumludur.
 - InvoiceGenerator.cs: Sipariþin faturalarýný oluþturur.
 - EmailService.cs: Sipariþ bilgi e-postalarýný gönderir.
 - OrderService.cs: Bu sýnýflarý koordine eder ve iþlemleri doðru sýrayla yönetir.