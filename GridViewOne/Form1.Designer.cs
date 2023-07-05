namespace GridViewOne
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select_file = new System.Windows.Forms.OpenFileDialog();
            this.txt_file_name = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.status_richTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_file_selector = new System.Windows.Forms.Button();
            this.serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_select_file = new System.Windows.Forms.DataGridViewButtonColumn();
            this.new_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.progress_bar = new System.Windows.Forms.DataGridViewImageColumn();
            this.file_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_number,
            this.file_name,
            this.btn_select_file,
            this.new_password,
            this.btn_save,
            this.progress_bar,
            this.file_status});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(13, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 290);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // select_file
            // 
            this.select_file.FileName = "openFileDialog1";
            // 
            // txt_file_name
            // 
            this.txt_file_name.Location = new System.Drawing.Point(150, 123);
            this.txt_file_name.Name = "txt_file_name";
            this.txt_file_name.Size = new System.Drawing.Size(105, 20);
            this.txt_file_name.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(555, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "GridView App Sample for DLL";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(355, 122);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(98, 20);
            this.txt_password.TabIndex = 14;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(457, 123);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 20);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // status_richTextBox
            // 
            this.status_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status_richTextBox.Location = new System.Drawing.Point(655, 124);
            this.status_richTextBox.Name = "status_richTextBox";
            this.status_richTextBox.Size = new System.Drawing.Size(100, 19);
            this.status_richTextBox.TabIndex = 13;
            this.status_richTextBox.Text = "";
            // 
            // btn_file_selector
            // 
            this.btn_file_selector.Location = new System.Drawing.Point(256, 121);
            this.btn_file_selector.Name = "btn_file_selector";
            this.btn_file_selector.Size = new System.Drawing.Size(98, 22);
            this.btn_file_selector.TabIndex = 8;
            this.btn_file_selector.Text = "Browse";
            this.btn_file_selector.UseVisualStyleBackColor = true;
            this.btn_file_selector.Click += new System.EventHandler(this.btn_file_selector_Click);
            // 
            // serial_number
            // 
            this.serial_number.HeaderText = "Sr. No.";
            this.serial_number.MaxInputLength = 4;
            this.serial_number.Name = "serial_number";
            this.serial_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // file_name
            // 
            this.file_name.HeaderText = "File Name";
            this.file_name.Name = "file_name";
            // 
            // btn_select_file
            // 
            this.btn_select_file.HeaderText = "Select";
            this.btn_select_file.Name = "btn_select_file";
            // 
            // new_password
            // 
            this.new_password.HeaderText = "Password";
            this.new_password.Name = "new_password";
            // 
            // btn_save
            // 
            this.btn_save.HeaderText = "Save";
            this.btn_save.Name = "btn_save";
            this.btn_save.Text = "Save";
            this.btn_save.ToolTipText = "Pause Operation";
            // 
            // progress_bar
            // 
            this.progress_bar.HeaderText = "Progress";
            this.progress_bar.Name = "progress_bar";
            // 
            // file_status
            // 
            this.file_status.HeaderText = "Status";
            this.file_status.Name = "file_status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(768, 443);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.status_richTextBox);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_file_name);
            this.Controls.Add(this.btn_file_selector);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GridView Example APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_file_name;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox status_richTextBox;
        private System.Windows.Forms.Button btn_file_selector;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
        private System.Windows.Forms.DataGridViewButtonColumn btn_select_file;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_password;
        private System.Windows.Forms.DataGridViewButtonColumn btn_save;
        private System.Windows.Forms.DataGridViewImageColumn progress_bar;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_status;
    }
}

