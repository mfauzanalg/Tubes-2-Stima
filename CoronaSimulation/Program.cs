﻿using System;
using System.Collections;
using Entity;
using ReadFile;
using System.Collections.Generic;

namespace CoronaSimulation
{
    public class Simulation
    {
        public static void Main()
        {
            ReadFromFile.Read();
            Queue<char> QueueEdge = new Queue<char>();

            Console.Write("Input Total Days Infected: ");
            int time = Convert.ToInt32(Console.ReadLine());
            //ReadFromFile.EdgeData is data which contains Data of Edge
            //ReadFromFile.GraphData is data which contains Data of Graph

            //Init Graph G sudah di ReadFile
            ReadFromFile.province.printGraph();


            


        }
    }
}
