﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QL_HSGV.GUI.HocSinh;

namespace TTN_QL_HSGV.GUI.HocSinh
{
    public partial class DanhSachHocSinh : Form
    {
        public DanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            //lấy id bằng cách chọn 1 dòng trong datagrv xong truyền qua form bên kia
            //nút chi tiết cần chỉ bật khi đang chọn 1 dòng trong datagrv nếu không chọn dòng nào thì để tắt
            ThongTinHocSinh formTTHS = new ThongTinHocSinh(1);
            formTTHS.Show();
        }
    }
}
