using System.Collections.Generic;
using System.Drawing;

namespace Places.Models
{
  public class City
  {
      private string _cityName;
      private string _length;
      private string _roadDawgz;
      private string _notes;
      // private Image _favPhoto;
      private int _id;

      private static List<City> _instances = new List<City> {};

      public string CityName { get => _cityName; set => _cityName = value; }
      public string Length { get => _length; set => _length = value; }
      public string RoadDawgz { get => _roadDawgz; set => _roadDawgz = value; }
      public string Notes { get => _notes; set => _notes = value; }
      // public string FavPhoto { get => _favPhoto; set => _favPhoto = value; }

      // public City(string cityName, string length, string roadDawgz, string notes, Image favPhoto)
      public City(string cityName, string length, string roadDawgz, string notes)
      {
          _cityName = cityName;
          _length = length;
          _roadDawgz = roadDawgz;
          _notes = notes;
          // _favPhoto = favPhoto;
          _instances.Add(this);
          _id = _instances.Count;
      }

      public string GetDescription()
      {
          return _cityName;
      }

      public void SetDescription(string newCityName)
      {
          _cityName = newCityName;
      }

      public int GetId()
      {
          return _id;
      }

      public static List<City> GetAll()
      {
          return _instances;
      }

      public static void ClearAll()
      {
          _instances.Clear();
      }

      public static City Find(int searchId)
      {
          return _instances[searchId-1];
      }
  }
}
