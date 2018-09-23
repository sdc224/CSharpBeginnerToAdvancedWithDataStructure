namespace CSharpAdvanced
{
    //where T : struct (value type)

    public class Nullable<T>
    {
        private readonly object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);                                      // Returns the defalut value of a type, for e.g. "0 for int"
        }
    }
}