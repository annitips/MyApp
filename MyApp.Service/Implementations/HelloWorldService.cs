using MyApp.DAL.Contracts;
using MyApp.Model;
using MyApp.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Service
{
    public class HelloWorldService : IHelloWorldService
    {
        IRepository _repository;

        public HelloWorldService(
            IRepository repository)
        {
            this._repository = repository;
        }


        public HelloWorld GetHelloWorldById(int Id)
        {

            return _repository.GetHelloWorldById(Id);
        }

        public List<HelloWorld> GetHelloWorldAll()
        {

            return _repository.GetHelloWorldAll();
        }

        public bool UpdateHelloWorld(int Id)
        {

            return _repository.UpdateHelloWorld(Id);
        }


        public bool DeleteHelloWorld(int Id)
        {

            return _repository.DeleteHelloWorld(Id);
        }


    }
}
