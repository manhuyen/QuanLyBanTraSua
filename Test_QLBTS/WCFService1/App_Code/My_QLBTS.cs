using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "My_QLBTS" in code, svc and config file together.
public class My_QLBTS : IMy_QLBTS
{
    TruyVan t = new TruyVan();
    public bool Change_Pass(int ID, string newpass)
    {
        return t.Change_Pass(ID, newpass);
    }

    public void DoWork()
    {
    }

    public int GetID(string taikhoan, string matkhau)
    {
        return t.GetID(taikhoan, matkhau);
    }

    public string GetName(string taikhoan, string matkhau)
    {
        return t.GetName(taikhoan, matkhau);
    }

    public string GetPass(string taikhoan, string matkhau)
    {
        return t.GetPass(taikhoan, matkhau);
    }

    public bool Quen_Pass(string tentaikhoan, string sodt, string newpass)
    {
       return t.Quen_Pass(tentaikhoan,sodt,newpass);
    }

   

    public bool Sua_DoUong(int madu, string tenloai, string tendu, string size,  double dongia, int maloai, string image)
    {
        return t.Sua_DoUong(madu,tenloai, tendu, size, dongia, maloai, image);
    }

    public bool Sua_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy)
    {
        return t.Sua_NV(matv, stt, hoten, loaithanhvien, sodt, email, diachi, diemtichluy);
    }

    public bool Sua_Topping(string matp, string tentp,  double gia, string image)
    {
        return t.Sua_Topping(matp, tentp, gia, image);
    }

    public bool Them_DoUong(string tendu, string size,  double dongia, int maloai, string image)
    {
        return t.Them_DoUong( tendu, size, dongia, maloai, image);
    }

    public bool Them_ThanhVien(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy)
    {
        return t.Them_NV(matv, stt, hoten, loaithanhvien, sodt, email, diachi, diemtichluy);
    }

    public bool Them_Topping(string matp, string tentp,  double gia, string image)
    {
        return t.Them_Topping(matp, tentp, gia, image);
    }

    public bool Update_LoaiTV()
    {
        return t.Update_LoaiThanhVien();
    }

    public DataTable Xem_DoUong()
    {
        string query = "select MaDU as STT, tendu as N'Tên Đồ Uống',LoaiDU.Maloai as N'Mã Loại',tenloai as N'Tên Loại',size,dongia as 'Gía Bán',HinhAnh as N'Image' from Douong,LoaiDU where Douong.Maloai=LoaiDU.Maloai";
        return t.Load_DB(query);

    }
   public DataTable Xem_ThanhVien()
    {
            string query = "Select * from Thanhvien";
            return t.Load_DB(query);
        
    }


    public DataTable Xem_Topping()
    {
         string query = "select * from Topping";
        return t.Load_DB(query);
    }

    public DataTable Xem_TuyTron(string query)
    {
        return t.Load_DB(query);
    }

    public bool Xoa_DoUong(int madu)
    {
        return t.Xoa_DoUong(madu);
    }

    public bool Xoa_ThanhVien(string matv)
    {
        return t.Xoa_NV(matv);
    }

    public bool Xoa_Topping(string matp)
    {
        return t.Xoa_Topping(matp);
    }
}
