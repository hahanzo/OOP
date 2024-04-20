#pragma warning disable SYSLIB0011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;

namespace OOP_C__lab6
{
    internal class DogCollectionWrapper : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogCollectionWrapper()
        {
            dogs = new List<Dog>();
        }

        public void Add(Dog dog)
        {
            dogs.Add(dog);
        }

        public void Remove(Dog dog)
        {
            dogs.Remove(dog);
        }

        public void RomoveByIndex(int index)
        {
            if (index >= 0 && index < dogs.Count)
            {
                dogs.RemoveAt(index);
            }
        }

        public void Clear()
        {
            dogs.Clear();
        }

        public void SortDogsByAlias()
        {
            dogs = dogs.OrderBy(dog => dog.Alias).ToList();
        }

        public List<Dog> GetDogsByGender(Gender gender)
        {
            return dogs.Where(dog => dog.Gender == gender).ToList();
        }

        public void SaveToBinaryFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fs, dogs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving to binary file: {ex.Message}");
            }
        }

        public void SaveToXmlFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Dog>));
                    xmlSerializer.Serialize(fs, dogs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving to XML file: {ex.Message}");
            }
        }

        public void SaveToJsonFile(string filePath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(dogs);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error saving to JSON file: {ex.Message}");
            }
        }

        public void LoadFromBinaryFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    dogs = (List<Dog>)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading from binary file: {ex.Message}");
            }
        }

        public void LoadFromXmlFile(string filePath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Dog>));
                using (StreamReader sr = new StreamReader(filePath))
                {
                    dogs = (List<Dog>)serializer.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading from XML file: {ex.Message}");
            }
        }

        public void LoadFromJsonFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                dogs = JsonSerializer.Deserialize<List<Dog>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading from JSON file: {ex.Message}");
            }
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
