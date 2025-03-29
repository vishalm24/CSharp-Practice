using ConsoleApp1.ModelsWithData;

namespace ConsoleApp1
{
    internal class Object_Initializer
    {
        public List<Customer> customers()
        {
            var custList = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Vishal Murudkar",
                    Address = "Dombivli",
                    Orders = new Lazy<List<Order>>(()=>
                        new List<Order>(){
                        new Order()
                        {
                            Id = 1,
                            Name = "Item 1",
                            Quantity = 1,
                            Price = 1200
                        },
                        new Order()
                        {
                            Id = 2,
                            Name = "Item 2",
                            Quantity = 12,
                            Price = 60
                        },
                        new Order()
                        {
                            Id = 3,
                            Name = "Item 3",
                            Quantity = 10,
                            Price = 50
                        }
                    })
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Pruthviraj Gandhve",
                    Address = "Dharashiv",
                    Orders = new Lazy<List<Order>>(()=>
                        new List<Order>(){
                        new Order()
                        {
                            Id = 4,
                            Name = "Item 2",
                            Quantity = 43,
                            Price = 60
                        },
                        new Order()
                        {
                            Id = 5,
                            Name = "Item 4",
                            Quantity = 8,
                            Price = 26
                        },
                        new Order()
                        {
                            Id = 6,
                            Name = "Item 3",
                            Quantity = 23,
                            Price = 50
                        }
                    })
                }
            };
            return custList;
        }
    }
}
