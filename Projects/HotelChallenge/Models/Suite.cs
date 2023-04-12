using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projects.HotelChallange.Models
{
    public class Suite
    {
        public string SuiteType;
        public int Capacity;
        public decimal DiaryValue;

        public Suite(string suiteType, int capacity, decimal diaryValue){
            SuiteType = suiteType;
            Capacity = capacity;
            DiaryValue = diaryValue;
        }

    }
}