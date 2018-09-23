namespace DataStructuresAndAlgorithms.DataStructures
{
    public class NodeDoubleLink<TData>
    {
        public TData Data;
        public NodeDoubleLink<TData> PreviousLink;
        public NodeDoubleLink<TData> NextLink;

        public NodeDoubleLink()
        {
            Data = default(TData);
        }

        public NodeDoubleLink(TData data)
        {
            Data = data;
            PreviousLink = null;
            NextLink = null;
        }
    }
}