using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class LuongThangNV
    {
        public string maNV;
        public string hoTen;
        public bool isMale;
        public string ngaySinh;
        public string chucVu;
        public float luongThang;
        public LuongThangNV() { }
        public LuongThangNV(string maNV)
        {
            this.maNV = maNV;
        }
        public LuongThangNV(string maNV, string hoTen, bool isMale, string ngaySinh, string chucVu, float luongThang) : this(maNV)
        {
            this.hoTen = hoTen;
            this.isMale = isMale;
            this.ngaySinh = ngaySinh;
            this.chucVu = chucVu;
            this.luongThang = luongThang;
        }       
    }
}
