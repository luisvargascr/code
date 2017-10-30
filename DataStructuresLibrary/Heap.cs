using System;

namespace DataStructures
{
    public class Heap
    {
        private int CAPACITY = 10;
        private int _size;
        private int[] _items;

        public Heap()
        {
            _size = 0;
            _items = new int[CAPACITY];
        }
        private int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        private int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        private int GetParentIndex (int childIndex) { return (childIndex - 1) / 2; }

        private bool HasLeftChild (int index) { return GetLeftChildIndex(index) < _size; }
        private bool HasRightChild (int index) { return GetRightChildIndex(index) < _size; }
        private bool HasParent (int index) { return GetParentIndex(index) >= 0; }

        private int LeftChild (int index) { return _items[GetLeftChildIndex(index)]; }
        private int RightChild (int index) { return _items[GetRightChildIndex(index)]; }
        private int Parent (int index) { return _items[GetParentIndex(index)]; }

        private void Swap (int indexOne, int indexTwo)
        {
            int temp = _items[indexOne];
            _items[indexOne] = _items[indexTwo];
            _items[indexTwo] = temp;
        }
        private void ExpandCapacity()
        {
            if (_size == CAPACITY)
            {
                Array.Copy(_items, _items, CAPACITY * 2);
                CAPACITY *= 2;
            }
        }
        public int Peek()
        {
            if (_size == 0) throw new Exception("Illegal operation on an empty heap!");
            return _items[0];
        }
        public int Poll()
        {
            if (_size == 0) throw new Exception("Illegal operation on an empty heap!");
            int item = _items[0];
            _items[0] = _items[_size - 1];
            _size--;
            HeapifyDown();
            return item;
        }
        public void Add (int item)
        {
            ExpandCapacity();
            _items[_size] = item;
            _size++;
            HeapifyUp();
        }
        public void HeapifyUp()
        {
            int index = _size - 1;
            while (HasParent(index) && Parent(index) > _items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }
        public void HeapifyDown()
        {
            int index = 0;
            while(HasLeftChild(index))
            {
                int SmallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                {
                    SmallerChildIndex = GetRightChildIndex(index);
                }
                if (_items[index] < _items[SmallerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, SmallerChildIndex);
                }
                index = SmallerChildIndex;
            }
        }

    }
}
