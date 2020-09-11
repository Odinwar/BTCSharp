using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Bai49
{
    class ManagerStudent
    {
        private List<Student> students;
        public const string KHOA = "khoa";
        public const string MASO = "mssv";
        public const string TEN = "name";
        public const string DIEMTRUNGBINH = "tbhoctap";
        public ManagerStudent()
        {
            students = new List<Student>();
        }
        public ManagerStudent(List<Student> students)
        {
            this.students = students;
        }
        public void showInfoStudent()
        {
            if (students.Count == 0) Console.WriteLine("List rong  ");
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public bool add(Student student)
        {
            try
            {
                students.Add(student);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool edit(Student student) 
        {
            var temp = students.Where(x => x.mssv == student.mssv).FirstOrDefault();
            if (temp == null) return false;
            temp.name = student.name;
            temp.khoa = student.khoa;
            temp.tbhoctap = student.tbhoctap;
            temp.renluyen = student.renluyen;
            temp.setxeploai();
            return true;
        }
        public bool remove(Student student)
        {
            var temp = students.Where(x => x.mssv == student.mssv).FirstOrDefault();
            try{
                students.Remove(temp);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool remove(List<Student> students)
        {
            foreach (var x in students)
                if (!remove(x)) return false;
            return true;
        }
        public bool add(List<Student> students) 
        {

            foreach (var student in students)
                if (!add(student)) return false;
            return true;
        }
        public dynamic search(string value, string type = null) {
            if (students.Count == 0) return null;
            var result = new List<Student>();
            switch (type)
            {
                case TEN:
                    result = students.Where(x => value.Contains(x.name)).ToList();
                    break;
                case MASO:
                    result = students.Where(x => value.Contains(x.mssv.ToString())).ToList();
                    break;
                case KHOA:
                    result = students.Where(x => value.Contains(x.khoa)).ToList();
                    break;
                case DIEMTRUNGBINH:
                    result = students.Where(x => value.Contains(x.tbhoctap.ToString())).ToList();
                    break;
                default:
                     result = students.Where(x =>
                                    value.Contains(x.mssv.ToString()) ||
                                    value.Contains(x.khoa) ||
                                    value.Contains(x.name) ||
                                    value.Contains(x.renluyen.ToString()) ||
                                    value.Contains(x.tbhoctap.ToString())).ToList();
                     break;
            }
            return result;
        }
    }
}
