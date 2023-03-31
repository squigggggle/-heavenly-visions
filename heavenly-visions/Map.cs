using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heavenly_visions
{
    public class Map
    {
        private Dictionary<int, string> items;

        public Map()
        {
            items = new Dictionary<int, string>();
        }

        public void Add(int key, string value)
        {
            items[key] = value;
        }

        public string Remove(int key)
        {
            string value;
            if (!items.TryGetValue(key, out value))
            {
                throw new Exception("Key not found");
            }
            items.Remove(key);
            return value;
        }

        public string Lookup(int key)
        {
            string value;
            if (!items.TryGetValue(key, out value))
            {
                throw new Exception("Key not found");
            }
            return value;
        }

        public void Update(int key, string newValue)
        {
            if (!items.ContainsKey(key))
            {
                throw new Exception("Key not found");
            }
            items[key] = newValue;
        }
    }
}
