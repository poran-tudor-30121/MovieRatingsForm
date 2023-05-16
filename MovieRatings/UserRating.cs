//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRatings
{
    public class UserRating
    {

        public string MovieTitle { get; set; }
        public string UserName { get; set; }
        public float Rating { get; set; }


    }
}