using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab5.Models
{
    public class NhanVienvaSoLanSua
    {
        private string hoten;
        private string sdt;
        private int solan;
        public string HoTen { get => this.hoten; set => this.hoten = value; }
        public string SDT { get => this.sdt; set => this.sdt = value; }
        public int SoLan { get => this.solan; set => this.solan = value; }
    }
    public class DataContext
    {
        public string ConnectionString { get; set; }

        public DataContext(string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public int sqlInsertCanHo(CanHoModel canho)
        {
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "Insert into CanHo values(@macanho, @tenchuho)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("macanho", canho.MaCanHo);
                //cmd.Parameters.Add("tenchuho", System.Data.SqlDbType.NVarChar).Value = canho.TenChuHo;
                cmd.Parameters.AddWithValue("tenchuho", canho.TenChuHo);
                return cmd.ExecuteNonQuery();
            }
        }
        public List<NhanVienvaSoLanSua> sqlListByTimeNhanVien(int SoLanSua)
        {
            List<NhanVienvaSoLanSua> list = new List<NhanVienvaSoLanSua>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select TENNHANVIEN, SODIENTHOAI, Sum(LANTHU) as solan " +
                    "From NHANVIEN nv join NV_BT n on nv.MANHANVIEN=n.MANHANVIEN " +
                    "Group By nv.MANHANVIEN, TENNHANVIEN, SODIENTHOAI " +
                    "HaVing Sum(LANTHU) >= @solan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("solan", SoLanSua);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienvaSoLanSua()
                        {
                            HoTen = reader["tennhanvien"].ToString(),
                            SDT = reader["sodienthoai"].ToString(),
                            SoLan = Convert.ToInt32(reader["solan"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<NhanVienModel> sqlListNhanVien()
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select * From NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienModel()
                        {
                            MaNhanVien = reader["manhanvien"].ToString(),
                            TenNhanVien = reader["tennhanvien"].ToString(),
                            SoDienThoai = reader["sodienthoai"].ToString(),
                            GioiTinh = Convert.ToBoolean(reader["gioitinh"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<NV_BTModel> sqlListNV_BTByNhanVien(string MaNhanVien)
        {
            List<NV_BTModel> list = new List<NV_BTModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select * From NV_BT Where MaNhanVien = @manhanvien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manhanvien", MaNhanVien);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NV_BTModel()
                        {
                            MaNhanVien = reader["manhanvien"].ToString(),
                            MaThietBi = reader["mathietbi"].ToString(),
                            MaCanHo = reader["macanho"].ToString(),
                            LanThu = Convert.ToInt32(reader["lanthu"]),
                            NgayBaoTri = Convert.ToDateTime(reader["ngaybaotri"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int sqlDeleteNV_BT(string manhanvien, string mathietbi, string macanho, string lanthu)
        {
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "Delete From NV_BT " +
                    "Where MaNhanVien = @manhanvien and MaThietBi = @mathietbi " +
                          "and MaCanHo = @macanho and LanThu = @lanthu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manhanvien", manhanvien);
                cmd.Parameters.AddWithValue("mathietbi", mathietbi);
                cmd.Parameters.AddWithValue("macanho", macanho);
                cmd.Parameters.AddWithValue("lanthu", lanthu);
                return cmd.ExecuteNonQuery();
            }
        }
        public NV_BTModel sqlGetNV_BT(string manhanvien, string mathietbi, string macanho, string lanthu)
        {
            NV_BTModel nv_bt = new NV_BTModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "Select * From NV_BT " +
                    "Where MaNhanVien = @manhanvien and MaThietBi = @mathietbi " +
                          "and MaCanHo = @macanho and LanThu = @lanthu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manhanvien", manhanvien);
                cmd.Parameters.AddWithValue("mathietbi", mathietbi);
                cmd.Parameters.AddWithValue("macanho", macanho);
                cmd.Parameters.AddWithValue("lanthu", lanthu);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nv_bt.MaNhanVien = reader["manhanvien"].ToString();
                        nv_bt.MaThietBi = reader["mathietbi"].ToString();
                        nv_bt.MaCanHo = reader["macanho"].ToString();
                        nv_bt.LanThu = Convert.ToInt32(reader["lanthu"]);
                        nv_bt.NgayBaoTri = Convert.ToDateTime(reader["ngaybaotri"]);
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return nv_bt;
        }
        public int sqlUpdateNV_BT(NV_BTModel nv_bt)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "Update NV_BT " +
                            "Set MaThietBi = @mathietbi, MaCanHo = @macanho, LanThu = @lanthu, NgayBaoTri = @ngaybaotri " +
                            "Where MaNhanVien = @manhanvien and MaThietBi = @mathietbi " +
                            "and MaCanHo = @macanho and LanThu = @lanthu";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("manhanvien", nv_bt.MaNhanVien);
                cmd.Parameters.AddWithValue("mathietbi", nv_bt.MaThietBi);
                cmd.Parameters.AddWithValue("macanho", nv_bt.MaCanHo);
                cmd.Parameters.AddWithValue("lanthu", nv_bt.LanThu);
                cmd.Parameters.AddWithValue("ngaybaotri", nv_bt.NgayBaoTri);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
