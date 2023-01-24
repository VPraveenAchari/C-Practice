namespace CollectionsExample
{
    class Collections
    {
        
        public static void Main(String[] args)
        {
            Console.WriteLine("ArrayList");
            ArrayListEx ar = new ArrayListEx();
            ar.Display();
            Console.WriteLine("stack");
            StackEx st = new StackEx();
            st.Display();
            Console.WriteLine("Queue");
            QueueEx qu = new QueueEx();
            qu.Display();
            Console.WriteLine("HashTable");
            HashTableEx hte = new HashTableEx();
            hte.Display();
            Console.WriteLine("SortedList");
            SortedListEx stl = new SortedListEx();
            stl.Display();
        }
    }
}