using ConsoleUI;
using System;

static double Add(double x, double y) => x + y;
Console.WriteLine(Add(4, 3));

PersonModel frodo = new() { Id = "1", FirstName = "Frodo", LastName = "Baggins" };
Console.WriteLine($"Hello, {frodo.FirstName} {frodo.LastName}! {frodo.Id}");

PersonModel sam = new("2", "Samwise", "Gamgee");
Console.WriteLine($"Hello, {sam.FirstName} {sam.LastName}! {sam.Id}");

PersonModel p3 = null;
if (p3 is not null)
{
    Console.WriteLine($"Hello, {p3.FirstName} {p3.LastName}! {p3.Id}");
}