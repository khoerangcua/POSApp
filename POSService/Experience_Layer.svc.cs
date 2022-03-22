using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Experience_Layer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Experience_Layer.svc or Experience_Layer.svc.cs at the Solution Explorer and start debugging.
    public class Experience_Layer : IExperience_Layer
    {
        public void DoWork()
        {
        }

        public HoaDon ThanhToanHoaDon(int idhoadon, byte phuongthucthanhtoan, bool guimail)
        {
            throw new NotImplementedException();
        }

        public HoaDon ThemSanPhamVaoHoaDon(int idhoadon, int idsanpham, int soluong)
        {
            throw new NotImplementedException();
        }

        public HoaDon XoaSanPhamKhoiHoaDon(int idhoadon, int idsanpham)
        {
            throw new NotImplementedException();
        }
    }
}
