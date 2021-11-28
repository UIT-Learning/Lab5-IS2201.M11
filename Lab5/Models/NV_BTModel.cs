using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class NV_BTModel
    {
        private string manhanvien;
        private string mathietbi;
        private string macanho;
        private int lanthu;
        private DateTime ngaybaotri;
        public string MaNhanVien { get => this.manhanvien; set => this.manhanvien = value; }
        public string MaThietBi { get => this.mathietbi; set => this.mathietbi = value; }
        public string MaCanHo { get => this.macanho; set => this.macanho = value; }
        public int LanThu { get => this.lanthu; set => this.lanthu = value; }
        public DateTime NgayBaoTri { get => this.ngaybaotri; set => this.ngaybaotri = value; }
    }
}
