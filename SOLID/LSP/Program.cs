// See https://aka.ms/new-console-template for more information

using LSP.Payments;

// By using Liskov substitution principle, we are able to remove or re-use CreditCard, DebitCard or BarclaysRewards based on business logic without breaking the program since all of the classes inherit from IPaymentInstrument interface.
// You can test it by uncomment the following lines - both have Validate and Collect methods implemented.
// var card = new CreditCard();
// var card = new DebitCard();
var card = new BarclaysRewards();

card.Validate();
card.Collect();

Console.ReadKey();