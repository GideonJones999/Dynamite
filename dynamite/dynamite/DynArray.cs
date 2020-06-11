using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamite
{
    class DynArray <T>
    {
        //Properties
        private T[] data = new T[1];
        private int capacity = 1;
        private int count = 0;

        //Member Methods
        public int Capacity
        {
            get { return capacity; }
        }
        public int Count
        {
            get { return count; }
        }
        public T getMember(int index)
        {
            if (index >= 0 && index < count)
                return data[index];
            else
                return default(T);
        }
        public void RemoveMember(int index)
        {
            //Add Things  
        }
        public void Add(T p)
        {
            if(count >= capacity)
                DoubleCapacity();

            data[count] = p;
            count++;
        }

        private void DoubleCapacity()
        {
            T[] temp = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
                temp[i] = data[i];
            capacity *= 2;
            data = temp;
        }

    }
}
