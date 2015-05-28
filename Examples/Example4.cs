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
        private static bool isSimpleForExample4 = true;
        private static Point[] figurePointsForExample4 = new Point[7]
        {
            new Point(){ X = -3, Y = 4},
            new Point(){ X = 2, Y = 6},
            new Point(){ X = 1, Y = 3},
            new Point(){ X = 2, Y = 4},
            new Point(){ X = 3, Y = 4},
            new Point(){ X = 3, Y = 0},
            new Point(){ X = -1, Y = -1}
        };


        private static List<AdditionalProblemPoint> additionalProblemPointsForExample4 = new List<AdditionalProblemPoint>
        {
            new AdditionalProblemPoint(new Point(){X = 1.5f, Y = 4.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 0.0f, Y = 0.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 2.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 3.0f, Y = 2.0f}, true),
            new AdditionalProblemPoint(new Point(){X = -2.0f, Y = 6.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 3.0f}, true)
        };
        public static List<AdditionalProblemPoint> GetAdditionalPointsForExample4()
        {
            return additionalProblemPointsForExample4;
        }

        public static Point[] GetFigurePointsForExample4()
        {
            return figurePointsForExample4;
        }
        public static double GetMainProblemSolutionForExample4()
        {
            return 27.0;
        }

        public static bool GetSeconDaryProblemSolutionForExample4()
        {
            return isSimpleForExample4;
        }
    }
}
