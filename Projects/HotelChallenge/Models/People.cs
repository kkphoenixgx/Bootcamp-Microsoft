using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projects.HotelChallange.Models
{
  public class People
  {

    public People(string name, string lastName){
      Name = name;
      LastName = lastName;
    }

    public string Name;
    public string LastName;

  }
}