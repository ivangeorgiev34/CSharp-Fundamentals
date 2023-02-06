using System;
using System.Collections.Generic;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> listOfSongs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                Song song = new Song(input[0], input[1], input[2]);
                listOfSongs.Add(song);
            }
            string type = Console.ReadLine();
            foreach (Song song in listOfSongs)
            {
                if (type == song.TypeList)
                {
                    Console.WriteLine(song.Name);
                }
                else if (type == "all")
                {
                    Console.WriteLine(song.Name);
                }

            }
        }
        class Song
        {
            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
