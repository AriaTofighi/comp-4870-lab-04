using Lab04.Models;

namespace Lab04.Data;

public class SampleData
{
    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
         new City() {
             CityId=1,
             CityName="Surrey",
             Population=1000,
             ProvinceCode="BC"
         },
         new City() {
             CityId=2,
             CityName="Vancouver",
             Population=2000,
             ProvinceCode="BC"
         },
         new City() {
             CityId = 3,
             CityName="Burnaby",
             Population=3000,
             ProvinceCode="BC"
         },
         new City() {
             CityId=4,
             CityName="Calgary",
             Population=4000,
             ProvinceCode="AB"
         },
         new City() {
             CityId=5,
             CityName="Edmonton",
             Population=30000,
             ProvinceCode="AB"
         },
         new City() {
             CityId=6,
             CityName="Red Deer",
             Population=30000,
             ProvinceCode="AB"
         },
          new City() {
             CityId=7,
             CityName="Toronto",
             Population=30000,
             ProvinceCode="ON"
         },
          new City() {
             CityId = 8,
             CityName="Hamilton",
             Population=30000,
             ProvinceCode="ON"
         },
          new City() {
             CityId = 9,
             CityName="Ottawa",
             Population=30000,
             ProvinceCode="ON"
         },

      };
        return cities;
    }
    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
         new Province {
             ProvinceCode = "BC",
             ProvinceName = "British Columba",
         },
         new Province {
             ProvinceCode = "AB",
             ProvinceName = "Alberta",
         },
         new Province {
             ProvinceCode = "ON",
             ProvinceName = "Ontario",
         },

      };
        return provinces;
    }
}