using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms.PolymorphicApproach
{
    public class PolymorphicAnimalMenu
    {
        static List<Animal> animals = new List<Animal>();
        public void ShowAnimalsMenu()
        {
            while (true)
            {
                Console.WriteLine("Animals Menu:");
                Console.WriteLine("1. Choose from existing animals");
                Console.WriteLine("2. Add animal");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ChooseExistingAnimal();
                        break;
                    case "2":
                        AddNewAnimal();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }

        }

        static void LoadAnimals()
        {
            string path = @"C:\Users\Ilija\source\repos\OldMacDonaldsFarms\OldMacDonaldsFarms\animals.json";
            try
            {
                if (File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);
                    var data = JsonSerializer.Deserialize<List<CustomAnimal>>(jsonString);

                    animals.Clear();
                    animals.AddRange(data);
                }
                else
                {
                    Console.WriteLine("File does not exist at the specified path.");
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"An error occurred while deserializing the JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void ChooseExistingAnimal()
        {
            LoadAnimals();

            while (true)
            {
                Console.Write("Choose an animal OR choose ZERO to exit the program: ");
                string input = Console.ReadLine();
                int choice;

                if (int.TryParse(input, out choice) && choice > 0 && choice <= animals.Count)
                {
                    Animal animal = animals[choice - 1];
                    animal.SingVerse();
                }
                else if (choice == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
        private void AddNewAnimal()
        {
            Console.Write("Enter the name of the new animal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the sound of the new animal: ");
            string sound = Console.ReadLine();

            Animal newAnimal = new CustomAnimal { Name = name, Sound = sound };
            animals.Add(newAnimal);

            Console.WriteLine($"New animal '{name}' with sound '{sound}' added successfully!");

            SaveAnimalToJson();
        }

        private void SaveAnimalToJson()
        {
            string jsonString = JsonSerializer.Serialize(animals);

            string filePath = @"C:\Users\Ilija\source\repos\OldMacDonaldsFarms\OldMacDonaldsFarms\animals.json";
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Animal is saved to JSON document.");
        }

    }
}
