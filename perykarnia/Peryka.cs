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

		public void RemoveProduct() {
			string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
			services = JsonSerializer.Deserialize<List<Service>>(jsonToLoad);
		}
	} 
}
