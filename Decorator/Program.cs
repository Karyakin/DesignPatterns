/*
 * Классы должны быть открыты к расширениюи закрыты для изменения.
 * Иными словами, надо стремится к тому, чтобы классы обрастали поведением без изменения кода.
 * Принцип такой: У нас есть базовый напиток или вода, мы оборачиваем его в класс с молоком, в класс с сахаром и т.д.
 * т.е базовый функционал мы не трогаем, а лишь декарируем его другим функционалом
 * _________________________________________________________________________________
 * 1- Мы наследуем интерфейс а не поведение(для приемственности типа)
 * 2- Композиция для расширения поведения
 * 3- Композиция дает свободу выполнения
 * 4- Вместо абстрактного класса может быть и интерфей - все в зависимости от исходной структуры
 */

using Decorator.Decorator;
using Decorator.Models;


BeverageBase esspresso = new Espresso();

BeverageBase greenTea = new GreenTea();

Print(esspresso);
Print(greenTea);

Console.WriteLine("_____________________________________________________________________");

BeverageBase capuccino = new SugarCondiment(new MilkCondiment(new Espresso()));
BeverageBase blackTea = new BlackTeaCondiment(new Water());
BeverageBase blackTeaWithSugar = new SugarCondiment(new BlackTeaCondiment(new Water()));
BeverageBase blackTeaWithSugarAndMilk = new MilkCondiment(new SugarCondiment(new BlackTeaCondiment(new Water())));

Print(capuccino);
Print(blackTea);
Print(blackTeaWithSugar);
Print(blackTeaWithSugarAndMilk);

Console.ReadKey();

static void Print(BeverageBase beverege)
{
  Console.WriteLine($"Beverage: {beverege.GetDescription()}, price: {beverege.GetCost()}");

}