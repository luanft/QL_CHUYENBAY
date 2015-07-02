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
using MainForm;
using System.Data.Linq;
using System.Data.SqlClient;


namespace MainForm
{
    #region Struct Region
    public struct TempBuffer
    {
        public TempBuffer(string _machuyen, string _matuyen, string _thoigianbay,
            string _ngaykhoihanh, string _giokhoihanh, string _dongia)
        {
            MaCB = _machuyen;
            MaTB = _matuyen;
            TGbay = _thoigianbay;
            NgayKH = _ngaykhoihanh;
            GioKH = _giokhoihanh;
            DonG = _dongia;
        }
        string MaCB;
        public string MaChuyenBay
        {
            get { return MaCB; }
            set { MaCB = value; }
        }
        string MaTB;
        public string MaTuyenBay
        {
            get { return MaTB; }
            set { MaTB = value; }
        }
        string TGbay;
        public string ThoiGianBay
        {
            get { return TGbay; }
            set { TGbay = value; }
        }
        string NgayKH;
        public string NgayKhoiHanh
        {
            get { return NgayKH; }
            set { NgayKH = value; }
        }
        string GioKH;
        public string GioKhoiHanh
        {
            get { return GioKH; }
            set { GioKH = value; }
        }
        string DonG;
        public string DonGia
        {
            get { return DonG; }
            set { DonG = value; }
        }
    }
    public struct sanbayTG
    {
        int ThoiGianDung;
        string GhiChu;
        string MaSanBay;
        public sanbayTG(string _masanbay, int _thoigiandung, string _ghichu)
        {
            this.ThoiGianDung = _thoigiandung;
            this.GhiChu = _ghichu;
            this.MaSanBay = _masanbay;
        }
        public int TgDung
        {
            get { return this.ThoiGianDung; }
            set { this.ThoiGianDung = value; }
        }
        public string MaSB
        {
            get { return this.MaSanBay; }
            set { this.MaSanBay = value; }
        }
        public string Ghchu
        {
            get { return this.GhiChu; }
            set { this.GhiChu = value; }
        }
    }
    public struct ctghe
    {
        string mahangve;
        int soghe;
        public ctghe(string _mahangve, int _soghe)
        {
            mahangve = _mahangve;
            soghe = _soghe;
        }
        public string MaHangVe
        {
            get { return mahangve; }
            set { mahangve = value; }
        }
        public int SoGhe
        {
            get { return soghe; }
            set { soghe = value; }
        }
    }
    public struct ttchuyenbay
    {
        string MC;
        public string MaChuyen
        {
            get { return MC; }
            set { MC = value; }
        }
        string MT;
        public string MaTuyen
        {
            get { return MT; }
            set { MT = value; }
        }
        string TGB;
        public string ThoiGianBay
        {
            get { return TGB; }
            set { TGB = value; }
        }
        string GKH;
        public string GioKhoiHanh
        {
            get { return GKH; }
            set { GKH = value; }
        }
        string NKH;
        public string NgayKhoiHanh
        {
            get { return NKH; }
            set { NKH = value; }
        }
        string DG;
        public string DonGia
        {
            get { return DG; }
            set { DG = value; }
        }
        public ttchuyenbay(string _machuyen, string _matuyen, string _thoigianbay,string _giokhoihanh, string _ngaykhoihanh, string _dongia)
        {
            MC = _machuyen;
            MT = _matuyen;
            TGB = _thoigianbay;
            GKH = _giokhoihanh;
            NKH = _ngaykhoihanh;
            DG = _dongia;
        }
    }
    #endregion
    public partial class ThemLichChuyenBay : Form
    {
        BusinessLogicLayer.ThemChuyenBayBLL bll =new BusinessLogicLayer.ThemChuyenBayBLL();
        public static string LICHCHUYENBAY = "LICHCHUYENBAY";
        private string parentForm;
        bool isDonGiaValid;
        bool isThoiGianValid;
        bool isNgayKhoiHanhValid;
        bool IsSelectOneRow = false;
        
        QLCBRules _rule = new QLCBRules();

        //private QLCBDataContext db = new QLCBDataContext();
        List<thongtinCB> ThongTinSBTG = new List<thongtinCB>();
        List<thongtinHV> ThongTinHV = new List<thongtinHV>();
        ttchuyenbay chuyenbaytemp = new ttchuyenbay();
        thongtinCB sbTGtemp = new thongtinCB();
        thongtinHV hvTemp = new thongtinHV();
        // định nghĩa hàm update cbb Mã tuyến bay
        public void updateCbbMaTuyenBay()
        {
            InitTuyenBay();
            // cập nhật cbbMaTuyenBay
        }
        public ThemLichChuyenBay()
        {
            KeyPreview = true;
            InitializeComponent();
            //resetState();
            defaultComponentState();
            InitTuyenBay();
            InitComboboxHangVe();
            // AutoMaChuyenBay();
            textBoxMaChuyenBay.Text = bll.LayMaChuyenBayTiepTheo();
            
            Column1.ReadOnly = true;
            Column2.ReadOnly = true;
            Column3.ReadOnly = true;
            Column4.ReadOnly = true;
            Column5.ReadOnly = true;
            Column6.ReadOnly = true;

        }
        private void LichChuyenBay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (dataGridViewChuyenBay.RowCount > 1)
                {
                    switch (MessageBox.Show(this, "Có dữ liệu chưa lưu! Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            e.Cancel = false;
                            //                         if (FormManager.CurrentTuyenBay != null)
                            //                             FormManager.CurrentTuyenBay.BeCalledByForm = "MAINFORM";
                            //                         FormManager.CurrentLichChuyenBay = null;
                            break;
                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                    }
                }
                
            }
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            //Đóng cả chương trình trong form này không phù hợp
            /*switch (MessageBox.Show(this, "Bạn có muốn thoát khỏi chương trình không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }*/
            this.Close();
        }
              
        private void buttonLuuVaThoat_Click(object sender, EventArgs e)
        {
            try
            {
                //lưu thông tin chuyến bay xuống CSDL
                //Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
                for (int i = 0; i < dataGridViewChuyenBay.Rows.Count - 1; i++)
                {             
                        #region comment
                        // Thay dô?i do code cu~ su? du?ng linQ
                        /*CHUYENBAY k = new CHUYENBAY();
                        k.MaChuyenBay = dataGridViewChuyenBay.Rows[i].Cells[0].Value.ToString();
                        k.MaTuyenBay = dataGridViewChuyenBay.Rows[i].Cells[1].Value.ToString();
                        k.ThoiGianBay = Convert.ToInt16(dataGridViewChuyenBay.Rows[i].Cells[2].Value.ToString());
                        k.NgayKhoiHanh = Convert.ToDateTime(dataGridViewChuyenBay.Rows[i].Cells[3].Value.ToString());
                        k.GioKhoiHanh = ToDateTime(dataGridViewChuyenBay.Rows[i].Cells[4].Value.ToString());
                        k.DonGia = Convert.ToDouble(dataGridViewChuyenBay.Rows[i].Cells[5].Value.ToString());
                        chuyenbays.InsertOnSubmit(k);*/
                        #endregion

                        string MaChuyenBay = dataGridViewChuyenBay.Rows[i].Cells[0].Value.ToString();
                        string MaTuyenBay = dataGridViewChuyenBay.Rows[i].Cells[1].Value.ToString();
                        int ThoiGianBay = Convert.ToInt16(dataGridViewChuyenBay.Rows[i].Cells[2].Value.ToString());
                        string NgayKhoiHanh = dataGridViewChuyenBay.Rows[i].Cells[3].Value.ToString();
                        string GioKhoiHanh = dataGridViewChuyenBay.Rows[i].Cells[4].Value.ToString();
                        double DonGia = Convert.ToDouble(dataGridViewChuyenBay.Rows[i].Cells[5].Value.ToString());
                        bll.ThemChuyenBay(MaChuyenBay,MaTuyenBay, ThoiGianBay,DonGia, NgayKhoiHanh, GioKhoiHanh);
                        //db.SubmitChanges();                    
                }

                //Table<SANBAYTRUNGGIAN> sanbaytrunggians = db.GetTable<SANBAYTRUNGGIAN>();
                for (int i = 0; i < ThongTinSBTG.Count; i++)
                {

                    for (int j = 0; j < ThongTinSBTG[i].ListSBTG.Count; j++)
                    {
                        #region comment
                        // Thay dô?i do code cu~ su? du?ng linQ
                        /*SANBAYTRUNGGIAN k = new SANBAYTRUNGGIAN();
                        k.MaChuyenBay = ThongTinSBTG[i].MaChuyenBay;
                        k.MaSanBayTrungGian = ThongTinSBTG[i].ListSBTG[j].MaSB;
                        k.ThoiGianDung = ThongTinSBTG[i].ListSBTG[j].TgDung;
                        k.GhiChu = ThongTinSBTG[i].ListSBTG[j].Ghchu;*/
                        //sanbaytrunggians.InsertOnSubmit(k);
                        #endregion

                        string MaChuyenBay = ThongTinSBTG[i].MaChuyenBay;
                        string MaSanBayTrungGian= ThongTinSBTG[i].ListSBTG[j].MaSB;
                        int ThoiGianDung=ThongTinSBTG[i].ListSBTG[j].TgDung;
                        string GhiChu = ThongTinSBTG[i].ListSBTG[j].Ghchu;
                        bll.ThemSanBayTrungGian(MaChuyenBay, MaSanBayTrungGian, ThoiGianDung, GhiChu);
                        //db.SubmitChanges();
                    }
                }
                //Table<CTGHE> chitietghes = db.GetTable<CTGHE>();
                for (int i = 0; i < ThongTinHV.Count; i++)
                {

                    for (int j = 0; j < ThongTinHV[i].ListTTHV.Count; j++)
                    {

                        #region comment
                        // Thay dô?i do code cu~ su? du?ng linQ
                        /*CTGHE k = new CTGHE();
                        k.MaChuyenBay = ThongTinHV[i].MaChuyenBay;
                        k.MaHangVe = ThongTinHV[i].ListTTHV[j].MaHangVe;
                        k.SoGhe = ThongTinHV[i].ListTTHV[j].SoGhe;
                        k.SoGheDat = 0;
                        k.SoGheTrong = ThongTinHV[i].ListTTHV[j].SoGhe;

                        chitietghes.InsertOnSubmit(k);*/
                        #endregion
                        string MaChuyenBay = ThongTinHV[i].MaChuyenBay;
                        string MaHangVe = ThongTinHV[i].ListTTHV[j].MaHangVe;
                        int SoGhe = ThongTinHV[i].ListTTHV[j].SoGhe;
                        bll.ThemLoaiGhe(MaChuyenBay, MaHangVe, SoGhe);
                        //db.SubmitChanges();
                    }
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show("Không thể lưu thông tin chuyến bay xuống CSDL!");
            }
            this.Close();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (!CheckRules())
            {
                //MessageBox.Show("Có gì đó sai thì phải :))! ");
                return;
            }

            #region comment
   //if (buttonThem.Text.Equals("Thêm"))
            //{
            //addRecordState();
            
            //dataGridViewChiTietGhe.Enabled = true;
            //}
            //else 
            //resetState();

            //them mot chuyen bay va`o ba?ng datagridView
            //if (isThoiGianValid == false)
            //{
            //    MessageBox.Show("Tho`i gian không ho?p lê?!", "Thông ba´o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (isDonGiaValid == false)
            //{
            //    MessageBox.Show("Ðon gia´ không ho?p lê?!", "Thông ba´o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (isNgayKhoiHanhValid == false)
            //{
            //    MessageBox.Show("Nga`y kho?i ha`nh không lê?!", "Thông ba´o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
   #endregion

            #region Lưu Thông Tin Hạng Vé Và SBTG vào List
            //lưu thông tin hạng vé
            thongtinHV hangvetemp = new thongtinHV(textBoxMaChuyenBay.Text);
            for (int i = 0; i < dataGridViewChiTietGhe.Rows.Count; i++)
            {                                
                    hangvetemp.AddHangVe(
                        dataGridViewChiTietGhe.Rows[i].Cells[0].Value.ToString(),
                        Convert.ToInt16(dataGridViewChiTietGhe.Rows[i].Cells[1].Value.ToString()));
                    dataGridViewChiTietGhe.Rows[i].Cells[1].Value = 0;
            }
            ThongTinHV.Add(hangvetemp);
            
            #endregion
            #region Đưa thông tin chuyến bay lên datagridview
            //dataGridViewChuyenBay
            //dataGridViewChuyenBay.Rows.Remove(dataGridViewChuyenBay.CurrentRow);
            dataGridViewChuyenBay.Rows.Add(
                        textBoxMaChuyenBay.Text,
                        comboBoxMaTuyenBay.Text,
                        textBoxThoiGianBay.Text,
                        dateTimePickerNgayKhoiHanh.Value.ToString(),
                        dateTimePickerGioKhoiHanh.Value.ToString("HH:mm:ss"),
                        textBoxDonGia.Text);
            #endregion
            addRecordState();
            buttonLuu.Enabled = true;
            buttonXoa.Enabled = true;
            //buttonCapNhat.Enabled = false;
            //buttonXoa.Enabled = false;
            //resetState();


        }
        #region bỏ
        // 
//         private void buttonSua_Click(object sender, EventArgs e)
//         {
//             if (buttonSua.Text.Equals("Sửa"))
//             {
//                 //editRecordState();
//                 // sửa dữ liệu vừa thêm
//                 if (CheckRules())
//                 {
//                     //chỉnh lại logic
// 
//                     /* Trước đó đã chọn 1 hàng
//                      * Và các control hiện tại đang bị disable
//                      * Bây giờ nhấn sửa, tất cả sẽ được enable để cho người dùng sửa
//                      */
// 
//                     editRecordState();
// 
//                     /*UpdateSBTG_HV();
//                     dataGridViewChuyenBay.CurrentRow.Cells[0].Value = textBoxMaChuyenBay.Text;
//                     dataGridViewChuyenBay.CurrentRow.Cells[1].Value = comboBoxMaTuyenBay.Text;
//                     dataGridViewChuyenBay.CurrentRow.Cells[2].Value = textBoxThoiGianBay.Text;
//                     dataGridViewChuyenBay.CurrentRow.Cells[3].Value = dateTimePickerNgayKhoiHanh.Value.ToShortDateString();
//                     dataGridViewChuyenBay.CurrentRow.Cells[4].Value = dateTimePickerGioKhoiHanh.Value.ToString("HH:mm:ss");
//                     dataGridViewChuyenBay.CurrentRow.Cells[5].Value = textBoxDonGia.Text;
//                     UpdateComboboxSBTG();*/
// 
//                 }
//             }
//            //hủy sửa
//             //if (buttonSua.Text.Equals("Hủy Sửa"))
//             else
//             {
//                 viewState();                
// 
//                 #region comment
// 
// /*dataGridViewChuyenBay.CurrentRow.Cells[0].Value = chuyenbaytemp.MaChuyen;
//                 dataGridViewChuyenBay.CurrentRow.Cells[1].Value = chuyenbaytemp.MaTuyen;
//                 dataGridViewChuyenBay.CurrentRow.Cells[2].Value = chuyenbaytemp.ThoiGianBay;
//                 dataGridViewChuyenBay.CurrentRow.Cells[3].Value = chuyenbaytemp.NgayKhoiHanh;
//                 dataGridViewChuyenBay.CurrentRow.Cells[4].Value = chuyenbaytemp.GioKhoiHanh;
//                 dataGridViewChuyenBay.CurrentRow.Cells[5].Value = chuyenbaytemp.DonGia;
// 
//                 textBoxMaChuyenBay.Text = chuyenbaytemp.MaChuyen;
//                 comboBoxMaTuyenBay.Text = chuyenbaytemp.MaTuyen;
//                 textBoxThoiGianBay.Text = chuyenbaytemp.ThoiGianBay;
//                 dateTimePickerNgayKhoiHanh.Value = ToDateTime(chuyenbaytemp.NgayKhoiHanh);
//                 dateTimePickerGioKhoiHanh.Value = ToDateTime(chuyenbaytemp.GioKhoiHanh);
//                 textBoxDonGia.Text = chuyenbaytemp.DonGia;
// 
//                 for (int i = 0; i < ThongTinSBTG.Count; i++)
//                 {
//                     if (ThongTinSBTG[i].MaChuyenBay == textBoxMaChuyenBay.Text)
//                     {
//                         ThongTinSBTG.RemoveAt(i);
//                         ThongTinSBTG.Add(sbTGtemp);
//                         dataGridViewSanBayTrungGian.Rows.Clear();
//                         for (int j = 0; j < sbTGtemp.ListSBTG.Count; j++)
//                             dataGridViewSanBayTrungGian.Rows.Add
//                                 (
//                                 sbTGtemp.ListSBTG[j].MaSB,
//                                  sbTGtemp.ListSBTG[j].TgDung,
//                                   sbTGtemp.ListSBTG[j].Ghchu
//                                 );
//                         break;
//                     }
//                 }
//                 for (int i = 0; i < ThongTinHV.Count; i++)
//                 {
//                     if (ThongTinHV[i].MaChuyenBay == textBoxMaChuyenBay.Text)
//                     {
//                         ThongTinHV.RemoveAt(i);
//                         ThongTinHV.Add(hvTemp);
//                         dataGridViewChiTietGhe.Rows.Clear();
//                         for (int j = 0; j < hvTemp.ListTTHV.Count; j++)
//                             dataGridViewChiTietGhe.Rows.Add(
//                                 hvTemp.ListTTHV[j].MaHangVe,
//                                 hvTemp.ListTTHV[j].SoGhe
//                                 );
//                         break;
//                     }
//                 }
//                 UpdateSBTG_HV();
//                 UpdateComboboxSBTG();
//                 ResetTemp();
//                 */
// #endregion
// 
//             }
// 
// 
        //         }
        #endregion
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            
            switch (MessageBox.Show(this, "Bạn có muốn xóa dữ liệu vừa thêm không?", "Cảnh báo!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                case DialogResult.OK:
                    // xóa dữ liệu vừa thêm trước đó;
                    //xóa trên datagridviewchuyenbay
                    //textBoxMaChuyenBay.Text = "";
                    textBoxDonGia.Text = "";
                    comboBoxMaTuyenBay.ResetText();
                    textBoxDonGia.Text = "";
                    textBoxThoiGianBay.Text = "";
                    textBoxSanBayDen.Text = "";
                    textBoxSanBayDi.Text = "";                   
                    for (int i = 0; i < ThongTinHV.Count; i++)
                    {
                        if (ThongTinHV[i].MaChuyenBay == textBoxMaChuyenBay.Text)
                        {
                            ThongTinHV.RemoveAt(i);
                            i--;
                        }
                    }
                    dataGridViewChuyenBay.Rows.Remove(dataGridViewChuyenBay.CurrentRow);
                    foreach (DataGridViewRow row in dataGridViewChuyenBay.SelectedRows)
                        if (!row.IsNewRow)
                            dataGridViewChuyenBay.Rows.Remove(row);
                    if (dataGridViewChuyenBay.RowCount == 0)
                    {
                        buttonLuu.Enabled = false;
                    }
                    //dataGridViewChiTietGhe.Rows.Clear();
                    //dataGridViewSanBayTrungGian.Rows.Clear();
                    
                    //buttonXoa.Enabled = false;
                    textBoxDonGia.Text = "1000000";
                    textBoxThoiGianBay.Text = "120";
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void buttonPhucHoi_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Bạn có muốn phục hồi dữ liệu vừa bị sửa/xóa không?", "Thông báo!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                case DialogResult.OK:
                    // phục hồi lại dữ liệu vừa thao tác trước đó;
                    // phục hồi datagridviewchuyenbay
                    dataGridViewChiTietGhe.Rows.Clear();

                    textBoxMaChuyenBay.Text = chuyenbaytemp.MaChuyen;
                    comboBoxMaTuyenBay.Text = chuyenbaytemp.MaTuyen;
                    textBoxThoiGianBay.Text = chuyenbaytemp.ThoiGianBay;
                    dateTimePickerNgayKhoiHanh.Value = ToDateTime(chuyenbaytemp.NgayKhoiHanh);
                    dateTimePickerGioKhoiHanh.Value = ToDateTime(chuyenbaytemp.GioKhoiHanh);
                    textBoxDonGia.Text = chuyenbaytemp.DonGia;
                    dataGridViewChuyenBay.Rows.Add
                        (
                        chuyenbaytemp.MaChuyen,
                        chuyenbaytemp.MaTuyen,
                        chuyenbaytemp.ThoiGianBay,
                        chuyenbaytemp.NgayKhoiHanh,
                        chuyenbaytemp.GioKhoiHanh,
                        chuyenbaytemp.DonGia
                        );


                    //phục hồi trên thông tin sân bay trung gian và thông tin hạng vé
                    ThongTinHV.Add(hvTemp);
                    ThongTinSBTG.Add(sbTGtemp);
                    for (int i = 0; i < hvTemp.ListTTHV.Count; i++)
                    {
                        dataGridViewChiTietGhe.Rows.Add(
                            hvTemp.ListTTHV[i].MaHangVe,
                            hvTemp.ListTTHV[i].SoGhe);
                    }
                    //buttonPhucHoi.Enabled = false;
                    buttonThem.Enabled = true;
                    ResetTemp();
                    break;
                case DialogResult.Cancel:
                    break;
            }
           // resetState();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
#region comment
//             if (!CheckRules()) return;
//             /*if (isThoiGianValid == false )
//             {
//                 MessageBox.Show("Tho`i gian không ho?p lê?!","Thông ba´o",MessageBoxButtons.OK,MessageBoxIcon.Warning);
//                 return;
//             }
//             if (isDonGiaValid == false)
//             {
//                 MessageBox.Show("Ðon gia´ không ho?p lê?!", "Thông ba´o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                 return;
//             }
//             if (isNgayKhoiHanhValid == false)
//             {
//                 MessageBox.Show("Nga`y kho?i ha`nh không lê?!", "Thông ba´o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                 return;
//             }*/
// 
// 
//             #region Câ?p nhâ?t H?ng Vé Và SBTG vào List
//             //câ?p nhâ?t sân bay trung gian c?a chuy?n bay
//             foreach (thongtinCB cbtg in ThongTinSBTG)
//             {
//                 if (cbtg.MaChuyenBay == textBoxMaChuyenBay.Text)
//                 {
//                     ThongTinSBTG.Remove(cbtg);
//                     break;
//                 }
//             }
//             thongtinCB temp = new thongtinCB(textBoxMaChuyenBay.Text);
//             for (int i = 0; i < dataGridViewSanBayTrungGian.Rows.Count; i++)
//             {
//                 if (!dataGridViewSanBayTrungGian.Rows[i].IsNewRow)
//                 {
//                     temp.AddSBTG(dataGridViewSanBayTrungGian.Rows[i].Cells[0].Value.ToString(),
//                     Convert.ToInt16(dataGridViewSanBayTrungGian.Rows[i].Cells[1].Value.ToString()),
//                     dataGridViewSanBayTrungGian.Rows[i].Cells[2].Value.ToString());
//                 }
//             }
//              //câ?p nhâ?t thông tin h?ng vé
//             foreach(thongtinHV hangve in ThongTinHV)
//             {
//                 if (hangve.MaChuyenBay == textBoxMaChuyenBay.Text)
//                 {
//                     ThongTinHV.Remove(hangve);
//                     break;
//                 }
//             }
//             thongtinHV hangvetemp = new thongtinHV(textBoxMaChuyenBay.Text);
//             for (int i = 0; i < dataGridViewChiTietGhe.Rows.Count; i++)
//             {
//                 if (!dataGridViewChiTietGhe.Rows[i].IsNewRow)
//                 {
//                     hangvetemp.AddHangVe(
//                         dataGridViewChiTietGhe.Rows[i].Cells[0].Value.ToString(),
//                         Convert.ToInt16(dataGridViewChiTietGhe.Rows[i].Cells[1].Value.ToString()));
//                 }
//             }
// 
//             //ThongTinSBTG.Add(temp);
//             //ThongTinHV.Add(hangvetemp);
//             dataGridViewSanBayTrungGian.Rows.Clear();
//             dataGridViewChiTietGhe.Rows.Clear();
//             #endregion
//             #region Ðua thông tin chuy?n bay lên datagridview
//             //dataGridViewChuyenBay
//             dataGridViewChuyenBay.Rows.Remove(dataGridViewChuyenBay.CurrentRow);
//             dataGridViewChuyenBay.Rows.Add(
//                         textBoxMaChuyenBay.Text,
//                         comboBoxMaTuyenBay.Text,
//                         textBoxThoiGianBay.Text,
//                         dateTimePickerNgayKhoiHanh.Value.ToShortDateString(),
//                         dateTimePickerGioKhoiHanh.Value.ToString("HH:mm:ss"),
//                         textBoxDonGia.Text);
//             #endregion
//             //buttonSua.Enabled = false;
//             buttonXoa.Enabled = false;
//             resetState();
#endregion
            try
            {
                //lưu thông tin chuyến bay xuống CSDL
                //Table<CHUYENBAY> chuyenbays = db.GetTable<CHUYENBAY>();
                for (int i = 0; i < dataGridViewChuyenBay.Rows.Count - 1; i++)
                {
                    #region comment
                    // Thay dô?i do code cu~ su? du?ng linQ
                    /*CHUYENBAY k = new CHUYENBAY();
                    k.MaChuyenBay = dataGridViewChuyenBay.Rows[i].Cells[0].Value.ToString();
                    k.MaTuyenBay = dataGridViewChuyenBay.Rows[i].Cells[1].Value.ToString();
                    k.ThoiGianBay = Convert.ToInt16(dataGridViewChuyenBay.Rows[i].Cells[2].Value.ToString());
                    k.NgayKhoiHanh = Convert.ToDateTime(dataGridViewChuyenBay.Rows[i].Cells[3].Value.ToString());
                    k.GioKhoiHanh = ToDateTime(dataGridViewChuyenBay.Rows[i].Cells[4].Value.ToString());
                    k.DonGia = Convert.ToDouble(dataGridViewChuyenBay.Rows[i].Cells[5].Value.ToString());
                    chuyenbays.InsertOnSubmit(k);*/
                    #endregion

                    string MaChuyenBay = dataGridViewChuyenBay.Rows[i].Cells[0].Value.ToString();
                    string MaTuyenBay = dataGridViewChuyenBay.Rows[i].Cells[1].Value.ToString();
                    int ThoiGianBay = Convert.ToInt16(dataGridViewChuyenBay.Rows[i].Cells[2].Value.ToString());
                    string NgayKhoiHanh = dataGridViewChuyenBay.Rows[i].Cells[3].Value.ToString();
                    string GioKhoiHanh = dataGridViewChuyenBay.Rows[i].Cells[4].Value.ToString();
                    double DonGia = Convert.ToDouble(dataGridViewChuyenBay.Rows[i].Cells[5].Value.ToString());
                    bll.ThemChuyenBay(MaChuyenBay, MaTuyenBay, ThoiGianBay, DonGia, NgayKhoiHanh, GioKhoiHanh);
                    //db.SubmitChanges();                    
                }
                
                //Table<CTGHE> chitietghes = db.GetTable<CTGHE>();
                for (int i = 0; i < ThongTinHV.Count; i++)
                {

                    for (int j = 0; j < ThongTinHV[i].ListTTHV.Count; j++)
                    {
                        #region comment
                        // Thay dô?i do code cu~ su? du?ng linQ
                        /*CTGHE k = new CTGHE();
                        k.MaChuyenBay = ThongTinHV[i].MaChuyenBay;
                        k.MaHangVe = ThongTinHV[i].ListTTHV[j].MaHangVe;
                        k.SoGhe = ThongTinHV[i].ListTTHV[j].SoGhe;
                        k.SoGheDat = 0;
                        k.SoGheTrong = ThongTinHV[i].ListTTHV[j].SoGhe;

                        chitietghes.InsertOnSubmit(k);*/
                        #endregion
                        string MaChuyenBay = ThongTinHV[i].MaChuyenBay;
                        string MaHangVe = ThongTinHV[i].ListTTHV[j].MaHangVe;
                        int SoGhe = ThongTinHV[i].ListTTHV[j].SoGhe;
                        bll.ThemLoaiGhe(MaChuyenBay, MaHangVe, SoGhe);
                        //db.SubmitChanges();
                    }
                }
                dataGridViewChuyenBay.Rows.Clear();
                MessageBox.Show("Đã Lưu");
                buttonXoa.Enabled = false;
                buttonLuu.Enabled = false;
                textBoxDonGia.Text = "1000000";
                textBoxThoiGianBay.Text = "120";          
            }
            catch (SqlException ee)
            {
                MessageBox.Show("Không thể lưu thông tin chuyến bay xuống CSDL!");
            }
        }
        #region kiểm tra tính hợp lệ
        // regex
        private void textBoxThoiGianBay_Validating(object sender, CancelEventArgs e)
        {
            //Table<THAMSO> thamsos = db.GetTable<THAMSO>();
            //THAMSO k = thamsos.Single(p => p.STT == 1);


            //string str = @"^\d{2,3}$";
            string str = @"^[-+]?[0-9]*\.?[0-9]+$";
            Regex rg = new Regex(str);
            
            if (!rg.IsMatch(textBoxThoiGianBay.Text))
            {

                MessageBox.Show(this, "Thời gian bay không được là kí tự", "Cảnh Báo!");
                labelThoiGianBay.ForeColor = Color.Red;
                isThoiGianValid = false;
            }
            else
            {
                int ThoiGianBayToiThieu = bll.LayThamSo("ThoiGianBayToiThieu");
                if (Int32.Parse(textBoxThoiGianBay.Text) < ThoiGianBayToiThieu  && ThoiGianBayToiThieu>0)
                {
                    MessageBox.Show(this, "Thời gian bay phải lớn hơn " + ThoiGianBayToiThieu, "Cảnh Báo!");
                    labelThoiGianBay.ForeColor = Color.Red;
                    isThoiGianValid = false;
                }

                labelThoiGianBay.ForeColor = Color.Black;
                isThoiGianValid = true;
            }

        }
        private void textBoxDonGia_Validating(object sender, CancelEventArgs e)
        {
            string str = @"^\d{1,7}$";
            Regex rg = new Regex(str);
            if (!rg.IsMatch(textBoxDonGia.Text))
            {
                MessageBox.Show(this, "Đơn giá không được là kí tự, tối đa 7 kí số", "Cảnh Báo!");
                labelDonGia.ForeColor = Color.Red;
                isDonGiaValid = false;
            }
            else
            {
                labelDonGia.ForeColor = Color.Black;
                isDonGiaValid = true;
            }
        }
        private void dateTimePickerNgayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerGioKhoiHanh.Value.Date < DateTime.UtcNow.Date)
            {
                MessageBox.Show("Ngày khởi hành phải sau ngày hôm nay!");
                labelNgayKhoiHanh.ForeColor = Color.Red;
                isNgayKhoiHanhValid = false;
            }
            else
            {
                labelNgayKhoiHanh.ForeColor = Color.Black;
                isNgayKhoiHanhValid = true;
            }

        }
        #endregion
        #region State
        void defaultComponentState()
        {
            labelDonGia.ForeColor = Color.Black;
            labelThoiGianBay.ForeColor = Color.Black;
            labelNgayKhoiHanh.ForeColor = Color.Black;
        }

        void resetState()
        {
            defaultComponentState();
            comboBoxMaTuyenBay.Enabled = false;
            dateTimePickerGioKhoiHanh.Enabled = false;
            dateTimePickerNgayKhoiHanh.Enabled = false;
            textBoxThoiGianBay.Enabled = false;
            textBoxThoiGianBay.Text = "";
            textBoxDonGia.Enabled = false;
            textBoxDonGia.Text = "";


            buttonThem.Text = "Thêm";
            buttonThem.Enabled = true;
//             buttonSua.Text = "Sửa";
//             buttonSua.Enabled = false;
            //buttonXoa.Enabled = false;
            //buttonPhucHoi.Enabled = false;
            buttonLuu.Enabled = false;
            

        }

        void addRecordState()
        {
            #region Control state
            defaultComponentState();
            comboBoxMaTuyenBay.Enabled = true;
            dateTimePickerGioKhoiHanh.Enabled = true;
            dateTimePickerNgayKhoiHanh.Enabled = true;
            textBoxThoiGianBay.Enabled = true;
            //textBoxThoiGianBay.Text = "";
            textBoxDonGia.Enabled = true;
            //textBoxDonGia.Text = "";
         
            //buttonThem.Text = "Hủy Thêm";
            //buttonCapNhat.Text = "Sửa";
            //buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            //buttonPhucHoi.Enabled = false;
            buttonLuu.Enabled = false;            
            buttonThoat.Enabled = true;
            buttonThem.Enabled = true;
            ButtonXuatFile.Enabled = true;
            #endregion
            #region Data state
            comboBoxMaTuyenBay.ResetText();
            textBoxMaChuyenBay.Text = bll.LayMaChuyenBayTiepTheo(textBoxMaChuyenBay.Text);
            textBoxDonGia.Text = "1000000";
            
            textBoxSanBayDen.Text = "";
            textBoxSanBayDi.Text = "";
            dateTimePickerNgayKhoiHanh.Refresh();
            dateTimePickerGioKhoiHanh.Refresh();
            //dataGridViewChiTietGhe.Rows.Clear();
            textBoxThoiGianBay.Text = "120";
            //dataGridViewChiTietGhe.Rows.Clear();
            
            #endregion


        }

        void editRecordState()
        {
            #region Control state
            defaultComponentState();
            comboBoxMaTuyenBay.Enabled = true;
            dataGridViewChiTietGhe.Enabled = true;
            dateTimePickerGioKhoiHanh.Enabled = true;
            dateTimePickerNgayKhoiHanh.Enabled = true;
            textBoxThoiGianBay.Enabled = true;
            textBoxDonGia.Enabled = true;


            buttonThem.Text = "Thêm";
            buttonThem.Enabled = false;
            //buttonSua.Text = "Hủy Sửa";
            buttonXoa.Enabled = false;
            //buttonPhucHoi.Enabled = false;
            buttonLuu.Enabled = true;         
            #endregion
           
        }
        //them ham viewstate
        void viewState()
        {
            #region Control State   
            dataGridViewChiTietGhe.Enabled = false;
            comboBoxMaTuyenBay.Enabled = false;
            textBoxThoiGianBay.Enabled = false;
            textBoxDonGia.Enabled = false;
            dateTimePickerNgayKhoiHanh.Enabled = false;
            dateTimePickerGioKhoiHanh.Enabled = false;


            buttonThem.Enabled = false;
            //buttonPhucHoi.Enabled = false;
            buttonLuu.Enabled = false;
            buttonXoa.Enabled = true;
            //buttonSua.Enabled = true;
            ButtonXuatFile.Enabled = false;
            buttonThoat.Enabled = false;
            #endregion
            #region Data state
            dataGridViewChiTietGhe.Rows.Clear();

            textBoxMaChuyenBay.Text = dataGridViewChuyenBay.CurrentRow.Cells[0].Value.ToString();
            comboBoxMaTuyenBay.Text = dataGridViewChuyenBay.CurrentRow.Cells[1].Value.ToString();
            UpdateTextBoxSanBay();
            textBoxThoiGianBay.Text = dataGridViewChuyenBay.CurrentRow.Cells[2].Value.ToString();
            textBoxDonGia.Text = dataGridViewChuyenBay.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerNgayKhoiHanh.Value = ToDateTime(dataGridViewChuyenBay.CurrentRow.Cells[3].Value.ToString());
            dateTimePickerGioKhoiHanh.Value = ToDateTime(dataGridViewChuyenBay.CurrentRow.Cells[4].Value.ToString());
            
            //Load thông tin hạng vé
            for (int i = 0; i < ThongTinHV.Count; i++)
            {
                if (ThongTinHV[i].MaChuyenBay == textBoxMaChuyenBay.Text)
                {
                    for (int j = 0; j < ThongTinHV[i].ListTTHV.Count; j++)
                    {
                        dataGridViewChiTietGhe.Rows.Add(
                            ThongTinHV[i].ListTTHV[j].MaHangVe,
                            ThongTinHV[i].ListTTHV[j].SoGhe.ToString());
                    }
                    break;
                }
            }
            #endregion
        }
        #endregion
        #region Xử lí
        private void comboBoxMaTuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
             UpdateTextBoxSanBay();
        }
        #region bỏ dey
        //         private void dataGridViewChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
//         {
//             if (this.dataGridViewChuyenBay.SelectedRows.Count == 1 && !dataGridViewChuyenBay.CurrentRow.IsNewRow)
//             {
//                 
//                 viewState();
//                 //sai logic, khi chọn 1 hàng, hiện thông tin lên nên disable hắn ngay!!
//                 //dataGridViewSanBayTrungGian.Enabled = true;
//                 //dataGridViewChiTietGhe.Enabled = true;
//                 //comboBoxMaTuyenBay.Enabled = true;
//                 //textBoxThoiGianBay.Enabled = true;
//                 //textBoxDonGia.Enabled = true;
//                 //dateTimePickerNgayKhoiHanh.Enabled = true;
//                 //dateTimePickerGioKhoiHanh.Enabled = true;     
//                 #region Update biến temp
//                 chuyenbaytemp.MaChuyen = textBoxMaChuyenBay.Text;
//                 chuyenbaytemp.MaTuyen = comboBoxMaTuyenBay.Text;
//                 chuyenbaytemp.ThoiGianBay = textBoxThoiGianBay.Text;
//                 chuyenbaytemp.DonGia = textBoxDonGia.Text;
//                 chuyenbaytemp.GioKhoiHanh = dateTimePickerGioKhoiHanh.Value.ToString("HH:mm:ss");
//                 chuyenbaytemp.NgayKhoiHanh = dateTimePickerNgayKhoiHanh.Value.ToShortDateString();
// 
//                 for (int i = 0; i < ThongTinSBTG.Count; i++)
//                 {
//                     if (ThongTinSBTG[i].MaChuyenBay == textBoxMaChuyenBay.Text)
//                     {
//                         sbTGtemp.MaChuyenBay = textBoxMaChuyenBay.Text;
//                         for (int j = 0; j < ThongTinSBTG[i].ListSBTG.Count; j++)
//                             sbTGtemp.AddSBTG(ThongTinSBTG[i].ListSBTG[j].MaSB, ThongTinSBTG[i].ListSBTG[j].TgDung,
//                                 ThongTinSBTG[i].ListSBTG[j].Ghchu);
//                         break;
//                     }
//                 }
// 
//                 for (int i = 0; i < ThongTinHV.Count; i++)
//                 {
//                     if (ThongTinHV[i].MaChuyenBay == textBoxMaChuyenBay.Text)
//                     {
//                         hvTemp.MaChuyenBay = textBoxMaChuyenBay.Text;
//                         for (int j = 0; j < ThongTinHV[i].ListTTHV.Count; j++)
//                         {
//                             hvTemp.AddHangVe(ThongTinHV[i].ListTTHV[j].MaHangVe, ThongTinHV[i].ListTTHV[j].SoGhe);
//                         }
//                         break;
//                     }
//                 }
//                 #endregion
//                 IsSelectOneRow = true;
//             }
//             else
//             {
//                 addRecordState();
//                 //dataGridViewSanBayTrungGian.Rows.Clear();
//                 //dataGridViewChiTietGhe.Enabled = false;
//                 //dataGridViewChiTietGhe.Rows.Clear();
//                 //ColumnSanBayTrungGian.Items.Clear();
//                 //resetState();
//                 //textBoxSanBayDen.Text = "";
//                 //textBoxSanBayDi.Text = "";
//                 //comboBoxMaTuyenBay.ResetText();
//                 //textBoxDonGia.Text = "";
//                 //textBoxThoiGianBay.Text = "";
//                 //textBoxMaChuyenBay.Text = "";
//                 ResetTemp();
//                 IsSelectOneRow = false;
//             }
// //             buttonSua.Text = "Sửa";
// //             buttonPhucHoi.Enabled = false;
        //         }
        #endregion

        #endregion
        #region Xử lý Database
        private void InitTuyenBay()
        {
            comboBoxMaTuyenBay.Items.Clear();
//            comboBoxMaTuyenBay.Items.Add("Thêm Tuyến Bay");
            /*Table<TUYENBAY> tuyenbays = db.GetTable<TUYENBAY>();
            foreach (var item in tuyenbays)
            {
                comboBoxMaTuyenBay.Items.Add(item.MaTuyenBay.ToString());
            }*/
            
            DataTable dt= bll.LayDanhSachMaTuyenBay();
            comboBoxMaTuyenBay.DataSource = dt;
            comboBoxMaTuyenBay.DisplayMember = "MaTuyenBay";
            comboBoxMaTuyenBay.ValueMember = "MaTuyenBay";
            //comboBoxMaTuyenBay.DisplayMember = ""
//             for (int i = 0; i < dt.Rows.Count;i++ )
//             {
//                 comboBoxMaTuyenBay.Items.Add(dt.Rows[i][0].ToString());
//             }

        }
        private void InitComboboxHangVe()
        {
            try
            {
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể Load bảng HANGVE! lỗi CSDL");
                return;
            }
        }

        private void UpdateTextBoxSanBay()
        {
            try
            {
                if (comboBoxMaTuyenBay.Items.Count > 0)
                {
                    /*string MaTuyenBay = comboBoxMaTuyenBay.Text;
                    Table<TUYENBAY> tuyenbays = db.GetTable<TUYENBAY>();

                    TUYENBAY tb = tuyenbays.Single(c => c.MaTuyenBay == MaTuyenBay);
                    if (tb != null)//đã load từ dữ liệu lên sao còn kiểm tra lại nữa
                    {
                        Table<SANBAY> sanbays = db.GetTable<SANBAY>();
                        SANBAY sb = sanbays.Single(c => c.MaSanBay == tb.MaSanBayDi);
                        if (sb != null)
                            textBoxSanBayDi.Text = sb.TenSanBay.ToString();
                        sb = sanbays.Single(c => c.MaSanBay == tb.MaSanBayDen);
                        if (sb != null)
                            textBoxSanBayDen.Text = sb.TenSanBay.ToString();
                     }*/
                    textBoxSanBayDen.Text = bll.LayTenSanBayDen(comboBoxMaTuyenBay.Text);
                    textBoxSanBayDi.Text = bll.LayTenSanBayDi(comboBoxMaTuyenBay.Text);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể tìm thấy tên sân bay thỏa mãn!");
                return;
            }
        }
        //bỏ HamTaoLao, chuyển thành hàm LayMaChuyenBayTiepTheo() đặt trong layer BLL 
        /*private string HamTaoLao(int k)
        {
            if (k >= 0 && k <= 9)
                return ("CB00" + k.ToString());
            if (k >= 10 && k <= 99)
                return ("CB0" + k.ToString());
            if (k >= 100 && k <= 999)
                return ("CB" + k.ToString());
            return "99999";

        }*/
        private bool CheckRules()
        {
            if (textBoxDonGia.Text == "" || textBoxThoiGianBay.Text == "" || textBoxSanBayDi.Text=="" ||textBoxSanBayDen.Text=="")
            {
                MessageBox.Show("Khong the de trong thoi gian bay hoac don gia!");
                return false;
            }

            //Chuyển về 3 lớp
            //Table<THAMSO> thamsos = db.GetTable<THAMSO>();
            //THAMSO k = thamsos.Single(p => p.STT == 1);
            int SoSBTGToiDa= bll.LayThamSo("SoSanBayTrungGianToiDa");
            int TGDToiThieu = bll.LayThamSo("ThoiGianDungToiThieu");
            int TGDToiDa = bll.LayThamSo("ThoiGianDungToiDa");
            #region Luật Hạng Vé
            bool flag = true;        
            for (int i = 0; i < dataGridViewChiTietGhe.Rows.Count - 1; i++)
            {
                if (dataGridViewChiTietGhe.Rows[i].Cells[1].Value == null || !_rule.IsNNumber(dataGridViewChiTietGhe.Rows[i].Cells[1].Value.ToString()))
                {
                    flag = false;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Số ghế phải là số nguyên!");
                return false;
            }
            #endregion
            //Kiểm tra Datagridview các chuyến bay

            return true;
        }


        #endregion

        private void UpdateSBTG_HV()
        {
            #region Xóa đi thông tin đã có
            for (int i = 0; i < ThongTinSBTG.Count; i++)
            {
                if (ThongTinSBTG[i].MaChuyenBay == textBoxMaChuyenBay.Text)
                {
                    ThongTinSBTG.RemoveAt(i);
                    //break;
                }
            }
            for (int i = 0; i < ThongTinHV.Count; i++)
            {
                if (ThongTinHV[i].MaChuyenBay == textBoxMaChuyenBay.Text)
                {
                    ThongTinHV.RemoveAt(i);
                    //break;
                }
            }
            #endregion
            #region Thêm Thông Tin Mới Vào
            //chưa kiểm tra tính đúng đắn dữ liệu. cần gọi hàm checkrules trước.
            //lưu thông tin hạng vé
            thongtinHV hangvetemp = new thongtinHV(textBoxMaChuyenBay.Text);
            for (int i = 0; i < dataGridViewChiTietGhe.Rows.Count; i++)
            {
                if (!dataGridViewChiTietGhe.Rows[i].IsNewRow)
                {
                    hangvetemp.AddHangVe(
                        dataGridViewChiTietGhe.Rows[i].Cells[0].Value.ToString(),
                        Convert.ToInt16(dataGridViewChiTietGhe.Rows[i].Cells[1].Value.ToString()));
                }
            }
            ThongTinHV.Add(hangvetemp);
            #endregion
        }

        private DateTime ToDateTime(string _a)
        {
            return (Convert.ToDateTime(_a));
        }
//         private void UpdateListHV(string _machuyenbay)
//         {
//             for (int i = 0; i < ThongTinHV.Count; i++)
//             {
//                 if (ThongTinHV[i].MaChuyenBay == _machuyenbay)
//                 {
//                     ThongTinHV[i].ListTTHV.Clear();
//                     for (int j = 0; j < dataGridViewChiTietGhe.Rows.Count; j++)
//                     {
//                         if (!dataGridViewChiTietGhe.Rows[j].IsNewRow)
//                         {
//                             ThongTinHV[i].AddHangVe(
//                                 dataGridViewChiTietGhe.Rows[j].Cells[0].Value.ToString(),
//                                 Convert.ToInt16(dataGridViewChiTietGhe.Rows[j].Cells[1].Value.ToString()));
//                         }
//                     }
//                     break;
//                 }
//             }
//         }

        private void ResetTemp()
        {
            chuyenbaytemp.MaChuyen = "";
            chuyenbaytemp.MaTuyen = "";
            chuyenbaytemp.ThoiGianBay = "";
            chuyenbaytemp.DonGia = "";
            chuyenbaytemp.GioKhoiHanh = "";
            chuyenbaytemp.NgayKhoiHanh = "";
            sbTGtemp.ListSBTG.Clear();
            hvTemp.ListTTHV.Clear();
        }

        private void ButtonXuatFile_Click(object sender, EventArgs e)
        {
            if (dataGridViewChuyenBay.Rows.Count - 1 > 0)
            {
                ExportFile temp = new ExportFile();
                temp.ExportExcel(dataGridViewChuyenBay);
            }
            else
            {
                MessageBox.Show("Không có dòng nào để xuất!");
            }
        }

        private void ThemLichChuyenBay_Load(object sender, EventArgs e)
        {

            this.dataGridViewChiTietGhe.DataSource = bll.LayDanhSachHangVe();
        }

        private void dataGridViewChiTietGhe_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewChiTietGhe_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewChiTietGhe_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

           MessageBox.Show("Số lượng ghế không là chữ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }

    public partial class thongtinCB
    {
        private string MaCB;
        public List<sanbayTG> ListSBTG = new List<sanbayTG>();
        public thongtinCB(string _machuyenbay)
        {
            MaCB = _machuyenbay;
        }
        public thongtinCB()
        {
            MaCB = "";
        }
        public void AddSBTG(string _masb, int _thoigiandung, string _ghichu)
        {
            bool flag = false;
            for (int i = 0; i < ListSBTG.Count; i++)
            {
                if (ListSBTG[i].MaSB == _masb)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
                this.ListSBTG.Add(new sanbayTG(_masb, _thoigiandung, _ghichu));
        }
        public void RemoveSBTG(string _masb)
        {
            for (int i = 0; i < ListSBTG.Count; i++)
            {
                if (ListSBTG[i].MaSB == _masb)
                {
                    ListSBTG.RemoveAt(i);
                    break;
                }
            }
        }
        public string MaChuyenBay
        {
            get { return MaCB; }
            set { MaCB = value; }
        }
    }
    public partial class thongtinHV
    {
        private string MaCB;
        public List<ctghe> ListTTHV = new List<ctghe>();
        public thongtinHV(string _machuyenbay)
        {
            MaCB = _machuyenbay;
        }
        public thongtinHV()
        {
            MaCB = "";
        }
        public void AddHangVe(string _mahanve, int _soghe)
        {
            bool flag = true;
            for (int i = 0; i < ListTTHV.Count; i++)
                if (ListTTHV[i].MaHangVe == _mahanve)
                {
                    flag = false;
                    break;
                }
            if (flag)
                ListTTHV.Add(new ctghe(_mahanve, _soghe));
        }
        public void RemoveHangVe(string _mahangve)
        {
            for (int i = 0; i < ListTTHV.Count; i++)
                if (ListTTHV[i].MaHangVe == _mahangve)
                {
                    ListTTHV.RemoveAt(i);
                    break;
                }
        }
        public string MaChuyenBay
        {
            get { return MaCB; }
            set { MaCB = value; }
        }
    }
}
