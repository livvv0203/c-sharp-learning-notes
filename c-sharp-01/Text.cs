using System;

namespace c_sharp_learning
{
    public class Text : PresentationObject
    {
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }


    }
}






















