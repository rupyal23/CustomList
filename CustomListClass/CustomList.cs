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
        
        //want to overload by adding the index functionality
        public void Add(T item, T item1)
        {
            
        }



        public void Remove(T item)
        {

        }

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
    }
}
