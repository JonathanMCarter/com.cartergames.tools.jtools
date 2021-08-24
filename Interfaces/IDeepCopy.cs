using System.Collections.Generic;

namespace JTools
{
    /// <summary>
    /// Makes the inheriting script need to provide a deep copy method for a type entered...
    /// </summary>
    public interface IDeepCopy<T>
    {
        List<T> GetDeepCopy();
    }
}