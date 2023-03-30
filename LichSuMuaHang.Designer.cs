namespace _20522114_NguyenAnhTuan_BTH1
{
    partial class LichSuMuaHang
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
            ListViewGroup listViewGroup11 = new ListViewGroup("Đơn 1", HorizontalAlignment.Left);
            ListViewGroup listViewGroup12 = new ListViewGroup("Đơn 2", HorizontalAlignment.Left);
            ListViewGroup listViewGroup13 = new ListViewGroup("Đơn 3", HorizontalAlignment.Left);
            ListViewGroup listViewGroup14 = new ListViewGroup("Đơn 4", HorizontalAlignment.Left);
            ListViewGroup listViewGroup15 = new ListViewGroup("Đơn 5", HorizontalAlignment.Left);
            ListViewItem listViewItem25 = new ListViewItem(new string[] { "1", "Máy xay thịt", "149.000đ", "2", "298.000đ" }, -1);
            ListViewItem listViewItem26 = new ListViewItem(new string[] { "2", "Ấm Đun Siêu Tốc Inox", "228.000đ", "3", "684.000đ" }, -1);
            ListViewItem listViewItem27 = new ListViewItem(new string[] { "", "", "", "", "982.000đ", "Đã giao", "4 sao" }, -1);
            ListViewItem listViewItem28 = new ListViewItem(new string[] { "1", "Màn hình cong", "2.749.000đ", "1", "2.749.000đ", "" }, -1);
            ListViewItem listViewItem29 = new ListViewItem(new string[] { "1", "Apple Iphone 13", "17.750.000đ", "1", "17.750.000đ" }, -1);
            ListViewItem listViewItem30 = new ListViewItem(new string[] { "", "", "", "", "17.750.000đ", "Chưa giao", "? sao" }, -1);
            ListViewItem listViewItem31 = new ListViewItem(new string[] { "", "", "", "", "2.749.000đ", "Đã giao", "4 sao", "" }, -1);
            ListViewItem listViewItem32 = new ListViewItem(new string[] { "1", "Ấm siêu tốc dáng lùn", "405.000đ", "2", "810.000đ", "" }, -1);
            ListViewItem listViewItem33 = new ListViewItem(new string[] { "2", "Ấm Đun Siêu Tốc Inox", "228.000đ", "1", "228.000đ", "" }, -1);
            ListViewItem listViewItem34 = new ListViewItem(new string[] { "", "", "", "", "1.038.000đ", "Đã giao", "5 sao" }, -1);
            ListViewItem listViewItem35 = new ListViewItem(new string[] { "1", "Máy pha cafe tự động Expresso", "2.479.000đ", "1", "2.479.000đ" }, -1);
            ListViewItem listViewItem36 = new ListViewItem(new string[] { "", "", "", "", "2.479.000đ", "Đã giao", "5 sao" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewGroup11.Header = "Đơn 1";
            listViewGroup11.Name = "listViewGroup1";
            listViewGroup12.Header = "Đơn 2";
            listViewGroup12.Name = "listViewGroup2";
            listViewGroup13.Header = "Đơn 3";
            listViewGroup13.Name = "listViewGroup3";
            listViewGroup14.Header = "Đơn 4";
            listViewGroup14.Name = "listViewGroup4";
            listViewGroup15.Header = "Đơn 5";
            listViewGroup15.Name = "listViewGroup5";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup11, listViewGroup12, listViewGroup13, listViewGroup14, listViewGroup15 });
            listViewItem25.Group = listViewGroup11;
            listViewItem26.Group = listViewGroup11;
            listViewItem27.Group = listViewGroup11;
            listViewItem28.Group = listViewGroup12;
            listViewItem29.Group = listViewGroup13;
            listViewItem30.Group = listViewGroup13;
            listViewItem31.Group = listViewGroup12;
            listViewItem32.Group = listViewGroup14;
            listViewItem33.Group = listViewGroup14;
            listViewItem34.Group = listViewGroup14;
            listViewItem35.Group = listViewGroup15;
            listViewItem36.Group = listViewGroup15;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem25, listViewItem26, listViewItem27, listViewItem28, listViewItem29, listViewItem30, listViewItem31, listViewItem32, listViewItem33, listViewItem34, listViewItem35, listViewItem36 });
            listView1.Location = new Point(103, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(745, 469);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sản phẩm";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá sản phẩm";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tổng giá";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tình trạng";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Đánh giá";
            columnHeader7.Width = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 581);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(360, 22);
            label1.Name = "label1";
            label1.Size = new Size(234, 38);
            label1.TabIndex = 1;
            label1.Text = "Lịch sử mua hàng";
            // 
            // LichSuMuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 581);
            Controls.Add(panel1);
            Name = "LichSuMuaHang";
            Text = "LichSuMuaHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Panel panel1;
        private Label label1;
    }
}