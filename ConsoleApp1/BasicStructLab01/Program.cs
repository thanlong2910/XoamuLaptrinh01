using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructLab01
{
    // https://daynhauhoc.com/t/bai-tap-ve-struct/2638 
    //    Cho một danh sách sinh viên được mô tả chi tiết như sau:

    //Danh sách sinh viên gồm n sinh viên.với n được nhập bất kỳ.
    //Thông tin một sinh viên bao gồm: Số thứ tự, Mã số sinh viên, Họ tên sinh viên, Điểm Nhập môn lập trình, Môn toán A1, Môn toán A2,
    // Môn Vật lý kỹ thuật, Môn anh văn, Điểm trung bình tích lũy, Xếp loại (xuất sắc, giỏi, khá, trung bình, yếu).
    //Thông tin môn học bao gồm: Mã môn, Tên môn, Số tín chỉ, Điểm.
    //Thực hiện các yêu cầu sau:
    //a) Hãy thiết kế và xây dựng các cấu trúc(struct) phù hợp cho bài toán
    //b) Xây dựng một chương trình hoàn chỉnh cho một lớp học đảm bảo các thao tác sau:
    //Hàm nhập xuất danh sách sinh viên(2 điểm).
    //Tìm một sinh viên thông qua mã số sinh viên hoặc qua tên sinh viên(1 điểm)
    //Tìm sinh viên có điểm trung bình cao nhất(1 điểm)
    //Liệt kê danh sách các sinh viên thuộc một loại bất kỳ(1 điểm)
    //Thêm, xóa một sinh viên ra khỏi danh sách(2 điểm)
    //Sắp xếp danh sách sinh viên tăng dần(1 điểm).
    //Theo điểm trung bình tích lũy
    //Hoặc Theo tên theo thứ tự ABC …
    //Lưu ý:
    //ĐTBTC là trung bình cộng của tất cả các môn dựa trên điểm số và số tín chỉ.
    //Lưu ý: Xếp loại được tính như sau:
    //Xuất sắc: ĐTBTL>=9
    //Giỏi với: 8.0<=ĐTBTL<9
    //Khá với: 6.5<=ĐTBTL<8.0
    //Trung bình: 5.0<=ĐTBTL<6.5
    //Yếu: ĐTBTL<5

    struct Sinhvien
    {
        int soThutu;
        string maso;
        string hoten;
        Diem diem;
        string xeploai;
    }

    struct Diem
    {
        double diemNhapmonLaptrinh;
        double diemToanA1;
        double diemToanA2;
        double diemVatlyKT;
        double diemAnhvan;
        double diemTrungbinh;
    }

    struct Monhoc
    {
        string maMonhoc;
        string tenMonhoc;
        int soTinchi;
        double diem;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
