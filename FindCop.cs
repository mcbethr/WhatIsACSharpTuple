using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections;

namespace WhatIsACSharpTuple
{
    public class FindCop
    {

        #region Fun with Modern Value Tuples

        public void ModernFunWithTuples()
        {

            (int Id, string Text) MyTuple = (1, "Hello tuple");
            string WelcomeText = MyTuple.Text;

            MyTuple.Text = "New Hello Tuple";


            (int Id, string FirstName, string LastName, string gender, int City, int Zip, int Country, int Street, int Firm, int Age, int Bank, bool IsActive) person =
       (1, "Ryan", "McBeth", "Male", 5, 6, 7, 8, 9, 10, 11, true);
            person.FirstName = "ryan";

            var MyTupleWithVar = (id: 1, text: "Hello tuple");


            (int Id, string Text) MyTuple2 = (1, "New Hello Tuple");

            ///Totally allowed
            if (MyTuple.Equals(MyTuple2))
            {
                int i = 1;
            }

            ///Totally allowed
            if (MyTuple == MyTuple2)
            {
                int i = 1;
            }
        }

        #endregion

        #region Find Closest cop With a Structure
        public struct ClosetCop{
            public Point CopLocation;
            public int CopBearing;
            public int CopDistance;
        }

        public ClosetCop FindClosestCopStructure()
        {
            Cop MyCop = SearchForClosestCop();

            ClosetCop CopToReturn = new ClosetCop();
            CopToReturn.CopBearing = MyCop.Bearing;
            CopToReturn.CopLocation = MyCop.Position;
            CopToReturn.CopDistance = MyCop.Distance;

            return CopToReturn;
        }

        #endregion

        #region Find Cop With an old immutable Tuple
        public Tuple<Point, int, int> FindClosestCopOriginalTuple()
        {
            Cop MyCop = SearchForClosestCop();

            Tuple<Point, int, int> CopTuple = new Tuple<Point, int, int>(MyCop.Position,MyCop.Bearing,MyCop.Distance);

            //Can't do this.
            //Tuple<int, int, int, int, int, int, int, int, int> tuple = new Tuple<int, int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8, 9)

            return (Tuple.Create(CopTuple.Item1, CopTuple.Item2, CopTuple.Item3));
        }
        #endregion

        #region Find Cop With the new Value Tuple type
        public (Point, int,int) ValueWayTupleReturnClosestCop()
        {
            Cop MyCop = SearchForClosestCop();

            return (MyCop.Position,MyCop.Bearing,MyCop.Distance);
        }
        #endregion

        #region Find Cop With Structure Async
        public static async Task<ClosetCop> FindClosestCopStructureAsync()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 0; i++)
                {
                    ///Business logic to Look for cops
                }
            });

            ClosetCop CopToReturn = new ClosetCop();
            CopToReturn.CopBearing = 90;
            CopToReturn.CopLocation = new Point(1,2);
            CopToReturn.CopDistance = 200;

            return CopToReturn;
        }
        #endregion

        #region Find Cop Async And pass back a class

        ///Can't do this
        //public static async Task SearchForClosestCopAsync(out Point myCopLocation, out int bearing, out int distance)
        public static async Task<Cop> FindClosestCopClassAsync()
        {
            Cop MyCop = new Cop();

            await Task.Run(() =>
            {
                for (int i = 0; i < 0; i++)
                {
                    ///Business logic to Look for cops
                }
            });

            //Hardcoded for now
            MyCop.Position = (new Point(1, 2));
            MyCop.Distance = 200;
            MyCop.Bearing = 90;

            return (MyCop);
        }
        #endregion

        #region Find cop Async and pass back arraylist
        ///Don't do this.  It is a fellony offence
        public static async Task<ArrayList> FindClosestCopArrayListAsync()
        {
            Cop MyCop = new Cop();

            await Task.Run(() =>
            {
                for (int i = 0; i < 0; i++)
                {
                    ///Business logic to Look for 
                }
            });

            //Hardcoded for now
            ArrayList CopToReturn = new ArrayList();
            CopToReturn.Add(new Point(1, 2));
            CopToReturn.Add(90);
            CopToReturn.Add(200);

            return (CopToReturn);
        }
        #endregion
        












        #region Find Cop Async and pass back ValueTuple
        public static async Task<ValueTuple<Point, int, int>> FindClosestCopValueTupleAsync()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 1; i++)
                {
                    ///Business logic to Look for cops
                    //Load up the values or tuple
                }
            });

            ///This is hardcoded for the demo
            Point _Location = (new Point(1, 2));
            int _Bearing = 90;
            int _Distance = 200;

            (Point Location, int Bearing, int Distance) MyCop = (_Location, _Bearing, _Distance);

            return MyCop;
        }

        #endregion
        
















        /// <summary>
        /// Search for the closet cop using early methods
        /// We're just keeping this for re-use
        /// </summary>
        /// <returns></returns>
        private Cop SearchForClosestCop()
        {
            Cop MyCop = new Cop();

            //Hardcoded for now
            MyCop.Position = (new Point(1, 2));
            MyCop.Distance = 200;
            MyCop.Bearing = 90;

            return (MyCop);
        }


    }
}
