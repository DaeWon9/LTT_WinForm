using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureTime.Model;

namespace LectureTime.Utility
{
    internal class DataProcessing
    {
        private static DataProcessing instance;

        public static DataProcessing Get()
        {
            if (instance == null)
                instance = new DataProcessing();
            return instance;
        }

        public bool IsLectureTimeOverlap(List<List<string>> list, string targetTime)
        {
            List<List<int>> startTimeToMinList = GetstartTimeToMinList(list);
            List<List<int>> endTimeToMinList = GetEndTimeToMinList(list);
            List<List<string>> dayList = GetDayList(list);

            List<string> targetTimeList = new List<string>();
            List<int> targetStartTime = new List<int>();
            List<int> targetEndTime = new List<int>();
            List<string> targetDay = new List<string>();

            if (targetTime == null)
                targetTimeList = ("공 23:00~23:30".Split().ToList());
            else
                targetTimeList = targetTime.Split().ToList();

            for (int i = 0; i<targetTimeList.Count; i++)
            {
                if (targetTimeList[i].Length > 1) // 시간임
                {
                    List<string> getTargetStartTimeList = targetTimeList[i].Split('~').ToList();
                    DateTime StartTime = Convert.ToDateTime(getTargetStartTimeList[0]);
                    DateTime EndTime = Convert.ToDateTime(getTargetStartTimeList[1]);

                    targetStartTime.Add(StartTime.Hour*60 + StartTime.Minute);
                    targetEndTime.Add(EndTime.Hour*60 + EndTime.Minute);
                }
                else
                {
                    targetDay.Add(targetTimeList[i]);
                }
            }

            for (int i = 0; i < startTimeToMinList.Count; i++) // 중복시간 체크
            {
                for (int j = 0; j < startTimeToMinList[i].Count; j++)
                {
                    if (dayList[i][j] == targetDay[j]) // 요일이 같은지 판단 후에 시간겹치는거 체크해야함.!!
                    {
                        if (startTimeToMinList[i][j] < targetEndTime[j] && targetStartTime[j] < endTimeToMinList[i][j]) // 시간이 겹치는거.!
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsLectureNameOverlap(List<List<string>> list, string targetName)
        {
            for (int row = 0; row < list.Count; row++) // 중복과목 체크
            {
                if (list[row][Constant.LECTURE_NAME].Equals(targetName))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsBaskGradeOver(string targetGrade)
        {
            return (BasketData.Get().basketedGrade + int.Parse(targetGrade)) > Constant.MAX_BASKET_GRADE;
        }

        public bool IsApplyGradeOver(string targetGrade)
        {
            return (ApplyData.Get().appliedGrade + int.Parse(targetGrade)) > Constant.MIN_APPLY_GRADE;
        }

        public List<string> GetTimeList(List<List<string>> list)
        {
            List<string> timeList = new List<string>();
            for (int row = 0; row < list.Count; row++)
            {
                timeList.Add(list[row][Constant.DATE]);
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

        public List<List<string>> GetDayList(List<List<string>> list)
        {
            List<string> getTimeList = GetTimeList(list);
            List<List<string>> timeSplitList = GetTimeSplitList(getTimeList);

            List<List<string>> dayList = new List<List<string>>();
            List<string> semiDayList = new List<string>();

            for (int i = 0; i< timeSplitList.Count; i++)
            {
                semiDayList.Clear();
                for (int j = 0; j < timeSplitList[i].Count; j++)
                {
                    if (timeSplitList[i][j].Length == 1) // 요일임
                    {
                        semiDayList.Add(timeSplitList[i][j]);
                    }
                }
                dayList.Add(new List<string>(semiDayList));
            }

            return dayList;
        }

        public List<List<int>> GetstartTimeToMinList(List<List<string>> list)
        {
            List<string> getTimeList = GetTimeList(list);
            List<List<string>> timeSplitList = GetTimeSplitList(getTimeList);
            List<List<int>> timeList = new List<List<int>>();
            List<int> semiTimeList = new List<int>();

            for (int i = 0; i< timeSplitList.Count; i++)
            {
                semiTimeList.Clear();
                for (int j = 0; j < timeSplitList[i].Count; j++)
                {
                    if (timeSplitList[i][j].Length > 1) // 시간임
                    {
                        List<string> getStartTimeList = timeSplitList[i][j].Split('~').ToList();
                        DateTime StartTime = Convert.ToDateTime(getStartTimeList[0]);
                        semiTimeList.Add(StartTime.Hour*60 + StartTime.Minute);
                    }
                }
                timeList.Add(new List<int>(semiTimeList));
            }

            return timeList;
        }

        public List<List<int>> GetEndTimeToMinList(List<List<string>> list)
        {
            List<string> getTimeList = GetTimeList(list);
            List<List<string>> timeSplitList = GetTimeSplitList(getTimeList);
            List<List<int>> timeList = new List<List<int>>();
            List<int> semiTimeList = new List<int>();

            for (int i = 0; i< timeSplitList.Count; i++)
            {
                semiTimeList.Clear();
                for (int j = 0; j < timeSplitList[i].Count; j++)
                {
                    if (timeSplitList[i][j].Length > 1) // 시간임
                    {
                        List<string> getStartTimeList = timeSplitList[i][j].Split('~').ToList();
                        DateTime EndTime = Convert.ToDateTime(getStartTimeList[1]);
                        semiTimeList.Add(EndTime.Hour*60 + EndTime.Minute);
                    }
                }
                timeList.Add(new List<int>(semiTimeList));
            }

            return timeList;
        }
    }
}
