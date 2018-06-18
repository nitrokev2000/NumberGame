using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberView
{
    class HashMap
    {
        public class IntDict<T>
        {
            private Dictionary<int, T> internalDict = new Dictionary<int, T>();

            public string Name { get; set; }

            public void Add(int key, T value)
            {
                internalDict.Add(key, value);
            }

            public ICollection<int> Keys
            {
                get { return internalDict.Keys; }
            }

            public bool Remove(int key)
            {
                return internalDict.Remove(key);
            }

            public ICollection<T> Values
            {
                get { return internalDict.Values; }
            }

            public T this[int key]
            {
                get
                {
                    return internalDict[key];
                }
                set
                {
                    internalDict[key] = value;
                }
            }

            public void Add(KeyValuePair<int, T> item)
            {
                internalDict.Add(item.Key, item.Value);
            }

            public bool Contains(KeyValuePair<int, T> item)
            {
                return (internalDict.ContainsKey(item.Key) && internalDict.ContainsValue(item.Value));
            }

            public bool Remove(KeyValuePair<int, T> item)
            {
                throw new NotImplementedException();
            }
        }
    }
}
