using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace perykarnia
{
	internal class Peryka
	{
		List<Service> services = new();


		public void AddProduct()
        {
			var newItem = new Service();

			Console.Write("Enter Service name: ");
			newItem.Name = Console.ReadLine();
			Console.Write("Enter Service category: ");
			newItem.Category = Console.ReadLine();
			Console.Write("Enter Service price: ");
			newItem.Priсe = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter Service quantity: ");

			services.Add(newItem);
		}

		public void Load() {
			string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
			services = JsonSerializer.Deserialize<List<Service>>(jsonToLoad);
		}

		public void Save()
		{
            string jsonToSave = JsonSerializer.Serialize(services);
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/services_db.json", jsonToSave);

        }
        public void Services()
			
            {
                Console.WriteLine("------- Service ---------");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Price: {item.Priсe}");
            }
		public void Delate()
		{
			for (int i = 0; i < services.Count; ++i)
				Console.WriteLine($"[{i}] Service: " + services[i].Name);

			Console.WriteLine("Enter number to delate:");
			int numToDelete = Convert.ToInt32(Console.ReadLine());

			if (numToDelete < 0 || numToDelete >= services.Count) ;

		   } 
    } 
}
