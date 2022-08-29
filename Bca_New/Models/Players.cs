using System.ComponentModel.DataAnnotations;

namespace Bca_New.Models
{
    public class Players
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public string? tournment_type { get; set; }
        public string? sport_name { get; set; }
        public string? date { get; set; }
        public string? start_time { get; set; }
        public string? end_time { get; set; }
        public string? status { get; set; }
    }
}
