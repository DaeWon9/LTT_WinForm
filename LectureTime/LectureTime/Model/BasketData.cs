using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureTime.Utility;

namespace LectureTime.Model
{
    internal class BasketData
    {
        public List<List<string>> basketDataList = new List<List<string>>();
        public int basketedGrade = 0;

        private static BasketData instance;

        public static BasketData Get()
        {
            if (instance == null)
                instance = new BasketData();
            return instance;
        }

        public BasketData()
        {
            this.basketDataList = new List<List<string>>();
        }
    }
}
