using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class AnswerForm
    {
       // public Guid SessionID { get; set; }
       // public string Caption { get; set; }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
       /* {
            f,
            m
        }
        */
        public DateTime Birth { get; set; }
        public string Marital { get; set; }    
        /*  {
            m,
            s
        }
        */
        public bool Programming { get; set; }

    }
}