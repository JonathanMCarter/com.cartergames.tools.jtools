namespace JTools
{
    public static class CustomLog
    {
        public static void Message(object message)
        {
            UnityEngine.Debug.Log(message);
        }
        
        public static void Warning(object message)
        {
            UnityEngine.Debug.LogWarning(message);
        }
        
        public static void Error(object message)
        {
            UnityEngine.Debug.LogError(message);
        }
    }
}