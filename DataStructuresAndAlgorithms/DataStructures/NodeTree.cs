namespace DataStructuresAndAlgorithms.DataStructures
{
    public class NodeTree<TData>
    {
        public TData Data;
        public NodeTree<TData> LeftChild;
        public NodeTree<TData> RightChild;

        public NodeTree(TData data)
        {
            Data = data;
            LeftChild = null;
            RightChild = null;
        }
    }
}
