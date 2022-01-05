﻿using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class Movie
        {
            string title;
            string rating;
            string year;

            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            //getters
            public string Title
            {
                get { return title; }
            }

            public string Rating
            {
                get { return rating; }
            }
            public string Year
            {
                get { return year; }
            }
            
        }
        static void Main(string[] args)
        {
            List<Movie> myMovies = new List<Movie>();
            string[] moviesFromFile = GetDataFromFile();
            
            foreach(string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine($"title from TempArray: {tempArray[0]}");
                //Console.WriteLine($"rating from TempArray: {tempArray[1]}");
                //Console.WriteLine($"year from TempArray: {tempArray[2]}");
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);
                myMovies.Add(newMovie);

            }

            foreach(Movie movieFromList in myMovies)
            {
                Console.WriteLine($"Title --> {movieFromList.Title}. Rating --> {movieFromList.Rating}. Year --> {movieFromList.Year}.");
            }
                
                
                
            //DisplayElementsFromArray(GetDataFromFile());
        }


        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\Programmeerimine\Failid\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
               

                

    }


    
}
