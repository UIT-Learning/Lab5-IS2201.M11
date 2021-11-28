using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class NhanVienModel
    {
        private string manhanvien;
        private string tennhanvien;
        private string sodienthoai;
        private bool gioitinh;
        public string MaNhanVien { get => this.manhanvien; set => this.manhanvien = value; }
        public string TenNhanVien { get => this.tennhanvien; set => this.tennhanvien = value; }
        public string SoDienThoai { get => this.sodienthoai; set => this.sodienthoai = value; }
        public bool GioiTinh { get => this.gioitinh; set => this.gioitinh = value; }
    }
}
