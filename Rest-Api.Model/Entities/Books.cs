using System;
using System.Collections.Generic;
using System.Text;

namespace Rest_Api.Model.Entities
{
    public class Books
    {
        public string Id { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreatedTime { get; set; }
        public double Prices { get; set; }
        public int PageNumbers { get; set; }  
    }
}
