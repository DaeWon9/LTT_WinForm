using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureTime.Utility;

namespace LectureTime.Model
{
    internal class ApplyData
    {
        public List<List<string>> applyDataList = new List<List<string>>();
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
            this.applyDataList = new List<List<string>>();
        }

        public List<string> GetNoList()
        {
            List<string> noList = new List<string>();
            for (int row = 0; row < applyDataList.Count; row++)
            {
                noList.Add(applyDataList[row][Constant.NO]);
            }
            return noList;
        }

        public List<string> GetRoomList()
        {
            List<string> roomList = new List<string>();
            for (int row = 0; row < applyDataList.Count; row++)
            {
                roomList.Add(applyDataList[row][Constant.ROOM]);
            }
            return roomList;
        }

        public List<string> GetNameList()
        {
            List<string> nameList = new List<string>();
            for (int row = 0; row < applyDataList.Count; row++)
            {
                nameList.Add(applyDataList[row][Constant.LECTURE_NAME]);
            }
            return nameList;
        }

        public List<string> GetTimeList()
        {
            List<string> timeList = new List<string>();
            for (int row = 0; row < applyDataList.Count; row++)
            {
                timeList.Add(applyDataList[row][Constant.DATE]);
            }
            return timeList;
        }
        public List<List<string>> GetTimeSplitList(List<string> TimeList)
        {
            List<List<string>> splitList = new List<List<string>>();

            for (int row = 0; row< TimeList.Count; row++)
            {
                if (TimeList[row] == null)
                {
                    splitList.Add(new List<string>("공 23:00~23:30".Split().ToList()));
                }
                else
                {
                    splitList.Add(new List<string>(TimeList[row].Split().ToList()));
                }
            }
            return splitList;
        }
    }
}
