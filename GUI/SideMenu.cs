using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class SideMenu : UserControl
    {
        public event EventHandler<string> MenuClicked;

        private Button selectedButton; // Nút đang được chọn

        public SideMenu()
        {
            InitializeComponent();

            // Gán sự kiện Click cho tất cả nút
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += Button_Click;          // xử lý chọn menu
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;

                    // Style mặc định
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        // ========= Hover =========
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != selectedButton)
                btn.BackColor = Color.Gainsboro;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != selectedButton)
                btn.BackColor = Color.White;
        }

        // ========= Click chọn menu =========
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Reset tất cả nút về mặc định
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button b)
                {
                    b.BackColor = Color.White;
                    b.ForeColor = Color.Black;
                }
            }

            // Đánh dấu nút được chọn
            selectedButton = btn;
            selectedButton.BackColor = Color.LightCyan;
            selectedButton.ForeColor = Color.Blue;

            // Bắn sự kiện với tên menu
            MenuClicked?.Invoke(this, btn.Text);
        }
    }
}
