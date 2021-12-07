
namespace lemmefind
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.label_home2 = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.tab_search = new System.Windows.Forms.TabPage();
            this.listView_results = new MaterialSkin.Controls.MaterialListView();
            this.col_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_object = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_search = new MaterialSkin.Controls.MaterialButton();
            this.textbox_search = new MaterialSkin.Controls.MaterialTextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.tab_retrain = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_retrain5 = new System.Windows.Forms.Label();
            this.label_retrain4 = new System.Windows.Forms.Label();
            this.textbox_retrain = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_retrain2 = new System.Windows.Forms.Label();
            this.textbox_retrain_keyword = new MaterialSkin.Controls.MaterialTextBox();
            this.label_retrain3 = new System.Windows.Forms.Label();
            this.textbox_download = new MaterialSkin.Controls.MaterialButton();
            this.textbox_retrain_limit = new MaterialSkin.Controls.MaterialComboBox();
            this.label_retrain = new System.Windows.Forms.Label();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.label_settings2 = new System.Windows.Forms.Label();
            this.label_settings = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tab_home.SuspendLayout();
            this.tab_search.SuspendLayout();
            this.tab_retrain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tab_home);
            this.materialTabControl1.Controls.Add(this.tab_search);
            this.materialTabControl1.Controls.Add(this.tab_retrain);
            this.materialTabControl1.Controls.Add(this.tab_settings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1075, 538);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tab_home
            // 
            this.tab_home.BackColor = System.Drawing.Color.LightGray;
            this.tab_home.Controls.Add(this.label_home2);
            this.tab_home.Controls.Add(this.label_home);
            this.tab_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.tab_home.ImageKey = "house.png";
            this.tab_home.Location = new System.Drawing.Point(4, 39);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(1067, 495);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Home";
            // 
            // label_home2
            // 
            this.label_home2.AutoSize = true;
            this.label_home2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home2.Location = new System.Drawing.Point(11, 55);
            this.label_home2.Name = "label_home2";
            this.label_home2.Size = new System.Drawing.Size(0, 18);
            this.label_home2.TabIndex = 2;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(6, 3);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(124, 43);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "Home";
            // 
            // tab_search
            // 
            this.tab_search.BackColor = System.Drawing.Color.LightGray;
            this.tab_search.Controls.Add(this.listView_results);
            this.tab_search.Controls.Add(this.btn_search);
            this.tab_search.Controls.Add(this.textbox_search);
            this.tab_search.Controls.Add(this.label_search);
            this.tab_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.tab_search.ImageKey = "searching.png";
            this.tab_search.Location = new System.Drawing.Point(4, 39);
            this.tab_search.Name = "tab_search";
            this.tab_search.Padding = new System.Windows.Forms.Padding(3);
            this.tab_search.Size = new System.Drawing.Size(1067, 495);
            this.tab_search.TabIndex = 1;
            this.tab_search.Text = "Search";
            // 
            // listView_results
            // 
            this.listView_results.AutoSizeTable = false;
            this.listView_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_no,
            this.col_object,
            this.col_lat,
            this.col_lng,
            this.col_amount});
            this.listView_results.Depth = 0;
            this.listView_results.FullRowSelect = true;
            this.listView_results.HideSelection = false;
            this.listView_results.Location = new System.Drawing.Point(25, 144);
            this.listView_results.MinimumSize = new System.Drawing.Size(200, 100);
            this.listView_results.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView_results.MouseState = MaterialSkin.MouseState.OUT;
            this.listView_results.Name = "listView_results";
            this.listView_results.OwnerDraw = true;
            this.listView_results.Size = new System.Drawing.Size(768, 333);
            this.listView_results.TabIndex = 4;
            this.listView_results.UseCompatibleStateImageBehavior = false;
            this.listView_results.View = System.Windows.Forms.View.Details;
            // 
            // col_no
            // 
            this.col_no.Text = "No";
            // 
            // col_object
            // 
            this.col_object.Text = "Object";
            this.col_object.Width = 112;
            // 
            // col_lat
            // 
            this.col_lat.Text = "Latitude";
            this.col_lat.Width = 150;
            // 
            // col_lng
            // 
            this.col_lng.Text = "Longitude";
            this.col_lng.Width = 150;
            // 
            // col_amount
            // 
            this.col_amount.Text = "Amount";
            this.col_amount.Width = 109;
            // 
            // btn_search
            // 
            this.btn_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_search.Depth = 0;
            this.btn_search.HighEmphasis = true;
            this.btn_search.Icon = null;
            this.btn_search.Location = new System.Drawing.Point(182, 99);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_search.Size = new System.Drawing.Size(78, 36);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_search.UseAccentColor = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textbox_search
            // 
            this.textbox_search.AnimateReadOnly = false;
            this.textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_search.Depth = 0;
            this.textbox_search.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_search.LeadingIcon = null;
            this.textbox_search.Location = new System.Drawing.Point(25, 87);
            this.textbox_search.MaxLength = 50;
            this.textbox_search.MouseState = MaterialSkin.MouseState.OUT;
            this.textbox_search.Multiline = false;
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(150, 50);
            this.textbox_search.TabIndex = 2;
            this.textbox_search.Text = "";
            this.textbox_search.TrailingIcon = null;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.Location = new System.Drawing.Point(27, 20);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(148, 43);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "Search";
            // 
            // tab_retrain
            // 
            this.tab_retrain.BackColor = System.Drawing.Color.LightGray;
            this.tab_retrain.Controls.Add(this.groupBox2);
            this.tab_retrain.Controls.Add(this.groupBox1);
            this.tab_retrain.Controls.Add(this.label_retrain);
            this.tab_retrain.ImageKey = "learning.png";
            this.tab_retrain.Location = new System.Drawing.Point(4, 39);
            this.tab_retrain.Name = "tab_retrain";
            this.tab_retrain.Size = new System.Drawing.Size(1067, 495);
            this.tab_retrain.TabIndex = 3;
            this.tab_retrain.Text = "Retrain";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label_retrain5);
            this.groupBox2.Controls.Add(this.label_retrain4);
            this.groupBox2.Controls.Add(this.textbox_retrain);
            this.groupBox2.Location = new System.Drawing.Point(533, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 329);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // label_retrain5
            // 
            this.label_retrain5.AutoSize = true;
            this.label_retrain5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retrain5.Location = new System.Drawing.Point(6, 216);
            this.label_retrain5.Name = "label_retrain5";
            this.label_retrain5.Size = new System.Drawing.Size(416, 18);
            this.label_retrain5.TabIndex = 6;
            this.label_retrain5.Text = "After following our user manual, press button below";
            // 
            // label_retrain4
            // 
            this.label_retrain4.AutoSize = true;
            this.label_retrain4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retrain4.Location = new System.Drawing.Point(6, 60);
            this.label_retrain4.Name = "label_retrain4";
            this.label_retrain4.Size = new System.Drawing.Size(248, 18);
            this.label_retrain4.TabIndex = 1;
            this.label_retrain4.Text = "Follow our user documentaion";
            // 
            // textbox_retrain
            // 
            this.textbox_retrain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textbox_retrain.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.textbox_retrain.Depth = 0;
            this.textbox_retrain.HighEmphasis = true;
            this.textbox_retrain.Icon = null;
            this.textbox_retrain.Location = new System.Drawing.Point(9, 253);
            this.textbox_retrain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textbox_retrain.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_retrain.Name = "textbox_retrain";
            this.textbox_retrain.NoAccentTextColor = System.Drawing.Color.Empty;
            this.textbox_retrain.Size = new System.Drawing.Size(75, 36);
            this.textbox_retrain.TabIndex = 5;
            this.textbox_retrain.Text = "Detect";
            this.textbox_retrain.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.textbox_retrain.UseAccentColor = false;
            this.textbox_retrain.UseVisualStyleBackColor = true;
            this.textbox_retrain.Click += new System.EventHandler(this.textbox_retrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label_retrain2);
            this.groupBox1.Controls.Add(this.textbox_retrain_keyword);
            this.groupBox1.Controls.Add(this.label_retrain3);
            this.groupBox1.Controls.Add(this.textbox_download);
            this.groupBox1.Controls.Add(this.textbox_retrain_limit);
            this.groupBox1.Location = new System.Drawing.Point(13, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 329);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // label_retrain2
            // 
            this.label_retrain2.AutoSize = true;
            this.label_retrain2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retrain2.Location = new System.Drawing.Point(6, 60);
            this.label_retrain2.Name = "label_retrain2";
            this.label_retrain2.Size = new System.Drawing.Size(393, 18);
            this.label_retrain2.TabIndex = 1;
            this.label_retrain2.Text = "Type a keyword of an image you like to download";
            // 
            // textbox_retrain_keyword
            // 
            this.textbox_retrain_keyword.AnimateReadOnly = false;
            this.textbox_retrain_keyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_retrain_keyword.Depth = 0;
            this.textbox_retrain_keyword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_retrain_keyword.LeadingIcon = null;
            this.textbox_retrain_keyword.Location = new System.Drawing.Point(9, 93);
            this.textbox_retrain_keyword.MaxLength = 50;
            this.textbox_retrain_keyword.MouseState = MaterialSkin.MouseState.OUT;
            this.textbox_retrain_keyword.Multiline = false;
            this.textbox_retrain_keyword.Name = "textbox_retrain_keyword";
            this.textbox_retrain_keyword.Size = new System.Drawing.Size(150, 50);
            this.textbox_retrain_keyword.TabIndex = 4;
            this.textbox_retrain_keyword.Text = "";
            this.textbox_retrain_keyword.TrailingIcon = null;
            // 
            // label_retrain3
            // 
            this.label_retrain3.AutoSize = true;
            this.label_retrain3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retrain3.Location = new System.Drawing.Point(6, 162);
            this.label_retrain3.Name = "label_retrain3";
            this.label_retrain3.Size = new System.Drawing.Size(409, 18);
            this.label_retrain3.TabIndex = 7;
            this.label_retrain3.Text = "Choose the number of images you like to download";
            // 
            // textbox_download
            // 
            this.textbox_download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textbox_download.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.textbox_download.Depth = 0;
            this.textbox_download.HighEmphasis = true;
            this.textbox_download.Icon = null;
            this.textbox_download.Location = new System.Drawing.Point(9, 253);
            this.textbox_download.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textbox_download.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_download.Name = "textbox_download";
            this.textbox_download.NoAccentTextColor = System.Drawing.Color.Empty;
            this.textbox_download.Size = new System.Drawing.Size(102, 36);
            this.textbox_download.TabIndex = 5;
            this.textbox_download.Text = "Download";
            this.textbox_download.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.textbox_download.UseAccentColor = false;
            this.textbox_download.UseVisualStyleBackColor = true;
            this.textbox_download.Click += new System.EventHandler(this.textbox_download_Click);
            // 
            // textbox_retrain_limit
            // 
            this.textbox_retrain_limit.AutoResize = false;
            this.textbox_retrain_limit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textbox_retrain_limit.Depth = 0;
            this.textbox_retrain_limit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.textbox_retrain_limit.DropDownHeight = 174;
            this.textbox_retrain_limit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textbox_retrain_limit.DropDownWidth = 121;
            this.textbox_retrain_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_retrain_limit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textbox_retrain_limit.FormattingEnabled = true;
            this.textbox_retrain_limit.IntegralHeight = false;
            this.textbox_retrain_limit.ItemHeight = 43;
            this.textbox_retrain_limit.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "300",
            "500",
            "700",
            "1000"});
            this.textbox_retrain_limit.Location = new System.Drawing.Point(9, 195);
            this.textbox_retrain_limit.MaxDropDownItems = 4;
            this.textbox_retrain_limit.MouseState = MaterialSkin.MouseState.OUT;
            this.textbox_retrain_limit.Name = "textbox_retrain_limit";
            this.textbox_retrain_limit.Size = new System.Drawing.Size(121, 49);
            this.textbox_retrain_limit.StartIndex = 0;
            this.textbox_retrain_limit.TabIndex = 6;
            // 
            // label_retrain
            // 
            this.label_retrain.AutoSize = true;
            this.label_retrain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retrain.Location = new System.Drawing.Point(6, 3);
            this.label_retrain.Name = "label_retrain";
            this.label_retrain.Size = new System.Drawing.Size(161, 37);
            this.label_retrain.TabIndex = 0;
            this.label_retrain.Text = "RETRAIN";
            // 
            // tab_settings
            // 
            this.tab_settings.BackColor = System.Drawing.Color.LightGray;
            this.tab_settings.Controls.Add(this.label_settings2);
            this.tab_settings.Controls.Add(this.label_settings);
            this.tab_settings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_settings.ImageKey = "settings.png";
            this.tab_settings.Location = new System.Drawing.Point(4, 39);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Size = new System.Drawing.Size(1067, 495);
            this.tab_settings.TabIndex = 2;
            this.tab_settings.Text = "Settings";
            // 
            // label_settings2
            // 
            this.label_settings2.AutoSize = true;
            this.label_settings2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_settings2.Location = new System.Drawing.Point(11, 55);
            this.label_settings2.Name = "label_settings2";
            this.label_settings2.Size = new System.Drawing.Size(172, 18);
            this.label_settings2.TabIndex = 2;
            this.label_settings2.Text = "Will be updated soon";
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_settings.Location = new System.Drawing.Point(6, 3);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(167, 43);
            this.label_settings.TabIndex = 1;
            this.label_settings.Text = "Settings";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house.png");
            this.imageList1.Images.SetKeyName(1, "learning.png");
            this.imageList1.Images.SetKeyName(2, "searching.png");
            this.imageList1.Images.SetKeyName(3, "settings.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 605);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "Let Me See";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            this.tab_home.PerformLayout();
            this.tab_search.ResumeLayout(false);
            this.tab_search.PerformLayout();
            this.tab_retrain.ResumeLayout(false);
            this.tab_retrain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.tab_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabPage tab_search;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_settings;
        private MaterialSkin.Controls.MaterialButton btn_search;
        private MaterialSkin.Controls.MaterialTextBox textbox_search;
        private MaterialSkin.Controls.MaterialListView listView_results;
        private System.Windows.Forms.ColumnHeader col_lat;
        private System.Windows.Forms.ColumnHeader col_lng;
        private System.Windows.Forms.TabPage tab_retrain;
        private System.Windows.Forms.Label label_retrain;
        private System.Windows.Forms.ColumnHeader col_no;
        private System.Windows.Forms.Label label_retrain2;
        private System.Windows.Forms.Label label_home2;
        private System.Windows.Forms.Label label_settings2;
        private System.Windows.Forms.ColumnHeader col_object;
        private MaterialSkin.Controls.MaterialButton textbox_download;
        private MaterialSkin.Controls.MaterialTextBox textbox_retrain_keyword;
        private System.Windows.Forms.Label label_retrain3;
        private MaterialSkin.Controls.MaterialComboBox textbox_retrain_limit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_retrain4;
        private MaterialSkin.Controls.MaterialButton textbox_retrain;
        private System.Windows.Forms.Label label_retrain5;
        private System.Windows.Forms.ColumnHeader col_amount;
    }
}

