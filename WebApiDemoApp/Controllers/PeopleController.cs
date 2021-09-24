using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemoApp.Models;

namespace WebApiDemoApp.Controllers
{
   /// <summary>
   /// This is where all my info is for person 
   /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Prabhat", LastName = "Thapa", Id = 1 });
            people.Add(new Person { FirstName = "Kid", LastName = "kudi", Id = 2 });
            people.Add(new Person { FirstName = "Trap", LastName = "bag", Id = 3 });

        }
        //this is how u specify a rout or override a default rout 
        //when we use curly brakets it's for the call to pass value on the url 



        /// <summary>
        /// gets a list of the first name of all the users 
        /// </summary>
        /// <param name="userId"> The unique identifier for the persomn</param>
        /// <param name="age"> getting person age </param>
        /// <returns></returns>

        [Route("api/people/GetFirstName/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstName(int userId , int age )
        {
            List<string> output = new List<string>();
            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        // GET: api/People
        public List<Person> Get()
        {
             return people; 
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x=> x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
