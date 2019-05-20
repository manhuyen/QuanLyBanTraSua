using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class Bus
    {
        Dal dal = new Dal();
        thanhvien tv = new thanhvien();
        public DataTable Xem_ThanhVien()
        {
            string query = "Select * from Thanhvien";
            return dal.Load_DB(query);
        }
        public bool Them_NV(thanhvien tv)
        {
            return dal.Them_NV(tv);
        }
        public bool Xoa_NV(string tv)
        {
            return dal.Xoa_NV(tv);
        }
        public bool Sua_NV(thanhvien tv)
        {
            return dal.Sua_NV(tv);
        }
        public DataTable Xem_Menu()
        {
            string query = "select MaDU as STT, tendu as N'Tên Đồ Uống',LoaiDU.Maloai as N'Mã Loại',tenloai as N'Tên Loại',size,dongia as 'Gía Bán',HinhAnh as N'Image' from Douong,LoaiDU where Douong.Maloai=LoaiDU.Maloai";
            return dal.Load_DB(query);
        }
        public bool Them_DoUong(Menu_DU m)
        {
            return dal.Them_DoUong(m);
        }
        public bool Xoa_DoUong(int madu)
        {
            return dal.Xoa_DoUong(madu);
        }
        public bool Sua_DoUong(Menu_DU m)
        {
            return dal.Sua_DoUong(m);
        }
        public DataTable Xem_Topping()
        {
            string query = "select * from Topping";
            return dal.Load_DB(query);
        }
        public bool Them_Topping(Menu_DU m)
        {
            return dal.Them_Topping(m);
        }
        public bool Xoa_Topping(string matp)
        {
            return dal.Xoa_Topping(matp);
        }
        public bool Sua_Topping(Menu_DU m)
        {
            return dal.Sua_Topping(m);
        }
        public DataTable Xem_Phieunhap()
        {
            string query = "Select * from Phieunhap";
            return dal.Load_DB(query);
        }
        public bool Them_PN(Phieunhap pn)
        {
            return dal.Them_PN(pn);
        }
        public bool Xoa_PN(string MaPN)
        {
            return dal.Xoa_PN(MaPN);
        }
        public bool Sua_PN(Phieunhap pn)
        {
            return dal.Sua_PN(pn);
        }
        public DataTable XemNguyenlieu()
        {
            string query = "Select * from Nguyenlieu";
            return dal.Load_DB(query);
        }
        public bool Them_NL(Phieunhap nl)
        {
            return dal.Them_NL(nl);
        }
        public bool Xoa_NL(string MaNl)
        {
            return dal.Xoa_NL(MaNl);
        }
        public bool Sua_NL(Phieunhap pn)
        {
            return dal.Sua_NL(pn);
        }
        public DataTable Xem_NVK()
        {
            string query = "Select * from Nhanvien";
            return dal.Load_DB(query);
        }
        public bool Them_NVK(Phieunhap pn)
        {
            return dal.Them_NVK(pn);
        }
        public bool Xoa_NVK(string MaPN)
        {
            return dal.Xoa_NVK(MaPN);
        }
        public bool Sua_NVK(Phieunhap pn)
        {
            return dal.Sua_NVK(pn);
        }
        public int GetID(string taikhoan,string matkhau)
        {
            return dal.GetID(taikhoan, matkhau);
        }
        public string GetName(string tk,string mk)
        {
            return dal.GetName(tk, mk);
        }
        public string GetPass(string tk, string mk)
        {
            return dal.GetPass(tk, mk);
        }
        public bool Quen_Pass(string tentaikhoan, string sodt, string NewPass)
        {
            return dal.Quen_Pass(tentaikhoan, sodt, NewPass);
        }
        public bool Change_Pass(int ID,string NewPass)
        {
            return dal.Change_Pass(ID, NewPass);
        }

    }
}
