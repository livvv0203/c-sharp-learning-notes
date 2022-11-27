using System;
namespace Properties
{
    class Box
    {
        // Member variables
        private int length;
        private int height;
        private int width;
        private int volume;

        // getter and setters
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length; 
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1}, width is {2} , volume is {3}.",
                length, height, width, volume = length * height * width);
        }





    }
}
