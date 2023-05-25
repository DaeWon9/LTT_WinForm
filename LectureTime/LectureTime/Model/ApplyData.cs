using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureTime.Model
{
    internal class ApplyData
    {
        public List<List<string>> applayDataList = new List<List<string>>();
        public int appliedGrade = 0;

        private static ApplyData instance;

        public static ApplyData Get()
        {
            if (instance == null)
                instance = new ApplyData();
            return instance;
        }

        public ApplyData()
        {
            this.applayDataList = new List<List<string>>();
        }
    }
}
