using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;

namespace WhatIsACSharpTuple
{
    class Program
    {
        static async Task Main(string[] args)
        {
            FindCop FC = new FindCop();

            //Try with non Async Classic Tuple - This isn't that useful
            Tuple<Point, int, int> MyTupleCop = FC.FindClosestCopOriginalTuple();
            PrintCopData("OriginalTuple", MyTupleCop.Item1, MyTupleCop.Item2, MyTupleCop.Item3);

            ///Try with a structure Async
            FindCop.ClosetCop closestCop;
            closestCop = await FindCop.FindClosestCopStructureAsync();
            PrintCopData("Structure", closestCop.CopLocation, closestCop.CopBearing, closestCop.CopDistance);

            ///Try with a class
            Cop myCop = await FindCop.FindClosestCopClassAsync();
            PrintCopData("WithClass", myCop.Position, myCop.Bearing, myCop.Distance);

            //Try with an ArrayList
            ArrayList CopList = new ArrayList();
            CopList = await FindCop.FindClosestCopArrayListAsync();
            PrintCopData("ArrayList ", (Point)CopList[0], (int)CopList[1], (int)CopList[2]);

            ///Try with a Tuple
            (Point Location, int Bearing, int Distance) = await FindCop.FindClosestCopValueTupleAsync();

            PrintCopData("SearchForCopTuple", Location, Bearing, Distance);

 
        }

        static void PrintCopData(string MethodType, Point Location,int Bearing,int Distance)
        {
            Console.WriteLine();
            Console.WriteLine(MethodType + " Location: " + Location.X + "," + Location.Y + " Bearing: " + Bearing + " Distance: "+ Distance);
        }



    }
}
