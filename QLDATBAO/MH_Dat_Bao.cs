using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;
namespace QLDATBAO
{
    public partial class MH_Dat_Bao : Form
    {
        public MH_Dat_Bao()
        {
            InitializeComponent();
        }

        //Bien Toan Cuc
        DataTable tblKHACHHANG, tblPHIEUDATBAO, tblCTDATBAO, tblTAPCHI;
        SqlDataAdapter daPDB, daCTDB, daKH, daTC;
        BindingManagerBase bindPDB, bindCTDB;
        bool capNhat;
        private void loadDSDT()
        {
            cbSDT.DataSource = tblKHACHHANG;
            cbSDT.ValueMember = "MaKH"; 
            cbSDT.DisplayMember = "DienThoai";// Field hiển thị cbo
            cbSDT.AutoCompleteMode = AutoCompleteMode.Suggest; // Cho phép tìm với kí tự bắt đầu
            cbSDT.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        //Event
        private void cbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSDT.SelectedIndex;
            if (index >= 0)
            {
                txtTenKH.Text = tblKHACHHANG.Rows[index]["TenKH"].ToString();
                txtDiaChi.Text = tblKHACHHANG.Rows[index]["DiaChi"].ToString();
            }
            else
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
            }

        }
        private void loadTAPCHI()
        {
            cbTapChi.DataSource = tblTAPCHI;
            cbTapChi.ValueMember = "MaTC";
            cbTapChi.DisplayMember = "TenTC";
            cbTapChi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTapChi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTapChi.SelectedIndex = -1; //Bỏ chọn
        }
        private void addColCTDATBAO()
        {
            // Tao DS
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblTAPCHI, tblCTDATBAO });
            // Tao qh
            DataRelation qh = new DataRelation("FRK_TAPCHI_CTDATBAO", tblTAPCHI.Columns["MaTC"], tblCTDATBAO.Columns["MaTC"]);
            ds.Relations.Add(qh);
            //Tao cot phu
            DataColumn cot_TenTC = new DataColumn("TenTC", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).TenTC");
            DataColumn cot_DonGiaThang = new DataColumn("DonGiaThang", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).DonGiaThang");
            DataColumn cot_ThanhTien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).DonGiaThang * SoLuong *(ThangKT - ThangBD +1 ) ");

            tblCTDATBAO.Columns.Add(cot_TenTC);
            tblCTDATBAO.Columns.Add(cot_DonGiaThang);
            tblCTDATBAO.Columns.Add(cot_ThanhTien);
        }
        private void loadCTDATBAO()
        {
            bindCTDB = this.BindingContext[tblCTDATBAO];
            dgvCTDatBao.AutoGenerateColumns = false;
            dgvCTDatBao.DataSource = tblCTDATBAO;
        }

        private void bdPDB_PositionChanged(object sender, EventArgs e)
        {
            tblCTDATBAO.DefaultView.RowFilter = "SoPhieu='" + txtSoPhieu.Text + "'";
            int s = 0;
            foreach (DataRowView r in tblCTDATBAO.DefaultView)
            {
                s += int.Parse( r["ThanhTien"].ToString());
            }
            txtTong.Text = s.ToString();
        }

        private void loadDSDATBAO()
        {
            //Tao lien ket tblPHIEUDATBAO voi cac control
            txtSoPhieu.DataBindings.Add("text", tblPHIEUDATBAO, "SoPhieu", true);
            dtNgayDat.DataBindings.Add("value", tblPHIEUDATBAO, "NgayDat", true);
            cbSDT.DataBindings.Add("SelectedValue", tblPHIEUDATBAO, "MaKH", true);
            bindPDB = this.BindingContext[tblPHIEUDATBAO];
            //Đăng Ký Event PositionChanged xu ly bởi bdPDB_PositionChanged(object sender, EventArgs e)
            bindPDB.PositionChanged += new EventHandler(bdPDB_PositionChanged);
        }

        private void ennableButton()
        {
            btnNewDB.Enabled = !capNhat;
            btnUpdateDB.Enabled = !capNhat;
            btnDeleteDB.Enabled = !capNhat;
            btnPrint.Enabled = !capNhat;
            btnCancelDB.Enabled = capNhat;
            btnSaveDB.Enabled = capNhat;
            btnAddTC.Enabled = capNhat;
            btnDeleteTC.Enabled = capNhat;
            dgvCTDatBao.Enabled = capNhat;
        }

        //Event
        private void MH_Dat_Bao_Load(object sender, EventArgs e)
        {
            tblKHACHHANG = new DataTable();
            tblPHIEUDATBAO = new DataTable();
            tblCTDATBAO = new DataTable();
            tblTAPCHI = new DataTable();
            daKH = new SqlDataAdapter("Select * from KHACHHANG", Modules.cnnStr);
            daPDB = new SqlDataAdapter("Select * from PHIEUDATBAO", Modules.cnnStr);
            daCTDB = new SqlDataAdapter("Select * from CTDATBAO", Modules.cnnStr);
            daTC = new SqlDataAdapter("Select * from TAPCHI", Modules.cnnStr);
            ///
            try
            {
                daKH.Fill(tblKHACHHANG);
                daPDB.Fill(tblPHIEUDATBAO);
                daCTDB.Fill(tblCTDATBAO);
                daTC.Fill(tblTAPCHI);
                SqlCommandBuilder cmdPDB = new SqlCommandBuilder(daPDB); //Tạo cầu nối để cập nhật xuống CSDL
                SqlCommandBuilder cmdCTDB = new SqlCommandBuilder(daCTDB);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadDSDT();
            loadTAPCHI();
            addColCTDATBAO();
            loadCTDATBAO();
            loadDSDATBAO();
            bdPDB_PositionChanged(sender, e);
            capNhat = false;
            ennableButton();
        }
        //Event xu ly STT
        private void dgvCTDatBao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTDatBao.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        
        //Event
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindPDB.Position = 0;
        }
        //Event
        private void btnPreviuos_Click(object sender, EventArgs e)
        {
            if (bindPDB.Position > 0)
                bindPDB.Position -= 1;
        }
        //Event
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bindPDB.Position < bindPDB.Count - 1)
                bindPDB.Position += 1;
        }
        //Event
        private void btnLast_Click(object sender, EventArgs e)
        {;
            bindPDB.Position = bindPDB.Count - 1;
        }
        //Event
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmInHD f = new frmInHD();
            f.SoPhieu = txtSoPhieu.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        //Event AddTC
        private void btnAddTC_Click(object sender, EventArgs e)
        {
            if (cbTapChi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn tạp chí!!!!");
                return;
            }
            int count = tblCTDATBAO.Select("SoPhieu = '" + txtSoPhieu.Text + "' and MaTC='" + cbTapChi.SelectedValue + "'").Count();
            if (count > 0)
            {
                MessageBox.Show("Tạp chí này đã tồn tại, chọn tap chí khác!!!");
                return;
            }
            //Xu ly add tap chi
            DataRow r = tblCTDATBAO.NewRow();
            r["MaTC"] = cbTapChi.SelectedValue;
            r["SoPhieu"] = txtSoPhieu.Text;
            r["SoLuong"] = nudSoLuong.Value;
            r["ThangBD"] = nudThangBD.Value;
            r["ThangKT"] = nudThangKT.Value;
            tblCTDATBAO.Rows.Add(r);
            bdPDB_PositionChanged(sender, e);
        }
        //Event DeleteTC
        private void btnDeleteTC_Click(object sender, EventArgs e)
        {
            //int index = dgvCTDatBao.CurrentRow.Index;
            int index = bindCTDB.Position;
            if (index >= 0)
                bindCTDB.RemoveAt(index);
        }
        private void btnCancelDB_Click(object sender, EventArgs e)
        {
            bindCTDB.CancelCurrentEdit();
            tblCTDATBAO.RejectChanges();
            bindPDB.CancelCurrentEdit();
            tblPHIEUDATBAO.RejectChanges();
            bdPDB_PositionChanged(sender, e);
            capNhat = false;
            ennableButton();
        }
        //Event NewDB
        private void btnNewDB_Click(object sender, EventArgs e)
        {
            bindPDB.AddNew();
            dtNgayDat.Value = DateTime.Now;
            try
            {
                //Goi fuction fn_CreateMaPDB de phat sinh So Phieu Dat Bao
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = Modules.cnn;
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.CommandText = "dbo.pro_CreateMaHD";
                cmm.Parameters.Add("@MaPHNew", SqlDbType.NVarChar, 5).Direction = ParameterDirection.Output;
                Modules.cnn.Open();
                cmm.ExecuteScalar();
                txtSoPhieu.Text = cmm.Parameters["@MaPHNew"].Value.ToString();
                capNhat = true;
                ennableButton();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Modules.cnn.Close();
        }

        //Event SaveDB
        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            if (cbSDT.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn khách hàng!!!");
                return;
            }

            try
            {
                bindPDB.EndCurrentEdit();
                daPDB.Update(tblPHIEUDATBAO);
                tblPHIEUDATBAO.AcceptChanges();

                bindCTDB.EndCurrentEdit();
                daCTDB.Update(tblCTDATBAO);
                tblCTDATBAO.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!!!");
                capNhat = false;
                ennableButton();
            }
            catch (SqlException ex)
            {
                tblCTDATBAO.RejectChanges();
                tblPHIEUDATBAO.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            capNhat = true;
            ennableButton();
        }

        //Event DeleteDB
        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            try
            {
                //Xoa CTDB theo SoPhieu
                var rows = tblCTDATBAO.Select("SoPhieu ='" + txtSoPhieu.Text + "'");
                foreach (DataRow r in rows)
                    r.Delete();
                daCTDB.Update(tblCTDATBAO);
                tblCTDATBAO.AcceptChanges();
                //Xoa PDB
                bindPDB.RemoveAt(bindPDB.Position);
                daPDB.Update(tblPHIEUDATBAO);
                tblPHIEUDATBAO.AcceptChanges();
                MessageBox.Show("Xóa thành công!!!");
            }
            catch (SqlException ex)
            {
                tblCTDATBAO.RejectChanges();
                tblPHIEUDATBAO.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }
        
        
      
        
       
      
    }
}
