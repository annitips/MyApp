using MyApp.Model;
using MyApp.Service.Contracts;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    
    [RoutePrefix("api/HelloWorld")]
    public class HelloworldController : ApiController
    {

        IHelloWorldService _helloWorldService;

        public HelloworldController()
        {

        }

        public HelloworldController(IHelloWorldService helloWorldService)
        {
            this._helloWorldService = helloWorldService;
        }


        // GET: api/Helloworld/Show
        [Route("Show")]
        public HelloWorld Get()
        {
            var hello = new HelloWorld() { Id = 1, Name = "Hello World" };

            
            return hello;
        }

        // GET: api/Helloworld/ShowAll
        [Route("ShowAll")]
        public HttpResponseMessage GetAll()
        {
            var hello = _helloWorldService.GetHelloWorldAll();

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, hello);
            return response;
        }


        // GET: api/Helloworld/Show/5
        [Route(Name ="Show/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            var hello = _helloWorldService.GetHelloWorldById(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, hello);
            return response;
        }

        // POST: api/Helloworld/Create
        [HttpPost]
        [Route("Create")]
        public HttpResponseMessage Post([FromBody]HelloWorld value)
        {
            //TODO: Implement Write to DB
            var uri = Url.Link("DefaultApi", value);
            return Request.CreateResponse(HttpStatusCode.OK, uri);

        }

        // PUT: api/Helloworld/Update/5
        [HttpPut]
        [Route("Update/{id}")]
        public void Put(int id, [FromBody]string value)
        {
            //TODO: Implement Update
        }

        // DELETE: api/Helloworld/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            //TODO: Implement Delete
        }
    }
}
