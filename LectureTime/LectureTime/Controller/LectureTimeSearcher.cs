using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureTime.Model;
using LectureTime.Utility;

namespace LectureTime.Controller
{
    internal class LectureTimeSearcher
    {
        public List<List<string>> Search(string department = "", string classification = "", string grade = "", string lecturetName = "", string professor = "")
        {
            List<List<string>> allLecture = ExcelData.Get().allData;
            List<List<string>> searchResultList = new List<List<string>>();

            for (int no = 1; no < allLecture.Count; no++)
            {
                if( allLecture[no][Constant.DEPARTMENT].Contains(department) &&
                    allLecture[no][Constant.CLASSCIFICATION].Contains(classification) &&
                    allLecture[no][Constant.GRADE].Contains(grade) &&
                    allLecture[no][Constant.LECTURE_NAME].Contains(lecturetName) &&
                    allLecture[no][Constant.PROFESSOR].Contains(professor))
                {
                    searchResultList.Add(allLecture[no]);
                }
            }

            return searchResultList;
        }
    }
}
