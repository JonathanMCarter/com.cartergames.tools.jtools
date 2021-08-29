using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools
{
    /// <summary>
    /// A collection of useful methods to do with vectors specifically...
    /// </summary>
    public static class GetVector
    {
        /// <summary>
        /// Gets a line from a to b...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <param name="normalise">Should the result be normalised...</param>
        /// <returns>Vector2</returns>
        public static Vector2 Line(Vector2 a, Vector2 b, bool normalise = true)
        {
            return normalise ? (b - a).normalized : (b - a);
        }


        /// <summary>
        /// Gets a line from a to b...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <param name="normalise">Should the result be normalised...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Line(Vector3 a, Vector3 b, bool normalise = true)
        {
            return normalise ? (b - a).normalized : (b - a);
        }
        
        
        /// <summary>
        /// Gets a line from a to b...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Line(Vector3 a, Vector3 b)
        {
            return (b - a).normalized + a;
        }
        
        
        /// <summary>
        /// Gets a line from a to b...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <param name="distance">The length the line should extend to...</param>
        /// <returns>Vector2</returns>
        public static Vector2 Line(Vector2 a, Vector2 b, float distance)
        {
            return ((b - a).normalized + a) * distance;
        }
        
        
        /// <summary>
        /// Gets a line from a to b...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <param name="distance">The length the line should extend to...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Line(Vector3 a, Vector3 b, float distance)
        {
            return ((b - a).normalized + a) * distance;
        }
        
        
        /// <summary>
        /// Gets a middle point of a line between a & b
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <returns>Vector2</returns>
        public static Vector2 MidPoint(Vector2 a, Vector2 b)
        {
            return (a + b) * .5f;
        }
        
        
        /// <summary>
        /// Gets a middle point of a line between a & b
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <returns>Vector3</returns>
        public static Vector3 MidPoint(Vector3 a, Vector3 b)
        {
            return (a + b) * .5f;
        }
        
        
        
        /// <summary>
        /// Gets the distance between the two vectors...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <returns>Vector2</returns>
        public static float Distance(Vector2 a, Vector2 b)
        {
            return Vector2.Distance(a, b);
        }


        /// <summary>
        /// Gets the distance between the two vectors...
        /// </summary>
        /// <param name="a">The start point...</param>
        /// <param name="b">The end point...</param>
        /// <returns>Vector3</returns>
        public static float Distance(Vector3 a, Vector3 b)
        {
            return Vector3.Distance(a, b);
        }

        
        /// <summary>
        /// Returns a vector with the modified x value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The vector to get edits from...</param>
        /// <returns>Vector2</returns>
        public static Vector2 Vector2DifferentX(Vector2 a, Vector2 b)
        {
            return new Vector2(b.x, a.y);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified x value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The value to change x to...</param>
        /// <returns>Vector2</returns>
        public static Vector2 Vector2DifferentX(Vector2 a, float b)
        {
            return new Vector2(b, a.y);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified y value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The vector to get edits from...</param>
        /// <returns>Vector2</returns>
        public static Vector2 Vector2DifferentY(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x, b.y);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified y value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The value to change y to...</param>
        /// <returns>Vector2</returns>
        public static Vector2 Vector2DifferentY(Vector2 a, float b)
        {
            return new Vector2(a.x, b);
        }


        /// <summary>
        /// Returns a vector with the modified x value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The vector to get edits from...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Vector3DifferentX(Vector3 a, Vector3 b)
        {
            return new Vector3(b.x, a.y ,a.z);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified x value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The value to change x to...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Vector3DifferentX(Vector3 a, float b)
        {
            return new Vector3(b, a.y ,a.z);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified y value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The vector to get edits from...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Vector3DifferentY(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x, b.y ,a.z);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified y value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The value to change y to...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Vector3DifferentY(Vector3 a, float b)
        {
            return new Vector3(a.x, b ,a.z);
        }
        
        
        /// <summary>
        /// Returns a vector with the modified z value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The vector to get edits from...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Vector3DifferentZ(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x, a.y, b.z);
        }


        /// <summary>
        /// Returns a vector with the modified z value...
        /// </summary>
        /// <param name="a">The initial vector to edit...</param>
        /// <param name="b">The value to change z to...</param>
        /// <returns>Vector3</returns>
        public static Vector3 Vector3DifferentZ(Vector3 a, float b)
        {
            return new Vector3(a.x, a.y, b);
        }


        public static Vector3 Divided(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        
        public static Vector3 Multiplied(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Vector3 Abs(Vector3 a)
        {
            return new Vector3(Mathf.Abs(a.x), Mathf.Abs(a.y), Mathf.Abs(a.z));
        }
    }
}
