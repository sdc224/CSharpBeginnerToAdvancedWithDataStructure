namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Link = null;

        public Node()
        {
            Data = default(T);
        }

        public Node(T data)
        {
            Data = data;
        }
    }
}