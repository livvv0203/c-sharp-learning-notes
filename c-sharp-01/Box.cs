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

        // public int Width { get; set; }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.width;
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

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





