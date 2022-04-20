/*
 * Классы должны быть открыты к расширениюи закрыты для изменения.
 * Иными словами, надо стремится к тому, чтобы классы обрастали поведением без изменения кода.
 * Принцип такой: У нас есть базовый напито, мы оборачиваем его в класс с молоком, в класс с сахаром и т.д.
 */
using Decorator.Models;

BeverageBase caputino = new Capuccino();
BeverageBase hotChocolate = new HotChocolate();
BeverageBase esspresso = new Espresso();




Console.WriteLine($"Beverage: {caputino.GetDescription()}, price: {caputino.GetCost()}");
Console.WriteLine($"Beverage: {hotChocolate.GetDescription()}, price: {hotChocolate.GetCost()}");
Console.WriteLine($"Beverage: {esspresso.GetDescription()}, price: {esspresso.GetCost()}");



Console.ReadKey();