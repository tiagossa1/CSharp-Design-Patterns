// See https://aka.ms/new-console-template for more information

using DIP.Payments;

var paymentProcess = new PaymentProcess();
paymentProcess.Pay("ABC-123");

Console.ReadKey();