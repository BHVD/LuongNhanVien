using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LuongThangNV_DAL : Connect
    {
        public LuongThangNV_DAL() { }
        public DataTable Load_LuongThangNV()
        {
            return Load_DL("select manv,hoten, ngaysinh,gioitinh, luong.chucvu" +
                ", tienluong +(select SUM(sotien)-(select Sum(sotien)from thuongphat where ploai=0) from thuongphat where ploai=1) [luongthang] " +
                "from dbo.luong INNER JOIN " +
                " dbo.nhanvien ON dbo.luong.chucvu = dbo.nhanvien.chucvu");
        }
        public DataTable Load_LuongThangMotNV(LuongThangNV lt)
        {
            return Load_DL("select manv,hoten, ngaysinh,gioitinh, luong.chucvu" +
                ", tienluong +(select SUM(sotien)-(select Sum(sotien)from thuongphat where ploai=0) from thuongphat where ploai=1) [luongthang] " +
                "from dbo.luong INNER JOIN " +
                " dbo.nhanvien ON dbo.luong.chucvu = dbo.nhanvien.chucvu"
                + $" where manv='{lt.maNV}'");
        }

    }
}
