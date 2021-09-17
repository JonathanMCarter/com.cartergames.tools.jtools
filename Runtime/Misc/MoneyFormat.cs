using System;
using UnityEngine;

namespace JTools
{
    public static class MoneyFormat
    {
        private static readonly string[] Suffixes = {"", "k","M", "B", "T", "aa", "ab", "ac", "ad", "ae", "af", "ag", "ah", "ai", "aj", "ak", "al", "am", "an", "ao", "ap", "aq", "ar", "as", "at", "au", "av", "aw", "ax", "ay", "az", "ba", "bb", "bc", "bd", "be", "bf", "bg", "bh", "bi", "bj", "bk", "bl", "bm", "bn", "bo", "bp", "bq", "br", "bs", "bt", "bu", "bv", "bw", "bx", "by", "bz", };
        
        public static string Format(double value)
        {
            string result;
            int i;
 
            for (i = 0; i < Suffixes.Length; i++)
                if (value < 900)
                    break;
                else value = Math.Floor(value / 100f) / 10f;
 
            if (Math.Abs(value - Math.Floor(value)) < .1f)
                result = value + Suffixes[i];
            else result = value.ToString("F1") + Suffixes[i];
            return result;
        }
        
        
        public static string Format(float value)
        {
            string result;
            int i;
 
            for (i = 0; i < Suffixes.Length; i++)
                if (value < 900)
                    break;
                else value = Mathf.Floor(value / 100f) / 10f;
 
            if (Math.Abs(value - Mathf.Floor(value)) < .1f)
                result = value + Suffixes[i];
            else result = value.ToString("F1") + Suffixes[i];
            return result;
        }
        
        
        public static string Format(int value)
        {
            float read = value;
            string result;
            int i;
 
            for (i = 0; i < Suffixes.Length; i++)
                if (read < 900)
                    break;
                else read = Mathf.Floor(read / 100f) / 10f;
 
            if (Math.Abs(read - Mathf.Floor(read)) < .1f)
                result = read + Suffixes[i];
            else result = read.ToString("F1") + Suffixes[i];
            return result;
        }
    }
}