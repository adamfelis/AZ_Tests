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
        private static bool isSimpleForExample3 = true;
        private static Point[] figurePointsForExample3 = new Point[3]
        {
            new Point(){ X = -1, Y = -1},
            new Point(){ X = 0, Y = 2},
            new Point(){ X = 3, Y = 0}
        };


        private static List<AdditionalProblemPoint> additionalProblemPointsForExample3 = new List<AdditionalProblemPoint>
        {
            new AdditionalProblemPoint(new Point(){X = 0.0f, Y = 0.0f}, true),
            new AdditionalProblemPoint(new Point(){X = -1.0f, Y = 1.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 2.0f, Y = 1.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 3.0f, Y = 0.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 4.0f, Y = 2.0f}, false)
        };
        public static List<AdditionalProblemPoint> GetAdditionalPointsForExample3()
        {
            return additionalProblemPointsForExample3;
        }

        public static Point[] GetFigurePointsForExample3()
        {
            return figurePointsForExample3;
        }
        public static double GetMainProblemSolutionForExample3()
        {
            return 5.5;
        }
        public static bool GetSeconDaryProblemSolutionForExample3()
        {
            return isSimpleForExample3;
        }
    }
}
