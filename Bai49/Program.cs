using System;
using System.Collections.Generic;
/*
* Bài tập 4: Tạo lớp Student có các thuộc tính sau: Mã số sinh viên, Tên
* sinh viên, Khoa, Điểm trung bình học tập, Điểm rèn luyện, Xếp loại.
* Trong đó:
* - Nếu sinh viên có Điểm trung bình học tập >= 9.0 & Điểm rèn luyện >= 90 thì Xếp loại Xuất Sắc;
* - Nếu sinh viên có Điểm trung bình học tập >= 9.0 & 80 <= Điểm rèn luyện < 90 thì Xếp loại Giỏi;
* - Nếu sinh viên có Điểm trung bình học tập >= 9.0 & 70 <= Điểm rèn luyện < 80 thì Xếp loại Khá;
* - Nếu sinh viên có Điểm trung bình học tập >= 8.0 & Điểm rèn luyện >= 80 thì Xếp loại Giỏi;
* - Nếu sinh viên có Điểm trung bình học tập >= 8.0 & 70 <= Điểm rèn luyện < 80 thì Xếp loại Khá;
* - Nếu sinh viên có Điểm trung bình học tập >= 7.0 & Điểm rèn luyện >= 70 thì Xếp loại Khá;
* - Các trường hợp còn lại sinh viên Xếp loại Yếu.
* 1) Thêm các property cho các thuộc tính thành viên và viết hàm thành viên thiết lập giá trị thuộc tính Xếp loại cho lớp Student.
* 2) Viết các chức năng sau:
* - Hiển thị thông tin sinh viên;
* - Tìm sinh viên theo tên, mã số, khoa, điểm trung bình;
* - Thao tác với danh sách sinh viên (new, del, edit, update & search)
*/
namespace Bai49
{
    class Program
    {
        private static List<Student> students;
        static void Main(string[] args)
        {
            seedData();
            ManagerStudent managerStudent = new ManagerStudent(students);
            managerStudent.showInfoStudent();
            Student student =new  Student(2,"Name", "CNTT", 9.0m, 70);
            managerStudent.edit(student);
            managerStudent.showInfoStudent();
        }
        public static void seedData() 
        {
            students = new List<Student>();
            students.Add(new Student("Name","CNTT",9.0m,90));
            students.Add(new Student("Name", "CK", 8.0m, 80));
            students.Add(new Student("Name", "DT", 7.0m, 60));
            students.Add(new Student("Name", "CNTP", 6.0m, 70));
            students.Add(new Student("Name", "XD", 5.0m, 80));
        }
    }
}
