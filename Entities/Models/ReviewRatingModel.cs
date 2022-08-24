using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ReviewRatingModel
    {
        public int Review_ID { get; set; }
        public int Customer_ID { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}
