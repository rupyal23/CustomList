using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
       
        private int _count;
        public int count { get { return _count; } }
        private int _defCapacity = 4;
        public int capacity { get { return _defCapacity; } set { _defCapacity = value; } }
        T[] items;
        public CustomList()
        {
            items = new T[_defCapacity];
        }

        //another constructor to declare list with the capacity
        public CustomList(int item)
        {
            _defCapacity = item;
            items = new T[_defCapacity];
        }
        

        //Indexer for the custom list
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                
                items[index] = value;
            }
        }

        //generic method to add objects to custom list
        public void Add(T item)
        {
            _count++;
            Resize();
            items[_count-1] = item;
        }

        public void AddForConversion(T item)
        {
            _count++;
            items[_count - 1] = item;
        }

        //Overloaded by adding the index functionality. Add a value at the specified index and shifts list to the right.
        public void Add(T item, int item1)
        {
            _count++;
            Resize();
            
            for(int i = _count; i > item1 ; i--)
            {
                items[i] = items[i - 1];

            }
            items[item1] = item;
        }

        //Remove Method- Removes the first instance of the item in the list
        public void Remove(T item)
        {
            
            for (int i = 0; i < items.Length; i++)
            {
                if (item.Equals(items[i]))
                {
                    items[i] = default(T);
                    _count--;
                    for (int j = i; j < _count; j++)
                    {
                        items[j] = items[j + 1];
                        
                    }
                    items[_count] = default(T); 
                    break; //used so that it only removes one instance and break out of the loop
                }
            }
        }

        //Helper method to resize the array in the list
        public void Resize()
        {
            if(_count == capacity)
            {
                capacity = capacity * 2;
                T[] temporaryItems = new T[capacity];
                for( int i = 0; i < items.Length; i++)
                {
                    temporaryItems[i] = items[i];
                }
                items = temporaryItems;
            }
        }

        public override string ToString()
        {
            
            string stringifiedList = "";
            for(int i = 0; i < _count; i++)
            {
                stringifiedList += items[i] + " ";
            }
            return stringifiedList;

        }
    }
}
