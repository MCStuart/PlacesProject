using System.Collections.Generic;

namespace Places.Models
{
  public class City
  {
      private string _description;
      private int _id;
      private static List<City> _instances = new List<City> {};

      public City (string description)
      {
          _description = description;
          _instances.Add(this);
          _id = _instances.Count;
      }

      public string GetDescription()
      {
          return _description;
      }

      public void SetDescription(string newDescription)
      {
          _description = newDescription;
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
