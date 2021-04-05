using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class MyDictionary<T>
    {
        T[] itemList;

        public MyDictionary()
        {
            itemList = new T[0];
        }

        public void Add(T item)
        {
            T[] temp = itemList;
            itemList = new T[itemList.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                itemList[i] = temp[i];
            }
            itemList[itemList.Length - 1] = item;
        }

        public int itemListLength
        {
           get { return itemList.Length; }
        }

        public T[] items
        {
            get { return itemList; }
        }
    }
}
