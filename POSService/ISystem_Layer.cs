using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISystem_Layer" in both code and config file together.
    [ServiceContract]
    public interface ISystem_Layer
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        List<DanhMucSanPham> GetDanhMucSanPham();

        [OperationContract]
        List<SanPham> GetSanPhams(int iddanhmucsanpham);

        [OperationContract]
        SanPham GetSanPham(int idsanpham);

        [OperationContract]
        GiamGia GetDiscount(int idsanpham);

        [OperationContract]
        List<ChiTietHoaDon> GetHoaDonItems(int idhoadon);

        [OperationContract]
        HoaDon GetHoaDonInfor(int idhoadon);

        [OperationContract]
        int CountHoaDonOfSingleItem(int idhoadon, int idsanpham);

        [OperationContract]
        bool RemoveHoaDonItem(int idhoadon, int idsanpham);

        [OperationContract]
        bool UpdateHoaDonItem(int idhoadon, int idsanpham);

        [OperationContract]
        KhachHang GetKhachHangByNumPhone(string numphone);

        [OperationContract]
        bool AddNewKhachHang(KhachHang khachhang);

        [OperationContract]
        bool UpdateKhachHangToHoaDon(int idhoadon, int idkhachhang);

        [OperationContract]
        bool UpdateStateToHoaDon(int idhoadon, bool trangthai);

        [OperationContract]
        bool UpdateMailToHoaDon(int idhoadon, bool trangthai);

        [OperationContract]
        KhachHang GetKhachHangById(int idkhachang);

        [OperationContract]
        bool SendMailAPI(HoaDon hoadon, KhachHang khachhang, List<ChiTietHoaDon> hoadonitems);

        [OperationContract]
        HoaDon TaoHoaDonMoi();
    }
    #region DataContract
    [DataContract]
    public class DanhMucSanPham
    {
        int idDanhMuc;
        string tenDanhMuc;

        public DanhMucSanPham(int idDanhMuc, string tenDanhMuc)
        {
            this.IdDanhMuc = idDanhMuc;
            this.TenDanhMuc = tenDanhMuc;
        }

        public int IdDanhMuc { get => idDanhMuc; set => idDanhMuc = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }
    }

    [DataContract]
    public class SanPham
    {

        int idHangHoa;
        string tenHangHoa;
        double donGia;
        string diaChiAnh;
        int idDanhMuc;

        public SanPham(int idHangHoa, string tenHangHoa, double donGia, string diaChiAnh, int idDanhMuc)
        {
            this.IdHangHoa = idHangHoa;
            this.TenHangHoa = tenHangHoa;
            this.DonGia = donGia;
            this.DiaChiAnh = diaChiAnh;
            this.IdDanhMuc = idDanhMuc;
        }

        public SanPham(int idhanghoa, string tenhanghoa, double? dongia, string diachianh, int? iddanhmuc)
        {
            idHangHoa = idhanghoa;
            tenHangHoa = tenhanghoa;
            Dongia = dongia;
            diaChiAnh = diachianh;
            Iddanhmuc = iddanhmuc;
        }

        public int IdHangHoa { get => idHangHoa; set => idHangHoa = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double? Dongia { get; }
        public string DiaChiAnh { get => diaChiAnh; set => diaChiAnh = value; }
        public int IdDanhMuc { get => idDanhMuc; set => idDanhMuc = value; }
        public int? Iddanhmuc { get; }
    }

    [DataContract]
    public class GiamGia
    {
        int idGiamGia;
        DateTime ngayBatDau;
        private DateTime? ngaybatdau;
        DateTime ngayKetThuc;
        private DateTime? ngayketthuc;
        double phanTramGia;
        int idHangHoa;
        private int? idhanghoa;
        private double? phantramgiam;

        public GiamGia(int idGiamGia, DateTime ngayBatDau, DateTime ngayKetThuc, double phanTramGia, int idHangHoa)
        {
            this.IdGiamGia = idGiamGia;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.PhanTramGia = phanTramGia;
            this.IdHangHoa = idHangHoa;
        }

        public GiamGia(int idgiamgia, DateTime? ngaybatdau, DateTime? ngayketthuc, double? phantramgiam, int? idhanghoa)
        {
            idGiamGia = idgiamgia;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.phantramgiam = phantramgiam;
            this.idhanghoa = idhanghoa;
        }

        public int IdGiamGia { get => idGiamGia; set => idGiamGia = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public double PhanTramGia { get => phanTramGia; set => phanTramGia = value; }
        public int IdHangHoa { get => idHangHoa; set => idHangHoa = value; }
    }

    [DataContract]
    public class ChiTietHoaDon
    {
        int idChiTietHoaDon;
        int soLuong;
        private int? soluong;
        double tongCong;
        private double? tongcong;
        double donGia;
        private double? dongia;
        double phanTramGiam;
        private double? phantramgiam;
        int idHoaDon;
        private int? idhoadon;
        int idHangHoa;
        private int? idhanghoa;
        

        
        public ChiTietHoaDon(int idchitiethoadon, int? soluong, double? tongcong, double? dongia, double? phantramgiam, int? idhoadon, int? idhanghoa)
        {
            idChiTietHoaDon = idchitiethoadon;
            this.soluong = soluong;
            this.tongcong = tongcong;
            this.dongia = dongia;
            this.phantramgiam = phantramgiam;
            this.idhoadon = idhoadon;
            this.idhanghoa = idhanghoa;
           
        }

        public int IdChiTietHoaDon { get => idChiTietHoaDon; set => idChiTietHoaDon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double TongCong { get => tongCong; set => tongCong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double PhanTramGiam { get => phanTramGiam; set => phanTramGiam = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdHangHoa { get => idHangHoa; set => idHangHoa = value; }
       
        
    }

    [DataContract]
    public class HoaDon
    {
        int idHoaDon;
        DateTime ngayLap;
        private DateTime? ngaylap;
        double tongTien;
        private double? tongtien;
        int idKhachHang;
        private int? idkhachhang;
        byte phuongThucThanhToan;
        private byte? phuongthucthanhtoan;
        bool trangThaiThanhToan;
        private bool? trangthaithanhtoan;
        bool mail;
        private bool? mail1;

        public HoaDon(int idhoadon, DateTime? ngaylap, double? tongtien, int? idkhachhang, byte? phuongthucthanhtoan, bool? trangthaithanhtoan, bool mail)
        {
            idHoaDon = idhoadon;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.idkhachhang = idkhachhang;
            this.phuongthucthanhtoan = phuongthucthanhtoan;
            this.trangthaithanhtoan = trangthaithanhtoan;
            this.mail = mail;
        }

        public HoaDon(int idhoadon, DateTime? ngaylap, double? tongtien, int? idkhachhang, byte? phuongthucthanhtoan, bool? trangthaithanhtoan, bool? mail1)
        {
            idHoaDon = idhoadon;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.idkhachhang = idkhachhang;
            this.phuongthucthanhtoan = phuongthucthanhtoan;
            this.trangthaithanhtoan = trangthaithanhtoan;
            this.mail1 = mail1;
        }

        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public byte PhuongThucThanhToan { get => phuongThucThanhToan; set => phuongThucThanhToan = value; }
        public bool TrangThaiThanhToan { get => trangThaiThanhToan; set => trangThaiThanhToan = value; }
        public bool Mail { get => mail; set => mail = value; }
    }

    [DataContract]
    public class KhachHang
    {
        int idKhachHang;
        string tenKhachHang;
        string email;
        string soDienThoai;
        string diaChi;

        public KhachHang(int idKhachHang, string tenKhachHang, string email, string soDienThoai, string diaChi)
        {
            this.IdKhachHang = idKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.Email = email;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
        }

        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
    #endregion
}
