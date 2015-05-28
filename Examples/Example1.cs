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
        public class AdditionalProblemPoint
        {
            public Point p;
            public bool value;
            public AdditionalProblemPoint(Point p, bool value)
            {
                this.p = p;
                this.value = value;
            }
        }
        private static bool isSimpleForExample1 = true;
        private static Point[] figurePointsForExample1 = new Point[3]
        {
            new Point(){ X = 1, Y = 1},
            new Point(){ X = 3, Y = 3},
            new Point(){ X = 4, Y = 1}
        };

        private static List<AdditionalProblemPoint> additionalProblemPointsForExample1 = new List<AdditionalProblemPoint>
        {
            new AdditionalProblemPoint(new Point(){X = 2.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 2.0f}, false),
            new AdditionalProblemPoint(new Point(){X = 1.0f, Y = 1.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 2.0f, Y = 2.0f}, true),
            new AdditionalProblemPoint(new Point(){X = 4.0f, Y = 2.0f}, false)
        };
        public static List<AdditionalProblemPoint> GetAdditionalPointsForExample1()
        {
            return additionalProblemPointsForExample1;
        }

        public static Point[] GetFigurePointsForExample1()
        {
            return figurePointsForExample1;
        }
        public static double GetMainProblemSolutionForExample1()
        {
            return 3.0;
        }
        public static bool GetSeconDaryProblemSolutionForExample1()
        {
            return isSimpleForExample1;
        }
    }
}
