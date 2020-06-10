namespace QLDATBAO
{
    partial class MH_Dat_Bao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MH_Dat_Bao));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTC = new DevExpress.XtraEditors.SimpleButton();
            this.dgvCTDatBao = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTC = new DevExpress.XtraEditors.SimpleButton();
            this.nudThangKT = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudThangBD = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTapChi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreviuos = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDatBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTong);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btnDeleteTC);
            this.groupControl1.Controls.Add(this.dgvCTDatBao);
            this.groupControl1.Controls.Add(this.btnAddTC);
            this.groupControl1.Controls.Add(this.nudThangKT);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.nudThangBD);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.nudSoLuong);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.cbTapChi);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 490);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1562, 560);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Chi tiết Đặt Báo";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(195, 113);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(238, 27);
            this.txtTong.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tổng Tiền: ";
            // 
            // btnDeleteTC
            // 
            this.btnDeleteTC.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTC.ImageOptions.SvgImage")));
            this.btnDeleteTC.Location = new System.Drawing.Point(1200, 44);
            this.btnDeleteTC.Name = "btnDeleteTC";
            this.btnDeleteTC.Size = new System.Drawing.Size(132, 63);
            this.btnDeleteTC.TabIndex = 22;
            this.btnDeleteTC.Text = "Delete";
            this.btnDeleteTC.Click += new System.EventHandler(this.btnDeleteTC_Click);
            // 
            // dgvCTDatBao
            // 
            this.dgvCTDatBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDatBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTC,
            this.ThangBD,
            this.ThangKT,
            this.SoLuong,
            this.DonGiaThang,
            this.ThanhTien});
            this.dgvCTDatBao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCTDatBao.Location = new System.Drawing.Point(2, 152);
            this.dgvCTDatBao.Name = "dgvCTDatBao";
            this.dgvCTDatBao.RowTemplate.Height = 28;
            this.dgvCTDatBao.Size = new System.Drawing.Size(1558, 406);
            this.dgvCTDatBao.TabIndex = 21;
            this.dgvCTDatBao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTDatBao_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "TenTC";
            this.TenTC.HeaderText = "Tên Tạp Chí";
            this.TenTC.Name = "TenTC";
            this.TenTC.ReadOnly = true;
            this.TenTC.Width = 300;
            // 
            // ThangBD
            // 
            this.ThangBD.DataPropertyName = "ThangBD";
            this.ThangBD.HeaderText = "Tháng Bắt Đầu";
            this.ThangBD.Name = "ThangBD";
            this.ThangBD.Width = 150;
            // 
            // ThangKT
            // 
            this.ThangKT.DataPropertyName = "ThangKT";
            this.ThangKT.HeaderText = "Tháng Kết Thúc";
            this.ThangKT.Name = "ThangKT";
            this.ThangKT.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGiaThang
            // 
            this.DonGiaThang.DataPropertyName = "DonGiaThang";
            this.DonGiaThang.HeaderText = "Đơn Giá Tháng";
            this.DonGiaThang.Name = "DonGiaThang";
            this.DonGiaThang.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 150;
            // 
            // btnAddTC
            // 
            this.btnAddTC.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddTC.ImageOptions.SvgImage")));
            this.btnAddTC.Location = new System.Drawing.Point(1049, 44);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(132, 63);
            this.btnAddTC.TabIndex = 20;
            this.btnAddTC.Text = "Add";
            this.btnAddTC.Click += new System.EventHandler(this.btnAddTC_Click);
            // 
            // nudThangKT
            // 
            this.nudThangKT.Location = new System.Drawing.Point(939, 59);
            this.nudThangKT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangKT.Name = "nudThangKT";
            this.nudThangKT.Size = new System.Drawing.Size(75, 27);
            this.nudThangKT.TabIndex = 19;
            this.nudThangKT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(840, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tháng KT:";
            // 
            // nudThangBD
            // 
            this.nudThangBD.Location = new System.Drawing.Point(759, 58);
            this.nudThangBD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangBD.Name = "nudThangBD";
            this.nudThangBD.Size = new System.Drawing.Size(75, 27);
            this.nudThangBD.TabIndex = 17;
            this.nudThangBD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(659, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tháng BĐ:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(566, 58);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(74, 27);
            this.nudSoLuong.TabIndex = 15;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(470, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Số Lượng:";
            // 
            // cbTapChi
            // 
            this.cbTapChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTapChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbTapChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTapChi.FormattingEnabled = true;
            this.cbTapChi.Location = new System.Drawing.Point(195, 58);
            this.cbTapChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTapChi.Name = "cbTapChi";
            this.cbTapChi.Size = new System.Drawing.Size(238, 28);
            this.cbTapChi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tìm Tên Tạp Chí: ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnPrint);
            this.groupControl2.Controls.Add(this.btnCancelDB);
            this.groupControl2.Controls.Add(this.btnSaveDB);
            this.groupControl2.Controls.Add(this.btnDeleteDB);
            this.groupControl2.Controls.Add(this.btnUpdateDB);
            this.groupControl2.Controls.Add(this.btnNewDB);
            this.groupControl2.Controls.Add(this.btnLast);
            this.groupControl2.Controls.Add(this.btnNext);
            this.groupControl2.Controls.Add(this.btnPreviuos);
            this.groupControl2.Controls.Add(this.btnFirst);
            this.groupControl2.Controls.Add(this.txtDiaChi);
            this.groupControl2.Controls.Add(this.txtTenKH);
            this.groupControl2.Controls.Add(this.cbSDT);
            this.groupControl2.Controls.Add(this.dtNgayDat);
            this.groupControl2.Controls.Add(this.txtSoPhieu);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 195);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1562, 295);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Phiếu đặt báo";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(1125, 196);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(132, 64);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancelDB
            // 
            this.btnCancelDB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelDB.ImageOptions.SvgImage")));
            this.btnCancelDB.Location = new System.Drawing.Point(1125, 123);
            this.btnCancelDB.Name = "btnCancelDB";
            this.btnCancelDB.Size = new System.Drawing.Size(132, 64);
            this.btnCancelDB.TabIndex = 18;
            this.btnCancelDB.Text = "Cancel";
            this.btnCancelDB.Click += new System.EventHandler(this.btnCancelDB_Click);
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSaveDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveDB.ImageOptions.SvgImage")));
            this.btnSaveDB.Location = new System.Drawing.Point(1125, 41);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(132, 64);
            this.btnSaveDB.TabIndex = 17;
            this.btnSaveDB.Text = "Save";
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDB.ImageOptions.Image")));
            this.btnDeleteDB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDeleteDB.Location = new System.Drawing.Point(978, 197);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(132, 64);
            this.btnDeleteDB.TabIndex = 16;
            this.btnDeleteDB.Text = "Delete";
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDB.ImageOptions.Image")));
            this.btnUpdateDB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdateDB.Location = new System.Drawing.Point(978, 123);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(132, 64);
            this.btnUpdateDB.TabIndex = 15;
            this.btnUpdateDB.Text = "Update";
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewDB
            // 
            this.btnNewDB.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewDB.ImageOptions.SvgImage")));
            this.btnNewDB.Location = new System.Drawing.Point(978, 41);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(132, 64);
            this.btnNewDB.TabIndex = 14;
            this.btnNewDB.Text = "New";
            this.btnNewDB.Click += new System.EventHandler(this.btnNewDB_Click);
            // 
            // btnLast
            // 
            this.btnLast.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLast.ImageOptions.SvgImage")));
            this.btnLast.Location = new System.Drawing.Point(342, 197);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 63);
            this.btnLast.TabIndex = 13;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.Location = new System.Drawing.Point(238, 198);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 62);
            this.btnNext.TabIndex = 12;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPreviuos
            // 
            this.btnPreviuos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPreviuos.ImageOptions.SvgImage")));
            this.btnPreviuos.Location = new System.Drawing.Point(133, 200);
            this.btnPreviuos.Name = "btnPreviuos";
            this.btnPreviuos.Size = new System.Drawing.Size(80, 60);
            this.btnPreviuos.TabIndex = 11;
            this.btnPreviuos.Click += new System.EventHandler(this.btnPreviuos_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFirst.ImageOptions.SvgImage")));
            this.btnFirst.Location = new System.Drawing.Point(30, 201);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(72, 60);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(618, 99);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(334, 73);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(195, 145);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(238, 27);
            this.txtTenKH.TabIndex = 8;
            // 
            // cbSDT
            // 
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(195, 99);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(238, 27);
            this.cbSDT.TabIndex = 7;
            this.cbSDT.SelectedIndexChanged += new System.EventHandler(this.cbSDT_SelectedIndexChanged);
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDat.Location = new System.Drawing.Point(618, 41);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(334, 27);
            this.dtNgayDat.TabIndex = 6;
            this.dtNgayDat.Value = new System.DateTime(2020, 6, 3, 0, 0, 0, 0);
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(195, 46);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(238, 27);
            this.txtSoPhieu.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(526, 153);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 19);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Địa Chỉ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(122, 19);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Tên Khách Hàng:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tìm theo SĐT:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(474, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ngày đặt hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tìm Số Phiếu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1562, 87);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "ĐẶT BÁO THEO THÁNG";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // MH_Dat_Bao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1562, 1050);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MH_Dat_Bao";
            this.Text = "Form_DatBao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MH_Dat_Bao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDatBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTapChi;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnAddTC;
        private System.Windows.Forms.NumericUpDown nudThangKT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudThangBD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancelDB;
        private DevExpress.XtraEditors.SimpleButton btnSaveDB;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDB;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDB;
        private DevExpress.XtraEditors.SimpleButton btnNewDB;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPreviuos;
        private System.Windows.Forms.DataGridView dgvCTDatBao;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label1;
    }
}