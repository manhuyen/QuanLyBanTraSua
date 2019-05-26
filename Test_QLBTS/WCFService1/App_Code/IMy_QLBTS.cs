using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMy_QLBTS" in both code and config file together.
[ServiceContract]
public interface IMy_QLBTS
{
    [OperationContract]
    void DoWork();
    [OperationContract]
    DataTable Xem_ThanhVien();
    [OperationContract]
    bool Them_ThanhVien(string matv,int stt,string hoten,string loaithanhvien,string sodt,string email,string diachi,int diemtichluy);
    [OperationContract]
    bool Xoa_ThanhVien(string matv);
    [OperationContract]
    bool Sua_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy);
    [OperationContract]
    DataTable Xem_DoUong();
    [OperationContract]
    bool Them_DoUong(string tendu,string size, double dongia,int maloai,string image);
    [OperationContract]
    bool Xoa_DoUong(int madu);
    [OperationContract]
    bool Sua_DoUong(int madu,string tenloai,string tendu, string size,  double dongia, int maloai, string image);
    [OperationContract]
    DataTable Xem_Topping();
    [OperationContract]
    bool Them_Topping(string matp,string tentp, double gia,string image);
    [OperationContract]
    bool Xoa_Topping(string matp);
    [OperationContract]
    bool Sua_Topping(string matp, string tentp,  double gia, string image);
    [OperationContract]
    DataTable Xem_Phieunhap();
    [OperationContract]
    bool Them_Phieunhap(string manhap, string manv, DateTime ngaynhap);
    [OperationContract]
    bool Xoa_Phieunhap(string manhap);
    [OperationContract]
    bool Sua_Phieunhap(string manhap, string manv, DateTime ngaynhap);
    [OperationContract]
    DataTable Xem_Nguyenlieu();
    [OperationContract]
    bool Them_Nguyenlieu(string manl, string tennl, string dvt);
    [OperationContract]
    bool Xoa_Nguyenlieu(string manl);
    [OperationContract]
    bool Sua_Nguyenlieu(string manl, string tennl, string dvt);
    [OperationContract]
    DataTable Xem_NhanvienKho();
    [OperationContract]
    bool Them_NhanvienKho(string manv, string tennv, string sdt);
    [OperationContract]
    bool Xoa_NhanvienKho(string manv);
    [OperationContract]
    bool Sua_NhanvienKho(string manv, string tennv, string sdt);
    [OperationContract]
    int GetID(string taikhoan,string matkhau);
    [OperationContract]
    string GetName(string taikhoan, string matkhau);
    [OperationContract]
    string GetPass(string taikhoan, string matkhau);
    [OperationContract]
    bool Quen_Pass(string tentaikhoan,string sodt,string newpass);
    [OperationContract]
    bool Change_Pass(int ID,string newpass);
    [OperationContract]
   
    DataTable Xem_TuyTron(string query);
    [OperationContract]
    bool Update_LoaiTV();
    [OperationContract]
    bool Check_Thanhvien(string matv);
    [OperationContract]
    bool Check_Topping(string matp);

    [OperationContract]
    DataTable DoanhThu_DateToDate(string From, string To);

}
