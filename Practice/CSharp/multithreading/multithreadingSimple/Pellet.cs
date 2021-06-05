namespace multithreadingSimple
{
    public class Pellet
    {
        public int id;
        public int destination;
        public int size;
        public int order;
        public Pellet(int id, int destination, int size, int order)
        {
            this.id = id;
            this.destination = destination;
            this.size = size;
            this.order = order;
        }
    }
}