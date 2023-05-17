using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_GTLN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const int MaxPhanTu = 20; // Số lượng phần tử tối đa trong mảng

            // Nhập giá trị tài sản của các tỷ phú
            double[] giaTriTaiSan = new double[MaxPhanTu];
            int soLuong = 0;

            Console.WriteLine("Nhập giá trị tài sản của các tỷ phú (đơn vị tỉ đô) (tối đa {0} giá trị)", MaxPhanTu);
            Console.WriteLine("Nhập -1 để kết thúc nhập.");

            double giaTri;
            do
            {
                Console.Write("Nhập giá trị tài sản thứ {0}: ", soLuong + 1);
                string nhap = Console.ReadLine();

                if (double.TryParse(nhap, out giaTri) && giaTri > 0)
                {
                    giaTriTaiSan[soLuong] = giaTri;
                    soLuong++;
                }
                else if (nhap == "-1")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
                }
            } while (soLuong < MaxPhanTu);

            // Tìm giá trị tài sản lớn nhất và vị trí của nó
            double giaTriLonNhat = giaTriTaiSan[0];
            int viTri = 0;

            for (int i = 1; i < soLuong; i++)
            {
                if (giaTriTaiSan[i] > giaTriLonNhat)
                {
                    giaTriLonNhat = giaTriTaiSan[i];
                    viTri = i;
                }
            }

            // Kiểm tra và hiển thị kết quả
            if (soLuong > 0)
            {
                Console.WriteLine("Giá trị tài sản lớn nhất là {0} tỉ đô, tại vị trí {1} trong danh sách.", giaTriLonNhat, viTri + 1);
            }
            else
            {
                Console.WriteLine("Không có giá trị tài sản nào được nhập.");
            }
            Console.ReadKey();
        }
    }
}
