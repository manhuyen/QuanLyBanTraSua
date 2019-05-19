using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAL
{
    public class Dal:DBConnection
    {
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
        public bool Them_NV(thanhvien tv)
        {
            string query = $"Insert into Thanhvien(MaTV,STT,hoten,loaithanhvien,soDT,email,diachi,diemtichluy) values(N'{tv._matv}',{tv._stt},N'{tv._hoten}',N'{tv._loaitv}',N'{tv._sodt}',N'{tv._email}',N'{tv._diachi}',{tv._diemTl})";
            Load_DB(query);
            return true;
        }
        public bool Xoa_NV(string matv)
        {
            string query = $"update HoaDon set MaTV=null where MaTV=N'{matv}' delete Thanhvien where MaTV=N'{matv}'";
            Load_DB(query);
            return true;
        }
        public bool Sua_NV(thanhvien tv)
        {
            string query = $"update Thanhvien set Matv=N'{tv._matv}',STT={tv._stt},hoten=N'{tv._hoten}',loaithanhvien=N'{tv._loaitv}',soDT='{tv._sodt}',email=N'{tv._email}',diachi=N'{tv._diachi}',diemtichluy={tv._diemTl} Where MaTV=N'{tv._matv}' ";
            Load_DB(query);
            return true;
        }
        public bool Them_DoUong(Menu_DU m)
        {
            string query = $"insert into Douong(tendu,size,dongia,MaLoai,HinhAnh) values(N'{m._tendu}',N'{m._size}',{m._dongia},{m._maloai},N'{m._image}') ";
            Load_DB(query);
            return true;
        }
        public bool Xoa_DoUong(int madu)
        {
            string query = $"delete Douong where MaDU={madu}";
            Load_DB(query);
            return true;
        }
        public bool Sua_DoUong(Menu_DU m)
        {
            string query = $"update Douong set tendu=N'{m._tendu}',size='{m._size}',dongia={m._dongia},HinhAnh=N'{m._image}' where MaDU={m._madu}   update LoaiDU set tenloai=N'{m._loaidu}' where MaLoai={m._maloai}";

            Load_DB(query);
            return true;
        }
        public bool Them_Topping(Menu_DU m)
        {
            string query=$"Insert into Topping(Matopping,tentopping,giatopping,Image) values('{m._matopping}',N'{m._tentopping}',{m._gia},N'{m._image}')";
            Load_DB(query);
            return true;
        }
        public bool Xoa_Topping(string matp)
        {
            string query = $"delete Topping where Matopping='{matp}'";
            Load_DB(query);
            return true;
        }
        public bool Sua_Topping(Menu_DU m)
        {
            string query = $"Update Topping set tentopping=N'{m._tentopping}',giatopping={m._gia},Image=N'{m._image}' where Matopping=N'{m._matopping}'";
            Load_DB(query);
            return true;
        }
        public int GetID(string ten,string matkhau)
        {
            string query=($"Select * from Login_QLBTS where user_ten='{ten}' and user_pass='{matkhau}'");
            int id=0;
            DataTable dt = Load_DB(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    id =Convert.ToInt16( dr["STT"].ToString());
                }
            }
            return id;
        }
        public string GetName(string ten, string matkhau)
        {
            string query = ($"Select * from Login_QLBTS where user_ten='{ten}' and user_pass='{matkhau}'");
            string name=null;
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
            string query = ($"Select * from Login_QLBTS where user_ten='{ten}' and user_pass='{matkhau}'");
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
        public bool Change_Pass(int ID,string NewPass)
        {
            string query=$"update Login_QLBTS set user_pass='{NewPass}' where STT={ID} ";
            Load_DB(query);
            return true;
        }
        public bool Quen_Pass(string tentaikhoan,string sodt,string NewPass)
        {
          
                string query = $"select * from Login_QLBTS where sodt='{sodt}' and user_ten='{tentaikhoan}' ";
                DataTable dt = new DataTable();
                dt = Load_DB(query);
            string pass = null;
                  foreach (DataRow dr in dt.Rows)
                   {
                     pass = dr["user_ten"].ToString();
                    }
            if (pass != null)
                {
                 string query1 = ($"update Login_QLBTS set user_pass='{NewPass}'  where sodt = '{sodt}' and user_ten='{tentaikhoan}'");
                 dt = Load_DB(query1);
                 return true;
                }
                else
                {
                    return false;
                }
     
        }



    }
}
