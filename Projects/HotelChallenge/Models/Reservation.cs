using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projects.HotelChallange.Models;

namespace Projects.HotelChallange.Models
{
    public class Reservation
    {
        public List<People> Guests = new List<People>();
        public List<Suite> SuitesReserved = new List<Suite>();
        
        public int ReservedDays{ get; set; }


        // ----------- Constructors -----------

        public Reservation(int reservedDays){
            ReservedDays = reservedDays;
        }

        // ----------- Main Methods -----------

        public void SignInGuest(List<People> guests){

            foreach(People guest in guests){
                if(guest == null) return; 
            
                Guests.Add(guest);
            }
        }
        public void SignInSuite(Suite suite){
            SuitesReserved.Add(suite);

            Console.WriteLine("Suite reservada com sucesso");
        }

        public decimal diaryCalc(Suite suite){
            decimal totalValue = ReservedDays * suite.DiaryValue;
            
            return totalValue;
        }


    }
}