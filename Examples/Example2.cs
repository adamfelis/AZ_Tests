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
        private static bool isSimpleForExample2 = true;
        private static Point[] figurePointsForExample2 = new Point[4]
        {
            new Point(){ X = 1, Y = 3},
            new Point(){ X = 3, Y = 6},
            new Point(){ X = 7, Y = 8},
            new Point(){ X = 5, Y = 1}
        };


        private static List<AdditionalProblemPoint> additionalProblemPointsForExample2 = new List<AdditionalProblemPoint>
        {
            new AdditionalProblemPoint(new Point(){X = 3.5f, Y = 2.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 5.0f, Y = 2.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 5.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 7.0f, Y = -1.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 3.0f, Y = 4.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 3.0f}, true)
        };
        public static List<AdditionalProblemPoint> GetAdditionalPointsForExample2()
        {
            return additionalProblemPointsForExample2;
        }
        public static Point[] GetFigurePointsForExample2()
        {
            return figurePointsForExample2;
        }
        public static double GetMainProblemSolutionForExample2()
        {
            return 20.0;
        }
        public static bool GetSeconDaryProblemSolutionForExample2()
        {
            return isSimpleForExample2;
        }
    }
}
