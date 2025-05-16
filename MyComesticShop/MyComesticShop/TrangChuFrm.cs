using ComesticShop;
using MyComesticShop.Forms;
using MyComesticShop.Forms.BanHang1;
using MyComesticShop.Forms.DangNhap;
using MyComesticShop.Forms.KhachHang;
using MyComesticShop.Forms.KhuyenMai;
using MyComesticShop.Forms.NhaCungCap;
using MyComesticShop.Forms.NhapHang;
using MyComesticShop.Forms.UserForms;
using System;
using System.Windows.Forms;


namespace MyComesticShop
{
    public partial class TrangChuFrm : Form
    {
        public GiaoDienFrm giaoDienFrm;
        public DanhSachNDFrm FrmDanhSachNV;
        public DanhSachNCCFrm danhSachNCCFrm;
        public DanhSachKHFrm danhSachKHFrm;
        public DanhSachMaKhuyenMai danhsachMaKMFrm;
        public BaoCaoNhapHang baoCaoNhapHang1;



        public TrangChuFrm()
        {
            InitializeComponent();

            TChangeTime.Start();
            giaoDienFrm = new GiaoDienFrm();
            giaoDienFrm.TopLevel = false;
            giaoDienFrm.Dock = DockStyle.Fill;
            giaoDienFrm.FormBorderStyle = FormBorderStyle.None;
            panelParent.Controls.Add(giaoDienFrm);
            giaoDienFrm.Show();
            DangXuat();
        }

        private void DangXuat()
        {
            msTrangChu.Enabled = false;
            tsbtnDangXuat.Visible = false;
            tsbtnDonHangMoi.Enabled = false;
            tsbtnDonNhapMoi.Enabled = false;
            tsbtnKhuyenMai.Enabled = false;
            tsbtnKho.Enabled = false;
            tsbtnBaoCao.Enabled = false;
            tsbtnDangNhap.Visible = true;
        }

        public void DangNhap()
        {
            msTrangChu.Enabled = true;
            tsbtnDangXuat.Visible = true;
            tsbtnDonHangMoi.Enabled = true;
            tsbtnDonNhapMoi.Enabled = true;
            tsbtnKhuyenMai.Enabled = true;
            tsbtnKho.Enabled = true;
            tsbtnBaoCao.Enabled = true;
            tsbtnDangNhap.Visible = false;
        }


        private void TrangChuFrm_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void PhanQuyentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhanLoaiFrm frm = new PhanLoaiFrm();
            frm.ShowDialog();
        }


        private void EmployeeRegistation1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienFrm frm = new NhanVienFrm();
            frm.ShowDialog();
        }

        private void NewUser1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoNguoiDungFrm user = new TaoNguoiDungFrm();
            user.ShowDialog();
        }

        private void toolStripbtnDangNhap_Click(object sender, EventArgs e)
        {
            TrangDangNhapFrm tdn = new TrangDangNhapFrm(this);
            tdn.ShowDialog();
        }

        private void TChangeTime_Tick(object sender, EventArgs e)
        {
            tssblCurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsbtnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void tsmiBtnThayDoiMK_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhauFrm thayDoiMatKhau = new ThayDoiMatKhauFrm();
            thayDoiMatKhau.ShowDialog();
        }

        private void DanhSachNVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(FrmDanhSachNV == null)
            {
                FrmDanhSachNV = new DanhSachNDFrm();
            }

            //FrmDanhSachNV.TopLevel = false;
            //panelParent.Controls.Add(FrmDanhSachNV);
            //FrmDanhSachNV.FormBorderStyle = FormBorderStyle.None;
            //FrmDanhSachNV.Dock = DockStyle.Fill;
            //FrmDanhSachNV.BringToFront();
            FrmDanhSachNV.Show();
        }

        private void NewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCapFrm frm = new NhaCungCapFrm();
            frm.ShowDialog();
        }

        private void sảnPhẩmKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void kháchHàngTíchĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHangFrm khachHangFrm = new KhachHangFrm();
            khachHangFrm.ShowDialog();
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if(danhSachNCCFrm == null)
            {
                danhSachNCCFrm = new DanhSachNCCFrm();
            }
            //danhSachNCCFrm.TopLevel = false;
            //panelParent.Controls.Add(danhSachNCCFrm);
            //danhSachNCCFrm.FormBorderStyle = FormBorderStyle.None;
            //danhSachNCCFrm.Dock = DockStyle.Fill;
            //danhSachNCCFrm.BringToFront();
            danhSachNCCFrm.Show();

        }

        private void danhSáchKháchHàngThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKHFrm == null)
            {
                danhSachKHFrm = new DanhSachKHFrm();
            }
            //panelParent.Controls.Clear(); // Thêm dòng này

            //danhSachKHFrm.TopLevel = false;
            //danhSachKHFrm.FormBorderStyle = FormBorderStyle.None;
            //danhSachKHFrm.Dock = DockStyle.Fill;

            //panelParent.Controls.Add(danhSachKHFrm);

            //danhSachKHFrm.BringToFront();
            danhSachKHFrm.Show();


        }

        private void tạoĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHangFrm Nhaphang = new NhapHangFrm();
            Nhaphang.ShowDialog();
        }

        private void taoĐonNhậpMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHangFrm BanHang = new BanHangFrm();
            BanHang.ShowDialog();
        }

        private void AddMaKhuyenMaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhuyenMaiFrm khuyenMai = new KhuyenMaiFrm();
            khuyenMai.ShowDialog();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchMãKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(danhsachMaKMFrm == null)
            {
                danhsachMaKMFrm = new DanhSachMaKhuyenMai();
                danhsachMaKMFrm.Show();
            }
        }

  
        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void báoCáoNhậpHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BaoCaoNhapHang baoCaoNhapHang = new BaoCaoNhapHang(3);
            baoCaoNhapHang.ShowDialog();
        }

        private void báoCáoBánHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BaoCaoBanHang baoCaoBanHang = new BaoCaoBanHang(4);
            baoCaoBanHang.ShowDialog();
        }

        private void danhSáchBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachBanHang danhSachBanHang = new DanhSachBanHang();
            danhSachBanHang.ShowDialog();
        }

        private void danhSáchNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhapHang danhSachNhapHang = new DanhSachNhapHang();
            danhSachNhapHang.ShowDialog();
        }
    }
}
