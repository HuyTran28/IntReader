
namespace Đọc_số_nguyên
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.tickViet = new System.Windows.Forms.RadioButton();
            this.tickEng = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tickMale = new System.Windows.Forms.RadioButton();
            this.tickFemale = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.grLang = new System.Windows.Forms.Panel();
            this.grGender = new System.Windows.Forms.Panel();
            this.tipRead = new System.Windows.Forms.ToolTip(this.components);
            this.grLang.SuspendLayout();
            this.grGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(133, 34);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(303, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số nguyên";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 181);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(421, 170);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // tickViet
            // 
            this.tickViet.AutoSize = true;
            this.tickViet.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickViet.Location = new System.Drawing.Point(16, 4);
            this.tickViet.Name = "tickViet";
            this.tickViet.Size = new System.Drawing.Size(100, 23);
            this.tickViet.TabIndex = 3;
            this.tickViet.TabStop = true;
            this.tickViet.Text = "Tiếng Việt ";
            this.tickViet.UseVisualStyleBackColor = true;
            this.tickViet.Click += new System.EventHandler(this.allTick_Click);
            // 
            // tickEng
            // 
            this.tickEng.AutoSize = true;
            this.tickEng.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickEng.Location = new System.Drawing.Point(179, 6);
            this.tickEng.Name = "tickEng";
            this.tickEng.Size = new System.Drawing.Size(94, 23);
            this.tickEng.TabIndex = 4;
            this.tickEng.TabStop = true;
            this.tickEng.Text = "Tiếng Anh";
            this.tickEng.UseVisualStyleBackColor = true;
            this.tickEng.Click += new System.EventHandler(this.allTick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn ngôn ngữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn giọng đọc";
            // 
            // tickMale
            // 
            this.tickMale.AutoSize = true;
            this.tickMale.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickMale.Location = new System.Drawing.Point(16, 1);
            this.tickMale.Name = "tickMale";
            this.tickMale.Size = new System.Drawing.Size(59, 23);
            this.tickMale.TabIndex = 7;
            this.tickMale.TabStop = true;
            this.tickMale.Text = "Nam";
            this.tickMale.UseVisualStyleBackColor = true;
            // 
            // tickFemale
            // 
            this.tickFemale.AutoSize = true;
            this.tickFemale.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickFemale.Location = new System.Drawing.Point(179, 1);
            this.tickFemale.Name = "tickFemale";
            this.tickFemale.Size = new System.Drawing.Size(48, 23);
            this.tickFemale.TabIndex = 8;
            this.tickFemale.TabStop = true;
            this.tickFemale.Text = "Nữ";
            this.tickFemale.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(396, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.Image = ((System.Drawing.Image)(resources.GetObject("btnRead.Image")));
            this.btnRead.Location = new System.Drawing.Point(392, 143);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(41, 32);
            this.btnRead.TabIndex = 11;
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            this.btnRead.MouseEnter += new System.EventHandler(this.btnRead_MouseEnter);
            // 
            // grLang
            // 
            this.grLang.Controls.Add(this.tickViet);
            this.grLang.Controls.Add(this.tickEng);
            this.grLang.Location = new System.Drawing.Point(160, 66);
            this.grLang.Name = "grLang";
            this.grLang.Size = new System.Drawing.Size(276, 32);
            this.grLang.TabIndex = 12;
            // 
            // grGender
            // 
            this.grGender.Controls.Add(this.tickMale);
            this.grGender.Controls.Add(this.tickFemale);
            this.grGender.Location = new System.Drawing.Point(160, 101);
            this.grGender.Name = "grGender";
            this.grGender.Size = new System.Drawing.Size(276, 22);
            this.grGender.TabIndex = 13;
            // 
            // tipRead
            // 
            this.tipRead.ShowAlways = true;
            this.tipRead.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(443, 405);
            this.Controls.Add(this.grGender);
            this.Controls.Add(this.grLang);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc số nguyên";
            this.grLang.ResumeLayout(false);
            this.grLang.PerformLayout();
            this.grGender.ResumeLayout(false);
            this.grGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RadioButton tickViet;
        private System.Windows.Forms.RadioButton tickEng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton tickMale;
        private System.Windows.Forms.RadioButton tickFemale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Panel grLang;
        private System.Windows.Forms.Panel grGender;
        private System.Windows.Forms.ToolTip tipRead;
    }
}

