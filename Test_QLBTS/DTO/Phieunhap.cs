using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phieunhap
    {
        public Phieunhap()
        {

        }
        private string MaNL, tenNL, donvitinh;
        private string Manhap;
        private string MaNV, tennv, soDT;
        private int slnhap, sltrongkho;
        private DateTime ngaynhap;

        public string _manl { get { return MaNL; } set { value = MaNL; } }
        public string _tennl { get { return tenNL; } set { value = tenNL; } }
        public string _donvitinh { get { return donvitinh; } set { value = donvitinh; } }
        public string _manhap { get { return Manhap; } set { value = Manhap; } }
        public string _manv { get { return MaNV; } set { value = MaNV; } }
        public string _tennv { get { return tennv; } set { value = tennv; } }
        public string _soDT { get { return soDT; } set { value = soDT; } }
        public int _slnhap { get { return slnhap; } set { value = slnhap; } }
        public int _sltrongkho { get { return sltrongkho; } set { value = sltrongkho; } }
        public DateTime _ngaynhap { get { return ngaynhap; } set { value = ngaynhap; } }
    }
}
