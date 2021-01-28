using System.Collections;
using System.Collections.Generic;

namespace MyDictionarys
{
    public class MyDictionary<T>
    {
        private T[] K;
        private T[] V;
        private List<int> t = new List<int>();

        public MyDictionary()
        {
            K = new T[0];
            V = new T[0];
        }

        public void Add(T k, T v)
        {
            T[] tempKey = K;
            T[] tempVlaue = V;
            K = new T[K.Length + 1];
            V = new T[V.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                K[i] = tempKey[i];
                V[i] = tempVlaue[i];
            }

            K[^1] = k;
            V[^1] = v;
        }

        public int Length
        {
            get
            {
                return K.Length;
            }
        }
    }
}