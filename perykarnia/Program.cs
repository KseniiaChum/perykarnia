
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


using perykarnia;
using System.Text.Json;

Console.WriteLine("------Welcome to perycarnia-------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t1. Add new services");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all services");
Console.WriteLine("\t5. Dalete services");
Console.WriteLine("\t6. Sell services");
Console.WriteLine("\t7. register services");


Peryka p = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            p.AddProduct();
            break;
        case 2:
            p.Load();
           break;
        case 3:
            p.Save();
            break;
        case 4:
            p.Services();
            break;
        case 5:
            p.Delate();
           
            break;


    }
}
