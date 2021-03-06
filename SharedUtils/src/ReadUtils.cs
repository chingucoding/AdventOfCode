﻿using System.IO;
using System.Linq;

namespace AdventOfCode.SharedUtils
{
    public static class ReadUtils
    {
        public static string[] ReadDataFromFile(string fileName)
        {
            FileStream fileToRead = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

            var data = File.ReadLines(fileName).ToArray();
            fileToRead.Close();

            return data;
        }

        public static long[] ReadLongDataFromFile(string fileName)
        {
            FileStream fileToRead = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

            var data = File.ReadLines(fileName).Select(line => long.Parse(line)).ToArray();
            fileToRead.Close();

            return data;
        }

        public static int[] ReadIntDataFromFile(string fileName)
        {
            FileStream fileToRead = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

            var data = File.ReadLines(fileName).Select(line => int.Parse(line)).ToArray();
            fileToRead.Close();

            return data;
        }

        public static int[] ReadIntDataFromFileSingleLine(string fileName)
        {
            return ReadDataFromFile(fileName)[0].Split(',').Select(line => int.Parse(line)).ToArray();
        }
    }
}
