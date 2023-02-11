using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDemo.Models
{
    public class DataModel
    {
        public int id  { get; set; }
        public string? device { get; set; }
        public bool status { get; set; }
        public DateTime date { get; set; }

    }
}
