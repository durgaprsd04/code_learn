using System;

namespace multithreading
{
    public class Pellet:IComparable<Pellet>
    {
        public int id;
        public int source;
        public int size;
        public int order;

        public Pellet(int id, int source, int size, int order)
        {
            this.id = id;
            this.source = source;
            this.size = size;
            this.order = order;
        }
        public int CompareTo(Pellet other)
        {
            if(source==other.source)
                return this.order - other.order;
            return 0;
        }
        public override string ToString()
        {
            return $"id {id} source {source} size {size} order{order}";
        }
    }
}