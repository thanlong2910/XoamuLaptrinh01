/*		                     
		|-----------------------------------------------|
		|		        ĐỒ ÁN GIỮA KỲ                   |
        |           Họ Tên: Thân Minh Viện                  |    
		|		    Mã Số Sinh Viên: MSSV001                |
		|		    Lớp: TH01                               |																
		|-----------------------------------------------|
*/

/* I. Đề bài
	Viết chương trình so sánh thời gian chạy của các thuật toán sắp xếp theo quy trình sau:
	1. Đọc mảng các số nguyên từ file, có cấu trúc như sau:
	    - Số phần tử trong mảng
	    - Các phần tử trong mảng
	Ví dụ:
	    4
	    1 2 3 4
	2. Cài đặt 4 thuật toán sắp xếp mảng GIẢM dần: Interchange sort, Selection sort, Quick sort, 1 thuật toán tự chọn (khác 3 thuật toán đầu).
	3. Ghi nhận thời gian chạy của mỗi thuật toán.
	4. Tăng số lượng phần tử của file đầu vào. Số lượng phần tử của file đầu vào: 100, 500, 1000, 5000 .	571.cpp  
*/

/* II. Quy định nộp bài
	1. Cần nộp:
	    - Source code
	    - File word so sánh thời gian chạy của các thuật toán với số lượng phần tử tăng dần.
	2. Tất cả nội dung cần nộp được đặt tên là MSSV. Sau đó nén lại và upload lên moodle
	3. Thời gian nộp bài: 	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practice03
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int MAX_INDEX =1000;

            // Nhập kích thước mảng

            // Đọc mảng từ file

            // Xuất mảng

            // Sắp xếp mảng giảm dần theo thuật toán Interchange sort

            // Sắp xếp mảng giảm dần theo thuật toán Selection sort

            // Sắp xếp mảng giảm dần theo thuật toán Quick sort

            // Sắp xếp mảng giảm dần theo thuật toán Interchange sort

            // Sắp xếp mảng giảm dần theo thuật toán Interchange sort

            MeNu(); // Gọi lại hàm MeNu .
        }

        // Hàm nhập số lượng phần tử của mảng .
        static void NhapVaoSoLuongPhanTuCuaMang(ref int n, int MAX_INDEX)
        {
            quaylai: Console.Write("\n Nhap so luong phan tu cua mang: n = ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > MAX_INDEX)
            {
                Console.WriteLine("\n So phan tu ban nhap vao khong hop le! Xin vui long nhap lai!"); // Báo lỗi .
                goto quaylai; // Dùng hợp ngữ thay cho vòng lặp,tác dụng quay lại nếu nhập vào số không thỏa .
            }
            Console.WriteLine("n = {0}", n);
        }

        // Hàm tạo ra file.txt có tên NamSon.txt để truyền dữ liệu số phần tử ngẫu nhiên vào,khỏi mất công tạo ra file rồi nhập tay vào .
        static void GhiFileNamSon(int[] array, int n)
        {

            //FILE* pFile;
            //pFile = fopen("C:\\NamSon.txt", "wt"); // Tạo ra file có tên là NamSon.txt chứa dữ liệu là số lượng các phần tử cần tạo và giá trị ngẫu nhiên của các phần tử ở trong ổ C .
            //fprintf(pFile, "So Luong Cac Phan Tu Trong Mang La:%d \n", n);
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = (rand() % 41) - 20;// Tạo ngẫu nhiên các số nằm trong đoạn [-20,20] .
            //    fprintf(pFile, "a[%d]=%d\n", i, a[i]); // Ghi các giá trị ngẫu nhiên do chương trình tạo ra vào file NamSon.txt  .
            //}
            //fclose(pFile); // Đóng file lại .
        }

        // Theo đúng yêu cầu đề bài sau khi đã ghi dữ liệu lên file NamSon.txt thì sẽ đọc dữ liệu từ file đó vào chương trình bao gồm số lượng phần tử trong mảng các số nguyên và giá trị của các phần tử trong mảng .
        static void DocFileNamSon(int[] a, int n)
        {
            //FILE* pFile;
            //pFile = fopen("C:\\NamSon.txt", "r+t"); // Tìm kiếm và mở file NamSon.txt ở trong ổ C để đọc dữ liệu trong file vào lại chương trình .
            //if (pFile == NULL)
            //{
            //    printf("\nKhong Doc Duoc File NamSon.txt"); // Báo lỗi không đọc được file NamSon.txt
            //}
            //else
            //{
            //    printf("\n>>>>>>>>>>>Du Lieu Doc Tu File NamSon.txt :<<<<<<<<<<<<<<<<<<<\n");
            //    for (int i = 0; i < n; i++)
            //    {
            //        fscanf(pFile, "%d\t", &a[i]); // Đọc dữ liệu từ file vào chương trình .
            //        printf("a[%d]=%d\n", i, a[i]); // Xuất ra màn hình .
            //    }
            //}
            //fclose(pFile); // Đóng file lại .
        }

        // Hàm xuất mảng các số nguyên .
        static void DisplayArray(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ",  array[i]);
            }
        }

        // Hàm hoán vị 2 số nguyên .
        static void SwapTwoNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Hàm sắp xếp mảng số nguyên giảm dần bằng thuật toán Interchange Sort .
        static void SapXepGiamDanBangThuatToanInterchangeSort(int[] array, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        SwapTwoNumbers(ref array[i], ref array[j]); // Gọi lại hàm hoán vị 2 số nguyên .
                    }
                }
            }
        }

        // Hàm sắp xếp mảng số nguyên giảm dần bằng thuật toán Quick Sort .
        static void SapXepGiamDanBangThuatToanQuickSort(int[] array, int left, int right)
        {
            int i, j, x;
            if (left >= right)
            {
                return;
            }
            x = array[(left + right) / 2]; // Chọn phần tử giữa làm giá trị mốc .
            i = left;
            j = right;
            while (i < j)
            {
                while (array[i] > x)
                {
                    i++;
                }
                while (array[j] < x)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapTwoNumbers(ref array[i], ref array[j]); // Gọi lại hàm hoán vị 2 số nguyên .
                    i++;
                    j--;
                }
            }
            SapXepGiamDanBangThuatToanQuickSort(array, left, j);
            SapXepGiamDanBangThuatToanQuickSort(array, i, right);
        }

        // Hàm sắp xếp mảng số nguyên giảm dần bằng thuật toán Selection Sort .
        static void SapXepGiamDanBangThuatToanSelectionSort(int[] array, int n)
        {
            int max;
            for (int i = 0; i < n - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }
                if (max != i)
                {
                    SwapTwoNumbers(ref array[max], ref array[i]); // Gọi lại hàm hoán vị 2 số nguyên .
                }
            }
        }

        // Hàm sắp xếp mảng số nguyên giảm dần bằng thuật toán Bubble Sort .
        static void SapXepGiamDanBangThuatToanBubbleSort(int[] array, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (array[j] > array[j - 1])
                    {
                        SwapTwoNumbers(ref array[j], ref array[j - 1]); // Gọi lại hàm hoán vị 2 số nguyên .
                    }
                }
            }
        }

        // Hàm MeNu .
        static void MeNu(int MAX_INDEX)
        {
            // Khai báo 4 mảng a,b,c,d ứng với 4 thuật toán sắp xếp .
            int[] arrayA = new int[MAX_INDEX];
            int[] arrayB = new int[MAX_INDEX];
            int[] arrayC = new int[MAX_INDEX];
            int[] arrayD = new int[MAX_INDEX];
            int w, n;

            do
            {
                // Bảng MeNu đưa ra các sự lựa chọn .
                Console.WriteLine("\n-------------------------------------MeNu---------------------------------------\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n Moi ban lua chon cac yeu cau !");
                Console.WriteLine("\n");
                Console.WriteLine("\nNhap so ban chon roi nhan Enter de xac nhan!");
                Console.WriteLine("\n");
                Console.WriteLine("\n 1 - Nhap Vao So Luong Phan Tu Can Sap Xep ");
                Console.WriteLine("\n");
                Console.WriteLine("\n 2 - Tinh Thoi Gian Sap Xep Cua Thuat Toan Interchange Sort ");
                Console.WriteLine("\n");
                Console.WriteLine("\n 3 - Tinh Thoi Gian Sap Xep Cua Thuat Toan Quick Sort ");
                Console.WriteLine("\n");
                Console.WriteLine("\n 4 - Tinh Thoi Gian Sap Xep Cua Thuat Toan Selection Sort ");
                Console.WriteLine("\n");
                Console.WriteLine("\n 5 - Tinh Thoi Gian Sap Xep Cua Thuat Toan Bubble Sort ");
                Console.WriteLine("\n");
                Console.WriteLine("\n 0 - Thoat Chuong Trinh ");
                Console.WriteLine("\n");
                Console.WriteLine("\n--------------------------------------------------------------------------------\n");
                Console.WriteLine("\n");
                Console.WriteLine("\n Moi ban nhap vao lua chon cua ban o day:");
                w = int.Parse(Console.ReadLine());
                // Ở đây nếu ngay từ đầu người dùng không lựa chọn nhập vào số lượng phần tử cần sắp xếp thì các lựa chọn tính toán thời gian của các thuật toán sắp xếp 2-3-4-5 sẽ không thể thực thi,báo lỗi và thoát chương trình .

                //    // Cấu trúc switch-case .
                //    switch (w)
                //    {
                //        case 1: // Nhập vào số lượng phần tử cần tạo ra để thực thi sắp xếp bởi 4 thuật toán .
                //            {
                //                NhapVaoSoLuongPhanTuCuaMang(n);
                //                break; // có tác dụng khi đã làm xong nhiệm vụ của nó thì sẽ thoát ra và hiện lại bảng MeNu cho người dùng muốn nhập vào lựa chọn tiếp theo . Nếu không có lệnh break này thì khi đã làm xong nhiệm vụ của nó,chương trình không thoát ra và hiện lại bảng MeNu cho ta nhập vào lựa chọn tiếp theo mà sẽ tiếp tục chạy xuống những đoạn lệnh bên dưới và tính toán những đoạn lệnh đó mặc dù chưa có sự cho phép của ta !
                //            }
                //        case 2: // Đo thời gian chạy của bước sắp giảm dần và bước xuất ra kết quả của Thuật Toán Interchange Sort .
                //            {
                //                GhiFileNamSon(a, n);
                //                DocFileNamSon(a, n);
                //                // Đoạn code đo thời gian chạy của đoạn lệnh  .
                //                int i = 1000;
                //                clock_t start1 = clock();
                //                while (i-- > 0)
                //                    SapXepGiamDanBangThuatToanInterchangeSort(a, n);
                //                printf("\n>>>>>>Mang Sau Khi Sap Xep Giam Dan Bang Thuat Toan Interchange Sort La:<<<<<<\n");
                //                XuatMang(a, n);
                //                printf("\n");
                //                clock_t finish1 = clock();
                //                double duration1 = (double)(finish1 - start1) / CLOCKS_PER_SEC;
                //                printf("\n");
                //                printf("Thoi gian thuc thi cua thuat toan Interchange Sort la: %.2lf giay", duration1); // Trả về thời gian sắp xếp của Thuật Toán Interchange Sort.
                //                printf("\n");
                //                break; // có tác dụng khi đã làm xong nhiệm vụ của nó thì sẽ thoát ra và hiện lại bảng MeNu cho người dùng muốn nhập vào lựa chọn tiếp theo . Nếu không có lệnh break này thì khi đã làm xong nhiệm vụ của nó,chương trình không thoát ra và hiện lại bảng MeNu cho ta nhập vào lựa chọn tiếp theo mà sẽ tiếp tục chạy xuống những đoạn lệnh bên dưới và tính toán những đoạn lệnh đó mặc dù chưa có sự cho phép của ta !
                //            }
                //        case 3: // Đo thời gian chạy của bước sắp giảm dần và bước xuất ra kết quả của Thuật Toán Quick Sort .
                //            {
                //                GhiFileNamSon(b, n);
                //                DocFileNamSon(b, n);
                //                // Đoạn code đo thời gian chạy của đoạn lệnh  .
                //                int j = 1000;
                //                clock_t start2 = clock();
                //                while (j-- > 0)
                //                    SapXepGiamDanBangThuatToanQuickSort(b, 0, n - 1);
                //                printf("\n>>>>>>>>>>Mang Sau Khi Sap Xep Giam Dan Bang Thuat Toan Quick Sort La:<<<<<<<\n");
                //                XuatMang(b, n);
                //                printf("\n");
                //                clock_t finish2 = clock();
                //                double duration2 = (double)(finish2 - start2) / CLOCKS_PER_SEC;
                //                printf("\n");
                //                printf("Thoi gian thuc thi cua thuat toan Quick Sort la: %.2lf giay", duration2);// Trả về thời gian sắp xếp của Thuật Toán Quick Sort.
                //                printf("\n");
                //                break; // có tác dụng khi đã làm xong nhiệm vụ của nó thì sẽ thoát ra và hiện lại bảng MeNu cho người dùng muốn nhập vào lựa chọn tiếp theo . Nếu không có lệnh break này thì khi đã làm xong nhiệm vụ của nó,chương trình không thoát ra và hiện lại bảng MeNu cho ta nhập vào lựa chọn tiếp theo mà sẽ tiếp tục chạy xuống những đoạn lệnh bên dưới và tính toán những đoạn lệnh đó mặc dù chưa có sự cho phép của ta !
                //            }
                //        case 4: // Đo thời gian chạy của bước sắp giảm dần và bước xuất ra kết quả của Thuật Toán Selection Sort .
                //            {
                //                GhiFileNamSon(c, n);
                //                DocFileNamSon(c, n);
                //                // Đoạn code đo thời gian chạy của đoạn lệnh  .
                //                int k = 1000;
                //                clock_t start3 = clock();
                //                while (k-- > 0)
                //                    SapXepGiamDanBangThuatToanSelectionSort(c, n);
                //                printf("\n>>>>>>>>>Mang Sau Khi Sap Xep Giam Dan Bang Thuat Toan Selection Sort La:<<<<<<<\n");
                //                XuatMang(c, n);
                //                printf("\n");
                //                clock_t finish3 = clock();
                //                double duration3 = (double)(finish3 - start3) / CLOCKS_PER_SEC;
                //                printf("\n");
                //                printf("Thoi gian thuc thi cua thuat toan Selection Sort la: %.2lf giay", duration3);// Trả về thời gian sắp xếp của Thuật Toán Selection Sort.
                //                printf("\n");
                //                break; // có tác dụng khi đã làm xong nhiệm vụ của nó thì sẽ thoát ra và hiện lại bảng MeNu cho người dùng muốn nhập vào lựa chọn tiếp theo . Nếu không có lệnh break này thì khi đã làm xong nhiệm vụ của nó,chương trình không thoát ra và hiện lại bảng MeNu cho ta nhập vào lựa chọn tiếp theo mà sẽ tiếp tục chạy xuống những đoạn lệnh bên dưới và tính toán những đoạn lệnh đó mặc dù chưa có sự cho phép của ta !
                //            }
                //        case 5: // Đo thời gian chạy của bước sắp giảm dần và bước xuất ra kết quả của Thuật Toán Bubble Sort .
                //            {
                //                GhiFileNamSon(d, n);
                //                DocFileNamSon(d, n);
                //                // Đoạn code đo thời gian chạy của đoạn lệnh  .
                //                int l = 1000;
                //                clock_t start4 = clock();
                //                while (l-- > 0)
                //                    SapXepGiamDanBangThuatToanBubbleSort(d, n);
                //                printf("\n>>>>>>>>>Mang Sau Khi Sap Xep Giam Dan Bang Thuat Toan Bubble Sort La:<<<<<<<\n");
                //                XuatMang(d, n);
                //                printf("\n");
                //                clock_t finish4 = clock();
                //                double duration4 = (double)(finish4 - start4) / CLOCKS_PER_SEC;
                //                printf("\n");
                //                printf("Thoi gian thuc thi cua thuat toan Bubble Sort la: %.2lf giay", duration4);// Trả về thời gian sắp xếp của Thuật Toán Bubble Sort.
                //                printf("\n");
                //                break; // có tác dụng khi đã làm xong nhiệm vụ của nó thì sẽ thoát ra và hiện lại bảng MeNu cho người dùng muốn nhập vào lựa chọn tiếp theo . Nếu không có lệnh break này thì khi đã làm xong nhiệm vụ của nó,chương trình không thoát ra và hiện lại bảng MeNu cho ta nhập vào lựa chọn tiếp theo mà sẽ tiếp tục chạy xuống những đoạn lệnh bên dưới và tính toán những đoạn lệnh đó mặc dù chưa có sự cho phép của ta !
                //            }
                //        case 0: // Thoát khỏi chương trình .
                //            {
                //                printf("\nThanks You For Using The Program ! Goodbye And See You Later !\n"); // Khi người dùng thoát chương trình sẽ hiển thị lời chào !
                //                getch(); // Dừng màn hình lại .
                //            }
                //    }
                } while (w != 0); // vòng lặp sẽ tiếp tục thực hiện khi nhận lệnh của người dùng nhập vào giá trị khác 0 . Nếu nhập vào giá trị 0 thì chương trình sẽ kết thúc .

            }


    }
}
