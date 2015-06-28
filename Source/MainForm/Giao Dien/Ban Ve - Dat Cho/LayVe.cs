using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Linq;
using System.Data.SqlClient;
using MainForm.BusinessLogicLayer;
using System.Globalization;

namespace MainForm.Giao_diện.Bán_Vé___Đặt_Chỗ
{
    public partial class LayVe : Form
    {
#region old_code
        //QLCBDataContext db = new QLCBDataContext();
        //public LayVe()
        //{
        //    InitializeComponent();
        //    ResetAllState();
        //}
        //private string _parentForm;
        //public string BeCalledByForm
        //{
        //    get { return _parentForm; }
        //    set { _parentForm = value; }
        //}
       
        //private void ResetAllState()
        //{
        //    ButtonXacNhan.Enabled = false;
        //    textBoxCMND.ResetText();
        //    textBoxCMND.Enabled = false;
        //    textBoxHoTen.ResetText();
        //    textBoxHoTen.Enabled = false;
        //    textBoxSDT.ResetText();
        //    textBoxSDT.Enabled = false;
        //    comboBoxMaVe.Items.Clear();
        //    comboBoxMaVe.ResetText();
        //    comboBoxMaVe.Enabled = false;
        //}
        //private void InitComboboxMaVe()
        //{
        //    try 
        //    {
        //        comboBoxMaVe.ResetText();
        //        comboBoxMaVe.Items.Clear();

        //        Table<CTPHIEUDATCHO> ctdc = db.GetTable<CTPHIEUDATCHO>();
        //        var temp = from e in ctdc
        //               where (e.LayVe == 0)
        //               select e;
        //        foreach(var k in temp)
        //        {
        //            if(ConHieuDung(k.MaChuyenBay))
        //                comboBoxMaVe.Items.Add(k.MaVe);
        //            else
        //            {
        //                var h = ctdc.Single(p=>p.MaVe == k.MaVe);
        //                h.LayVe = 2;
        //                db.SubmitChanges();
        //                //2 là vé chưa lấy đã hết hạng
        //            }
        //        }
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Không thể khơi tạo combobox mã vé!");
        //    }
            

        //}
        //private bool ConHieuDung(string _machuyenbay)
        //{
        //    Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
        //    CHUYENBAY temp = chuyenbays.Single(p=>p.MaChuyenBay == _machuyenbay);
        //    if(temp.NgayKhoiHanh > DateTime.Now)
        //        return true;
        //    else 
        //        return false;
        //}
        //#region Thoát

        //private void buttonQuayVe_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void LayVe_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.WindowsShutDown)
        //        return;
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        switch (MessageBox.Show(this, "Bạn có muốn dừng việc lấy vé hay không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        //        {
        //            case DialogResult.Yes:
        //                e.Cancel = false;
        //                switch (FormManager.CurrentLayVe.BeCalledByForm)
        //                {
        //                    case "MAINFORM":
        //                        FormManager.CurrentLayVe = null;
        //                        break;
        //                }
        //                break;
        //            case DialogResult.No:
        //                e.Cancel = true;
        //                break;
        //        }
        //    }
        //}
        //#endregion

        //private void buttonLayVeMoi_Click(object sender, EventArgs e)
        //{
        //    buttonLayVeMoi.Enabled = false;
        //    InitComboboxMaVe();
        //    comboBoxMaVe.Enabled = true;
        //    textBoxCMND.Enabled = true;
        //    textBoxHoTen.Enabled = true;
        //    textBoxSDT.Enabled = true;
        //    ButtonXacNhan.Enabled = true;
        //}

        //private void ButtonXacNhan_Click(object sender, EventArgs e)
        //{
        //    if (checkRules())
        //    {
        //        try
        //        {
        //            Table<CTPHIEUDATCHO> ctdc = db.GetTable<CTPHIEUDATCHO>();
        //            CTPHIEUDATCHO k = ctdc.Single(p => p.MaVe == comboBoxMaVe.Text);
        //            k.LayVe = 1;
        //            k.TenHanhKhach = textBoxHoTen.Text;
        //            k.CMND = textBoxCMND.Text;
        //            k.DienThoai = textBoxSDT.Text;
        //            db.SubmitChanges();
        //            ResetAllState();
        //            ButtonXacNhan.Enabled = false;
        //            buttonLayVeMoi.Enabled = true;
        //        }
        //        catch (SqlException)
        //        {
        //            MessageBox.Show("Không thể lấy vé, lỗi CSDL!");
        //        }
        //    }
        //}
        //private bool checkRules()
        //{
        //    if (textBoxCMND.Text == "" && textBoxSDT.Text == "" && textBoxHoTen.Text == "")
        //    {
        //        MessageBox.Show("Không thể để trống thông tin hành khách!");
        //        return false;
        //    }
        //    if (!IsNumber(textBoxCMND.Text) && (textBoxCMND.Text.Length < 9 || textBoxCMND.Text.Length > 12))
        //    {
        //        MessageBox.Show("Số CMND phải là 1 số có từ 9 tới 12 chử số!");
        //        return false;
        //    }
        //    if (!IsNumber(textBoxSDT.Text) && (textBoxSDT.Text.Length < 10 || textBoxSDT.Text.Length > 12))
        //    {
        //        MessageBox.Show("Số điện thoại phải là 1 số có từ 10 tới 12 chử số!");
        //        return false;
        //    }
        //    return true;
        //}

        //private bool IsNumber(string pValue)
        //{
        //    foreach (Char c in pValue)
        //    {
        //        if (!Char.IsDigit(c))
        //            return false;
        //    }
        //    return true;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{

        //}
#endregion

//#region new_code_ author:nhan

    private LayveBLL _layvebll = new LayveBLL();

    public LayVe()
    {
        InitializeComponent();
    }

    private void LayVe_Load(object sender, EventArgs e)
    {         
        
    }

#region xu_ly_buton_them_tao_ma_thoat_sua
    private void button_thoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void button_taoVeMoi_Click(object sender, EventArgs e)
    {
        // xoa text tren cac o nhap lieu
        xoa_all_component();
        // tao ma ve tu dong
        textBox_mave.Text = _layvebll.tao_ma_ve();
        //not_enable button sua
        button_suave.Enabled = false;
        // enable button luu
        Button_luu.Enabled = true;
    }
    private void Button_luu_Click(object sender, EventArgs e)
    {
        if (radioButton_chuadatve.Checked == true)
        {
            if (ktra_du_lieu_truoc_khi_luu_hoac_update() == true)
            {
                // luu xuong csdl
                _layvebll.luu_ve_moi_chua_dat(textBox_mave.Text, comboBox_maCB.Text, textBox_tenhk.Text, textBox_scmnd.Text, textBox_sodt.Text, comboBox_Mahangve.Text, textBox_giatien.Text);
                // thong bao cho nguoi dung
                thong_bao_cho_nguoi_dung("Lưu thành công!",1);
                //re load datagrilview 
                dataGridView_thongtinve.DataSource = _layvebll.lay_danh_sach_ve_khong_dat_truoc();
                // not_enable button luu
                Button_luu.Enabled = false;
                // enable button sua
                button_suave.Enabled = true;
            }
        }
        else
        {
            if (ktra_du_lieu_truoc_khi_luu_hoac_update() == true)
            {
                // luu xuong csdl
                _layvebll.luu_ve_da_dat(textBox_mave.Text,comboBox_maCB.Text, comboBox_Mahangve.Text,textBox_tenhk.Text,textBox_sodt.Text,textBox_scmnd.Text);
                // thong bao cho nguoi dung
                thong_bao_cho_nguoi_dung("Lưu thành công!", 1);
                //re load datagrilview 
                dataGridView_thongtinve.DataSource = _layvebll.lay_danh_sach_ve_da_dat_truoc();
                // not_enable button luu
                Button_luu.Enabled = false;
                // xoa danh sach ma cb, ma hv auto complete
                xoa_danh_sach_ma_khi_chua_dat_ve();
                // danh sach ma phieu dat  de auto complete
                lay_danh_sach_ma_khi_da_dat_ve();
            }
        }
    }
    private void button_suave_Click(object sender, EventArgs e)
    {
        if (radioButton_chuadatve.Checked == true)
        {
            if (ktra_du_lieu_truoc_khi_luu_hoac_update() == true)
            {
                _layvebll.cap_nhat_ve_khong_dat_truoc(comboBox_maphieudat.Text, textBox_mave.Text, comboBox_maCB.Text, textBox_tenhk.Text, textBox_scmnd.Text, textBox_sodt.Text, comboBox_Mahangve.Text, textBox_giatien.Text);
                // thong bao cho nguoi dung
                thong_bao_cho_nguoi_dung("Sửa thành công!", 1);
                //re load datagrilview 
                dataGridView_thongtinve.DataSource = _layvebll.lay_danh_sach_ve_khong_dat_truoc();
                //cap nhat so luong ge trong va so luong ghe dat

            }
        }
        else
        {
            if (ktra_du_lieu_truoc_khi_luu_hoac_update() == true)
            {
                _layvebll.cap_nhat_ve_dat_truoc( textBox_mave.Text, textBox_tenhk.Text, textBox_scmnd.Text, textBox_sodt.Text);
                // thong bao cho nguoi dung
                thong_bao_cho_nguoi_dung("Sửa thành công!", 1);
                //re load datagrilview 
                dataGridView_thongtinve.DataSource = _layvebll.lay_danh_sach_ve_da_dat_truoc();
                //cap nhat so luong ge trong va so luong ghe dat

            }
        }
    }
    #endregion

#region radiobutton_change_selected
    private void radioButton_dadatve_CheckedChanged(object sender, EventArgs e)
    {
        
        dataGridView_thongtinve.DataSource = _layvebll.lay_danh_sach_ve_da_dat_truoc();
        dataGridView_thongtinve.ClearSelection();
        // enable component
        enabled_layve();
        // xoa danh sach ma cb, ma hv auto complete
        xoa_danh_sach_ma_khi_chua_dat_ve();
        // danh sach ma phieu dat  de auto complete
        lay_danh_sach_ma_khi_da_dat_ve();
    }
    private void radioButton_chuadatve_CheckedChanged(object sender, EventArgs e)
    {
        dataGridView_thongtinve.DataSource = _layvebll.lay_danh_sach_ve_khong_dat_truoc();
        dataGridView_thongtinve.ClearSelection();
        // enable component
        enabled_muavemoi();
        // xoa danh sach ma phieu auto complete,xoa data tren cac component
        xoa_danh_sach_ma_khi_da_dat_ve();
        //  danh sach ma cb, ma hv auto complete
        lay_danh_sach_ma_khi_chua_dat_ve();
        // nếu không có phiếu đặt nào thì không cho xử lý nút tạo mới vé để lấy phiếu đặt
        if (comboBox_maCB.Items.Count == 0)
        {
            // thogn bao cho nguoi dung
            thong_bao_cho_nguoi_dung("Chỉ có thể chính sửa,không thể tạo vé mới!Vì không có CB nào khỏi hành trong những ngày tới",2);
            button_taoVeMoi.Enabled = false;
        }
        else
        {
            button_taoVeMoi.Enabled = true;
        }
        
    }
    public void enabled_layve()
    {
        not_enabled_all();
        comboBox_maphieudat.Enabled = true;
        textBox_tenhk.Enabled = true;
        textBox_sodt.Enabled = true;
        textBox_scmnd.Enabled = true;
        // button xu ly
        button_taoVeMoi.Visible = false;
        Button_luu.Enabled = false;


    }
    public void enabled_muavemoi()
    {
        not_enabled_all();
        //textBox_giatien.Enabled = true;
        comboBox_Mahangve.Enabled = true;
        comboBox_maCB.Enabled = true;
        textBox_scmnd.Enabled = true;
        textBox_sodt.Enabled = true;
        textBox_tenhk.Enabled = true;
        //buton xu ly
        button_taoVeMoi.Visible = true;
        button_suave.Enabled = false;
        Button_luu.Enabled = false;
    }
    public void not_enabled_all()
    {
        comboBox_maphieudat.Enabled = false;
        textBox_giatien.Enabled = false;
        comboBox_Mahangve.Enabled = false;
        textBox_tenhangve.Enabled = false;
        comboBox_maCB.Enabled = false;
        textBox_mave.Enabled = false;
        textBox_scmnd.Enabled = false;
        textBox_sodt.Enabled = false;
        textBox_tenhk.Enabled = false;
        button_taoVeMoi.Enabled = false;
        button_suave.Enabled = false;
        label_thongbao.Visible = false;
        Button_luu.Enabled = false;
        // xoa all
        xoa_all_component();
    }
    public void xoa_all_component()
    {
        label_thongbao.Visible = false;
        comboBox_maphieudat.Text = null;
        textBox_giatien.Text = null;
        comboBox_Mahangve.Text = null;
        comboBox_maCB.Text = null;
        textBox_scmnd.Text = null;
        textBox_sodt.Text = null;
        textBox_tenhk.Text = null;
        label_mahv.Visible = false;
        label_macb.Visible = false;
        labe_maphieudat.Visible = false;
        textBox_mave.Text = null;
        xoa_du_lieu_thong_tin_CB();
        dataGridView_thongtinve.ClearSelection();
    }
    public void lay_danh_sach_ma_khi_da_dat_ve()
    {

        this.comboBox_maphieudat.Items.AddRange(_layvebll.lay_danh_sach_ma_phieu_dat());
        
        // uodate commbobox macb
        this.comboBox_maCB.Items.AddRange(_layvebll.lay_danh_sach_ma_CB());

    }
    public void xoa_danh_sach_ma_khi_da_dat_ve()
    {
        this.comboBox_maphieudat.Items.Clear();
        this.comboBox_maCB.Items.Clear();
        this.comboBox_Mahangve.Items.Clear();

    }
    public void lay_danh_sach_ma_khi_chua_dat_ve()
    {
        // uodate commbobox macb
        this.comboBox_maCB.Items.AddRange(_layvebll.lay_danh_sach_ma_CB());

    }
    public void xoa_danh_sach_ma_khi_chua_dat_ve()
    {
        this.comboBox_maphieudat.Items.Clear();
        this.comboBox_maCB.Items.Clear();
        this.comboBox_Mahangve.Items.Clear();
    }
    #endregion

#region update_data_for_combobox
    private void comboBox_maphieudat_Update(object sender, EventArgs e)
    {
        if (comboBox_maphieudat.Items.Contains(comboBox_maphieudat.Text) == false)
        {
            if (this.Visible == true)
            {
                // enable label báo lỗi
                labe_maphieudat.Visible = true;
                xoa_all_component_radio_da_dat_ve();
            }

        }
        else
        {
            labe_maphieudat.Visible = false;
            gan_thong_tin_all_da_dat_ve();
            Button_luu.Enabled = true;
            button_suave.Enabled = false;
                
        }
        label_thongbao.Visible = false;
    }
    private void comboBox_maCB_Update(object sender, EventArgs e)
    {
        if (comboBox_maCB.Items.Contains(comboBox_maCB.Text) == false)
        {
            if (this.Visible == true)
            {
                // enable label báo lỗi
                label_macb.Visible = true;
                // xoa thong tin trong combobox mahv
                comboBox_Mahangve.Items.Clear();
                // xoa du lieu trong thong tin cb
                xoa_du_lieu_thong_tin_CB();
            }
        }
        else
        {
            // not-enable label bao loi 
            label_macb.Visible = false;
            // clear ma hang ve
            comboBox_Mahangve.Items.Clear();
            // add item vao ma hang ve
            this.comboBox_Mahangve.Items.AddRange(_layvebll.lay_danh_sach_ma_hang_ve(comboBox_maCB.Text));
            // load texxt trong cac component thong tin chuyen bay 
            gan_du_lieu_thong_tin_CB();
        }
        
    }
    private void comboBox_Mahangve_Update(object sender, EventArgs e)
    {
        if (comboBox_Mahangve.Items.Contains(comboBox_Mahangve.Text) == false)
        {
            if (this.Visible == true)
            {
                label_mahv.Visible = true;
                //xoa thong tin hang ve va gia tien
                xoa_thong_tin_han_ve();
            }
        }
        else
        {
            label_mahv.Visible = false;
            //lay thong tin ten ve va gia tien
            gan_thong_tin_han_ve();
        }
    }

    #region xu_ly_du_lieu_sau_khi_chon_com_bo_box
    //thog tin cb _ sau khi chon combobox maCB
    public void gan_du_lieu_thong_tin_CB()
    {
        //ten san bay di
        textBox_SB_di.Text = _layvebll.lay_thong_tin_san_bay_di(comboBox_maCB.Text);
        // san bay den
        textBox_SB_den.Text = _layvebll.lay_thong_tin_san_bay_den(comboBox_maCB.Text);
        //thoi gian bay
        textBox_Tgian_bay.Text = _layvebll.lay_thoi_gian_bay(comboBox_maCB.Text);
        // ngay bay
        textBox_ngay_bay.Text = _layvebll.lay_ngay_khoi_hanh(comboBox_maCB.Text);
        // gio xuat phat
        textBox_giobay.Text = _layvebll.lay_gio_khoi_hanh(comboBox_maCB.Text);
        // san bay trung gian
        dataGridView_thongtincb.DataSource = _layvebll.lay_danh_sach_SBTG(comboBox_maCB.Text);
        // not select trong datagrid view SB trung gian
        dataGridView_thongtincb.ClearSelection();
    }
    public void xoa_du_lieu_thong_tin_CB()
    {
        //ten san bay di
        textBox_SB_di.Text = "";
        // san bay den
        textBox_SB_den.Text = "";
        //thoi gian bay
        textBox_Tgian_bay.Text = "";
        // ngay bay
        textBox_ngay_bay.Text = "";
        // gio xuat phat
        textBox_giobay.Text = "";
        // san bay trung gian
        dataGridView_thongtincb.DataSource = null;
    }
    //thong tin hang ve_ sau khi chon combo
    public void gan_thong_tin_han_ve()
    {
        // ten hang ve
        textBox_tenhangve.Text = _layvebll.lay_ten_hang_ve(comboBox_Mahangve.Text);
        // gia tien
        textBox_giatien.Text = _layvebll.lay_gia_hang_ve(comboBox_maCB.Text, comboBox_Mahangve.Text);
    }
    public void xoa_thong_tin_han_ve()
    {
        // ten hang ve
        textBox_tenhangve.Text = null;
        // gia tien
        textBox_giatien.Text = null;
    }
    // clean textbox
    public void gan_thong_tin_all_da_dat_ve()
    {
        textBox_mave.Text = _layvebll.lay_thong_tin_ma_ve_da_dat(comboBox_maphieudat.Text);
        comboBox_maCB.Text = _layvebll.lay_thong_tin_ma_cb_da_dat(comboBox_maphieudat.Text);
        textBox_tenhk.Text = _layvebll.lay_thong_tin_te_kh_da_dat(comboBox_maphieudat.Text);
        textBox_scmnd.Text = _layvebll.lay_thong_tin_cmnd_da_dat(comboBox_maphieudat.Text);
        textBox_sodt.Text = _layvebll.lay_thong_tin_sdt_da_dat(comboBox_maphieudat.Text);
        comboBox_Mahangve.Text = _layvebll.lay_thong_tin_hang_ve_da_dat(comboBox_maphieudat.Text);
    }
    public void xoa_all_component_radio_da_dat_ve()
    {
        
        textBox_giatien.Text = null;
        comboBox_Mahangve.Text = null;
        comboBox_maCB.Text = null;
        textBox_scmnd.Text = null;
        textBox_sodt.Text = null;
        textBox_tenhk.Text = null;
        label_mahv.Visible = false;
        label_macb.Visible = false;
        xoa_du_lieu_thong_tin_CB();
        dataGridView_thongtinve.ClearSelection();
    }
    #endregion
#endregion

#region kiem_tra_thong_tin_hop_le_nguoi_mua_ve
    private void textBox_tenhk_TextChanged(object sender, EventArgs e)
    {
        if(textBox_tenhk.Text.Length>50)
        {
            label_tenhk.Visible = true;
        }
        else
        {
            label_tenhk.Visible = false;
        }
    }

    private void textBox_scmnd_TextChanged(object sender, EventArgs e)
    {
        if (textBox_scmnd.Text.Length != 9 )
        {
            label_cmnd.Visible = true;
            
        }
        else
        {
            try
            {
                long t = long.Parse(textBox_scmnd.Text);
                //khong loi 
                label_cmnd.Visible = false;
            }
            catch
            {
                label_cmnd.Visible = true;
               
            }

            
        }
    }

    private void textBox_sodt_TextChanged(object sender, EventArgs e)
    {
        if (textBox_sodt.Text.Length > 11 || textBox_sodt.Text.Length <10)
        {
            label_sodt.Visible = true;
            
            
        }
        else
        {
            
            try
            {
                long t = long.Parse(textBox_sodt.Text);
                //khong loi 
                label_sodt.Visible = false;

            }
            catch
            {
                label_sodt.Visible = true;
                
            }

            
        }
    }

    #endregion

#region ktra_du_lieu_truoc_khi_luu_hoac_update
    public void thong_bao_cho_nguoi_dung(string loi, int maloi)
    {
        label_thongbao.Visible = true;
        // nội dung
        label_thongbao.Text = loi;
        // xét màu
        switch (maloi)
        {
            case 2:// lưu không thành công, label thông báo chữ màu đỏ
                {
                    label_thongbao.BackColor = Color.Red;
                    break;
                }
            case 1: // lưu thành công, label thông báo chữ màu xanh
                {
                    label_thongbao.BackColor = Color.Green;
                    break;
                }
            default:
                break;

        }

    }
    public bool ktra_du_lieu_truoc_khi_luu_hoac_update()
    {
        
        if(labe_maphieudat.Visible==true|| label_cmnd.Visible==true|| label_macb.Visible==true
            || label_mahv.Visible==true||label_sodt.Visible==true||label_tenhk.Visible==true)
        {
            thong_bao_cho_nguoi_dung("Thao tác không thành công. Lỗi ở những ô có thông báo 'lỗi'!",2);
            return false;
        }
        if (radioButton_chuadatve.Checked==true &&( textBox_mave.Text.Trim().Length==0||textBox_scmnd.Text.Trim().Length == 0 || comboBox_maCB.Text.Trim().Length == 0
            || comboBox_Mahangve.Text.Trim().Length == 0 || textBox_sodt.Text.Trim().Length == 0 || textBox_tenhk.Text.Trim().Length == 0))
        {
            thong_bao_cho_nguoi_dung("Thao tác không thành công. Các ô nhập không thể chừa trống!", 2);
            return false;
        }
        if (radioButton_dadatve.Checked == true && (textBox_mave.Text.Trim().Length==0||comboBox_maphieudat.Text.Trim().Length==0|| textBox_scmnd.Text.Trim().Length == 0
            || comboBox_maCB.Text.Trim().Length == 0|| comboBox_Mahangve.Text.Trim().Length == 0 || textBox_sodt.Text.Trim().Length == 0 ||
            textBox_tenhk.Text.Trim().Length == 0))
        {
            thong_bao_cho_nguoi_dung("Thao tác không thành công. Các ô nhập không thể chừa trống!", 2);
            return false;
        }
        //ktra thong tin ngay chuyen bay phai lon hon ngay hien tai 
        DateTime t = DateTime.ParseExact(textBox_ngay_bay.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime tt = DateTime.ParseExact(textBox_giobay.Text, "H:m:s", CultureInfo.InvariantCulture);
        DateTime now = DateTime.Now;
        if (t.Day <= now.Day && t.Month <= now.Month && t.Year <= now.Year && tt.Hour<=now.Hour && tt.Minute<= now.Minute && tt.Second<=now.Second)
        {
            thong_bao_cho_nguoi_dung("Thao tác không thành công. Không thể sửa vé hoặc tạo vé với chuyến bay đã cất cánh!", 2);
            return false;
        }
        //ktra con ve hay khong
        if (_layvebll.so_ghe_trong(comboBox_maCB.Text, comboBox_Mahangve.Text) < 1&&radioButton_chuadatve.Checked==true)
        {
            thong_bao_cho_nguoi_dung("Thao tác không thành công. Chuyến bay với hạng vé này đã hết chỗ!", 2);
            return false;
        }
        return true;
    }

    #endregion

#region datagridview_thong tin ve
    private void dataGridView_thongtinve_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // != dong head column
        if(e.RowIndex!=-1)
        {
            // xoa du lieu tren cac texxtbox
            xoa_all_component();
            // select row
            dataGridView_thongtinve.Rows[e.RowIndex].Selected = true;
            // not_enable button luu 
            Button_luu.Enabled = false;
            // enable buttton sua
            button_suave.Enabled = true;
            //load thong tin len cac text
            gan_du_lieu_len_cac_combonent_khi_chua_dat_ve(e.RowIndex);

        }   
    }

    public void gan_du_lieu_len_cac_combonent_khi_chua_dat_ve(int row)
    {
        comboBox_maphieudat.Text = dataGridView_thongtinve.Rows[row].Cells[0].Value.ToString();
        textBox_mave.Text=dataGridView_thongtinve.Rows[row].Cells[1].Value.ToString();
        comboBox_maCB.SelectedText = dataGridView_thongtinve.Rows[row].Cells[2].Value.ToString();
        textBox_tenhk.Text = dataGridView_thongtinve.Rows[row].Cells[3].Value.ToString();
        textBox_scmnd.Text = dataGridView_thongtinve.Rows[row].Cells[4].Value.ToString();
        textBox_sodt.Text = dataGridView_thongtinve.Rows[row].Cells[5].Value.ToString();
        comboBox_Mahangve.SelectedText = dataGridView_thongtinve.Rows[row].Cells[6].Value.ToString();
    }

    #endregion

   

    

    

   //#endregion
    


    




    }
}

