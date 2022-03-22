using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExperience_Layer" in both code and config file together.
    [ServiceContract]
    public interface IExperience_Layer
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        HoaDon ThemSanPhamVaoHoaDon(int idhoadon, int idsanpham, int soluong);
        [OperationContract]
        HoaDon XoaSanPhamKhoiHoaDon(int idhoadon, int idsanpham);
        [OperationContract]
        HoaDon ThanhToanHoaDon(int idhoadon, byte phuongthucthanhtoan, bool guimail);
    }
}
