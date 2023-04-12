using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projects.HotelChallange.Models;

namespace Projects.HotelChallange.Models
{
    public class Reservation
    {
        public List<People> Guests{ get; set; }
        public List<Suite> suiteList{ get; set; }

        public int ReservedDays;

        public Reservation(int reservedDays){
            ReservedDays = reservedDays;
        }

        // ----------- Main Methods -----------

        public void SignInGuest(List<People> guests){
            foreach(People guest in guests){
                Guests.Add(guest);
            }
        }
        public void SignInSuite(Suite Suite){
            
        }

        public decimal diaryCalc(){
            decimal totalValue = 0;
            
            return totalValue;
        }

    }
}