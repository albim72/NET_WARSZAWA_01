using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaGeneryczna
{
    class MojaTablicaGeneryczna<T>
    {
        private int[] array;
        private T[] genericArray;

        public MojaTablicaGeneryczna(int size)
        {
            array = new int[size+1];
            genericArray = new T[size+1];
        }

        public int getItem(int index)
        {
            return array[index];
        }

        public T getGenericArray(int index)
        {
            return genericArray[index];
        }

        public void setValue(int index, int value)
        {
            array[index] = value;
        }

        public void setGenericValue(int index, T value)
        {
            genericArray[index] = value;
        }


    }
}
