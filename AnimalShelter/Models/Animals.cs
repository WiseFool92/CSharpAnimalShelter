using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AnimalShelter.Models
{
  public class Animals
  {
    public int AnimalsId { get; set; }
    public string Description { get; set; }
  }
}