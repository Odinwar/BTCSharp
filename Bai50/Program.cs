using System;
/*
 * Tạo lớp Question có các thuộc tính và phương thức sau:
 * ID_Question
 * Content_Question (nội dung câu hỏi)
 * Answer_1 (nội dung câu trả lời 1)
 * Answer_2 (nội dung câu trả lời 2)
 * Answer_3 (nội dung câu trả lời 3)
 * Right_Answer (nội dung câu trả lời đúng)
 * Max_Time (thời gian tối đa để trả lời câu hỏi)
 * a. Thêm các property cho các thuộc tính thành viên.
 * b. Viết các phương thức:
 * c. Hiển thị nội dung câu hỏi;
 * d. Tìm kiếm câu hỏi (lựa chọn một trong các thuộc tính sau:
 * ID_Question, Max_Time hoặc Content_Question);
 * e. Các thao tác với câu hỏi (new, del, edit, update câu hỏi).
 */
namespace Bai50
{
    class Program
    {

        static void Main(string[] args)
        {
            ManagerQuestion question = new ManagerQuestion();
            question.seedData();
            question.showAll();
            question.remove(1);
            question.showAll();
        }
    }
}
