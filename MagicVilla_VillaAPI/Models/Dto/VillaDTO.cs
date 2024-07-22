using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required] //if you miis this you will get error like this. The Name field is required. status code is 400
        [MaxLength(7)] //you should follow max length is 7 only  
        public string Name { get; set; }
        public int Occupancy {  get; set; }
        public int Sqft { get; set; }
    }
}
