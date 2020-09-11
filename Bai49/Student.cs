using System;
using System.Collections.Generic;
using System.Text;

namespace Bai49
{
    class Student
    {
        public static int mssvId = 1;
        public int mssv { get; set; }
        public string name { get; set; }
        public string khoa { get; set; }
        public decimal tbhoctap { get; set; }
        public decimal renluyen { get; set; }
        private string xeploai ;
        public Student() {
            this.mssv = mssvId;
            mssvId++;
        }
        public Student(string name, string khoa, decimal tbhoctap, decimal renluyen)
        {
            this.mssv = mssvId;
            this.name = name;
            this.khoa = khoa;
            this.tbhoctap = tbhoctap;
            this.renluyen = renluyen;
            mssvId++;
            setxeploai();
        }
        
        public Student(int mssv, string name, string khoa, decimal tbhoctap, decimal renluyen)
        {
            this.mssv = mssv;
            this.name = name;
            this.khoa = khoa;
            this.tbhoctap = tbhoctap;
            this.renluyen = renluyen;
            setxeploai();
        }
        public string getXeploai()
        {
            return this.xeploai;
        }
        public void setxeploai()
        {
            if (tbhoctap >= 9)
            {
                if (renluyen >= 90) xeploai = "Xuat sac";
                else if (renluyen >= 80) xeploai = "Gioi";
                else if (renluyen >= 70) xeploai = "Kha";
                else xeploai = "Yeu";
            }
            else if (tbhoctap >= 8)
            {
                if (renluyen >= 80) xeploai = "Gioi";
                else if (renluyen >= 70) xeploai = "Kha";
                else xeploai = "Yeu";
            }
            else if (tbhoctap > 7)
            {
                if (renluyen >= 70) xeploai = "Kha";
                else xeploai = "Yeu";
            }
            else xeploai = "Yeu";
        }
        public override string ToString()
        {
            return mssv + " " + name + " " +
                   khoa + " " + tbhoctap + " " +
                   renluyen +" " + xeploai;
        }
    }
}
