using AZ.objectMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_Tests.Examples
{
    partial class Examples
    {
        private static bool isSimpleForExample5 = false;
        private static Point[] figurePointsForExample5 = new Point[5]
        {
            new Point(){ X = -2, Y = 5},
            new Point(){ X = -1, Y = 6},
            new Point(){ X = 0, Y = 1},
            new Point(){ X = 2, Y = 3},
            new Point(){ X = -2, Y = 1}
        };

        public static Point[] GetFigurePointsForExample5()
        {
            return figurePointsForExample5;
        }
        public static bool GetSeconDaryProblemSolutionForExample5()
        {
            return isSimpleForExample5;
        }
    }
}
