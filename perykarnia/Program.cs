
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


List<Service> services= new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            var newItem = new Service();

            Console.Write("Enter Service name: ");
            newItem.Name = Console.ReadLine();
            Console.Write("Enter Service category: ");
            newItem.Category = Console.ReadLine();
            Console.Write("Enter Service price: ");
            newItem.Priсe = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Service quantity: ");

            services.Add(newItem);
            break;
        case 2:
            string jsonToSave = JsonSerializer.Serialize(services);
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/services_db.json", jsonToSave);
            break;
        case 3:
            string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
            services = JsonSerializer.Deserialize<List<Service>>(jsonToLoad);
            break;
        case 4:
            foreach (var item in services)
            {
                Console.WriteLine("------- Service ---------");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Price: {item.Priсe}");
            }
            break;
        case 5:
            for (int i = 0; i < services.Count; ++i)
                Console.WriteLine($"[{i}] Service: " + services[i].Name);

            Console.WriteLine("Enter number to delate:");
            int numToDelete = Convert.ToInt32(Console.ReadLine());

            if (numToDelete < 0 || numToDelete >= services.Count)
            {
                Console.WriteLine("Number out of range!");
            break;
            }
            services.RemoveAt(numToDelete);
            Console.WriteLine("Service deleted successfully!");
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