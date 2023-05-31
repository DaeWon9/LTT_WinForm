using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using LectureTime.Utility;
using LectureTime.Model;
using Excel = Microsoft.Office.Interop.Excel;

namespace LectureTime.Controller
{
    internal class UserServicer
    {
        public bool IsLoginSuccess(string inputId, string inputPw)
        {
            if (inputId == Constant.USER_ID && inputPw == Constant.USER_PASSWORD)
                return true;
            return true;
        }

        public void SaveToExcel()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 바탕화면 경로 
            string path = Path.Combine(desktopPath, "MyLectureTimeTable.xlsx"); // 엑셀 파일 저장 경로 
            string[] excelTitle = { "NO", "개설학과전공", "학수번호", "분반", "교과목명", "이수구분", "학년", "학점", "요일 및 강의시간", "강의실", "메인교수명", "강의언어" };


      Application excel = new Application();
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            excel.DisplayAlerts = false;

            // 워크시트 선택
            Worksheet worksheet = workbook.Worksheets.Item["Sheet1"];

            //시트 이름 변경
            worksheet.Name = "시간표";

            //컬럼 별로 너비 변경
            Range ModRange = worksheet.Columns[1];

            SetColumnSize(ModRange, worksheet, 1, 6);
            SetColumnSize(ModRange, worksheet, 2, 20);
            SetColumnSize(ModRange, worksheet, 3, 10);
            SetColumnSize(ModRange, worksheet, 4, 6);
            SetColumnSize(ModRange, worksheet, 5, 30);
            SetColumnSize(ModRange, worksheet, 6, 15);
            SetColumnSize(ModRange, worksheet, 7, 5);
            SetColumnSize(ModRange, worksheet, 8, 5);
            SetColumnSize(ModRange, worksheet, 9, 30);
            SetColumnSize(ModRange, worksheet, 10, 15);
            SetColumnSize(ModRange, worksheet, 11, 30);
            SetColumnSize(ModRange, worksheet, 12, 10);
            SetColumnSize(ModRange, worksheet, 13, 6);
            SetColumnSize(ModRange, worksheet, 14, 20);
            SetColumnSize(ModRange, worksheet, 15, 20);
            SetColumnSize(ModRange, worksheet, 16, 20);
            SetColumnSize(ModRange, worksheet, 17, 20);
            SetColumnSize(ModRange, worksheet, 18, 20);
            SetColumnSize(ModRange, worksheet, 19, 20);


            ModRange = (Range)worksheet.get_Range("A1", "L1");
            ModRange.Merge(true);
            ModRange.Font.Size = 13;
            ModRange.Font.Bold = true;
            ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter; //가운데 정렬
            ModRange.Value = $"수 강 신 청 내 역";

            ModRange = (Range)worksheet.get_Range("N1", "S1");
            ModRange.Merge(true);
            ModRange.Font.Size = 13;
            ModRange.Font.Bold = true;
            ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter; //가운데 정렬
            ModRange.Value = $"시 간 표";

            for (int i = 0; i < 12; i++)
            {
                ModRange = (Range)worksheet.Cells[2, 1 + i];
                ModRange.Font.Size = 13;
                ModRange.Font.Bold = true;
                ModRange.Value = excelTitle[i];
                ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            }

            for (int i = 1; i < ApplyData.Get().applyDataList.Count; i++)
            {
                for (int j = 0; j<12; j++)
                {
                    ModRange = (Range)worksheet.Cells[3 + (i - 1), 1 + j];
                    ModRange.Value = ApplyData.Get().applyDataList[i][j];
                    ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                }
            }
            ////////////////////////시간표
            InputExcelData(ModRange, worksheet, "월", 2, 15, 13, true, true);
            InputExcelData(ModRange, worksheet, "화", 2, 16, 13, true, true);
            InputExcelData(ModRange, worksheet, "수", 2, 17, 13, true, true);
            InputExcelData(ModRange, worksheet, "목", 2, 18, 13, true, true);
            InputExcelData(ModRange, worksheet, "금", 2, 19, 13, true, true);

            InputExcelData(ModRange, worksheet, "09:00~09:30", 3, 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "09:30~10:00", 3 + (2 * 1), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "10:00~10:30", 3 + (2 * 2), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "10:30~11:00", 3 + (2 * 3), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "11:00~11:30", 3 + (2 * 4), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "11:30~12:00", 3 + (2 * 5), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "12:00~12:30", 3 + (2 * 6), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "12:30~13:00", 3 + (2 * 7), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "13:00~13:30", 3 + (2 * 8), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "13:30~14:00", 3 + (2 * 9), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "14:00~14:30", 3 + (2 * 10), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "14:30~15:00", 3 + (2 * 11), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "15:00~15:30", 3 + (2 * 12), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "15:30~16:00", 3 + (2 * 13), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "16:00~16:30", 3 + (2 * 14), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "16:30~17:00", 3 + (2 * 15), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "17:00~17:30", 3 + (2 * 16), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "17:30~18:00", 3 + (2 * 17), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "18:00~18:30", 3 + (2 * 18), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "18:30~19:00", 3 + (2 * 19), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "19:00~19:30", 3 + (2 * 20), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "19:30~20:00", 3 + (2 * 21), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "20:00~20:30", 3 + (2 * 22), 14, 13, true, true);
            InputExcelData(ModRange, worksheet, "20:30~21:00", 3 + (2 * 23), 14, 13, true, true);

            SaveToExcelAppliedLecture(ModRange, worksheet);

            workbook.SaveAs(Filename: path);
            workbook.Close();
        }

        private void InputExcelData(Range ModRange, Worksheet worksheet, string inputData, int row, int colum, int fontSize = 11, bool isBold = false, bool isCenter = false)
        {
            ModRange = (Range)worksheet.Cells[row, colum];
            ModRange.Font.Size = fontSize;
            ModRange.Font.Bold = isBold;
            ModRange.Value = inputData;
            if (isCenter)
                ModRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }

        private void SetColumnSize(Range ModRange, Worksheet worksheet, int columnIndex, int size)
        {
            ModRange = worksheet.Columns[columnIndex];
            ModRange.ColumnWidth = size;
        }

        private void SaveToExcelAppliedLecture(Range ModRange, Worksheet worksheet)
        {
            List<string> getTimeList = ApplyData.Get().GetTimeList();
            List<List<string>> timeSplitList = ApplyData.Get().GetTimeSplitList(getTimeList);
            List<string> lectureNameList = ApplyData.Get().GetNameList();
            List<string> lectureRoomList = ApplyData.Get().GetRoomList();

            List<List<string>> dayList = new List<List<string>>();
            List<List<int>> firstTimeList = new List<List<int>>();
            List<List<int>> diffCount = new List<List<int>>();

            List<string> semiDayList = new List<string>();
            List<int> semiFirstTimeList = new List<int>();
            List<int> semiDiffCount = new List<int>();

            int posX = 0;
            int posY = 0;

            for (int i = 0; i< timeSplitList.Count; i++)
            {
                semiDayList.Clear();
                semiFirstTimeList.Clear();
                semiDiffCount.Clear();
                for (int j = 0; j < timeSplitList[i].Count; j++)
                {
                    if (timeSplitList[i][j].Length > 1) // 시간임
                    {
                        List<string> getStartTimeList = timeSplitList[i][j].Split('~').ToList();
                        DateTime StartTime = Convert.ToDateTime(getStartTimeList[0]);
                        DateTime EndTime = Convert.ToDateTime(getStartTimeList[1]);
                        TimeSpan timeDiff = EndTime - StartTime;

                        int diffHour = timeDiff.Hours; //시간차이
                        int diffMinute = timeDiff.Minutes; //분차이

                        diffMinute = diffMinute + diffHour*60;
                        int diffcnt = diffMinute / 30;

                        semiDiffCount.Add(diffcnt);
                        semiFirstTimeList.Add(StartTime.Hour*60 + StartTime.Minute); // ->분으로 나옴.
                    }
                    else // 요일임
                        semiDayList.Add(timeSplitList[i][j]);
                }

                if (semiDayList.Count > semiFirstTimeList.Count) // 요일, 시간 개수 맞춰주기 최대 2개임
                {
                    semiFirstTimeList.Add(semiFirstTimeList[0]);
                    semiDiffCount.Add(semiDiffCount[0]);
                }

                diffCount.Add(new List<int>(semiDiffCount));
                firstTimeList.Add(new List<int>(semiFirstTimeList));
                dayList.Add(new List<string>(semiDayList));
            }



            for (int i = 0; i < dayList.Count; i++)
            {
                for (int j = 0; j < dayList[i].Count; j++)
                {
                    if (dayList[i][j].Equals("월"))
                        posX = Constant.EXCEL_POS_X_MON;
                    if (dayList[i][j].Equals("화"))
                        posX = Constant.EXCEL_POS_X_TUE;
                    if (dayList[i][j].Equals("수"))
                        posX = Constant.EXCEL_POS_X_WED;
                    if (dayList[i][j].Equals("목"))
                        posX = Constant.EXCEL_POS_X_THR;
                    if (dayList[i][j].Equals("금"))
                        posX = Constant.EXCEL_POS_X_FRI;
                    if (dayList[i][j].Equals("공"))
                        posX = Constant.EXCEL_POS_X_NOT;

                    switch (firstTimeList[i][j])  // 분
                    {
                        case 9 * 60: // 9:00
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE;
                            break;
                        case 9 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (1 * 2);
                            break;
                        case 10 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (2 * 2);
                            break;
                        case 10 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (3 * 2);
                            break;
                        case 11 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (4 * 2);
                            break;
                        case 11 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (5 * 2);
                            break;
                        case 12 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (6 * 2);
                            break;
                        case 12 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (7 * 2);
                            break;
                        case 13 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (8 * 2);
                            break;
                        case 13 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (9 * 2);
                            break;
                        case 14 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (10 * 2);
                            break;
                        case 14 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (11 * 2);
                            break;
                        case 15 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (12 * 2);
                            break;
                        case 15 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (13 * 2);
                            break;
                        case 16 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (14 * 2);
                            break;
                        case 16 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (15 * 2);
                            break;
                        case 17 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (16 * 2);
                            break;
                        case 17 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (17 * 2);
                            break;
                        case 18 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (18 * 2);
                            break;
                        case 18 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (19 * 2);
                            break;
                        case 19 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (20 * 2);
                            break;
                        case 19 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (21 * 2);
                            break;
                        case 20 * 60:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (22 * 2);
                            break;
                        case 20 * 60 + 30:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (23 * 2);
                            break;
                        default:
                            posY = Constant.CURSOR_Y_POS_TIME_TABLE + (24 * 2);
                            break;
                    }

                    for (int k = 0; k<diffCount[i][j]; k++)
                    {
                        InputExcelData(ModRange, worksheet, lectureNameList[i], posY + (k * 2), posX);
                        InputExcelData(ModRange, worksheet, lectureRoomList[i], posY + ((k * 2) + 1), posX);
                    }

                }
            }
        }


    }
}
