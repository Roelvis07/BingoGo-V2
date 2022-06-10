
namespace BingoGo_V2
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_numeroAleatorio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_punctuation = new System.Windows.Forms.Label();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btn_bingo = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.new_play = new Guna.UI.WinForms.GunaButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.items_group = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPictureBox5 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox4 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.LBL_M1 = new System.Windows.Forms.Label();
            this.LBL_M2 = new System.Windows.Forms.Label();
            this.LBL_S1 = new System.Windows.Forms.Label();
            this.LBL_S2 = new System.Windows.Forms.Label();
            this.LBL_dp = new System.Windows.Forms.Label();
            this.btn_game_over = new Guna.UI.WinForms.GunaButton();
            this.btn_full_house = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(26, 440);
            this.progressBar.Maximum = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar.Size = new System.Drawing.Size(150, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 33;
            this.progressBar.Visible = false;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.AutoSize = true;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gunaElipsePanel1.Size = new System.Drawing.Size(345, 78);
            this.gunaElipsePanel1.TabIndex = 0;
            this.gunaElipsePanel1.Visible = false;
            // 
            // lbl_numeroAleatorio
            // 
            this.lbl_numeroAleatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_numeroAleatorio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numeroAleatorio.Font = new System.Drawing.Font("Century Gothic", 50F, System.Drawing.FontStyle.Bold);
            this.lbl_numeroAleatorio.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_numeroAleatorio.Location = new System.Drawing.Point(6, 25);
            this.lbl_numeroAleatorio.Name = "lbl_numeroAleatorio";
            this.lbl_numeroAleatorio.Size = new System.Drawing.Size(116, 68);
            this.lbl_numeroAleatorio.TabIndex = 2;
            this.lbl_numeroAleatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_punctuation
            // 
            this.lbl_punctuation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_punctuation.AutoEllipsis = true;
            this.lbl_punctuation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_punctuation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_punctuation.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_punctuation.Location = new System.Drawing.Point(413, 343);
            this.lbl_punctuation.Name = "lbl_punctuation";
            this.lbl_punctuation.Size = new System.Drawing.Size(138, 52);
            this.lbl_punctuation.TabIndex = 4;
            this.lbl_punctuation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.Controls.Add(this.lbl_numeroAleatorio);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(411, 177);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 60;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(125, 125);
            this.gunaElipsePanel2.TabIndex = 5;
            // 
            // btn_bingo
            // 
            this.btn_bingo.Animated = true;
            this.btn_bingo.AnimationHoverSpeed = 0.07F;
            this.btn_bingo.AnimationSpeed = 0.03F;
            this.btn_bingo.BackColor = System.Drawing.Color.Transparent;
            this.btn_bingo.BaseColor = System.Drawing.Color.Transparent;
            this.btn_bingo.BorderColor = System.Drawing.Color.Transparent;
            this.btn_bingo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bingo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_bingo.Enabled = false;
            this.btn_bingo.FocusedColor = System.Drawing.Color.Empty;
            this.btn_bingo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_bingo.ForeColor = System.Drawing.Color.White;
            this.btn_bingo.Image = null;
            this.btn_bingo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_bingo.ImageSize = new System.Drawing.Size(80, 80);
            this.btn_bingo.Location = new System.Drawing.Point(207, 458);
            this.btn_bingo.Name = "btn_bingo";
            this.btn_bingo.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_bingo.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_bingo.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_bingo.OnHoverImage = null;
            this.btn_bingo.OnPressedColor = System.Drawing.Color.Black;
            this.btn_bingo.Radius = 10;
            this.btn_bingo.Size = new System.Drawing.Size(145, 31);
            this.btn_bingo.TabIndex = 6;
            this.btn_bingo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_bingo.Visible = false;
            this.btn_bingo.Click += new System.EventHandler(this.btn_bingo_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(459, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // new_play
            // 
            this.new_play.AnimationHoverSpeed = 0.07F;
            this.new_play.AnimationSpeed = 0.03F;
            this.new_play.BackColor = System.Drawing.Color.Transparent;
            this.new_play.BaseColor = System.Drawing.Color.Transparent;
            this.new_play.BorderColor = System.Drawing.Color.Transparent;
            this.new_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.new_play.FocusedColor = System.Drawing.Color.Empty;
            this.new_play.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_play.ForeColor = System.Drawing.Color.Black;
            this.new_play.Image = ((System.Drawing.Image)(resources.GetObject("new_play.Image")));
            this.new_play.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_play.ImageSize = new System.Drawing.Size(160, 30);
            this.new_play.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.new_play.Location = new System.Drawing.Point(400, 38);
            this.new_play.Name = "new_play";
            this.new_play.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.new_play.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.new_play.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.new_play.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("new_play.OnHoverImage")));
            this.new_play.OnPressedColor = System.Drawing.Color.Transparent;
            this.new_play.Radius = 10;
            this.new_play.Size = new System.Drawing.Size(160, 30);
            this.new_play.TabIndex = 10;
            this.new_play.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_play.Click += new System.EventHandler(this.new_play_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Letter_C_Icon_32.png");
            this.imageList1.Images.SetKeyName(1, "Letter_T_Icon_32.png");
            this.imageList1.Images.SetKeyName(2, "Exclamation_mark_Icon_32.png");
            this.imageList1.Images.SetKeyName(3, "King-Crown.gif");
            // 
            // items_group
            // 
            this.items_group.BackColor = System.Drawing.Color.White;
            this.items_group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.items_group.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.items_group.Location = new System.Drawing.Point(21, 435);
            this.items_group.Margin = new System.Windows.Forms.Padding(0, 30, 30, 0);
            this.items_group.Name = "items_group";
            this.items_group.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.items_group.Size = new System.Drawing.Size(160, 69);
            this.items_group.TabIndex = 14;
            this.items_group.Visible = false;
            // 
            // gunaPictureBox5
            // 
            this.gunaPictureBox5.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox5.ErrorImage = null;
            this.gunaPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox5.Image")));
            this.gunaPictureBox5.InitialImage = null;
            this.gunaPictureBox5.Location = new System.Drawing.Point(285, 20);
            this.gunaPictureBox5.Name = "gunaPictureBox5";
            this.gunaPictureBox5.Size = new System.Drawing.Size(60, 60);
            this.gunaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox5.TabIndex = 19;
            this.gunaPictureBox5.TabStop = false;
            this.gunaPictureBox5.Visible = false;
            // 
            // gunaPictureBox4
            // 
            this.gunaPictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox4.ErrorImage = null;
            this.gunaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox4.Image")));
            this.gunaPictureBox4.InitialImage = null;
            this.gunaPictureBox4.Location = new System.Drawing.Point(219, 20);
            this.gunaPictureBox4.Name = "gunaPictureBox4";
            this.gunaPictureBox4.Size = new System.Drawing.Size(60, 60);
            this.gunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox4.TabIndex = 18;
            this.gunaPictureBox4.TabStop = false;
            this.gunaPictureBox4.Visible = false;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.ErrorImage = null;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.InitialImage = null;
            this.gunaPictureBox3.Location = new System.Drawing.Point(153, 20);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(60, 60);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 17;
            this.gunaPictureBox3.TabStop = false;
            this.gunaPictureBox3.Visible = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.ErrorImage = null;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.InitialImage = null;
            this.gunaPictureBox2.Location = new System.Drawing.Point(87, 20);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(60, 60);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 16;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Visible = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.ErrorImage = null;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.InitialImage = null;
            this.gunaPictureBox1.Location = new System.Drawing.Point(21, 20);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 15;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Visible = false;
            // 
            // LBL_M1
            // 
            this.LBL_M1.BackColor = System.Drawing.Color.Transparent;
            this.LBL_M1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_M1.ForeColor = System.Drawing.Color.Black;
            this.LBL_M1.Location = new System.Drawing.Point(458, 470);
            this.LBL_M1.Name = "LBL_M1";
            this.LBL_M1.Size = new System.Drawing.Size(18, 30);
            this.LBL_M1.TabIndex = 22;
            this.LBL_M1.Text = "0";
            this.LBL_M1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_M2
            // 
            this.LBL_M2.BackColor = System.Drawing.Color.Transparent;
            this.LBL_M2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_M2.ForeColor = System.Drawing.Color.Black;
            this.LBL_M2.Location = new System.Drawing.Point(481, 470);
            this.LBL_M2.Name = "LBL_M2";
            this.LBL_M2.Size = new System.Drawing.Size(18, 30);
            this.LBL_M2.TabIndex = 23;
            this.LBL_M2.Text = "0";
            this.LBL_M2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_S1
            // 
            this.LBL_S1.BackColor = System.Drawing.Color.Transparent;
            this.LBL_S1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_S1.ForeColor = System.Drawing.Color.Black;
            this.LBL_S1.Location = new System.Drawing.Point(529, 470);
            this.LBL_S1.Name = "LBL_S1";
            this.LBL_S1.Size = new System.Drawing.Size(18, 30);
            this.LBL_S1.TabIndex = 24;
            this.LBL_S1.Text = "0";
            this.LBL_S1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_S2
            // 
            this.LBL_S2.BackColor = System.Drawing.Color.Transparent;
            this.LBL_S2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_S2.ForeColor = System.Drawing.Color.Black;
            this.LBL_S2.Location = new System.Drawing.Point(552, 470);
            this.LBL_S2.Name = "LBL_S2";
            this.LBL_S2.Size = new System.Drawing.Size(18, 30);
            this.LBL_S2.TabIndex = 25;
            this.LBL_S2.Text = "0";
            this.LBL_S2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_dp
            // 
            this.LBL_dp.BackColor = System.Drawing.Color.Transparent;
            this.LBL_dp.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dp.ForeColor = System.Drawing.Color.Black;
            this.LBL_dp.Location = new System.Drawing.Point(504, 470);
            this.LBL_dp.Name = "LBL_dp";
            this.LBL_dp.Size = new System.Drawing.Size(18, 30);
            this.LBL_dp.TabIndex = 26;
            this.LBL_dp.Text = ":";
            this.LBL_dp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_game_over
            // 
            this.btn_game_over.AnimationHoverSpeed = 0.07F;
            this.btn_game_over.AnimationSpeed = 0.03F;
            this.btn_game_over.BackColor = System.Drawing.Color.Transparent;
            this.btn_game_over.BaseColor = System.Drawing.Color.Transparent;
            this.btn_game_over.BorderColor = System.Drawing.Color.Transparent;
            this.btn_game_over.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game_over.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_game_over.FocusedColor = System.Drawing.Color.Empty;
            this.btn_game_over.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_game_over.ForeColor = System.Drawing.Color.Transparent;
            this.btn_game_over.Image = global::BingoGo_V2.Properties.Resources.cartel_back7;
            this.btn_game_over.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_game_over.ImageSize = new System.Drawing.Size(400, 165);
            this.btn_game_over.Location = new System.Drawing.Point(3, 163);
            this.btn_game_over.Name = "btn_game_over";
            this.btn_game_over.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_game_over.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_game_over.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_game_over.OnHoverImage = null;
            this.btn_game_over.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_game_over.Size = new System.Drawing.Size(400, 165);
            this.btn_game_over.TabIndex = 27;
            this.btn_game_over.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.btn_game_over.Visible = false;
            this.btn_game_over.Click += new System.EventHandler(this.btn_game_over_Click);
            // 
            // btn_full_house
            // 
            this.btn_full_house.AnimationHoverSpeed = 0.07F;
            this.btn_full_house.AnimationSpeed = 0.03F;
            this.btn_full_house.BackColor = System.Drawing.Color.Transparent;
            this.btn_full_house.BaseColor = System.Drawing.Color.Transparent;
            this.btn_full_house.BorderColor = System.Drawing.Color.Transparent;
            this.btn_full_house.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_full_house.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_full_house.FocusedColor = System.Drawing.Color.Empty;
            this.btn_full_house.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_full_house.ForeColor = System.Drawing.Color.Transparent;
            this.btn_full_house.Image = global::BingoGo_V2.Properties.Resources.cartel_back8;
            this.btn_full_house.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_full_house.ImageSize = new System.Drawing.Size(400, 165);
            this.btn_full_house.Location = new System.Drawing.Point(3, 167);
            this.btn_full_house.Name = "btn_full_house";
            this.btn_full_house.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_full_house.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_full_house.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_full_house.OnHoverImage = null;
            this.btn_full_house.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_full_house.Size = new System.Drawing.Size(400, 165);
            this.btn_full_house.TabIndex = 28;
            this.btn_full_house.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.btn_full_house.Visible = false;
            this.btn_full_house.Click += new System.EventHandler(this.btn_full_house_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_full_house);
            this.Controls.Add(this.btn_game_over);
            this.Controls.Add(this.LBL_dp);
            this.Controls.Add(this.LBL_S2);
            this.Controls.Add(this.LBL_S1);
            this.Controls.Add(this.LBL_M2);
            this.Controls.Add(this.LBL_M1);
            this.Controls.Add(this.gunaPictureBox5);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.gunaPictureBox4);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.items_group);
            this.Controls.Add(this.new_play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_bingo);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.lbl_punctuation);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BingoGo V2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label lbl_numeroAleatorio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_punctuation;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaButton btn_bingo;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton new_play;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox5;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private System.Windows.Forms.Label LBL_M1;
        private System.Windows.Forms.Label LBL_M2;
        private System.Windows.Forms.Label LBL_S1;
        private System.Windows.Forms.Label LBL_S2;
        private System.Windows.Forms.Label LBL_dp;
        private Guna.UI.WinForms.GunaButton btn_game_over;
        private Guna.UI.WinForms.GunaButton btn_full_house;
        private System.Windows.Forms.FlowLayoutPanel items_group;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

