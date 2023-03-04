// See https://aka.ms/new-console-template for more information

// For context: Client is a CRUD class for possible Client object and Notify is a class that notifies the client about something.
// In the given example, both Client and Notify class methods were introduced here, making Program.cs a god class.
// This breaks the Single Responsibility principle that stats that a class should only have one reason to change and it should NOT have multiple things happening in the same class.
// So, the proposed solution was to break the methods into Client and Notify classes.

Console.ReadKey();