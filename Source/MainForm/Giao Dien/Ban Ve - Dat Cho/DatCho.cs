using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.BusinessLogicLayer;
namespace MainForm
{
    public partial class DatCho : Form
    {
#region old_code

        //    QLCBDataContext db = new QLCBDataContext();
        //    QLCBRules _rule = new QLCBRules();
        //    private string _mainForm;
        //    private bool _datCho;    // để biết khi nào thì form được phép đặt chỗ
        //    private bool _banVe;     // để biết khi nào thì form đươc phép bán vé
        //    private bool _layVe;     // để biết khi nào thì form cho phép người đặt chỗ chỉ định người lấy vé
        //    public string NAME
        //    {
        //        get { return "DATCHO"; }
        //    }

        //    public string BeCalledByForm
        //    {
        //        get { return _mainForm; }
        //        set { _mainForm = value; }
        //    }

        //    public bool BanVe
        //    {
        //        set { _banVe = value; }
        //        get { return _banVe; }

        //    }
        //    public bool LayVe
        //    {
        //        set { _layVe = value; }
        //        get { return _layVe; }
        //    }

        //    public DatCho()
        //    {
        //        InitializeComponent();
        //        buttonPhieuMoi.Enabled = true;
        //        buttonThemVe.Enabled = true;
        //        textBoxMaPhieuDatCho.Enabled = false;
        //        textBoxCMNDDatCho.Enabled = false;
        //        textBoxHoTenDatCho.Enabled = false;
        //        textBoxSDTDatCho.Enabled = false;

        //        ButtonLuu.Enabled = false;
        //        buttonThemVe.Enabled = false;
        //        comboBoxMaChuyenBay.Enabled = false;
        //        comboBoxMaHangVe.Enabled = false;
        //        ButtonLuuVe.Enabled = false;
        //        buttonXoa.Enabled = false;
        //        buttonXuatFile.Enabled = false;
        //        dataGridViewVe.Enabled = false;
        //    }



        //    private void DatCho_Load(object sender, EventArgs e)
        //    {

        //    }

        //    private void DatCho_FormClosing(object sender, FormClosingEventArgs e)
        //    {
        //        if (e.CloseReason == CloseReason.WindowsShutDown)
        //            return;
        //        if (e.CloseReason == CloseReason.UserClosing)
        //        {
        //            switch (MessageBox.Show(this, "Bạn có muốn dừng việc đặt chỗ hay không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        //            {
        //                case DialogResult.Yes:

        //                    e.Cancel = false;
        //                    switch (FormManager.CurrentDatCho.BeCalledByForm)
        //                    {
        //                        case "MAINFORM":
        //                            FormManager.CurrentMainForm.Show();
        //                            FormManager.CurrentDatCho = null;
        //                            break;

        //                    }
        //                    break;
        //                case DialogResult.No:
        //                    e.Cancel = true;
        //                    break;
        //            }
        //        }
        //    }

        //    private void buttonQuayVe_Click(object sender, EventArgs e)
        //    {
        //        //phục hồi các ghế không mua nữa
        //        if (dataGridViewVe.Rows.Count - 1 > 0)
        //        {
        //            Table<CTGHE> ctg = db.GetTable<CTGHE>();
        //            for (int i = 0; i < dataGridViewVe.Rows.Count - 1; i++)
        //            {
        //                CTGHE ctgtemp = ctg.Single(p => ((p.MaHangVe == dataGridViewVe.Rows[i].Cells[1].Value.ToString())
        //                    && (p.MaChuyenBay == dataGridViewVe.Rows[i].Cells[0].Value.ToString())));
        //                ctgtemp.SoGheDat--;
        //                ctgtemp.SoGheTrong++;
        //            }
        //            db.SubmitChanges();
        //            dataGridViewVe.Rows.Clear();
        //        }
        //        this.Close();
        //    }

        //    private void buttonThem_Click(object sender, EventArgs e)
        //    {
        //        comboBoxMaChuyenBay.Enabled = true;
        //        UpdateComboboxMaChuyenBay();
        //        ButtonLuuVe.Enabled = true;
        //        buttonThemVe.Enabled = false;
        //    }

        //    private string AutoMaPhieuDat()
        //    {
        //        Table<PHIEUDATCHO> phieudatchos = db.GetTable<PHIEUDATCHO>();
        //        bool flag = true;
        //        int k = 0;
        //        while (flag)
        //        {
        //            var bang = from e in phieudatchos
        //                       where (e.MaPhieuDat == CreateMaPhieu(k))
        //                       select e;
        //            if (bang.Count() > 0)
        //                k++;
        //            else
        //                flag = false;
        //        }
        //        return CreateMaPhieu(k);

        //    }
        //    private string CreateMaPhieu(int k)
        //    {
        //        if (k >= 0 && k <= 9)
        //            return ("PD00" + k.ToString());
        //        if (k >= 10 && k <= 99)
        //            return ("PD0" + k.ToString());
        //        if (k >= 100 && k <= 999)
        //            return ("PD" + k.ToString());
        //        return "99999";

        //    }
        //    private string AutoMaMaVe()
        //    {

        //        Table<CTPHIEUDATCHO> ctphieus = db.GetTable<CTPHIEUDATCHO>();
        //        bool flag = true;
        //        int k = 0;
        //        while (flag)
        //        {
        //            int i = 0;
        //            for (; i < dataGridViewVe.Rows.Count; i++)
        //            {
        //                if (!dataGridViewVe.Rows[i].IsNewRow)
        //                {
        //                    if (dataGridViewVe.Rows[i].Cells[3].Value.ToString() == CreateMaVe(k))
        //                        break;
        //                }
        //            }
        //            if (i >= dataGridViewVe.Rows.Count)
        //            {
        //                var bang = from e in ctphieus
        //                           where (e.MaVe == CreateMaVe(k))
        //                           select e;
        //                if (bang.Count() > 0)
        //                    k++;
        //                else
        //                    flag = false;
        //            }
        //            else
        //                k++;

        //        }
        //        return CreateMaVe(k);

        //    }
        //    private string CreateMaVe(int k)
        //    {
        //        if (k >= 0 && k <= 9)
        //            return ("MV00" + k.ToString());
        //        if (k >= 10 && k <= 99)
        //            return ("MV0" + k.ToString());
        //        if (k >= 100 && k <= 999)
        //            return ("MV" + k.ToString());
        //        return "99999";

        //    }
        //    private bool CheckRules()
        //    {
        //        if (textBoxHoTenDatCho.Text == "" && textBoxCMNDDatCho.Text == "" && textBoxSDTDatCho.Text == "")
        //        {
        //            MessageBox.Show("Không thể để trống thông tin người đặt chổ!");
        //            return false;
        //        }
        //        if (!_rule.IsNNumber(textBoxCMNDDatCho.Text) && (textBoxCMNDDatCho.Text.Length < 9 || textBoxCMNDDatCho.Text.Length > 12))
        //        {
        //            MessageBox.Show("Số CMND phải là 1 số có từ 9 tới 12 chử số!");
        //            return false;
        //        }
        //        if (!_rule.IsNNumber(textBoxSDTDatCho.Text) && (textBoxSDTDatCho.Text.Length < 10 || textBoxSDTDatCho.Text.Length > 12))
        //        {
        //            MessageBox.Show("Số điện thoại là 1 số có từ 10 tới 12 chử số!");
        //            return false;
        //        }
        //        if (dataGridViewVe.Rows.Count - 1 <= 0)
        //        {
        //            MessageBox.Show("ít nhất phải mua một vé!");
        //            return false;
        //        }
        //        return true;
        //    }

        //    private void buttonPhieuMoi_Click(object sender, EventArgs e)
        //    {
        //        buttonXoa.Enabled = true;
        //        textBoxCMNDDatCho.Enabled = true;
        //        textBoxSDTDatCho.Enabled = true;
        //        textBoxHoTenDatCho.Enabled = true;
        //        textBoxMaPhieuDatCho.Text = AutoMaPhieuDat();
        //        buttonThemVe.Enabled = true;
        //        ButtonLuu.Enabled = true;
        //        buttonPhieuMoi.Enabled = false;
        //        buttonXuatFile.Enabled = true;
        //    }
        //    private void UpdateComboboxMaChuyenBay()
        //    {
        //        comboBoxMaChuyenBay.Items.Clear();
        //        comboBoxMaChuyenBay.ResetText();
        //        Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
        //        var temp = from e in chuyenbays
        //                   where (e.NgayKhoiHanh.Value > DateTime.Now)
        //                   select e;

        //        if (temp.Count() > 0)
        //            foreach (var k in temp)
        //            {
        //                if (!HetCho(k.MaChuyenBay))
        //                    comboBoxMaChuyenBay.Items.Add(k.MaChuyenBay);
        //            }

        //    }

        //    private bool HetCho(string _machuyenbay)
        //    {
        //        Table<CTGHE> ctg = db.GetTable<CTGHE>();
        //        var temp = from e in ctg
        //                   where (e.MaChuyenBay == _machuyenbay && e.SoGheDat < e.SoGhe)
        //                   select e;
        //        if (temp.Count() > 0)
        //            return false;
        //        return true;
        //    }

        //    private void comboBoxMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        comboBoxMaHangVe.Enabled = true;
        //        comboBoxMaHangVe.ResetText();
        //        comboBoxMaHangVe.Items.Clear();
        //        Table<CTGHE> ctg = db.GetTable<CTGHE>();
        //        var temp = from k in ctg
        //                   where (k.MaChuyenBay == comboBoxMaChuyenBay.Text &&
        //                    k.SoGheDat < k.SoGhe)
        //                   select k;
        //        foreach (var m in temp)
        //        {
        //            comboBoxMaHangVe.Items.Add(m.MaHangVe);
        //        }
        //    }

        //    private void ButtonLuuVe_Click(object sender, EventArgs e)
        //    {
        //        if (comboBoxMaHangVe.Text != "")
        //        {
        //            try
        //            {
        //                //tính đơn giá
        //                Table<HANGVE> hangves = db.GetTable<HANGVE>();
        //                HANGVE hangvetemp = hangves.Single(p => p.MaHangVe == comboBoxMaHangVe.Text);
        //                Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
        //                CHUYENBAY chuyenbaytemp = chuyenbays.Single(p => p.MaChuyenBay == comboBoxMaChuyenBay.Text);
        //                string giatien = (chuyenbaytemp.DonGia + chuyenbaytemp.DonGia * hangvetemp.TiLeDonGia).ToString();
        //                dataGridViewVe.Rows.Add
        //                    (
        //                        comboBoxMaChuyenBay.Text,
        //                        comboBoxMaHangVe.Text,
        //                        giatien,
        //                        AutoMaMaVe()
        //                    );

        //                Table<CTGHE> ctg = db.GetTable<CTGHE>();
        //                CTGHE ctgtemp = ctg.Single(p => ((p.MaHangVe == comboBoxMaHangVe.Text) && (p.MaChuyenBay == comboBoxMaChuyenBay.Text)));
        //                ctgtemp.SoGheDat++;
        //                ctgtemp.SoGheTrong--;
        //                db.SubmitChanges();
        //                ButtonLuuVe.Enabled = false;
        //                buttonThemVe.Enabled = true;
        //                comboBoxMaChuyenBay.Enabled = false;
        //                comboBoxMaHangVe.Enabled = false;
        //                comboBoxMaHangVe.ResetText();
        //            }
        //            catch (SqlException)
        //            {
        //                MessageBox.Show("Không thể lưu vé trên, lỗi CSDL!");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không thể để trống mã hạng vé!");
        //        }

        //    }

        //    private void ButtonLuu_Click(object sender, EventArgs e)
        //    {
        //        if (CheckRules())
        //        {
        //            try
        //            {
        //                //lưu thông tin phiếu đặt
        //                Table<PHIEUDATCHO> pdc = db.GetTable<PHIEUDATCHO>();
        //                PHIEUDATCHO k = new PHIEUDATCHO();
        //                k.MaPhieuDat = textBoxMaPhieuDatCho.Text;
        //                k.NguoiDat = textBoxHoTenDatCho.Text;
        //                k.NgayDat = DateTime.Now;
        //                k.CMND = textBoxCMNDDatCho.Text;
        //                k.DienThoai = textBoxSDTDatCho.Text;
        //                pdc.InsertOnSubmit(k);
        //                db.SubmitChanges();
        //            }
        //            catch (SqlException)
        //            {
        //                MessageBox.Show("không thể lưu thông tin phiếu xuống CSDL!");
        //            }

        //            //lưu thông tin vé đặt (chi tiết phiếu đặt)
        //            try
        //            {
        //                Table<CTPHIEUDATCHO> ctp = db.GetTable<CTPHIEUDATCHO>();
        //                for (int i = 0; i < dataGridViewVe.Rows.Count - 1; i++)
        //                {
        //                    CTPHIEUDATCHO m = new CTPHIEUDATCHO();
        //                    m.MaChuyenBay = dataGridViewVe.Rows[i].Cells[0].Value.ToString();
        //                    m.MaPhieuDat = textBoxMaPhieuDatCho.Text;
        //                    m.MaVe = dataGridViewVe.Rows[i].Cells[3].Value.ToString();
        //                    m.HangVe = dataGridViewVe.Rows[i].Cells[1].Value.ToString();
        //                    m.GiaTien = Convert.ToInt16(dataGridViewVe.Rows[i].Cells[2].Value.ToString());
        //                    m.LayVe = 0;
        //                    ctp.InsertOnSubmit(m);
        //                    db.SubmitChanges();
        //                }
        //            }
        //            catch (SqlException)
        //            {

        //                MessageBox.Show("Không thể lưu thông tin của vé xuống database!");
        //            }

        //            textBoxCMNDDatCho.ResetText();
        //            textBoxHoTenDatCho.ResetText();
        //            textBoxMaPhieuDatCho.ResetText();
        //            textBoxSDTDatCho.ResetText();
        //            textBoxCMNDDatCho.Enabled = false;
        //            textBoxHoTenDatCho.Enabled = false;
        //            textBoxMaPhieuDatCho.Enabled = false;
        //            textBoxSDTDatCho.Enabled = false;

        //            comboBoxMaChuyenBay.ResetText();
        //            comboBoxMaHangVe.ResetText();
        //            comboBoxMaHangVe.Enabled = false;
        //            comboBoxMaChuyenBay.Enabled = false;

        //            buttonThemVe.Enabled = false;
        //            ButtonLuuVe.Enabled = false;
        //            ButtonLuu.Enabled = false;
        //            dataGridViewVe.Rows.Clear();
        //            buttonXoa.Enabled = false;
        //            buttonPhieuMoi.Enabled = true;
        //            buttonXuatFile.Enabled = false;
        //        }
        //    }

        //    private void buttonXoa_Click(object sender, EventArgs e)
        //    {
        //        if (dataGridViewVe.Rows.Count - 1 > 0)
        //        {
        //            Table<CTGHE> ctg = db.GetTable<CTGHE>();
        //            for (int i = 0; i < dataGridViewVe.Rows.Count - 1; i++)
        //            {
        //                CTGHE ctgtemp = ctg.Single(p => ((p.MaHangVe == dataGridViewVe.Rows[i].Cells[1].Value.ToString())
        //                    && (p.MaChuyenBay == dataGridViewVe.Rows[i].Cells[0].Value.ToString())));
        //                ctgtemp.SoGheDat--;
        //                ctgtemp.SoGheTrong++;
        //            }
        //            db.SubmitChanges();
        //            dataGridViewVe.Rows.Clear();
        //        }
        //    }

        //    private void buttonXuatFile_Click(object sender, EventArgs e)
        //    {
        //        if (dataGridViewVe.Rows.Count - 1 > 0)
        //        {
        //            ExportFile temp = new ExportFile();
        //            temp.ExportExcel(dataGridViewVe);
        //        }
        //        else
        //            MessageBox.Show("Không có vé nào để xuất!");

        //    }
        
        #endregion

//#region new_code_ author:nhan
//#endregion
    public DatCho()
    {
        InitializeComponent();
    }

    DatchoBLL _datchobll = new DatchoBLL();
    private void DatCho_Load(object sender, EventArgs e)
    {
        not_enable_all_button();
        //add item combobox macb
        comboBox_MaChuyenBay.Items.Clear();
        comboBox_MaChuyenBay.Items.AddRange(_datchobll.lay_danh_sach_ma_CB());
        // load datagridview
        dataGridViewVe.DataSource = _datchobll.lay_danh_sach_khi_load_form();
        //xoa tu dong dat ve ma khong mua ve, cach ngay bay 1 ngay
        int t=_datchobll.xoa_dat_cho_cach_hom_nay_1_ngay_chua_thanh_toan();
        if(t!=0)
            MessageBox.Show("Đã xóa"+t+" phiếu đặt không thanh toán và cận ngày bay!");// chut sua datagril view_ click cell
    }
    public void not_enable_all_button()
    {
        button_taomoi.Enabled=true;
        button_sua.Enabled=false;
        Button_luu.Enabled=false;
        button_xoa.Enabled= false;
        button_thoat.Enabled=true;
        
    }
    public void clear_textbox_all()
    {
        textBox_CMNDDatCho.Clear();
        textBox_cmndhk.Clear();
        textBox_dienthoaihk.Clear();
        textBox_giave.Clear();
        textBox_gioxuatphat.Clear();
        textBox_MaPhieuDatCho.Clear();
        textBox_mave.Clear();
        textBox_ngaybay.Clear();
        textBox_SBden.Clear();
        textBox_SBdi.Clear();
        textBox_SDTDatCho.Clear();
        textBox_tenhk.Clear();
        textBox_tenngdat.Clear();
        textBox_tgianbay.Clear();
        textBox_tenhangve.Clear();
        comboBox_MaChuyenBay.Text = null;
        comboBox_MaHangVe.Text = null;
        //
        label_CMND_datve.Visible = false;
        label_macb.Visible = false;
        label_mahv.Visible = false;
        label_sdt_datve.Visible = false;
        label_socmndhk.Visible = false;
        label_sodthk.Visible = false;
        label_tenhk.Visible = false;
        label_tenngdat.Visible = false;
    }


#region xu_ly_button
    private void button_taomoi_Click(object sender, EventArgs e)
    {
        //enable button
        button_taomoi.Enabled = true;
        button_sua.Enabled = false;
        Button_luu.Enabled = true;
        button_xoa.Enabled = false;
        comboBox_MaHangVe.Enabled = true;
        comboBox_MaChuyenBay.Enabled = true;
        //xoa du lieu tren cac o nhap lieu
        clear_textbox_all();
        //gan ma phieu dat
        textBox_MaPhieuDatCho.Text = _datchobll.tao_ma_phieu_dat();
        // gan ma ve
        textBox_mave.Text = _datchobll.tao_ma_ve();

    }

    private void button_sua_Click(object sender, EventArgs e)
    {
        // ktra hop le
        if (ktra_du_lieu_truoc_khi_luu_hoac_update() == true)
        {
            // ktra coi ve da duoc lay chua
            if (int.Parse(_datchobll.lay_da_lay_ve(textBox_mave.Text)) == 0)
            {
                // cap nhat csdl
                _datchobll.cap_nhat_(textBox_mave.Text, comboBox_MaChuyenBay.Text, textBox_tenhk.Text, textBox_cmndhk.Text, textBox_dienthoaihk.Text,
                    comboBox_MaHangVe.Text, textBox_giave.Text, textBox_MaPhieuDatCho.Text, textBox_tenngdat.Text, textBox_CMNDDatCho.Text, textBox_SDTDatCho.Text);
                // load lại datagridview
                dataGridViewVe.DataSource = _datchobll.lay_danh_sach_khi_load_form();
            }
            else
            {
                MessageBox.Show("Vé đã bán không thể sửa thông tin trên phiếu đặt");
            }
        }
    }

    private void button_xoa_Click(object sender, EventArgs e)
    {
        // ktra data hop le
        if(ktra_du_lieu_truoc_khi_luu_hoac_update()==true)
        {
            // xoa csdl
            _datchobll.xoa(textBox_MaPhieuDatCho.Text,textBox_mave.Text,comboBox_MaChuyenBay.Text,comboBox_MaHangVe.Text);
            // load lại datagridview
            dataGridViewVe.DataSource = _datchobll.lay_danh_sach_khi_load_form();
            // clean textbox nhap
            clear_textbox_all();
        }
    }

    private void Button_luu_Click(object sender, EventArgs e)
    {
        
        //
        if(ktra_du_lieu_truoc_khi_luu_hoac_update()==true)
        {
            // enable button
            button_taomoi.Enabled = true;
            button_sua.Enabled = true;
            Button_luu.Enabled = false;
            button_xoa.Enabled = false;
            // luu xuong csdl
            _datchobll.luu(textBox_MaPhieuDatCho.Text, textBox_mave.Text, comboBox_MaChuyenBay.Text, comboBox_MaHangVe.Text,
                textBox_giave.Text, textBox_tenngdat.Text, textBox_CMNDDatCho.Text, textBox_SDTDatCho.Text, textBox_tenhk.Text, textBox_cmndhk.Text, textBox_dienthoaihk.Text);
            //load lại datagridview
            dataGridViewVe.DataSource = _datchobll.lay_danh_sach_khi_load_form();
            // not_enable 2 combobox
            comboBox_MaHangVe.Enabled = false;
            comboBox_MaChuyenBay.Enabled = false;
        }
    }

    private void button_thoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }
#endregion

#region kiem_tra_thong_tin_hop_le_nguoi_mua_ve[su_kien_update_text_cac_o_nhap_lieu]
    private void textBox_tenhk_TextChanged(object sender, EventArgs e)
    {
        if (textBox_tenhk.Text.Length > 50)
        {
            label_tenhk.Visible = true;
        }
        else
        {
            label_tenhk.Visible = false;
        }
    }

    private void textBox_scmndhk_TextChanged(object sender, EventArgs e)
    {
        if (textBox_cmndhk.Text.Length != 10)
        {
            label_socmndhk.Visible = true;
        }
        else
        {
            try
            {
                long t = long.Parse(textBox_cmndhk.Text);
                //khong loi 
                label_socmndhk.Visible = false;
            }
            catch
            {
                label_socmndhk.Visible = true;
                
            }


        }
    }

    private void textBox_sodthk_TextChanged(object sender, EventArgs e)
    {
        if (textBox_dienthoaihk.Text.Length > 11 || textBox_dienthoaihk.Text.Length < 10)
        {
            label_sodthk.Visible = true;
        }
        else
        {

            try
            {
                long t = long.Parse(textBox_dienthoaihk.Text);
                //khong loi 
                label_sodthk.Visible = false;

            }
            catch
            {
                label_sodthk.Visible = true;
                
            }


        }
    }

    private void textBox_tenngmua_TextChanged(object sender, EventArgs e)
    {
        if (textBox_tenngdat.Text.Length > 50)
        {
            label_tenngdat.Visible = true;
        }
        else
        {
            label_tenngdat.Visible = false;
        }
    }

    private void textBox_scmndngmua_TextChanged(object sender, EventArgs e)
    {
        if (textBox_CMNDDatCho.Text.Length != 10)
        {
            label_CMND_datve.Visible = true;
             
        }
        else
        {
            try
            {
                long t = long.Parse(textBox_CMNDDatCho.Text);
                //khong loi 
                label_CMND_datve.Visible = false;
            }
            catch
            {
                label_CMND_datve.Visible = true;
                 
            }


        }
    }

    private void textBox_sodtngmua_TextChanged(object sender, EventArgs e)
    {
        if (textBox_SDTDatCho.Text.Length > 11 || textBox_SDTDatCho.Text.Length < 10)
        {
            label_sdt_datve.Visible = true;
             
        }
        else
        {

            try
            {
                long t = long.Parse(textBox_SDTDatCho.Text);
                //khong loi 
                label_sdt_datve.Visible = false;

            }
            catch
            {
                label_sdt_datve.Visible = true;
                 // load thong tin hang ve
                load_thong_tin_hang_ve();
            }


        }
    }

    private void comboBox_MaChuyenBay_update(object sender, EventArgs e)
    {
        if (comboBox_MaChuyenBay.Items.Contains(comboBox_MaChuyenBay.Text) == false)
        {
            if (this.Visible == true)
            {
                label_macb.Visible = true;
            }

        }
        else
        {
            // not enable label bao loi
            label_macb.Visible = false;
            // add item combobox hangve
            comboBox_MaHangVe.Items.Clear();
            comboBox_MaHangVe.Items.AddRange(_datchobll.lay_danh_sach_ma_hang_ve(comboBox_MaChuyenBay.Text));
            // load thong tin cb
            load_thong_tin_cb();
            // 
        }
    }

    private void comboBox_MaHangVe_update(object sender, EventArgs e)
    {
        if (comboBox_MaHangVe.Items.Contains(comboBox_MaHangVe.Text) == false)
        {
            if (this.Visible == true)
            {

                label_mahv.Visible = true;
            }

        }
        else
        {
            label_mahv.Visible = false;
            //load thong tin ten hang ve va gia ca
            load_thong_tin_hang_ve();
        }
    }

    #region load_thong_tinCB_va_thong_tin_hang_ve_gia_ca
    public void load_thong_tin_cb()
    {
        textBox_SBdi.Text = _datchobll.lay_thong_tin_san_bay_di(comboBox_MaChuyenBay.Text);
        textBox_SBden.Text = _datchobll.lay_thong_tin_san_bay_den(comboBox_MaChuyenBay.Text);
        textBox_tgianbay.Text = _datchobll.lay_thoi_gian_bay(comboBox_MaChuyenBay.Text);
        textBox_ngaybay.Text = _datchobll.lay_ngay_khoi_hanh(comboBox_MaChuyenBay.Text);
        textBox_gioxuatphat.Text = _datchobll.lay_gio_khoi_hanh(comboBox_MaChuyenBay.Text);
    }
    public void load_thong_tin_hang_ve()
    {
        
        textBox_giave.Text=_datchobll.lay_gia_hang_ve(comboBox_MaChuyenBay.Text,comboBox_MaHangVe.Text);
        textBox_tenhangve.Text = _datchobll.lay_ten_hang_ve(comboBox_MaHangVe.Text);
    }

    #endregion

#endregion

#region ktra_du_lieu_truoc_khi_luu_hoac_update
    public bool ktra_du_lieu_truoc_khi_luu_hoac_update()
    {

        if (label_CMND_datve.Visible == true || label_macb.Visible == true || label_mahv.Visible == true
            || label_sdt_datve.Visible == true || label_socmndhk.Visible == true || label_sodthk.Visible == true
            || label_tenhk.Visible==true||label_tenngdat.Visible==true)
        {
            MessageBox.Show("Lỗi ở những ô có thông báo 'lỗi'!");
            return false;
        }
        
        if (textBox_tenngdat.Text.Trim().Length == 0 || textBox_CMNDDatCho.Text.Trim().Length == 0 || textBox_SDTDatCho.Text.Trim().Length == 0
            || textBox_tenhk.Text.Trim().Length == 0 || textBox_cmndhk.Text.Trim().Length == 0 || textBox_dienthoaihk.Text.Trim().Length == 0 ||
            comboBox_MaChuyenBay.Text.Trim().Length == 0 || comboBox_MaHangVe.Text.Trim().Length == 0)
        {
            MessageBox.Show("Các ô nhập không thể chừa trống!");
            return false;
        }

        //ktra thong tin ngay chuyen bay phai lon hon ngay hien tai 
        DateTime t = DateTime.ParseExact(textBox_ngaybay.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime now = DateTime.Now;
        now=now.AddDays(+_datchobll.lay_quy_dinh_han_chot_dat_ve());
        if (t.Day < now.Day && t.Month < now.Month && t.Year < now.Year)
        {
            MessageBox.Show("Không thể sửa phiếu đặt hoặc tạo mới, phiếu đặt phải được tạo trước khi cât cánh " + _datchobll.lay_quy_dinh_han_chot_dat_ve() + " ngày");
            return false;
        }

        //ktra con ve hay khong
        if (_datchobll.lay_so_ghe_trong(comboBox_MaChuyenBay.Text, comboBox_MaHangVe.Text) < 1)
        {
            MessageBox.Show("Chuyến bay với hạng vé này đã hết chỗ!");
            return false;
        }
        return true;
    }

    #endregion

#region datagrid_view
    private void dataGridViewVe_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int row = e.RowIndex;
        // clean textbox
        if (row != -1)
        {
            clear_textbox_all();
            //
            //
            comboBox_MaHangVe.Enabled = false;
            comboBox_MaChuyenBay.Enabled = false;
            // set gia tri
            textBox_CMNDDatCho.Text = dataGridViewVe.Rows[row].Cells[2].Value.ToString();
            textBox_cmndhk.Text = dataGridViewVe.Rows[row].Cells[8].Value.ToString();
            textBox_dienthoaihk.Text = dataGridViewVe.Rows[row].Cells[9].Value.ToString();
            textBox_mave.Text = dataGridViewVe.Rows[row].Cells[6].Value.ToString();
            textBox_SDTDatCho.Text = dataGridViewVe.Rows[row].Cells[3].Value.ToString();
            textBox_tenhk.Text = dataGridViewVe.Rows[row].Cells[7].Value.ToString();
            textBox_tenngdat.Text = dataGridViewVe.Rows[row].Cells[1].Value.ToString();
            comboBox_MaChuyenBay.Text = dataGridViewVe.Rows[row].Cells[4].Value.ToString();
            comboBox_MaHangVe.Text = dataGridViewVe.Rows[row].Cells[5].Value.ToString();
            textBox_MaPhieuDatCho.Text = dataGridViewVe.Rows[row].Cells[0].Value.ToString();
            // enable button
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_taomoi.Enabled = true;
            Button_luu.Enabled = false;
        }
    }
#endregion

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

}

}
