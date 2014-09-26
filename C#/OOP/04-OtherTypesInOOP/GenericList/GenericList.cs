namespace GenericList
{
    using System;

    [Version(0, 1)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        #region Fields

        private T[] data;
        private int indexer;

        #endregion

        #region Constructors

        public GenericList()
        {
            this.data = new T[DefaultCapacity];
        }

        public GenericList(int capacity)
        {
            if (capacity < 2)
            {
                throw new IndexOutOfRangeException("Initial capacity must greater than 2");
            }

            this.data = new T[capacity];
            this.indexer = 0;
        }

        #endregion

        #region Properties

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.indexer;
            }
        }

        #endregion

        #region Methods

        public void Add(T element)
        {
            if (this.indexer == this.Capacity)
            {
                this.ResizeData();
            }

            this.data[this.indexer] = element;
            this.indexer++;
        }

        public void RemoveAt(int index)
        {
            if (this.indexer == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T[] newData = new T[this.Capacity];

            for (int i = 0; i < index; i++)
            {
                newData[i] = this.data[i];
            }

            for (int i = index; i < this.data.Length - 1; i++)
            {
                newData[i] = this.data[i + 1];
            }
        }
                
        public void Remove()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            this.indexer--;
        }

        public T IndexOf(int index)
        {
            if (this.Count < index || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of the range of the list!");
            }

            return this.data[index];
        }

        public void InsertAt(int index, T element)
        {
            if (this.indexer == this.Capacity)
            {
                this.ResizeData();
            }

            T[] newData = new T[this.data.Length];

            for (int i = 0; i < index; i++)
            {
                newData[i] = this.data[i];
            }

            newData[index] = element;

            for (int i = index; i < this.indexer; i++)
            {
                newData[i + 1] = this.data[i]; 
            }

            this.data = newData;
            this.indexer++;
        }

        public int FindIndex(T element)
        {
            for (int i = 0; i < this.indexer; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return i;
                }
            }

            throw new ArgumentException("Element does not exist int the array");
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.indexer; i++)
            {
                if (this.data[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.indexer = 0;
        }

        public T Max()
        {
            if (this.Count < 1)
            {
                throw new InvalidOperationException("The list is empty ");
            }

            T max = this.data[0];

            for (int i = 1; i < this.indexer; i++)
            {
                if (this.data[i].CompareTo(max) > 0) 
                {
                    max = this.data[i];
                }
            }

            return max;
        }

        public T Min()
        {
            if (this.Count < 1)
            {
                throw new InvalidOperationException("The list is empty ");
            }

            T min = this.data[0];

            for (int i = 1; i < this.indexer; i++)
            {
                if (this.data[i].CompareTo(min) < 0)
                {
                    min = this.data[i];
                }
            }

            return min;
        }

        private void ResizeData()
        {
            T[] newData = new T[this.Capacity * 2];

            for (int i = 0; i < this.indexer; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }
        
        #endregion
    }
}
