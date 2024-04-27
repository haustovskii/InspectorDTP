using System;
using System.Collections.Generic;
using System.Text;
using Android.Media;
using Java.Sql;
using SQLite;

namespace InspectorDTP.AppData
{
    //Класс хранилище данных о ДПТ
    public class DTP
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TypeDTP { get; set; }
        //Место проишествия ДТП
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string CommentCity { get; set; }
        //Сведения о ДТП
        public DateTime DateTimeDtp { get; set; }
        public string SideMove { get; set; }
        public int RowMove { get; set; }
        public int QuanCar { get; set; }
        public string CommentDTP { get; set; }
        //Сведения о первом авто
        public string StampCar1 { get; set; }
        public string StateNumber1 { get; set; }
        public string ColorCar1 { get; set; }
        public string PTSCar1 { get; set; }
        public string RegNumber1 { get; set; }
        public string CommentCar1 { get; set; }
        //Сведения о втором авто
        public string StampCar2 { get; set; }
        public string StateNumber2 { get; set; }
        public string ColorCar2 { get; set; }
        public string PTSCar2 { get; set; }
        public string RegNumber2 { get; set; }
        public string CommentCar2 { get; set; }
        //Сведения об участниках ДПТ
        public int QuanPeople { get; set; }
        public string FIOPeople1 { get; set; }
        public string NumberAdoption1 { get; set; }
        public string FIOPeople2 { get; set; }
        public string NumberAdoption2 { get; set; }
        public string FIOPeople3 { get; set; }
        public string NumberAdoption3 { get; set; }
        public string FIOPeople4 { get; set; }
        public string NumberAdoption4 { get; set; }
        public string CommentPeopleDTP { get; set; }
        //Сведения о жертвах и пострадавших
        public int QuanVictim { get; set; }
        public string FIOVictim1 { get; set; }
        public string FIOVictim2 { get; set; }
        public string FIOVictim3 { get; set; }
        public string FIOVictim4 { get; set; }
        public int QuanLoss { get; set; }
        public string FIOLoss1 { get; set; }
        public string FIOLoss2 { get; set; }
        public string FIOLoss3 { get; set; }
        public string FIOLoss4 { get; set; }
        public string CommentVictimDTP { get; set; }
        public string SourceImageDTP { get; set; }
    }
}
