// See https://aka.ms/new-console-template for more information

using LSP.Payments;

// var card = new CreditCard();
// var card = new DebitCard();
var card = new BarclaysRewards();

card.Validate();
card.Collect();

Console.ReadKey();