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
        private static bool isSimpleForExample8 = true;
        private static Point[] figurePointsForExample8 = new Point[15]
        {
            new Point(){ X = 1, Y = 5},
            new Point(){ X = -1, Y = 2},
            new Point(){ X = -1, Y = 1},
            new Point(){ X = 1, Y = 1},
            new Point(){ X = 5, Y = 5},
            new Point(){ X = 5, Y = -5},
            new Point(){ X = 1, Y = -1},
            new Point(){ X = -1, Y = -1},
            new Point(){ X = -1, Y = -2},
            new Point(){ X = 1, Y = -5},
            new Point(){ X = -4, Y = -5},
            new Point(){ X = -2, Y = -2},
            new Point(){ X = -5, Y = 0},
            new Point(){ X = -2, Y = 2},
            new Point(){ X = -4, Y = 5}
        };


        private static List<AdditionalProblemPoint> additionalProblemPointsForExample8 = new List<AdditionalProblemPoint>
        {
            new AdditionalProblemPoint(new Point(){X = -4.0f, Y = 2.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 2.0f, Y = 0.0f}, true),
            new AdditionalProblemPoint(new Point(){X = -1.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = -2.0f, Y = 4.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 4.5f}, false),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 2.0f}, false)
        };
        public static List<AdditionalProblemPoint> GetAdditionalPointsForExample8()
        {
            return additionalProblemPointsForExample8;
        }

        public static Point[] GetFigurePointsForExample8()
        {
            return figurePointsForExample8;
        }
        public static double GetMainProblemSolutionForExample8()
        {
            return 56.0f;
        }

        public static bool GetSeconDaryProblemSolutionForExample8()
        {
            return isSimpleForExample8;
        }
    }
}
