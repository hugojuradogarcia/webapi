using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Value
    {
       public int id { get; set; }

        [MinLength(3)]
        public string text { get; set; }
    }
}