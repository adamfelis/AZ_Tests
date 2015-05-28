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
        private static bool isSimpleForExample6 = false;
        private static Point[] figurePointsForExample6 = new Point[6]
        {
            new Point(){ X = 1, Y = 2},
            new Point(){ X = 3, Y = 1.5f},
            new Point(){ X = 5, Y = 0.5f},
            new Point(){ X = 5, Y = 2},
            new Point(){ X = 3, Y = 1.5f},
            new Point(){ X = 1, Y = 0.5f}
        };

        public static Point[] GetFigurePointsForExample6()
        {
            return figurePointsForExample6;
        }
        public static bool GetSeconDaryProblemSolutionForExample6()
        {
            return isSimpleForExample6;
        }
    }
}
