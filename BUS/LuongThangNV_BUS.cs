using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class LuongThangNV_BUS
    {
        LuongThangNV_DAL luongThangNV_DAL = new LuongThangNV_DAL();
        public DataTable Load_BUS()
        {
            return luongThangNV_DAL.Load_LuongThangNV();
        }
        public DataTable Load_1NV_BUS(LuongThangNV lt)
        {
            return luongThangNV_DAL.Load_LuongThangMotNV(lt);
        }
    }
}
