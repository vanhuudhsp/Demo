using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDATBAO
{
    public partial class frmInHD : Form
    {
        public frmInHD()
        {
            InitializeComponent();
        }
        public string SoPhieu;
        private void frmInHD_Load(object sender, EventArgs e)
        {
            var query = "SELECT PHIEUDATBAO.SoPhieu, PHIEUDATBAO.NgayDat, KHACHHANG.TenKH," +
                        " KHACHHANG.DiaChi, KHACHHANG.DienThoai, TAPCHI.TenTC, TAPCHI.DonGiaThang," +
                        " CTDATBAO.ThangBD, CTDATBAO.ThangKT, CTDATBAO.SoLuong," +
                        " (CTDATBAO.ThangKT - CTDATBAO.ThangBD + 1)* TAPCHI.DonGiaThang AS ThanhTien" +
                        " FROM CTDATBAO INNER JOIN PHIEUDATBAO ON CTDATBAO.SoPhieu = PHIEUDATBAO.SoPhieu INNER JOIN " +
                        " KHACHHANG ON PHIEUDATBAO.MaKH = KHACHHANG.MaKH INNER JOIN TAPCHI ON CTDATBAO.MaTC = TAPCHI.MaTC" +
                        " Where PHIEUDATBAO.SoPhieu = '"+SoPhieu + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Modules.cnn);
            try
            {
                DataTable tbDatBao = new DataTable();
                da.Fill(tbDatBao);
                rptDatBao rpt = new rptDatBao();
                rpt.SetDataSource(tbDatBao);
                crvDatBao.ReportSource = rpt;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
