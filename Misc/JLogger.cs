namespace JTools
{
    public static class JLogger
    { 
        [System.Diagnostics.Conditional("USE_JLOG")]
        public static void Log(object message)
        {
            UnityEngine.Debug.Log(message);
        }
        
        [System.Diagnostics.Conditional("USE_JLOG")]
        public static void LogWarning(object message)
        {
            UnityEngine.Debug.LogWarning(message);
        }
        
        [System.Diagnostics.Conditional("USE_JLOG")]
        public static void LogError(object message)
        {
            UnityEngine.Debug.LogError(message);
        }
    }
}