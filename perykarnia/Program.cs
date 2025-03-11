
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

public class Perycarnia
{
	public string Name { get; set;}
    public double Prise { get; set; }
    public double Category{ get; set; }
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
    public string haircut { get; set; }
    public string hour { get; set; }
}