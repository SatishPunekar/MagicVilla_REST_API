using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> { 
            new VillaDTO {Id=1, Name="Pool view", Occupancy=20, Sqft=1500 },
            new VillaDTO {Id=2, Name="Beach view", Occupancy=30, Sqft=3000 }
            };
    }
}
