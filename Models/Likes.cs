using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace Models
{
    public class Likes : Record
    {
        public int MediaId { get; set; }
        public int UserId { get; set; }
    }
}