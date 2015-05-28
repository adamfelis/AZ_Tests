using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AZ.objectMappings;
using AZ;

namespace AZ_Tests
{
    [TestClass]
    public class ProblemTestClass
    {
        [TestMethod]
        public void Example1a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample1();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample1(), isPolygonSimple);
            double area = solutionProvider.CalculatePolygonArea();
            Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample1(), area);
        }
        [TestMethod]
        public void Example1b()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.AdditionalProblem = new AdditionalProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample1();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);
            foreach(var i in Examples.Examples.GetAdditionalPointsForExample1())
            {
                problems.AdditionalProblem.PointToCheck = i.p;
                Assert.AreEqual(i.value, solutionProvider.IsPointInsidePolygon());
            }
            //bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            //Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample1(), isPolygonSimple);
            //double area = solutionProvider.CalculatePolygonArea();
            //Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample1(), area);
        }

        [TestMethod]
        public void Example2a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample2();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample2(), isPolygonSimple);
            double area = solutionProvider.CalculatePolygonArea();
            Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample2(), area);
        }
        [TestMethod]
        public void Example2b()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.AdditionalProblem = new AdditionalProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample2();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            foreach (var i in Examples.Examples.GetAdditionalPointsForExample2())
            {
                problems.AdditionalProblem.PointToCheck = i.p;
                Assert.AreEqual(i.value, solutionProvider.IsPointInsidePolygon());
            }
            //bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            //Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample2(), isPolygonSimple);
            //double area = solutionProvider.CalculatePolygonArea();
            //Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample2(), area);
        }

        [TestMethod]
        public void Example3a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample3();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample3(), isPolygonSimple);
            double area = solutionProvider.CalculatePolygonArea();
            Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample3(), area);
        }
        [TestMethod]
        public void Example3b()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.AdditionalProblem = new AdditionalProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample3();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            foreach (var i in Examples.Examples.GetAdditionalPointsForExample3())
            {
                problems.AdditionalProblem.PointToCheck = i.p;
                Assert.AreEqual(i.value, solutionProvider.IsPointInsidePolygon());
            }
            //bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            //Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample3(), isPolygonSimple);
            //double area = solutionProvider.CalculatePolygonArea();
            //Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample3(), area);
        }

        [TestMethod]
        public void Example4a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample4();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample4(), isPolygonSimple);
            double area = solutionProvider.CalculatePolygonArea();
            Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample4(), area);
        }

        [TestMethod]
        public void Example4b()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.AdditionalProblem = new AdditionalProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample4();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            foreach (var i in Examples.Examples.GetAdditionalPointsForExample4())
            {
                problems.AdditionalProblem.PointToCheck = i.p;
                Assert.AreEqual(i.value, solutionProvider.IsPointInsidePolygon());
            }
            //bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            //Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample4(), isPolygonSimple);
            //double area = solutionProvider.CalculatePolygonArea();
            //Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample4(), area);
        }


        [TestMethod]
        public void Example5a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample5();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample5(), isPolygonSimple);
        }

        [TestMethod]
        public void Example6a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample6();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample6(), isPolygonSimple);
        }

        [TestMethod]
        public void Example7a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample7();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample7(), isPolygonSimple);
        }

        [TestMethod]
        public void Example8a()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample8();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample8(), isPolygonSimple);
            double area = solutionProvider.CalculatePolygonArea();
            Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample8(), area);
        }

        [TestMethod]
        public void Example8b()
        {
            Problems problems = new Problems();
            problems.MainProblem = new MainProblem();
            problems.AdditionalProblem = new AdditionalProblem();
            problems.MainProblem.FigurePoints = Examples.Examples.GetFigurePointsForExample8();
            var solutionProvider = new SolutionProvider();
            solutionProvider.Initialize(problems);

            foreach (var i in Examples.Examples.GetAdditionalPointsForExample8())
            {
                problems.AdditionalProblem.PointToCheck = i.p;
                Assert.AreEqual(i.value, solutionProvider.IsPointInsidePolygon());
            }
            //bool isPolygonSimple = solutionProvider.CheckIfPolygonIsSimple();
            //Assert.AreEqual(Examples.Examples.GetSeconDaryProblemSolutionForExample8(), isPolygonSimple);
            //double area = solutionProvider.CalculatePolygonArea();
            //Assert.AreEqual(Examples.Examples.GetMainProblemSolutionForExample8(), area);
        }
    }
}
