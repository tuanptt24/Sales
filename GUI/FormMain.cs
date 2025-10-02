using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Bo tròn ảnh đại diện và nút
            BoTronPictureBox(pBDaiDien, 35);
            BoTronButton(btnThongBao, 17, 17, 17, 17);

            // Thêm SideMenu
            SideMenu menu = new SideMenu();
            menu.Dock = DockStyle.Fill;
            menu.MenuClicked += Menu_MenuClicked;
            pLeft.Controls.Add(menu);
            menu.BringToFront(); // đưa lên trên btnDangXuat
        }

        private void Menu_MenuClicked(object sender, string menuName)
        {
            pContent.Controls.Clear();

            UserControl uc = null;
            switch (menuName)
            {
                case "Trả hàng":
                    uc = new TraHangUC(); break;
            }

            if (uc != null)
            {
                uc.Dock = DockStyle.Fill;
                pContent.Controls.Add(uc);
            }
        }

        // Hàm bo tròn PictureBox
        public void BoTronPictureBox(PictureBox pb, int radius)
        {
            if (pb.Width > 0 && pb.Height > 0)
            {
                GraphicsPath gp = new GraphicsPath();
                int w = pb.Width;
                int h = pb.Height;

                gp.AddArc(0, 0, radius, radius, 180, 90);
                gp.AddArc(w - radius, 0, radius, radius, 270, 90);
                gp.AddArc(w - radius, h - radius, radius, radius, 0, 90);
                gp.AddArc(0, h - radius, radius, radius, 90, 90);
                gp.CloseFigure();

                pb.Region = new Region(gp);
            }
        }

        // Hàm bo tròn Button
        public void BoTronButton(Button btn, int topLeft, int topRight, int bottomRight, int bottomLeft)
        {
            int w = btn.Width;
            int h = btn.Height;
            GraphicsPath gp = new GraphicsPath();

            if (topLeft > 0)
                gp.AddArc(0, 0, topLeft * 2, topLeft * 2, 180, 90);
            else gp.AddLine(0, 0, 0, 0);

            gp.AddLine(topLeft, 0, w - topRight, 0);

            if (topRight > 0)
                gp.AddArc(w - topRight * 2, 0, topRight * 2, topRight * 2, 270, 90);
            else gp.AddLine(w, 0, w, 0);

            gp.AddLine(w, topRight, w, h - bottomRight);

            if (bottomRight > 0)
                gp.AddArc(w - bottomRight * 2, h - bottomRight * 2, bottomRight * 2, bottomRight * 2, 0, 90);
            else gp.AddLine(w, h, w, h);

            gp.AddLine(w - bottomRight, h, bottomLeft, h);

            if (bottomLeft > 0)
                gp.AddArc(0, h - bottomLeft * 2, bottomLeft * 2, bottomLeft * 2, 90, 90);
            else gp.AddLine(0, h, 0, h);

            gp.AddLine(0, h - bottomLeft, 0, topLeft);
            gp.CloseFigure();

            btn.Region = new Region(gp);
        }
    }
}
