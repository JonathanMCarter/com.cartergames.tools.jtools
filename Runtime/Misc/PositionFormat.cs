namespace JTools
{
    public static class PositionFormat
    {
        /// <summary>
        /// Returns the position entered formatted with the correct ending characters as a string...
        /// </summary>
        /// <param name="pos">The position to get</param>
        /// <returns>String of the position with the correct ending characters...</returns>
        public static string GetFormattedPosition(int pos)
        {
            var _pos = pos.ToString();
            var _toCheck = int.Parse(_pos.Substring(_pos.Length - 1, 1));

            return _toCheck switch
            {
                1 => $"{_pos}st",
                2 => $"{_pos}nd",
                3 => $"{_pos}rd",
                _ => $"{_pos}th"
            };
        }
    }
}