# Single Responsibility Principle

## Her s�n�f tek bir sorumlulu�a sahiptir:
 - OrderCalculator.cs: Sipari� toplam�n� hesaplama i�lemlerinden sorumludur.
 - Order.cs: Sipari� olu�turma i�lemlerinden sorumludur.
 - InvoiceGenerator.cs: Sipari�in faturalar�n� olu�turur.
 - EmailService.cs: Sipari� bilgi e-postalar�n� g�nderir.
 - OrderService.cs: Bu s�n�flar� koordine eder ve i�lemleri do�ru s�rayla y�netir.