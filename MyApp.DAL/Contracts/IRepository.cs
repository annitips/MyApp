using MyApp.Model;
using System.Collections.Generic;

namespace MyApp.DAL.Contracts
{
    public interface IRepository
    {
        List<HelloWorld> GetHelloWorldAll();
        HelloWorld GetHelloWorldById(int Id);
        bool UpdateHelloWorld(int Id);
        bool DeleteHelloWorld(int Id);
    }
}
