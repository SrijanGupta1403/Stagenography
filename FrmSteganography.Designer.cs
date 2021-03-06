namespace Image2Image
{
    partial class FrmSteganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSteganography));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Load_img = new System.Windows.Forms.Label();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.DeLoadImage_tbx = new System.Windows.Forms.TextBox();
            this.DeSaveFile_tbx = new System.Windows.Forms.TextBox();
            this.DeSaveFileBrowse_btn = new System.Windows.Forms.Button();
            this.Save_File = new System.Windows.Forms.Label();
            this.DeLoadImageBrowse_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.EnFileBrowse_btn = new System.Windows.Forms.Button();
            this.EnImageBrowse_btn = new System.Windows.Forms.Button();
            this.Load_file = new System.Windows.Forms.Label();
            this.EnFile_tbx = new System.Windows.Forms.TextBox();
            this.Load_En_Image = new System.Windows.Forms.Label();
            this.EnImage_tbx = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.Image_Pre = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ByteCapacity_lbl = new System.Windows.Forms.Label();
            this.CanSave_lbl = new System.Windows.Forms.Label();
            this.ImageWidth_lbl = new System.Windows.Forms.Label();
            this.ImageHeight_lbl = new System.Windows.Forms.Label();
            this.ImageSize_lbl = new System.Windows.Forms.Label();
            this.Can_Save = new System.Windows.Forms.Label();
            this.Width_Lable = new System.Windows.Forms.Label();
            this.Height_lable = new System.Windows.Forms.Label();
            this.Size_Lable = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Close_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Load_img);
            this.groupBox1.Controls.Add(this.Decrypt_btn);
            this.groupBox1.Controls.Add(this.DeLoadImage_tbx);
            this.groupBox1.Controls.Add(this.DeSaveFile_tbx);
            this.groupBox1.Controls.Add(this.DeSaveFileBrowse_btn);
            this.groupBox1.Controls.Add(this.Save_File);
            this.groupBox1.Controls.Add(this.DeLoadImageBrowse_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(480, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Load_img
            // 
            this.Load_img.AutoSize = true;
            this.Load_img.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_img.Location = new System.Drawing.Point(10, 34);
            this.Load_img.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Load_img.Name = "Load_img";
            this.Load_img.Size = new System.Drawing.Size(105, 19);
            this.Load_img.TabIndex = 1;
            this.Load_img.Text = "Load Image :";
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt_btn.Location = new System.Drawing.Point(184, 126);
            this.Decrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(112, 35);
            this.Decrypt_btn.TabIndex = 3;
            this.Decrypt_btn.Text = "Decryption";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // DeLoadImage_tbx
            // 
            this.DeLoadImage_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeLoadImage_tbx.Location = new System.Drawing.Point(117, 29);
            this.DeLoadImage_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeLoadImage_tbx.Name = "DeLoadImage_tbx";
            this.DeLoadImage_tbx.Size = new System.Drawing.Size(230, 26);
            this.DeLoadImage_tbx.TabIndex = 0;
            // 
            // DeSaveFile_tbx
            // 
            this.DeSaveFile_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeSaveFile_tbx.Location = new System.Drawing.Point(117, 83);
            this.DeSaveFile_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeSaveFile_tbx.Name = "DeSaveFile_tbx";
            this.DeSaveFile_tbx.Size = new System.Drawing.Size(230, 26);
            this.DeSaveFile_tbx.TabIndex = 2;
            // 
            // DeSaveFileBrowse_btn
            // 
            this.DeSaveFileBrowse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeSaveFileBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeSaveFileBrowse_btn.Location = new System.Drawing.Point(358, 80);
            this.DeSaveFileBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeSaveFileBrowse_btn.Name = "DeSaveFileBrowse_btn";
            this.DeSaveFileBrowse_btn.Size = new System.Drawing.Size(112, 35);
            this.DeSaveFileBrowse_btn.TabIndex = 3;
            this.DeSaveFileBrowse_btn.Text = "Browse";
            this.DeSaveFileBrowse_btn.UseVisualStyleBackColor = true;
            this.DeSaveFileBrowse_btn.Click += new System.EventHandler(this.DeSaveFileBrowse_btn_Click);
            // 
            // Save_File
            // 
            this.Save_File.AutoSize = true;
            this.Save_File.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_File.Location = new System.Drawing.Point(10, 88);
            this.Save_File.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Save_File.Name = "Save_File";
            this.Save_File.Size = new System.Drawing.Size(94, 19);
            this.Save_File.TabIndex = 1;
            this.Save_File.Text = "Save file to:";
            // 
            // DeLoadImageBrowse_btn
            // 
            this.DeLoadImageBrowse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeLoadImageBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeLoadImageBrowse_btn.Location = new System.Drawing.Point(358, 26);
            this.DeLoadImageBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeLoadImageBrowse_btn.Name = "DeLoadImageBrowse_btn";
            this.DeLoadImageBrowse_btn.Size = new System.Drawing.Size(112, 35);
            this.DeLoadImageBrowse_btn.TabIndex = 1;
            this.DeLoadImageBrowse_btn.Text = "Browse";
            this.DeLoadImageBrowse_btn.UseVisualStyleBackColor = true;
            this.DeLoadImageBrowse_btn.Click += new System.EventHandler(this.DeLoadImageBrowse_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Encrypt_btn);
            this.groupBox2.Controls.Add(this.EnFileBrowse_btn);
            this.groupBox2.Controls.Add(this.EnImageBrowse_btn);
            this.groupBox2.Controls.Add(this.Load_file);
            this.groupBox2.Controls.Add(this.EnFile_tbx);
            this.groupBox2.Controls.Add(this.Load_En_Image);
            this.groupBox2.Controls.Add(this.EnImage_tbx);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(565, 173);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_btn.Location = new System.Drawing.Point(184, 128);
            this.Encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(112, 35);
            this.Encrypt_btn.TabIndex = 3;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // EnFileBrowse_btn
            // 
            this.EnFileBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnFileBrowse_btn.Location = new System.Drawing.Point(443, 80);
            this.EnFileBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnFileBrowse_btn.Name = "EnFileBrowse_btn";
            this.EnFileBrowse_btn.Size = new System.Drawing.Size(112, 35);
            this.EnFileBrowse_btn.TabIndex = 3;
            this.EnFileBrowse_btn.Text = "Browse";
            this.EnFileBrowse_btn.UseVisualStyleBackColor = true;
            this.EnFileBrowse_btn.Click += new System.EventHandler(this.EnFileBrowse_btn_Click);
            // 
            // EnImageBrowse_btn
            // 
            this.EnImageBrowse_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnImageBrowse_btn.Location = new System.Drawing.Point(445, 26);
            this.EnImageBrowse_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnImageBrowse_btn.Name = "EnImageBrowse_btn";
            this.EnImageBrowse_btn.Size = new System.Drawing.Size(112, 35);
            this.EnImageBrowse_btn.TabIndex = 1;
            this.EnImageBrowse_btn.Text = "Browse";
            this.EnImageBrowse_btn.UseVisualStyleBackColor = true;
            this.EnImageBrowse_btn.Click += new System.EventHandler(this.EnImageBrowse_btn_Click);
            // 
            // Load_file
            // 
            this.Load_file.AutoSize = true;
            this.Load_file.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_file.Location = new System.Drawing.Point(9, 88);
            this.Load_file.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Load_file.Name = "Load_file";
            this.Load_file.Size = new System.Drawing.Size(86, 19);
            this.Load_file.TabIndex = 1;
            this.Load_file.Text = "Load file  :";
            // 
            // EnFile_tbx
            // 
            this.EnFile_tbx.Location = new System.Drawing.Point(116, 84);
            this.EnFile_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnFile_tbx.Name = "EnFile_tbx";
            this.EnFile_tbx.Size = new System.Drawing.Size(319, 26);
            this.EnFile_tbx.TabIndex = 2;
            // 
            // Load_En_Image
            // 
            this.Load_En_Image.AutoSize = true;
            this.Load_En_Image.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_En_Image.Location = new System.Drawing.Point(9, 34);
            this.Load_En_Image.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Load_En_Image.Name = "Load_En_Image";
            this.Load_En_Image.Size = new System.Drawing.Size(100, 19);
            this.Load_En_Image.TabIndex = 1;
            this.Load_En_Image.Text = "Load Image:";
            // 
            // EnImage_tbx
            // 
            this.EnImage_tbx.Location = new System.Drawing.Point(116, 31);
            this.EnImage_tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnImage_tbx.Name = "EnImage_tbx";
            this.EnImage_tbx.Size = new System.Drawing.Size(319, 26);
            this.EnImage_tbx.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // Image_Pre
            // 
            this.Image_Pre.AutoSize = true;
            this.Image_Pre.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image_Pre.ForeColor = System.Drawing.Color.Black;
            this.Image_Pre.Location = new System.Drawing.Point(12, 223);
            this.Image_Pre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Image_Pre.Name = "Image_Pre";
            this.Image_Pre.Size = new System.Drawing.Size(133, 19);
            this.Image_Pre.TabIndex = 1;
            this.Image_Pre.Text = "Image Preview :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.ByteCapacity_lbl);
            this.groupBox3.Controls.Add(this.CanSave_lbl);
            this.groupBox3.Controls.Add(this.ImageWidth_lbl);
            this.groupBox3.Controls.Add(this.ImageHeight_lbl);
            this.groupBox3.Controls.Add(this.ImageSize_lbl);
            this.groupBox3.Controls.Add(this.Can_Save);
            this.groupBox3.Controls.Add(this.Width_Lable);
            this.groupBox3.Controls.Add(this.Height_lable);
            this.groupBox3.Controls.Add(this.Size_Lable);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(692, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(216, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ByteCapacity_lbl
            // 
            this.ByteCapacity_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ByteCapacity_lbl.AutoSize = true;
            this.ByteCapacity_lbl.Location = new System.Drawing.Point(132, 72);
            this.ByteCapacity_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ByteCapacity_lbl.Name = "ByteCapacity_lbl";
            this.ByteCapacity_lbl.Size = new System.Drawing.Size(0, 19);
            this.ByteCapacity_lbl.TabIndex = 2;
            // 
            // CanSave_lbl
            // 
            this.CanSave_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CanSave_lbl.AutoSize = true;
            this.CanSave_lbl.Location = new System.Drawing.Point(116, 149);
            this.CanSave_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CanSave_lbl.Name = "CanSave_lbl";
            this.CanSave_lbl.Size = new System.Drawing.Size(48, 19);
            this.CanSave_lbl.TabIndex = 1;
            this.CanSave_lbl.Text = "none";
            // 
            // ImageWidth_lbl
            // 
            this.ImageWidth_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageWidth_lbl.AutoSize = true;
            this.ImageWidth_lbl.Location = new System.Drawing.Point(116, 111);
            this.ImageWidth_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageWidth_lbl.Name = "ImageWidth_lbl";
            this.ImageWidth_lbl.Size = new System.Drawing.Size(18, 19);
            this.ImageWidth_lbl.TabIndex = 1;
            this.ImageWidth_lbl.Text = "0";
            // 
            // ImageHeight_lbl
            // 
            this.ImageHeight_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageHeight_lbl.AutoSize = true;
            this.ImageHeight_lbl.Location = new System.Drawing.Point(116, 72);
            this.ImageHeight_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageHeight_lbl.Name = "ImageHeight_lbl";
            this.ImageHeight_lbl.Size = new System.Drawing.Size(18, 19);
            this.ImageHeight_lbl.TabIndex = 1;
            this.ImageHeight_lbl.Text = "0";
            // 
            // ImageSize_lbl
            // 
            this.ImageSize_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSize_lbl.AutoSize = true;
            this.ImageSize_lbl.Location = new System.Drawing.Point(116, 34);
            this.ImageSize_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImageSize_lbl.Name = "ImageSize_lbl";
            this.ImageSize_lbl.Size = new System.Drawing.Size(18, 19);
            this.ImageSize_lbl.TabIndex = 1;
            this.ImageSize_lbl.Text = "0";
            // 
            // Can_Save
            // 
            this.Can_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Can_Save.AutoSize = true;
            this.Can_Save.Location = new System.Drawing.Point(20, 149);
            this.Can_Save.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Can_Save.Name = "Can_Save";
            this.Can_Save.Size = new System.Drawing.Size(94, 19);
            this.Can_Save.TabIndex = 0;
            this.Can_Save.Text = "Can Save: ";
            this.Can_Save.Click += new System.EventHandler(this.label9_Click);
            // 
            // Width_Lable
            // 
            this.Width_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Width_Lable.AutoSize = true;
            this.Width_Lable.Location = new System.Drawing.Point(20, 111);
            this.Width_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Width_Lable.Name = "Width_Lable";
            this.Width_Lable.Size = new System.Drawing.Size(67, 19);
            this.Width_Lable.TabIndex = 0;
            this.Width_Lable.Text = "Width: ";
            // 
            // Height_lable
            // 
            this.Height_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Height_lable.AutoSize = true;
            this.Height_lable.Location = new System.Drawing.Point(20, 72);
            this.Height_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Height_lable.Name = "Height_lable";
            this.Height_lable.Size = new System.Drawing.Size(71, 19);
            this.Height_lable.TabIndex = 0;
            this.Height_lable.Text = "Height: ";
            // 
            // Size_Lable
            // 
            this.Size_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Size_Lable.AutoSize = true;
            this.Size_Lable.Location = new System.Drawing.Point(20, 34);
            this.Size_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Size_Lable.Name = "Size_Lable";
            this.Size_Lable.Size = new System.Drawing.Size(53, 19);
            this.Size_Lable.TabIndex = 0;
            this.Size_Lable.Text = "Size: ";
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close_btn.Location = new System.Drawing.Point(790, 929);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(112, 35);
            this.Close_btn.TabIndex = 3;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Visible = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 971);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(921, 32);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "StatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(8, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 223);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(666, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt Image";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(666, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt Image";
            // 
            // FrmSteganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton = this.Close_btn;
            this.ClientSize = new System.Drawing.Size(921, 1003);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Image_Pre);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSteganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography ";
            this.Load += new System.EventHandler(this.FrmSteganography_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EnImageBrowse_btn;
        private System.Windows.Forms.Label Load_En_Image;
        private System.Windows.Forms.TextBox EnImage_tbx;
        private System.Windows.Forms.Button EnFileBrowse_btn;
        private System.Windows.Forms.Label Load_file;
        private System.Windows.Forms.TextBox EnFile_tbx;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Load_img;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.TextBox DeLoadImage_tbx;
        private System.Windows.Forms.TextBox DeSaveFile_tbx;
        private System.Windows.Forms.Button DeSaveFileBrowse_btn;
        private System.Windows.Forms.Label Save_File;
        private System.Windows.Forms.Button DeLoadImageBrowse_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Label Image_Pre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Size_Lable;
        private System.Windows.Forms.Label Can_Save;
        private System.Windows.Forms.Label ByteCapacity_lbl;
        private System.Windows.Forms.Label ImageSize_lbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label CanSave_lbl;
        private System.Windows.Forms.Label ImageWidth_lbl;
        private System.Windows.Forms.Label ImageHeight_lbl;
        private System.Windows.Forms.Label Width_Lable;
        private System.Windows.Forms.Label Height_lable;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

