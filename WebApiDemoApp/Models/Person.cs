using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoApp.Models
{
    /// <summary>
    /// This reps one specific person.
    /// </summary>
    public class Person
    {
        public int Id { get; set; } = 0; 
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";


    }
}