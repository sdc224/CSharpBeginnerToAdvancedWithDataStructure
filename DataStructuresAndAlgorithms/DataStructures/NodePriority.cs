namespace DataStructuresAndAlgorithms.DataStructures
{
    public class NodePriority<TData>
    {
        public int Priority;
        public TData Data;
        public NodePriority<TData> Link;

        public NodePriority(int priority, TData data)
        {
            Priority = priority;
            Data = data;
            Link = null;
        }
    }
}
