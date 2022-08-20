using System;
using System.Collections.Generic;

namespace c_sharp_learning
{
    // Indexers
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            // Initialize the dictionary
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}













