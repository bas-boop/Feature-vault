using Baz_geluk9.Feature_vault.Extensions;
using UnityEngine;

namespace Baz_geluk9.Feature_vault.Examples
{
    /// <summary>
    /// An example class for the vector extensions. Showing all Vector3 functions. It's the same usage for Vector2.
    /// </summary>
    public sealed class VectorExtensionsExample : MonoBehaviour
    {
        private Vector3 _exampleVector;

        private void Start()
        {
            SetAxis();
            DivideTest();
            AddTest();
            SubtractTest();
            MultiplyTest();
            CompareTest();
            RandomizeTest();
            InvertTest();
            MidpointTest();
            WeightedAverageTest();
            IsWithinRangeTest();
        }

        private void SetAxis()
        {
            _exampleVector.SetX(5);
            _exampleVector.SetY(10);
            _exampleVector.SetZ(3);
            print($"After SetAxis: {_exampleVector}");
        }

        private void DivideTest()
        {
            _exampleVector.Divide(new Vector3(2, 5, 1));
            print($"After Divide(Vector3): {_exampleVector}");

            _exampleVector.DivideX(2);
            print($"After DivideX(2): {_exampleVector}");
        }

        private void AddTest()
        {
            _exampleVector.Add(new Vector3(1, 2, 3));
            print($"After Add(Vector3): {_exampleVector}");

            _exampleVector.AddX(new Vector3(3, 0));
            print($"After AddX(2): {_exampleVector}");
        }

        private void SubtractTest()
        {
            _exampleVector.Subtract(new Vector3(1, 2, 3));
            print($"After Subtract(Vector3): {_exampleVector}");

            _exampleVector.SubtractX(new Vector3(3, 0));
            print($"After SubtractX(2): {_exampleVector}");
        }

        private void MultiplyTest()
        {
            _exampleVector.Multiply(new Vector3(2, 3, 4));
            print($"After Multiply(Vector3): {_exampleVector}");

            _exampleVector.MultiplyX(new Vector3(3, 0));
            print($"After MultiplyX(2): {_exampleVector}");
        }

        private void CompareTest()
        {
            bool isApproximatelyEqual = _exampleVector.Compare(new Vector3(10, 15, 12), 0.1f);
            print($"Is Approximately Equal: {isApproximatelyEqual}");
        }

        private void RandomizeTest()
        {
            _exampleVector.Randomize(new Vector3(0, 10));
            print($"After Randomize(Vector3, Vector3): {_exampleVector}");

            _exampleVector.RandomizeUniform(new Vector3(0, 5));
            print($"After RandomizeUniform(Vector3): {_exampleVector}");

            _exampleVector.RandomizeX(new Vector2(0, 5));
            print($"After RandomizeX(Vector2): {_exampleVector}");
        }

        private void InvertTest()
        {
            _exampleVector.Invert();
            print($"After Invert: {_exampleVector}");

            _exampleVector.InvertX();
            print($"After InvertX: {_exampleVector}");
        }

        private void MidpointTest()
        {
            Vector3 secondVector = new Vector3(10, 20, 30);
            Vector3 midpoint = _exampleVector.Midpoint(secondVector);
            print($"Midpoint: {midpoint}");
        }

        private void WeightedAverageTest()
        {
            Vector3 secondVector = new Vector3(10, 20, 30);
            Vector3 weightedAverage = _exampleVector.WeightedAverage(secondVector, 30);
            print($"Weighted Average: {weightedAverage}");
        }

        private void IsWithinRangeTest()
        {
            bool isWithinRange1 = _exampleVector.IsWithinRange(new Vector3(8, 15, 5), 9);
            print($"Is Within Range: {isWithinRange1}");
            
            bool isWithinRange2 = _exampleVector.IsWithinRange(new Vector3(8, 15, 5), 25);
            print($"Is Within Range: {isWithinRange2}");
        }
    }
}
