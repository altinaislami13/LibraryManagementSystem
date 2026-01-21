using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace LibraryApp.Data
{

    public static class DataStore
    {
        private static string folder = "Data";
        private static string filePath = Path.Combine(folder, "library.json");

        public static void Save(List<Item> items)
        {
          
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(items, options);
            File.WriteAllText(filePath, json);
        }

        public static List<Item> Load()
        {
         
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (!File.Exists(filePath))
                return new List<Item>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Item>>(json) ?? new List<Item>();
        }
    }

}
