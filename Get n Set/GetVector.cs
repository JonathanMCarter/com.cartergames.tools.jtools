using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JTools.GetSet
{
    public static class GetVector
    {
        public static Vector3 MidPoint(Vector3 a, Vector3 b)
        {
            return (a + b) * .5f;
        }
    }
}
