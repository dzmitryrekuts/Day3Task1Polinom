using NUnit.Framework;
using PolinomNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomTests
{
    [TestFixture]
    public class PolinomNUnitTests
    {

        public static IEnumerable TestCases
        {
            get
            {
                //positive tests
                yield return new TestCaseData(new double[] { 16.0, 32, 0 }, new double[] { -16.0, 0, 26 }).Returns(false);
                yield return new TestCaseData(new double[] { 16.0, 32, 0 }, new double[] { 16.0, 32, 0 }).Returns(true);
                yield return new TestCaseData(new double[] { 16.0, 32, 0, 54 }, new double[] { 0, 26 }).Returns(false);

            }
        }


        [Test, TestCaseSource(typeof(PolinomNUnitTests), "TestCases")]
        public bool Polinom_TestingEquels_PositiveTests(double[] array1, double[] array2)
        {

            var polinom1 = new Polinom(array1);
            var polinom2 = new Polinom(array2);

            return polinom1.Equals(polinom2);
        }

        [Test, TestCaseSource(typeof(PolinomNUnitTests), "TestCases")]
        public bool Polinom_TestingEquality_PositiveTests(double[] array1, double[] array2)
        {

            var polinom1 = new Polinom(array1);
            var polinom2 = new Polinom(array2);

            return polinom1 == polinom2;
        }


    }
}
