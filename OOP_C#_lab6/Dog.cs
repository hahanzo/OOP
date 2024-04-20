using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_C__lab6
{
    public enum Gender
    {
        Male,
        Female
    }

    [Serializable]
    public class Dog
    {
        public string alias;
        public string breed;
        public Gender gender;
        public double cost;
        public int age;

        public Dog(){}

        public Dog(string alias, string breed, Gender gender, double cost, int age)
        {
            if (string.IsNullOrWhiteSpace(alias))
                throw new ArgumentException("Alias cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(breed))
                throw new ArgumentException("Breed cannot be null or empty.");

            if (cost <= 0)
                throw new ArgumentException("Price must be greater than zero.");

            if (age <= 0)
                throw new ArgumentException("Age must be greater than zero.");

            this.alias = alias;
            this.breed = breed;
            this.gender = gender;
            this.cost = cost;
            this.age = age;
        }

        public string Alias
        {
            get => alias;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Alias cannot be null or empty.");
                alias = value;
            }
        }

        public string Breed
        {
            get => breed;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Breed cannot be null or empty.");
                breed = value;
            }
        }

        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        public double Cost
        {
            get => cost;
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Price must be greater than zero.");
                cost = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age must be greater than zero.");
                age = value;
            }
        }

        public void IncreasePriceForFemales()
        {
            if (gender == Gender.Female && age == 2)
            {
                cost *= 1.25;
            }
        }
    }
}
