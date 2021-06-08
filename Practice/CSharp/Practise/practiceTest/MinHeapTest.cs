using System;
using System.Collections.Generic;
using Xunit;
using Practise;

namespace practiceTest
{
    public class MinHeapTest
    {
        [Fact]
        public void MinHeap_Test1()
        {
            var heap = new MinHeap<int>();
            heap.Add(42);
            heap.Add(48);
            heap.Add(6);
            Assert.Equal(6, heap.GetMin());
        }

        [Fact]
        public void MinHeap_Test2()
        {
            var heap = new MinHeap<int>();
            heap.Add(42);
            heap.Add(48);
            heap.Add(6);
            heap.Add(8);
            heap.Add(-42);
            Assert.Equal(-42, heap.GetMin());
        }

        [Fact]
        public void MinHeap_Test3()
        {
            var heap = new MinHeap<int>();
            heap.Add(42);
            heap.Add(48);
            heap.Add(6);
            heap.Add(8);
            heap.Add(-42);
            var list = new List<int>(){-42, 6, 8, 42, 48};
            list.Sort();
            var l1 = new List<int>();
            for(int i=0;i<3;i++)
                l1.Add(heap.GetMin());
            Assert.Equal(l1, list);
        }
    }
}