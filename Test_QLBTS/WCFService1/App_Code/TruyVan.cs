﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for TruyVan
/// </summary>
public class TruyVan:DB_Connection
{
    public TruyVan()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool Update_LoaiThanhVien()
    {
        string query = "execute Update_Loaithanhvien";
        Load_DB(query);
        return true;

    }
    public DataTable Load_DB(string query)
    {
        sqlConnection.Open();
        DataTable dt = new DataTable("m");
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        sqlDataAdapter.Fill(dt);
        sqlConnection.Close();
        return dt;
    }
    public bool Them_NV(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy)
    {
        string query = "Insert into Thanhvien(MaTV,STT,hoten,loaithanhvien,soDT,email,diachi,diemtichluy) values('"+matv+"',"+stt+",N'"+hoten+"',N'"+loaithanhvien+"',N'"+sodt+"',N'"+email+"',N'"+diachi+"',"+diemtichluy+")";
        Load_DB(query);
        return true;
    }
    public bool Xoa_NV(string matv)
    {
        string query = "update HoaDon set MaTV=null where MaTV=N'"+matv+"' delete Thanhvien where MaTV=N'"+matv+"'";
        Load_DB(query);
        return true;
    }
    public bool Sua_NV(string matv, int stt, string hoten, string loaithanhvien, string sodt, string email, string diachi, int diemtichluy)
    {
        string query = "update Thanhvien set Matv=N'"+matv+"',STT="+stt+",hoten=N'"+hoten+"',loaithanhvien=N'"+loaithanhvien+"',soDT='"+sodt+"',email=N'"+email+"',diachi=N'"+diachi+"',diemtichluy="+diemtichluy+" Where MaTV=N'"+matv+"' ";
        Load_DB(query);
        return true;
    }
    public bool Them_DoUong(string tendu, string size, double dongia, int maloai, string image)
    {
        string query = "insert into Douong(tendu,size,dongia,MaLoai,HinhAnh) values(N'"+tendu+"',N'"+size+"',"+dongia+","+maloai+",N'"+image+"') ";
        Load_DB(query);
        return true;
    }
    public bool Xoa_DoUong(int madu)
    {
        string query = "update DongHD set MaDU=null where MaDU="+ madu+" delete Douong where MaDU="+madu;
        Load_DB(query);
        return true;
    }
    public bool Sua_DoUong(int madu,string tenloai,string tendu, string size, double dongia, int maloai, string image)
    {
        string query = "update Douong set tendu=N'"+tendu+"',size='"+size+"',dongia="+dongia+",HinhAnh=N'"+image+"' where MaDU="+madu+"   update LoaiDU set tenloai=N'"+tenloai+"' where MaLoai="+maloai+"";

        Load_DB(query);
        return true;
    }
    public bool Them_Topping(string matp, string tentp, double gia, string image)
    {
        string query = "Insert into Topping(Matopping,tentopping,giatopping,HinhAnh) values('"+matp+"',N'"+tentp+"',"+gia+",N'"+image+"')";
        Load_DB(query);
        return true;
    }
    public bool Xoa_Topping(string matp)
    {
        string query = "delete Topping where Matopping='"+matp+"'";
        Load_DB(query);
        return true;
    }
    public bool Sua_Topping(string matp, string tentp, double gia, string image)
    {
        string query = "Update Topping set tentopping=N'"+tentp+"',giatopping="+gia+",HinhAnh=N'"+image+"' where Matopping=N'"+matp+"'";
        Load_DB(query);
        return true;
    }
    public bool Them_PN(string manhap, string manv, DateTime ngaynhap)
    {
        string query = "Insert into Phieunhap(Manhap,MaNV,ngaynhap) values(N'" + manhap + "',N" + manv + ",N'" + ngaynhap + "')";
        Load_DB(query);
        return true;
    }
    public bool Xoa_PN(string manhap)
    {
        string query = "update Dongphieunhap set Manhap=null where Manhap=N'" + manhap + "' delete Phieunhap where Manhap=N'" + manhap + "'";
        Load_DB(query);
        return true;
    }
    public bool Sua_PN(string manhap, string manv, DateTime ngaynhap)
    {
        string query = "update Phieunhap set Manhap=N'" + manhap + "',MaNV=N'" + manv + "',ngaynhap=N'" + ngaynhap + "'";
        Load_DB(query);
        return true;
    }
    public bool Them_NL(string manl, string tennl, string dvt)
    {
        string query = "Insert into Nguyenlieu(MaNL,tenNL,donvitinh) values(N'" + manl + "',N" + tennl + ",N'" + dvt + "')";
        Load_DB(query);
        return true;
    }
    public bool Xoa_NL(string manl)
    {
        string query = "update Dongphieunhap set MaNL=null where MaNL=N'" + manl + "' delete Nguyenlieu where MaNL=N'" + manl + "'";
        Load_DB(query);
        return true;
    }
    public bool Sua_NL(string manl, string tennl, string dvt)
    {
        string query = "update Nguyenlieu set MaNL=N'" + manl + "',tenNL=N'" + tennl + "',donvitinh=N'" + dvt + "'";
        Load_DB(query);
        return true;
    }
    public bool Them_NVK(string manv, string tennv, string sdt)
    {
        string query = "Insert into Nhanvien(MaNV,tennv,soDT) values(N'" + manv + "',N" + tennv + ",N'" + sdt + "')";
        Load_DB(query);
        return true;
    }
    public bool Xoa_NVK(string manv)
    {
        string query = "update Phieunhap set MaNV=null where MaNV=N'" + manv + "' delete Nhanvien where MaNV=N'" + manv + "'";
        Load_DB(query);
        return true;
    }
    public bool Sua_NVK(string manv, string tennv, string sdt)
    {
        string query = "update Nhanvien set MaNV=N'" + manv + "',tennv=N'" + tennv + "',soDT=N'" + sdt + "'";
        Load_DB(query);
        return true;
    }
    public int GetID(string ten, string matkhau)
    {
        string query = "Select * from Login_QLBTS where user_ten='"+ten+"' and user_pass='"+matkhau+"'";
        int id = 0;
        DataTable dt = Load_DB(query);
        if (dt != null)
        {
            foreach (DataRow dr in dt.Rows)
            {
                id = Convert.ToInt16(dr["STT"].ToString());
            }
        }
        return id;
    }
    public string GetName(string ten, string matkhau)
    {
        string query = "Select * from Login_QLBTS where user_ten='"+ten+"' and user_pass='"+matkhau+"'";
        string name = null;
        DataTable dt = Load_DB(query);
        if (dt != null)
        {
            foreach (DataRow dr in dt.Rows)
            {
                name = dr["Name"].ToString();
            }
        }
        return name;
    }
    public string GetPass(string ten, string matkhau)
    {
        string query = "Select * from Login_QLBTS where user_ten='" + ten + "' and user_pass='" + matkhau + "'";
        string pass = null;
        DataTable dt = Load_DB(query);
        if (dt != null)
        {
            foreach (DataRow dr in dt.Rows)
            {
                pass = dr["user_pass"].ToString();
            }
        }
        return pass;
    }
    public bool Change_Pass(int ID, string NewPass)
    {
        string query = "update Login_QLBTS set user_pass='"+NewPass+"' where STT="+ID+" ";
        Load_DB(query);
        return true;
    }
    public bool Quen_Pass(string tentaikhoan, string sodt, string NewPass)
    {

        string query = "select * from Login_QLBTS where sodt='"+sodt+"' and user_ten='"+tentaikhoan+"' ";
        DataTable dt = new DataTable();
        dt = Load_DB(query);
        string pass = null;
        foreach (DataRow dr in dt.Rows)
        {
            pass = dr["user_ten"].ToString();
        }
        if (pass != null)
        {
            string query1 = ("update Login_QLBTS set user_pass='"+NewPass+"'  where sodt = '"+sodt+"' and user_ten='"+tentaikhoan+"'");
            dt = Load_DB(query1);
            return true;
        }
        else
        {
            return false;
        }

    }
    public bool checkID_Thanhvien(string matv)
    {
        string query = "select * from Thanhvien where matv='" + matv+"'";
        DataTable dt = new DataTable();
        dt = Load_DB(query);
        string check = null;
        foreach (DataRow dr in dt.Rows)
        {
            check = dr["MaTV"].ToString();
        }
        if (check!= null)
        {
           
            return false;
        }
        else
        {
            return true;
        }

    }
    public bool checkID_Topping(string matp)
    {
        string query = "select * from Topping where  Matopping='" + matp + "'";
        DataTable dt = new DataTable();
        dt = Load_DB(query);
        string check = null;
        foreach (DataRow dr in dt.Rows)
        {
            check = dr["Matopping"].ToString();
        }
        if (check != null)
        {

            return false;
        }
        else
        {
            return true;
        }

    }


}