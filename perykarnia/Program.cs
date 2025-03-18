﻿
/* ------------------- Перукарня
Створити ієрархію класів для подання інформації про  послуги перукарні
	стрижка(вид, ціна)
	Фарбування(вид, ціна)
	Манікюр(вид, ціна, додаткові)
	Косметична процедура( вид, тривалість, ціна)
Створити програму для роботи перукарні
	Вивід усіх послуг перукарні,  впорядковуючи за видом та назвою послуги
	Додавання(вилучення, редагування)  послуги  у(з)  базу
	Додавання(вилучення, редагування)   клієнта перукарні
	Додавання(вилучення. редагування)   майстра(перукаря, косметолога у(з)  базу
	Додавання(вилучення. редагування)  продуктів у(з)  базу
	Можливість  попереднього замовлення послуги 
	Реєстрація виконання послуги(клієнт, послуга, дата, виконавець) що за послуга
клас клієнт клас майстра стаж тощо,клас попереднього засовдення* також тип послуг
	*/


Console.WriteLine("------Welcome to perycarnia-------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t1. Add new services");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all services");
Console.WriteLine("\t5. Dalete services");
Console.WriteLine("\t6. Sell services");
Console.WriteLine("\t7. register services");


Service service = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter Service name: ");
            service.Name = Console.ReadLine();
            Console.Write("Enter Service category: ");
            service.Category = Console.ReadLine();
            Console.Write("Enter Service price: ");
            service.Priсe = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Service quantity: ");

            break;
        case 4:
            Console.WriteLine("------- Service ---------");
            Console.WriteLine($"Name: {service.Name}");
            Console.WriteLine($"Category: {service.Category}");
            Console.WriteLine($"Price: {service.Priсe}");
            break;
    }
}

public class Service
{
	public string Name { get; set;}
    public double Priсe { get; set; }
    public string Category { get; set; }
}

public class Нairdresser
{
    public string Name { get; set; }
    public string Experience { get; set; }
    public string Age { get; set; }
}

public class Client
{
    public string Name { get; set; }

    public double Number { get; set; }
}

public class Order
{
    public string Name { get; set; }
    public string Haircut { get; set; }
    public double Hour { get; set; }
    public string Clientneme { get; set; }

}