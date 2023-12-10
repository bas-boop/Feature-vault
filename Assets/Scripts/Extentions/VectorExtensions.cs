using UnityEngine;

namespace Baz_geluk9.Feature_vault.Extensions
{
    /// <summary>
    /// Provides versatile extensions for Vector2 and Vector3, enhancing functionality for various operations.
    /// Ideal for integration into any Unity project.
    /// Features:
    /// - Change Axis
    /// - Divide Vector & Axis
    /// - Combine Vector & Axis
    /// - Separate Vector & Axis
    /// - Multiply Vector & Axis
    /// - Compare Vector & Axis (with optional margin)
    /// - Randomize Vector & Axis
    /// - Invert Vector & Axis
    /// - Calculate Midpoint between 2 vectors
    /// - Calculate Weighted Average Vector
    /// - IsWithinRange Vector & Axis
    /// </summary>
    public static class VectorExtensions
    {
        #region Vector 3

        #region Change Axis

        /// <summary>
        /// Change the X vector of this Vector3
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="x">Target value for the X vector.</param>
        public static Vector3 ChangeX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }

        /// <summary>
        /// Change the Y vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Target value for the Y vector.</param>
        public static Vector3 ChangeY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }

        /// <summary>
        /// Change the Z vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="z">Target value for the Z vector.</param>
        public static Vector3 ChangeZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        #endregion

        #region Combine

        /// <summary>
        /// Combine the 2 Vectors3 into one.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is a combination.</returns>
        public static Vector3 CombineVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x + f.x, v.y + f.y, v.z + f.z);
        }
        
        /// <summary>
        /// Combine the X axis of two Vector3 into one.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with combined X axis.</returns>
        public static Vector3 CombineX(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x + f.x, v.y, v.z);
        }

        /// <summary>
        /// Combine the Y axis of two Vector3 into one.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with combined Y axis.</returns>
        public static Vector3 CombineY(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x, v.y + f.y, v.z);
        }

        /// <summary>
        /// Combine the Z axis of two Vector3 into one.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with combined Z axis.</returns>
        public static Vector3 CombineZ(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x, v.y, v.z + f.z);
        }

        #endregion

        #region Separate

        /// <summary>
        /// Remove the the given Vector3 form this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is a separation.</returns>
        public static Vector3 SeparateVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x - f.x, v.y - f.y, v.z - f.z);
        }
        
        /// <summary>
        /// Separate the X axis of the second Vector3 from the first Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with separated X axis.</returns>
        public static Vector3 SeparateX(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x - f.x, v.y, v.z);
        }

        /// <summary>
        /// Separate the Y axis of the second Vector3 from the first Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with separated Y axis.</returns>
        public static Vector3 SeparateY(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x, v.y - f.y, v.z);
        }

        /// <summary>
        /// Separate the Z axis of the second Vector3 from the first Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with separated Z axis.</returns>
        public static Vector3 SeparateZ(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x, v.y, v.z - f.z);
        }

        #endregion

        #region Multiple

        /// <summary>
        /// Multiple this Vector3 with the given Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is multiplied.</returns>
        public static Vector3 MultipleVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x * f.x, v.y * f.y, v.z * f.z);
        }
        
        /// <summary>
        /// Multiply the X axis of this Vector3 by the X axis of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with multiplied X axis.</returns>
        public static Vector3 MultipleX(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x * f.x, v.y, v.z);
        }

        /// <summary>
        /// Multiply the Y axis of this Vector3 by the Y axis of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with multiplied Y axis.</returns>
        public static Vector3 MultipleY(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x, v.y * f.y, v.z);
        }

        /// <summary>
        /// Multiply the Z axis of this Vector3 by the Z axis of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with multiplied Z axis.</returns>
        public static Vector3 MultipleZ(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x, v.y, v.z * f.z);
        }

        #endregion
        
        #region Divide

        /// <summary>
        /// Divide this Vector3 with the given Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is division.</returns>
        public static Vector3 DivideVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x / f.x, v.y / f.y, v.z / f.z);
        }
        
        /// <summary>
        /// Divide the X vector of this Vector3
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="x">Divider for the X vector.</param>
        public static Vector3 DivideX(this Vector3 v, float x)
        {
            return new Vector3(v.x / x, v.y, v.z);
        }

        /// <summary>
        /// Change the Y vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Divider value for the Y vector.</param>
        public static Vector3 DivideY(this Vector3 v, float y)
        {
            return new Vector3(v.x, v.y / y, v.z);
        }

        /// <summary>
        /// Change the Z vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="z">Divider value for the Z vector.</param>
        public static Vector3 DivideZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, v.z / z);
        }

        #endregion

        #region Compare

        /// <summary>
        /// Compare two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the vectors are approximately equal within the specified margin.</returns>
        public static bool Compare(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin
                   && Mathf.Abs(v.y - f.y) < margin
                   && Mathf.Abs(v.z - f.z) < margin;
        }
        
        /// <summary>
        /// Compare the X axis of two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the X axes are approximately equal within the specified margin.</returns>
        public static bool CompareX(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin;
        }

        /// <summary>
        /// Compare the Y axis of two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the Y axes are approximately equal within the specified margin.</returns>
        public static bool CompareY(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.y - f.y) < margin;
        }

        /// <summary>
        /// Compare the Z axis of two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the Z axes are approximately equal within the specified margin.</returns>
        public static bool CompareZ(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.z - f.z) < margin;
        }

        #endregion

        #region Random

        /// <summary>
        /// Randomize the X, Y, and Z axes of this Vector3 within specified ranges.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <param name="zRange">Range for the Z axis.</param>
        /// <returns>A new Vector3 with randomized axes.</returns>
        public static Vector3 RandomizeVector(this Vector3 v, Vector2 xRange, Vector2 yRange, Vector2 zRange)
        {
            return new Vector3(
                Random.Range(xRange.x, xRange.y),
                Random.Range(yRange.x, yRange.y),
                Random.Range(zRange.x, zRange.y)
            );
        }
        
        /// <summary>
        /// Randomize the X, Y, and Z axes of this Vector3 within the specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="range">Range for all axes.</param>
        /// <returns>A new Vector3 with randomized axes.</returns>
        public static Vector3 RandomizeVector(this Vector3 v, Vector2 range)
        {
            return new Vector3(
                Random.Range(range.x, range.y),
                Random.Range(range.x, range.y),
                Random.Range(range.x, range.y)
            );
        }
        
        /// <summary>
        /// Randomize all axes of this Vector3 with the same random number within the specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="range">Range for all axes.</param>
        /// <returns>A new Vector3 with the same randomized value for all axes.</returns>
        public static Vector3 RandomizeVectorUniform(this Vector3 v, Vector2 range)
        {
            float randomValue = Random.Range(range.x, range.y);
            return new Vector3(randomValue, randomValue, randomValue);
        }

        /// <summary>
        /// Randomize the X axis of this Vector3 within a specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <returns>A new Vector3 with a randomized X axis.</returns>
        public static Vector3 RandomizeX(this Vector3 v, Vector2 xRange)
        {
            return new Vector3(Random.Range(xRange.x, xRange.y), v.y, v.z);
        }

        /// <summary>
        /// Randomize the Y axis of this Vector3 within a specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <returns>A new Vector3 with a randomized Y axis.</returns>
        public static Vector3 RandomizeY(this Vector3 v, Vector2 yRange)
        {
            return new Vector3(v.x, Random.Range(yRange.x, yRange.y), v.z);
        }

        /// <summary>
        /// Randomize the Z axis of this Vector3 within a specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="zRange">Range for the Z axis.</param>
        /// <returns>A new Vector3 with a randomized Z axis.</returns>
        public static Vector3 RandomizeZ(this Vector3 v, Vector2 zRange)
        {
            return new Vector3(v.x, v.y, Random.Range(zRange.x, zRange.y));
        }
        
        #endregion

        #region Inverd

        /// <summary>
        /// Invert the X, Y, and Z axes of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with inverted axes.</returns>
        public static Vector3 InvertVector(this Vector3 v)
        {
            return new Vector3(-v.x, -v.y, -v.z);
        }
        
        /// <summary>
        /// Invert the X axis of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with the inverted X axis.</returns>
        public static Vector3 InvertX(this Vector3 v)
        {
            return new Vector3(-v.x, v.y, v.z);
        }

        /// <summary>
        /// Invert the Y axis of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with the inverted Y axis.</returns>
        public static Vector3 InvertY(this Vector3 v)
        {
            return new Vector3(v.x, -v.y, v.z);
        }

        /// <summary>
        /// Invert the Z axis of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with the inverted Z axis.</returns>
        public static Vector3 InvertZ(this Vector3 v)
        {
            return new Vector3(v.x, v.y, -v.z);
        }

        #endregion

        #region Midpoint

        /// <summary>
        /// Calculate the midpoint between two Vector3.
        /// </summary>
        /// <param name="v">The first Vector3.</param>
        /// <param name="f">The second Vector3.</param>
        /// <returns>The midpoint Vector3.</returns>
        public static Vector3 Midpoint(this Vector3 v, Vector3 f)
        {
            return CombineVector(v, f) / 2f;
        }
        
        /// <summary>
        /// Calculate the weighted average of two Vector3 based on specified weight.
        /// </summary>
        /// <param name="v">The first Vector3.</param>
        /// <param name="f">The second Vector3.</param>
        /// <param name="weight">Weight for the first Vector3. Should be in the range [0, 100], it's a percentage.</param>
        /// <returns>The weighted average Vector3.</returns>
        public static Vector3 WeightedAverage(Vector3 v, Vector3 f, float weight)
        {
            const float a = 100f;
            float b = a - weight;

            return (v * weight + f * b) / (weight + b);
        }

        #endregion
        
        #region IsWithinRange

        /// <summary>
        /// Checks if this Vector3 is within the specified range of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The target Vector3.</param>
        /// <param name="range">The range within which the f Vector3 is considered "within."</param>
        /// <returns>True if the f Vector3 is within the specified range; otherwise, false.</returns>
        public static bool IsWithinRange(this Vector3 v, Vector3 f, float range)
        {
            float distance = Vector3.Distance(v, f);
            return distance <= range;
        }

        /// <summary>
        /// Checks if the X component of this Vector3 is within the specified range of the X component of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="range">The range within which the X components are considered "within."</param>
        /// <returns>True if the X components are within the specified range; otherwise, false.</returns>
        public static bool IsXWithinRange(this Vector3 v, Vector3 f, float range)
        {
            return Mathf.Abs(v.x - f.x) <= range;
        }

        /// <summary>
        /// Checks if the Y component of this Vector3 is within the specified range of the Y component of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="range">The range within which the Y components are considered "within."</param>
        /// <returns>True if the Y components are within the specified range; otherwise, false.</returns>
        public static bool IsYWithinRange(this Vector3 v, Vector3 f, float range)
        {
            return Mathf.Abs(v.y - f.y) <= range;
        }

        /// <summary>
        /// Checks if the Z component of this Vector3 is within the specified range of the Z component of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="range">The range within which the Z components are considered "within."</param>
        /// <returns>True if the Z components are within the specified range; otherwise, false.</returns>
        public static bool IsZWithinRange(this Vector3 v, Vector3 f, float range)
        {
            return Mathf.Abs(v.z - f.z) <= range;
        }

        #endregion

        #endregion

        #region Vector 2

        #region Change Axis

        /// <summary>
        /// Change the X vector of this Vector2
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="x">Target value for the X vector.</param>
        public static Vector2 ChangeX(this Vector2 v, float x)
        {
            return new Vector2(x, v.y);
        }

        /// <summary>
        /// Change the Y vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="y">Target value for the Y vector.</param>
        public static Vector2 ChangeY(this Vector2 v, float y)
        {
            return new Vector2(v.x, y);
        }

        #endregion

        #region Combine

        /// <summary>
        /// Combine the 2 Vectors2 into one.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 that is a combination.</returns>
        public static Vector2 CombineVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x + f.x, v.y + f.y);
        }

        /// <summary>
        /// Combine the X axis of two Vector2 into one.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with combined X axis.</returns>
        public static Vector2 CombineX(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x + f.x, v.y);
        }

        /// <summary>
        /// Combine the Y axis of two Vector2 into one.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with combined Y axis.</returns>
        public static Vector2 CombineY(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x, v.y + f.y);
        }

        #endregion

        #region Separate

        /// <summary>
        /// Remove the given Vector2 from this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 that is a separation.</returns>
        public static Vector2 SeparateVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x - f.x, v.y - f.y);
        }

        /// <summary>
        /// Separate the X axis of the second Vector2 from the first Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with separated X axis.</returns>
        public static Vector2 SeparateX(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x - f.x, v.y);
        }

        /// <summary>
        /// Separate the Y axis of the second Vector2 from the first Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with separated Y axis.</returns>
        public static Vector2 SeparateY(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x, v.y - f.y);
        }

        #endregion

        #region Multiple

        /// <summary>
        /// Multiply this Vector2 with the given Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 that is multiplied.</returns>
        public static Vector2 MultipleVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x * f.x, v.y * f.y);
        }

        /// <summary>
        /// Multiply the X axis of this Vector2 by the X axis of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with multiplied X axis.</returns>
        public static Vector2 MultipleX(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x * f.x, v.y);
        }

        /// <summary>
        /// Multiply the Y axis of this Vector2 by the Y axis of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with multiplied Y axis.</returns>
        public static Vector2 MultipleY(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x, v.y * f.y);
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divide this Vector2 with the given Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector3 that is division.</returns>
        public static Vector2 DivideVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x / f.x, v.y / f.y);
        }

        /// <summary>
        /// Divide the X vector of this Vector2
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="x">Divider for the X vector.</param>
        public static Vector2 DivideX(this Vector2 v, float x)
        {
            return new Vector2(v.x / x, v.y);
        }

        /// <summary>
        /// Divide the Y vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="y">Divider value for the Y vector.</param>
        public static Vector2 DivideY(this Vector2 v, float y)
        {
            return new Vector2(v.x, v.y / y);
        }

        #endregion

        #region Compare

        /// <summary>
        /// Compare two Vector2 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the vectors are approximately equal within the specified margin.</returns>
        public static bool Compare(this Vector2 v, Vector2 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin 
                   && Mathf.Abs(v.y - f.y) < margin;
        }

        /// <summary>
        /// Compare the X axis of two Vector2 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the X axes are approximately equal within the specified margin.</returns>
        public static bool CompareX(this Vector2 v, Vector2 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin;
        }

        /// <summary>
        /// Compare the Y axis of two Vector2 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the Y axes are approximately equal within the specified margin.</returns>
        public static bool CompareY(this Vector2 v, Vector2 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.y - f.y) < margin;
        }

        #endregion

        #region Random

        /// <summary>
        /// Randomize the X, Y, and Z axes of this Vector2 within specified ranges.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <returns>A new Vector2 with randomized axes.</returns>
        public static Vector2 RandomizeVector(this Vector2 v, Vector2 xRange, Vector2 yRange)
        {
            return new Vector2(
                Random.Range(xRange.x, xRange.y),
                Random.Range(yRange.x, yRange.y)
            );
        }
        
        /// <summary>
        /// Randomize the X and Y components of this Vector2 within the specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="range">Range for X and Y components.</param>
        /// <returns>A new Vector2 with randomized X and Y components.</returns>
        public static Vector2 RandomizeVector(this Vector2 v, Vector2 range)
        {
            return new Vector2(
                Random.Range(range.x, range.y),
                Random.Range(range.x, range.y)
            );
        }

        /// <summary>
        /// Randomize both components of this Vector2 with the same random number within the specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="range">Range for both components.</param>
        /// <returns>A new Vector2 with the same randomized value for both components.</returns>
        public static Vector2 RandomizeVectorUniform(this Vector2 v, Vector2 range)
        {
            float randomValue = Random.Range(range.x, range.y);
            return new Vector2(randomValue, randomValue);
        }

        /// <summary>
        /// Randomize the X axis of this Vector2 within a specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <returns>A new Vector2 with a randomized X axis.</returns>
        public static Vector2 RandomizeX(this Vector2 v, Vector2 xRange)
        {
            return new Vector2(Random.Range(xRange.x, xRange.y), v.y);
        }

        /// <summary>
        /// Randomize the Y axis of this Vector2 within a specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <returns>A new Vector2 with a randomized Y axis.</returns>
        public static Vector2 RandomizeY(this Vector2 v, Vector2 yRange)
        {
            return new Vector2(v.x, Random.Range(yRange.x, yRange.y));
        }

        #endregion

        #region Invert

        /// <summary>
        /// Invert the X, and Y axes of this Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <returns>The Vector2 with inverted axes.</returns>
        public static Vector2 InvertVector(this Vector2 v)
        {
            return new Vector2(-v.x, -v.y);
        }

        /// <summary>
        /// Invert the X axis of this Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <returns>The Vector2 with the inverted X axis.</returns>
        public static Vector2 InvertX(this Vector2 v)
        {
            return new Vector2(-v.x, v.y);
        }

        /// <summary>
        /// Invert the Y axis of this Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <returns>The Vector2 with the inverted Y axis.</returns>
        public static Vector2 InvertY(this Vector2 v)
        {
            return new Vector2(v.x, -v.y);
        }

        #endregion
        
        #region Midpoint

        /// <summary>
        /// Calculate the midpoint between two Vector2.
        /// </summary>
        /// <param name="v">The first Vector2.</param>
        /// <param name="f">The second Vector2.</param>
        /// <returns>The midpoint Vector2.</returns>
        public static Vector2 Midpoint(this Vector2 v, Vector2 f)
        {
            return CombineVector(v, f) / 2f;
        }

        /// <summary>
        /// Calculate the weighted average of two Vector2 based on specified weight.
        /// </summary>
        /// <param name="v">The first Vector2.</param>
        /// <param name="f">The second Vector2.</param>
        /// <param name="weight">Weight for the first Vector2. Should be in the range [0, 100], it's a percentage.</param>
        /// <returns>The weighted average Vector2.</returns>
        public static Vector2 WeightedAverage(Vector2 v, Vector2 f, float weight)
        {
            const float a = 100f;
            float b = a - weight;

            return (v * weight + f * b) / (weight + b);
        }

        #endregion

        #region IsWithinRange

        /// <summary>
        /// Checks if this Vector2 is within the specified range of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The target Vector2.</param>
        /// <param name="range">The range within which the f Vector2 is considered "within."</param>
        /// <returns>True if the f Vector2 is within the specified range; otherwise, false.</returns>
        public static bool IsWithinRange(this Vector2 v, Vector2 f, float range)
        {
            float distance = Vector2.Distance(v, f);
            return distance <= range;
        }

        /// <summary>
        /// Checks if the X component of this Vector2 is within the specified range of the X component of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="range">The range within which the X components are considered "within."</param>
        /// <returns>True if the X components are within the specified range; otherwise, false.</returns>
        public static bool IsXWithinRange(this Vector2 v, Vector2 f, float range)
        {
            return Mathf.Abs(v.x - f.x) <= range;
        }

        /// <summary>
        /// Checks if the Y component of this Vector2 is within the specified range of the Y component of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="range">The range within which the Y components are considered "within."</param>
        /// <returns>True if the Y components are within the specified range; otherwise, false.</returns>
        public static bool IsYWithinRange(this Vector2 v, Vector2 f, float range)
        {
            return Mathf.Abs(v.y - f.y) <= range;
        }
        
        #endregion

        #endregion
    }
}
