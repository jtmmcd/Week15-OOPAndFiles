using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters
            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }

        

        static void Main(string[] args)
        {
            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] santaFromFile = GetDataFromFile();

            foreach (string line in santaFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
               
                SecretSanta newSanta = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newSanta);

            }

            foreach (SecretSanta santaFromList in mySecretSanta)
            {
                Console.WriteLine($"{santaFromList.Name} wants {santaFromList.Gift} for Christmas.");
            }


            
                //Anna wants new earrings for Christmas.
          
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Jalmar\OneDrive\KRG51\Programmeerimine\Failid\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
    } }
