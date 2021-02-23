using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int GameNumber { get; set; }
        public string GameTitle { get; set; }
        public DateTime DateAdded { get; set; }
        public int GamePrice { get; set; }
        public bool GameAvailability { get; set; }

        public bool Find(int gameNumber)
        {
            //always return true
            return true;
        }
    }
}