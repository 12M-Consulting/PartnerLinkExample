namespace PartnerLinkExample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtExample1 = new System.Windows.Forms.TextBox();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.txtExample2 = new System.Windows.Forms.TextBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnGetToken);
            this.groupBox1.Location = new System.Drawing.Point(463, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 195);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authenticaton - /api/v1/auth/authorize (GET)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(81, 116);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.ReadOnly = true;
            this.txtToken.Size = new System.Drawing.Size(238, 67);
            this.txtToken.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(81, 52);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(238, 20);
            this.txtPwd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(238, 20);
            this.txtUserName.TabIndex = 9;
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(250, 78);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(69, 23);
            this.btnGetToken.TabIndex = 8;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnExample2);
            this.groupBox2.Controls.Add(this.txtExample2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnExample1);
            this.groupBox2.Controls.Add(this.txtExample1);
            this.groupBox2.Location = new System.Drawing.Point(463, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 251);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product - /api/v1/odata/GetProducts (GET)";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(544, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(244, 20);
            this.txtUrl.TabIndex = 10;
            this.txtUrl.Text = "http://partnerlink.tumpaelektrik.com:5001/";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(509, 19);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 11;
            this.urlLabel.Text = "URL";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(444, 497);
            this.txtResult.TabIndex = 12;
            // 
            // txtExample1
            // 
            this.txtExample1.Location = new System.Drawing.Point(77, 34);
            this.txtExample1.Multiline = true;
            this.txtExample1.Name = "txtExample1";
            this.txtExample1.Size = new System.Drawing.Size(195, 46);
            this.txtExample1.TabIndex = 0;
            this.txtExample1.Text = "api/v1/odata/GetProducts?top=5";
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(278, 31);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(41, 23);
            this.btnExample1.TabIndex = 9;
            this.btnExample1.Text = "GET";
            this.btnExample1.UseVisualStyleBackColor = true;
            this.btnExample1.Click += new System.EventHandler(this.btnExample1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Example 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Example 2";
            // 
            // btnExample2
            // 
            this.btnExample2.Location = new System.Drawing.Point(278, 86);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(41, 23);
            this.btnExample2.TabIndex = 17;
            this.btnExample2.Text = "GET";
            this.btnExample2.UseVisualStyleBackColor = true;
            this.btnExample2.Click += new System.EventHandler(this.btnExample2_Click);
            // 
            // txtExample2
            // 
            this.txtExample2.Location = new System.Drawing.Point(77, 86);
            this.txtExample2.Multiline = true;
            this.txtExample2.Name = "txtExample2";
            this.txtExample2.Size = new System.Drawing.Size(195, 48);
            this.txtExample2.TabIndex = 16;
            this.txtExample2.Text = "api/v1/odata/GetProducts?$filter=contains(MalKodu,\'PHILIPS\')";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProcess.Location = new System.Drawing.Point(182, 216);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(460, 73);
            this.lblProcess.TabIndex = 13;
            this.lblProcess.Text = "PROCESSING";
            this.lblProcess.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.TextBox txtExample2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.TextBox txtExample1;
        private System.Windows.Forms.Label lblProcess;
    }
}

