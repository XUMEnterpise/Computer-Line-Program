namespace LineProgram
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
            this.stopwatch = new MaterialSkin.Controls.MaterialLabel();
            this.startBTN = new MaterialSkin.Controls.MaterialButton();
            this.resetBTN = new MaterialSkin.Controls.MaterialButton();
            this.CompleteBTN = new MaterialSkin.Controls.MaterialButton();
            this.pauseBTN = new MaterialSkin.Controls.MaterialButton();
            this.unpauseBTN = new MaterialSkin.Controls.MaterialButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Completedlbl = new MaterialSkin.Controls.MaterialLabel();
            this.averageTimelbl = new MaterialSkin.Controls.MaterialLabel();
            this.bestTimelbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.people1 = new MaterialSkin.Controls.MaterialButton();
            this.people2 = new MaterialSkin.Controls.MaterialButton();
            this.people3 = new MaterialSkin.Controls.MaterialButton();
            this.people4 = new MaterialSkin.Controls.MaterialButton();
            this.target = new MaterialSkin.Controls.MaterialLabel();
            this.exportdata = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.behindlbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.person4 = new MaterialSkin.Controls.MaterialButton();
            this.person3 = new MaterialSkin.Controls.MaterialButton();
            this.person2 = new MaterialSkin.Controls.MaterialButton();
            this.person1 = new MaterialSkin.Controls.MaterialButton();
            this.idbox = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.buildbox = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.scanBuild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stopwatch
            // 
            this.stopwatch.Depth = 0;
            this.stopwatch.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stopwatch.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.stopwatch.Location = new System.Drawing.Point(6, 24);
            this.stopwatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopwatch.Name = "stopwatch";
            this.stopwatch.Size = new System.Drawing.Size(370, 102);
            this.stopwatch.TabIndex = 0;
            this.stopwatch.Text = "00:00:00";
            this.stopwatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stopwatch.Click += new System.EventHandler(this.stopwatch_Click);
            // 
            // startBTN
            // 
            this.startBTN.AutoSize = false;
            this.startBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startBTN.Depth = 0;
            this.startBTN.HighEmphasis = true;
            this.startBTN.Icon = null;
            this.startBTN.Location = new System.Drawing.Point(4, 444);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.startBTN.Name = "startBTN";
            this.startBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startBTN.Size = new System.Drawing.Size(75, 36);
            this.startBTN.TabIndex = 1;
            this.startBTN.Text = "Start";
            this.startBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startBTN.UseAccentColor = false;
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.AutoSize = false;
            this.resetBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetBTN.Depth = 0;
            this.resetBTN.HighEmphasis = true;
            this.resetBTN.Icon = null;
            this.resetBTN.Location = new System.Drawing.Point(87, 444);
            this.resetBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetBTN.Size = new System.Drawing.Size(75, 36);
            this.resetBTN.TabIndex = 2;
            this.resetBTN.Text = "Reset";
            this.resetBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetBTN.UseAccentColor = false;
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // CompleteBTN
            // 
            this.CompleteBTN.AutoSize = false;
            this.CompleteBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompleteBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CompleteBTN.Depth = 0;
            this.CompleteBTN.HighEmphasis = true;
            this.CompleteBTN.Icon = null;
            this.CompleteBTN.Location = new System.Drawing.Point(170, 444);
            this.CompleteBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompleteBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompleteBTN.Name = "CompleteBTN";
            this.CompleteBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CompleteBTN.Size = new System.Drawing.Size(75, 36);
            this.CompleteBTN.TabIndex = 3;
            this.CompleteBTN.Text = "Complete";
            this.CompleteBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CompleteBTN.UseAccentColor = false;
            this.CompleteBTN.UseVisualStyleBackColor = true;
            this.CompleteBTN.Click += new System.EventHandler(this.CompleteBTN_Click);
            // 
            // pauseBTN
            // 
            this.pauseBTN.AutoSize = false;
            this.pauseBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pauseBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pauseBTN.Depth = 0;
            this.pauseBTN.HighEmphasis = true;
            this.pauseBTN.Icon = null;
            this.pauseBTN.Location = new System.Drawing.Point(253, 444);
            this.pauseBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pauseBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pauseBTN.Size = new System.Drawing.Size(75, 36);
            this.pauseBTN.TabIndex = 4;
            this.pauseBTN.Text = "Pause";
            this.pauseBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pauseBTN.UseAccentColor = false;
            this.pauseBTN.UseVisualStyleBackColor = true;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // unpauseBTN
            // 
            this.unpauseBTN.AutoSize = false;
            this.unpauseBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unpauseBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.unpauseBTN.Depth = 0;
            this.unpauseBTN.HighEmphasis = true;
            this.unpauseBTN.Icon = null;
            this.unpauseBTN.Location = new System.Drawing.Point(335, 444);
            this.unpauseBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unpauseBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.unpauseBTN.Name = "unpauseBTN";
            this.unpauseBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.unpauseBTN.Size = new System.Drawing.Size(75, 36);
            this.unpauseBTN.TabIndex = 5;
            this.unpauseBTN.Text = "Unpause";
            this.unpauseBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.unpauseBTN.UseAccentColor = false;
            this.unpauseBTN.UseVisualStyleBackColor = true;
            this.unpauseBTN.Click += new System.EventHandler(this.unpauseBTN_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            // 
            // Completedlbl
            // 
            this.Completedlbl.Depth = 0;
            this.Completedlbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Completedlbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.Completedlbl.Location = new System.Drawing.Point(0, 85);
            this.Completedlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Completedlbl.Name = "Completedlbl";
            this.Completedlbl.Size = new System.Drawing.Size(430, 34);
            this.Completedlbl.TabIndex = 6;
            this.Completedlbl.Text = "Completed:";
            // 
            // averageTimelbl
            // 
            this.averageTimelbl.Depth = 0;
            this.averageTimelbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.averageTimelbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.averageTimelbl.Location = new System.Drawing.Point(-1, 119);
            this.averageTimelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.averageTimelbl.Name = "averageTimelbl";
            this.averageTimelbl.Size = new System.Drawing.Size(433, 35);
            this.averageTimelbl.TabIndex = 8;
            this.averageTimelbl.Text = "Average Time:";
            // 
            // bestTimelbl
            // 
            this.bestTimelbl.Depth = 0;
            this.bestTimelbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.bestTimelbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.bestTimelbl.Location = new System.Drawing.Point(-1, 154);
            this.bestTimelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.bestTimelbl.Name = "bestTimelbl";
            this.bestTimelbl.Size = new System.Drawing.Size(431, 33);
            this.bestTimelbl.TabIndex = 9;
            this.bestTimelbl.Text = "Best Time:";
            this.bestTimelbl.Click += new System.EventHandler(this.bestTimelbl_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(4, 486);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 25);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "What step are you on?";
            // 
            // people1
            // 
            this.people1.AutoSize = false;
            this.people1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.people1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.people1.Depth = 0;
            this.people1.Enabled = false;
            this.people1.HighEmphasis = true;
            this.people1.Icon = null;
            this.people1.Location = new System.Drawing.Point(4, 517);
            this.people1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.people1.MouseState = MaterialSkin.MouseState.HOVER;
            this.people1.Name = "people1";
            this.people1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.people1.Size = new System.Drawing.Size(67, 33);
            this.people1.TabIndex = 13;
            this.people1.Text = "Step 1";
            this.people1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.people1.UseAccentColor = false;
            this.people1.UseVisualStyleBackColor = true;
            this.people1.Click += new System.EventHandler(this.people1_Click);
            // 
            // people2
            // 
            this.people2.AutoSize = false;
            this.people2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.people2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.people2.Depth = 0;
            this.people2.Enabled = false;
            this.people2.HighEmphasis = true;
            this.people2.Icon = null;
            this.people2.Location = new System.Drawing.Point(79, 517);
            this.people2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.people2.MouseState = MaterialSkin.MouseState.HOVER;
            this.people2.Name = "people2";
            this.people2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.people2.Size = new System.Drawing.Size(67, 33);
            this.people2.TabIndex = 14;
            this.people2.Text = "Step 2";
            this.people2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.people2.UseAccentColor = false;
            this.people2.UseVisualStyleBackColor = true;
            this.people2.Click += new System.EventHandler(this.people2_Click);
            // 
            // people3
            // 
            this.people3.AutoSize = false;
            this.people3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.people3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.people3.Depth = 0;
            this.people3.Enabled = false;
            this.people3.HighEmphasis = true;
            this.people3.Icon = null;
            this.people3.Location = new System.Drawing.Point(154, 517);
            this.people3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.people3.MouseState = MaterialSkin.MouseState.HOVER;
            this.people3.Name = "people3";
            this.people3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.people3.Size = new System.Drawing.Size(67, 33);
            this.people3.TabIndex = 15;
            this.people3.Text = "Step 3";
            this.people3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.people3.UseAccentColor = false;
            this.people3.UseVisualStyleBackColor = true;
            this.people3.Click += new System.EventHandler(this.people3_Click);
            // 
            // people4
            // 
            this.people4.AutoSize = false;
            this.people4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.people4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.people4.Depth = 0;
            this.people4.Enabled = false;
            this.people4.HighEmphasis = true;
            this.people4.Icon = null;
            this.people4.Location = new System.Drawing.Point(229, 517);
            this.people4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.people4.MouseState = MaterialSkin.MouseState.HOVER;
            this.people4.Name = "people4";
            this.people4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.people4.Size = new System.Drawing.Size(67, 33);
            this.people4.TabIndex = 16;
            this.people4.Text = "Step 4";
            this.people4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.people4.UseAccentColor = false;
            this.people4.UseVisualStyleBackColor = true;
            this.people4.Click += new System.EventHandler(this.people4_Click);
            // 
            // target
            // 
            this.target.Depth = 0;
            this.target.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.target.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.target.Location = new System.Drawing.Point(-1, 187);
            this.target.MouseState = MaterialSkin.MouseState.HOVER;
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(459, 35);
            this.target.TabIndex = 17;
            this.target.Text = "Target Time: What Step?";
            this.target.Click += new System.EventHandler(this.target_Click);
            // 
            // exportdata
            // 
            this.exportdata.AutoSize = false;
            this.exportdata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportdata.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exportdata.Depth = 0;
            this.exportdata.HighEmphasis = true;
            this.exportdata.Icon = null;
            this.exportdata.Location = new System.Drawing.Point(383, 573);
            this.exportdata.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exportdata.MouseState = MaterialSkin.MouseState.HOVER;
            this.exportdata.Name = "exportdata";
            this.exportdata.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exportdata.Size = new System.Drawing.Size(75, 36);
            this.exportdata.TabIndex = 10;
            this.exportdata.Text = "Export Data";
            this.exportdata.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exportdata.UseAccentColor = false;
            this.exportdata.UseVisualStyleBackColor = true;
            this.exportdata.Click += new System.EventHandler(this.exportdata_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(383, 534);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(75, 36);
            this.materialButton1.TabIndex = 18;
            this.materialButton1.Text = "Manual Overide";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // behindlbl
            // 
            this.behindlbl.Depth = 0;
            this.behindlbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.behindlbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.behindlbl.Location = new System.Drawing.Point(-1, 222);
            this.behindlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.behindlbl.Name = "behindlbl";
            this.behindlbl.Size = new System.Drawing.Size(433, 35);
            this.behindlbl.TabIndex = 19;
            this.behindlbl.Text = "Behind Target:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(4, 556);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(217, 25);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "How many people are on the line?";
            // 
            // person4
            // 
            this.person4.AutoSize = false;
            this.person4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.person4.Depth = 0;
            this.person4.HighEmphasis = true;
            this.person4.Icon = null;
            this.person4.Location = new System.Drawing.Point(229, 575);
            this.person4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.person4.MouseState = MaterialSkin.MouseState.HOVER;
            this.person4.Name = "person4";
            this.person4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.person4.Size = new System.Drawing.Size(67, 33);
            this.person4.TabIndex = 24;
            this.person4.Text = "4";
            this.person4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.person4.UseAccentColor = false;
            this.person4.UseVisualStyleBackColor = true;
            this.person4.Click += new System.EventHandler(this.person4_Click);
            // 
            // person3
            // 
            this.person3.AutoSize = false;
            this.person3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.person3.Depth = 0;
            this.person3.HighEmphasis = true;
            this.person3.Icon = null;
            this.person3.Location = new System.Drawing.Point(154, 575);
            this.person3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.person3.MouseState = MaterialSkin.MouseState.HOVER;
            this.person3.Name = "person3";
            this.person3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.person3.Size = new System.Drawing.Size(67, 33);
            this.person3.TabIndex = 23;
            this.person3.Text = "3";
            this.person3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.person3.UseAccentColor = false;
            this.person3.UseVisualStyleBackColor = true;
            this.person3.Click += new System.EventHandler(this.person3_Click);
            // 
            // person2
            // 
            this.person2.AutoSize = false;
            this.person2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.person2.Depth = 0;
            this.person2.HighEmphasis = true;
            this.person2.Icon = null;
            this.person2.Location = new System.Drawing.Point(79, 575);
            this.person2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.person2.MouseState = MaterialSkin.MouseState.HOVER;
            this.person2.Name = "person2";
            this.person2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.person2.Size = new System.Drawing.Size(67, 33);
            this.person2.TabIndex = 22;
            this.person2.Text = "2";
            this.person2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.person2.UseAccentColor = false;
            this.person2.UseVisualStyleBackColor = true;
            this.person2.Click += new System.EventHandler(this.person2_Click);
            // 
            // person1
            // 
            this.person1.AutoSize = false;
            this.person1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.person1.Depth = 0;
            this.person1.HighEmphasis = true;
            this.person1.Icon = null;
            this.person1.Location = new System.Drawing.Point(4, 575);
            this.person1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.person1.MouseState = MaterialSkin.MouseState.HOVER;
            this.person1.Name = "person1";
            this.person1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.person1.Size = new System.Drawing.Size(67, 33);
            this.person1.TabIndex = 21;
            this.person1.Text = "1";
            this.person1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.person1.UseAccentColor = false;
            this.person1.UseVisualStyleBackColor = true;
            this.person1.Click += new System.EventHandler(this.person1_Click);
            // 
            // idbox
            // 
            this.idbox.Depth = 0;
            this.idbox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.idbox.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.idbox.Location = new System.Drawing.Point(2, 257);
            this.idbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(433, 35);
            this.idbox.TabIndex = 25;
            this.idbox.Text = "ID:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(2, 292);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(433, 35);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "What Build Are You Building?";
            // 
            // buildbox
            // 
            this.buildbox.FormattingEnabled = true;
            this.buildbox.Items.AddRange(new object[] {
            "I7-3770-GTX1050TI-16GB-256GB-1TB",
            "I7-3770-1650-16GB-512GB-1TB",
            "R5-4600G-NOGPU-16GB-256GB-1TB",
            "R5-5600G-NOGPU-32GB-512GB-1TB",
            "R5-5500-GTX1050TI-16GB-512GB-1TB",
            "R5-5500-RTX3060-32GB-512GB-1TB",
            "I5-10400F-GTX1650-32GB-512GB-1TB",
            "I5-10400F-RTX3060-32GB-512GB-1TB",
            "I9-11900F-RTX3060-32GB-512GB-1TB",
            "I9-11900F-RTX3060-32GB-1TB-2TB",
            "i7-13700F-RTX4070-32GB-1TB",
            "I5-10400F-RTX4060-32GB-512GB-1TB"});
            this.buildbox.Location = new System.Drawing.Point(4, 321);
            this.buildbox.Name = "buildbox";
            this.buildbox.Size = new System.Drawing.Size(306, 21);
            this.buildbox.TabIndex = 27;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(2, 345);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(308, 26);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "Scan Build ID";
            // 
            // scanBuild
            // 
            this.scanBuild.Location = new System.Drawing.Point(4, 374);
            this.scanBuild.Name = "scanBuild";
            this.scanBuild.Size = new System.Drawing.Size(158, 20);
            this.scanBuild.TabIndex = 29;
            this.scanBuild.TextChanged += new System.EventHandler(this.scanBuild_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 617);
            this.Controls.Add(this.scanBuild);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.buildbox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.person4);
            this.Controls.Add(this.person3);
            this.Controls.Add(this.person2);
            this.Controls.Add(this.person1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.behindlbl);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.target);
            this.Controls.Add(this.people4);
            this.Controls.Add(this.people3);
            this.Controls.Add(this.people2);
            this.Controls.Add(this.people1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.exportdata);
            this.Controls.Add(this.bestTimelbl);
            this.Controls.Add(this.averageTimelbl);
            this.Controls.Add(this.Completedlbl);
            this.Controls.Add(this.unpauseBTN);
            this.Controls.Add(this.pauseBTN);
            this.Controls.Add(this.CompleteBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.stopwatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.Sizable = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel averageTimelbl;
        public MaterialSkin.Controls.MaterialLabel bestTimelbl;
        public MaterialSkin.Controls.MaterialLabel target;
        public MaterialSkin.Controls.MaterialLabel stopwatch;
        public MaterialSkin.Controls.MaterialButton startBTN;
        public MaterialSkin.Controls.MaterialButton resetBTN;
        public MaterialSkin.Controls.MaterialButton CompleteBTN;
        public MaterialSkin.Controls.MaterialButton pauseBTN;
        public MaterialSkin.Controls.MaterialButton unpauseBTN;
        public MaterialSkin.Controls.MaterialLabel Completedlbl;
        public MaterialSkin.Controls.MaterialButton people1;
        public MaterialSkin.Controls.MaterialButton people2;
        public MaterialSkin.Controls.MaterialButton people3;
        public MaterialSkin.Controls.MaterialButton people4;
        public MaterialSkin.Controls.MaterialButton exportdata;
        public MaterialSkin.Controls.MaterialButton materialButton1;
        public MaterialSkin.Controls.MaterialLabel behindlbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialButton person4;
        public MaterialSkin.Controls.MaterialButton person3;
        public MaterialSkin.Controls.MaterialButton person2;
        public MaterialSkin.Controls.MaterialButton person1;
        public MaterialSkin.Controls.MaterialLabel idbox;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox buildbox;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox scanBuild;
    }
}

