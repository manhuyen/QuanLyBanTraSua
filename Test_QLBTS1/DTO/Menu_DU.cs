using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Menu_DU
    {
        public Menu_DU()
        {
     
        }
        private string tendu, loaidu, size;
        private string matopping, tentopping,image;
        private int madu, maloai;
        double dongia, gia;
        public int _madu { get { return madu; } set { madu = value; } }
        public string _image { get { return image; } set { image = value; } }

        public string _tendu { get { return tendu; } set { tendu = value; } }
        public int _maloai{ get { return maloai; } set { maloai = value; } }
        public string _loaidu { get { return loaidu; } set { loaidu = value; } }
        public string _size { get { return size; } set { size = value; } }
        public double _dongia { get { return dongia; } set { dongia = value; } }
        public string _matopping { get { return matopping; } set { matopping = value; } }
        public string _tentopping { get { return tentopping; } set { tentopping = value; } }
        public double _gia { get { return gia; } set { gia = value; } }
    }
}
