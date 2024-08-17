using System;
using System.Reflection.Metadata.Ecma335;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");

            

        }

        public interface IEntity
        {
            // IEntity implement eden classlar veritabanı nesneleridir
        }

      public  class Product:IEntity
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

        public class Customer:IEntity
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

        public class Order:IEntity
        {
            public string Address { get; set; }
        }

        public interface IEntityRepository<T> where T: IEntity, new() // T yi sınırlandırdık suistimal edilemez duruma getirdik.
        {
            void Add(T t);
            void Update(T t);
            void Delete(T t);
        }

        class ProductDal : IEntityRepository<Product>
        {
            public void Add(Product t)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product t)
            {
                throw new NotImplementedException();
            }

            public void Update(Product t)
            {
                throw new NotImplementedException();
            }
        }

        class CustomerDal : IEntityRepository<Customer>
        {
            public void Add(Customer t)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer t)
            {
                throw new NotImplementedException();
            }

            public void Update(Customer t)
            {
                throw new NotImplementedException();
            }
        }

        class OrderDal : IEntityRepository<Order>
        {
            public void Add(Order t)
            {
                throw new NotImplementedException();
            }

            public void Delete(Order t)
            {
                throw new NotImplementedException();
            }

            public void Update(Order t)
            {
                throw new NotImplementedException();
            }
        }

    }

    

    
}
