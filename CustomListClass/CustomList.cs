using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
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


        //Helper method to desize- used in the - operator overloading
        public void Desize()
        {
            if((capacity - _count) > 4)
            {
                capacity = capacity / 2;
                T[] temporaryItems = new T[capacity];
                for(int i = 0; i < capacity; i++)
                {
                    temporaryItems[i] = items[i];
                }
                items = temporaryItems;
            }
        }

        //Overrided the ToString Method to stringify the objects in a list
        public override string ToString()
        {
            
            string stringifiedList = "";
            for(int i = 0; i < _count; i++)
            {
                stringifiedList += items[i] + " ";
            }
            return stringifiedList;

        }

        //Overloaded the + operator to add two lists
        public static CustomList<T> operator +(CustomList<T>List1, CustomList<T>List2)
        {
            CustomList<T> ResultList = new CustomList<T>();
            for(int i = 0; i < List1.count; i++)
            {
                ResultList.Add(List1[i]);
            }
            for(int j = 0; j < List2.count; j++)
            {
                ResultList.Add(List2[j]);
            }
            return ResultList;
        }

        //Overloaded the - operator to subtract two lists
        public static CustomList<T> operator -(CustomList<T>List1, CustomList<T>List2)
        {
            CustomList<T> ResultList = new CustomList<T>();
            ResultList = List1;
            for( int i = 0; i < List2.count; i++)
            {
                ResultList.Remove(List2[i]);
            }
            ResultList.Desize();
            return ResultList;
        }

        //Zip Method to Zip Two Lists
        public CustomList<T> Zip(CustomList<T>list)
        {
            CustomList<T> ResultList = new CustomList<T>();
            int counter;
            if (list.count > this.count)
            {
                counter = list.count;
               
            } else
            {
                counter = this.count;
               
            } 
            for (int i = 0; i < counter; i++)
            {
                if (i < this.count)
                {
                    ResultList.Add(this[i]);
                }
                if (i < list.count)
                {
                    ResultList.Add(list[i]);
                }
            }
            return ResultList;
        }

        //Interface Implementation for Iteration
        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < _count; index++)
            {
                yield return items[index];
            }
        }


        //Sorting for ints 
        public void Sort(CustomList<int>List)
        {
            int temp;
            for(int i = 0; i < _count; i++)
            {
                for (int j = i; j < _count; j++)
                {
                    if (List[i].CompareTo(List[j]) > 0)
                    {
                        temp = List[i];
                        List[i] = List[j];
                        List[j] = temp;
                        
                    }
                }
            }
        }
    }
}