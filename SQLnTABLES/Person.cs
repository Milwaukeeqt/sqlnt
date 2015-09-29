using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SQLnTABLES
{
    public class Person
    {
        public string Name{ get; set; }

        public string Surname { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public string SqlToString()
        {
            return "INSERT INTO Person (N,S,A,G) VALUES("+ Name + "," + Surname +"," + Age + "," + Gender + ")";
        }
    }
}