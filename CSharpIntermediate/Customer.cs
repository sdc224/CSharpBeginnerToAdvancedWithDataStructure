using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            /*Orders = new List<Order>();*/
        }
    }
}