using System;


namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");
        }

    }

    //Single Responsibility

    class User
    {
 
        void GetUserInfo(string name) { }
    }

}

class Write()
{
    void Add(string name) { }
    void Update(string name) { }
}

class Read()
{
    void GetAll(string name) { }
    void GetAllByCategoryId(int id) { }
}