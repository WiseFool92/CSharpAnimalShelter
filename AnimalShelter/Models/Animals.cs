using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models
{
  public class Animals
  {
    public int AnimalsId { get; set; }
    public string Description { get; set; }
    public string Name {get; set;}
    public int Age {get; set;}
    public string Species {get; set;}
    public string Gender { get; set; }
  }
}