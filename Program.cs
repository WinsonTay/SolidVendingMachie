// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var menuLoader = new CsvMenuLoader();
var vendingMachine = new VendingMachine(menuLoader);
vendingMachine.Start();