using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class ThietBiModel
    {
        private string mathietbi;
        private string tenthietbi;
        public string MaThietBi { get => this.mathietbi; set => this.mathietbi = value; }
        public string TenThietBi { get => this.tenthietbi; set => this.tenthietbi = value; }
    }
}
