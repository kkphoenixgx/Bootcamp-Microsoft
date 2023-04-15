using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projects.HotelChallange.Models
{
    public class Suite
    {

        public List<People> GuestsInSuite = new List<People>();
        public string SuiteType;
        public int Capacity;

        public decimal DiaryValue;
        public int ID;

        public Suite(string suiteType, int capacity, decimal diaryValue, int id){
            SuiteType = suiteType;
            Capacity = capacity;
            DiaryValue = diaryValue;
            ID = id;
        }

        public string subscribeToSuite(List<People> guests)
        {

            if( !(guests.Count <= Capacity) )
            {
                Console.Error.WriteLine("Quantidade de Hóspedes maaior que a capacidade máxima da suíte");
                Environment.Exit(0);
            } else if(GuestsInSuite.Count > 0){
                Console.Error.WriteLine("Já possuímos pessoas na suíte");
                // TODO: Create a way to delete people in the suite and automatically do it
                Environment.Exit(0);
            }

            string listOfSubscribedGuests = "";
            foreach (var guest in guests)
            {
                GuestsInSuite.Add(guest);
                listOfSubscribedGuests = listOfSubscribedGuests + $" {guest},";
            }
            return listOfSubscribedGuests;
        }

    }
}