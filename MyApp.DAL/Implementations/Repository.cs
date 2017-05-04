using MyApp.DAL.Contracts;
using MyApp.Model;
using System.Collections.Generic;

namespace MyApp.DAL.Implementations
{
    public class Repository : IRepository
    {
        List<HelloWorld> IRepository.GetHelloWorldAll()
        {
            //TODO: Implement Reading from DB
            //For now we are mimicing as if data is coming from DB
            List<HelloWorld> listHello = new List<HelloWorld>();
            HelloWorld hello = new HelloWorld()
            {
                Id = 1,
                Name = "Hello World"
            };

            listHello.Add(hello);

            return listHello;
        }
        HelloWorld IRepository.GetHelloWorldById(int Id)
        {
            //TODO: Implement Reading from DB using Id
            //For now we are mimicing as if data is coming from DB
            HelloWorld hello = new HelloWorld()
            {
                Id = 2,
                Name = "Hello World"
            };
            return hello;
        }

        bool IRepository.UpdateHelloWorld(int Id)
        {
            //TODO: Implement Update to DB using Id
            //For now we are just returning true

            return true;
        }

        bool IRepository.DeleteHelloWorld(int Id)
        {
            //TODO: Implement Delete from DB using Id
            //For now we are just returning true
            
            return true;
        }
    }
}
