﻿using System;
using System.Diagnostics;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] values = { null, String.Empty, "", " ", "\t", "\n", "\n\t", "\u2000" };
            int count = 0;

            foreach (var value in values)
            {
                Console.Write($"StringIsNullOrWhiteSpaceTest{++count}");
                Debug.Assert(Lab8.PrettifyList(value) == null);
                Console.WriteLine(" - Pass");
            }

            Console.WriteLine("---------------------------------");

            string minifiedList = "a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a";
            string prettifiedList = @"1) _/
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            string list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            //Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "\\";
            prettifiedList = @"1) \
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "_";
            prettifiedList = @"1) 
    a) 
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "Pope";
            prettifiedList = @"1) Pope
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "Aglio e olio|Carbonara|Ragu alla bolognese|Toowoomba";
            prettifiedList = @"1) Aglio e olio
2) Carbonara
3) Ragu alla bolognese
4) Toowoomba
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "Beverage_Cola_Sprite";
            prettifiedList = @"1) Beverage
    a) Cola
    b) Sprite
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "Jelly_Haribo/Goldbären/Bärchen-Pärchen|Candy_Halls/Honey Lemon/Blueberry/Grapefruit";
            prettifiedList = @"1) Jelly
    a) Haribo
        - Goldbären
        - Bärchen-Pärchen
2) Candy
    a) Halls
        - Honey Lemon
        - Blueberry
        - Grapefruit
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "/♥/|POCU_Lab/Discussion_Assignment//Midterm_/Final|";
            prettifiedList = @"1) /♥/
2) POCU
    a) Lab
        - Discussion
    b) Assignment
        - 
        - Midterm
    c) 
        - Final
3) 
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
            Console.WriteLine("---------------------------------");

            minifiedList = "|/__//||/|_/|/_||___";
            prettifiedList = @"1) 
2) /
    a) 
    b) 
        - 
        - 
3) 
4) /
5) 
    a) 
        - 
6) /
    a) 
7) 
8) 
    a) 
    b) 
    c) 
";
            Console.WriteLine($"한 줄로 표현한 목록 : {minifiedList}\n");
            list = Lab8.PrettifyList(minifiedList);
            Console.WriteLine($"이쁘게 복구한 목록 :\n{list}");
            Debug.Assert(prettifiedList == list);
        }
    }
}
