using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class thanhvien
    {
        private string matv, loaitv, email, diachi, sodt,hoten;
        private int stt, diemTl;
        public string _matv
        {
            get { return matv; }
            set { matv = value; }
        }
        public string _loaitv
        { 
            get { return loaitv; }
            set { loaitv = value; }
        }
        public string _email
        {
            get { return email; }
            set { email = value; }
        }
        public string _diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string _sodt
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string _hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public int _stt
        {
            get { return stt; }
            set { stt = value; }
        }
        public int _diemTl
        {
            get { return diemTl; }
            set { diemTl = value; }
        }
        public thanhvien()
        { }
        
        

    }
}
