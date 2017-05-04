using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Model;

namespace MyApp.Service.Contracts
{
    public interface IHelloWorldService
    {
        List<HelloWorld> GetHelloWorldAll();
        HelloWorld GetHelloWorldById(int Id);
        bool UpdateHelloWorld(int Id);
        bool DeleteHelloWorld(int Id);
    }
}
