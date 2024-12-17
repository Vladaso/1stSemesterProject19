using System;
using System.Collections.Generic;

namespace WorldOfZuul
{
    public class Screen
    {
        private char[,] screenBuffer;
        private int width;
        private int height;
        /// <summary>
        /// Initializes Screen object with the specified height and width
        /// </summary>
        public Screen(int height, int width)
        {
            this.width = width;
            this.height = height;
            screenBuffer = new char[height, width];
            ClearScreen();
        }

        /// <summary>
        /// Clears the screen buffer.
        /// </summary>
        public void ClearScreen()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    screenBuffer[y, x] = ' ';
                }
            }
        }
        /// <summary>
        /// Main method to set the content of the screen.
        /// </summary>
        public void SetScreenContent(string title, string inventory, string roomArt, string actionBar, List<Item> items)
        {
            ClearScreen();
            //Have precise control over where the content is placed

            int roomStart = 3;

            SetContentAtPosition(roomArt, roomStart, 0);
            //This overwrites the top left of the room art
            SetContentAtPosition(title, roomStart+1, 6); //Adds 4 padding which is in all the other strings

            SetContentAtPosition(inventory, 0, 4);
            SetContentAtPosition(actionBar, roomStart+23, 0);

            if(items.Count > 0){
                foreach (Item item in items)
                {
                    SetContentAtPosition(item.Symbol, roomStart + item.Y, 4 + item.X);
                }
            }
        }
        private void SetContentAtPosition(string content, int startY, int startX)
        {
            string[] lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); // splits the string into lines according to \n

            for (int y = 0; y < lines.Length && (startY + y) < height; y++)
            {
                string line = lines[y];
                for (int x = 0; x < line.Length && (startX + x) < width; x++)
                {
                    screenBuffer[startY + y, startX + x] = line[x];
                }
            }
        }
        

        /// <summary>
        /// Displays the 2D character array on the console.
        /// </summary>
        public void Display()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(screenBuffer[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}