namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNewsData = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRevise = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btClearImage = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbGaisya = new System.Windows.Forms.RadioButton();
            this.rbSonota = new System.Windows.Forms.RadioButton();
            this.GroopBox = new System.Windows.Forms.GroupBox();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新規入力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.GroopBox.SuspendLayout();
            this.ファイルFToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "記録者:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "日付:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(41, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(26, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(103, 200);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(339, 139);
            this.tb.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(21, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧:";
            // 
            // dgvNewsData
            // 
            this.dgvNewsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewsData.Location = new System.Drawing.Point(103, 344);
            this.dgvNewsData.Name = "dgvNewsData";
            this.dgvNewsData.RowTemplate.Height = 21;
            this.dgvNewsData.Size = new System.Drawing.Size(601, 176);
            this.dgvNewsData.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(102, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(184, 19);
            this.dtpDate.TabIndex = 3;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(102, 77);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(208, 20);
            this.cbAuthor.TabIndex = 4;
            // 
            // cbCar
            // 
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(103, 159);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(208, 20);
            this.cbCar.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "開く";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(465, 92);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(239, 204);
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(444, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像:";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(463, 313);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(73, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRevise
            // 
            this.btRevise.Location = new System.Drawing.Point(549, 313);
            this.btRevise.Name = "btRevise";
            this.btRevise.Size = new System.Drawing.Size(70, 23);
            this.btRevise.TabIndex = 7;
            this.btRevise.Text = "修正";
            this.btRevise.UseVisualStyleBackColor = true;
            this.btRevise.Click += new System.EventHandler(this.btRevise_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(632, 313);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(70, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(502, 63);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(82, 23);
            this.btOpenImage.TabIndex = 7;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btClearImage
            // 
            this.btClearImage.Location = new System.Drawing.Point(620, 63);
            this.btClearImage.Name = "btClearImage";
            this.btClearImage.Size = new System.Drawing.Size(84, 23);
            this.btClearImage.TabIndex = 7;
            this.btClearImage.Text = "削除";
            this.btClearImage.UseVisualStyleBackColor = true;
            this.btClearImage.Click += new System.EventHandler(this.btClearImage_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(594, 526);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = "終了";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.BackColor = System.Drawing.SystemColors.Control;
            this.rbToyota.Location = new System.Drawing.Point(6, 18);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 8;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = false;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.BackColor = System.Drawing.SystemColors.Control;
            this.rbNissan.Location = new System.Drawing.Point(59, 18);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 8;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = false;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.BackColor = System.Drawing.SystemColors.Control;
            this.rbHonda.Location = new System.Drawing.Point(112, 18);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 8;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = false;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.BackColor = System.Drawing.SystemColors.Control;
            this.rbSubaru.Location = new System.Drawing.Point(169, 18);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 8;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = false;
            // 
            // rbGaisya
            // 
            this.rbGaisya.AutoSize = true;
            this.rbGaisya.BackColor = System.Drawing.SystemColors.Control;
            this.rbGaisya.Location = new System.Drawing.Point(227, 18);
            this.rbGaisya.Name = "rbGaisya";
            this.rbGaisya.Size = new System.Drawing.Size(47, 16);
            this.rbGaisya.TabIndex = 8;
            this.rbGaisya.TabStop = true;
            this.rbGaisya.Text = "外車";
            this.rbGaisya.UseVisualStyleBackColor = false;
            // 
            // rbSonota
            // 
            this.rbSonota.AutoSize = true;
            this.rbSonota.BackColor = System.Drawing.SystemColors.Control;
            this.rbSonota.Location = new System.Drawing.Point(280, 18);
            this.rbSonota.Name = "rbSonota";
            this.rbSonota.Size = new System.Drawing.Size(54, 16);
            this.rbSonota.TabIndex = 8;
            this.rbSonota.TabStop = true;
            this.rbSonota.Text = "その他";
            this.rbSonota.UseVisualStyleBackColor = false;
            // 
            // GroopBox
            // 
            this.GroopBox.Controls.Add(this.rbToyota);
            this.GroopBox.Controls.Add(this.rbSonota);
            this.GroopBox.Controls.Add(this.rbNissan);
            this.GroopBox.Controls.Add(this.rbGaisya);
            this.GroopBox.Controls.Add(this.rbHonda);
            this.GroopBox.Controls.Add(this.rbSubaru);
            this.GroopBox.Location = new System.Drawing.Point(103, 103);
            this.GroopBox.Name = "GroopBox";
            this.GroopBox.Size = new System.Drawing.Size(339, 50);
            this.GroopBox.TabIndex = 9;
            this.GroopBox.TabStop = false;
            this.GroopBox.Text = "Maker";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem1});
            this.ファイルFToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(730, 24);
            this.ファイルFToolStripMenuItem.TabIndex = 10;
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ファイルFToolStripMenuItem1
            // 
            this.ファイルFToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規入力ToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem1.Name = "ファイルFToolStripMenuItem1";
            this.ファイルFToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem1.Text = "ファイル(&F)";
            // 
            // 新規入力ToolStripMenuItem
            // 
            this.新規入力ToolStripMenuItem.Name = "新規入力ToolStripMenuItem";
            this.新規入力ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新規入力ToolStripMenuItem.Text = "新規入力";
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(730, 563);
            this.Controls.Add(this.GroopBox);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRevise);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btClearImage);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCar);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvNewsData);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ファイルFToolStripMenuItem);
            this.MainMenuStrip = this.ファイルFToolStripMenuItem;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.GroopBox.ResumeLayout(false);
            this.GroopBox.PerformLayout();
            this.ファイルFToolStripMenuItem.ResumeLayout(false);
            this.ファイルFToolStripMenuItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNewsData;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbAuthor;
        private new System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRevise;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btClearImage;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbGaisya;
        private System.Windows.Forms.RadioButton rbSonota;
        private System.Windows.Forms.GroupBox GroopBox;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.MenuStrip ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新規入力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
    }
}

