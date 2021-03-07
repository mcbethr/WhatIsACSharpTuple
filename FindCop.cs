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

        #region Modern fun with Tuples

        public void ModernFunWithTuples()
        {
            (int Id, string FirstName, string LastName, int Vek, int City, int Zip, int Country, int Street, int Firm, int Age, int Bank, bool IsActive) person =
(1, "Bill", "Gates", 4, 5, 6, 7, 8, 9, 10, 11, true);
            person.FirstName = "ryan";

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

            ///This is immutable 
            var MyTuple = Tuple.Create(1, 2, 3);
            ///MyTuple.Item1 = 2;

            return (Tuple.Create(MyCop.Position, MyCop.Bearing, MyCop.Distance));
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
        ///public static async Task<Cop> SearchForClosestCopAsync(out Point myCopLocation, out int bearing, int distance)
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
        public static async Task<ValueTuple<Point, int,int>> FindClosestCopValueTupleAsync()
        {
            

            await Task.Run(() =>
            {
                for (int i = 0; i < 0; i++)
                {
                    ///Business logic to Look for cops
                }
            });

            (Point Location,int Bearing, int Distance) MyCop = (new Point(1, 2), 90, 200);

            return MyCop;
            //return (new ValueTuple<Point, int, int>(new Point(1, 2), 90, 200));
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
