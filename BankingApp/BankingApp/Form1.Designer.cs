namespace BankingApp
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
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAcc = new System.Windows.Forms.TextBox();
            this.txtBxBal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIniBal = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxDep = new System.Windows.Forms.TextBox();
            this.txtBxWith = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblWith = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAccBalName = new System.Windows.Forms.Label();
            this.lblAccountBal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(130, 68);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(173, 26);
            this.txtBxName.TabIndex = 0;
            this.txtBxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxAcc
            // 
            this.txtBxAcc.Location = new System.Drawing.Point(130, 100);
            this.txtBxAcc.Name = "txtBxAcc";
            this.txtBxAcc.Size = new System.Drawing.Size(173, 26);
            this.txtBxAcc.TabIndex = 2;
            this.txtBxAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxBal
            // 
            this.txtBxBal.Location = new System.Drawing.Point(130, 133);
            this.txtBxBal.Name = "txtBxBal";
            this.txtBxBal.Size = new System.Drawing.Size(173, 26);
            this.txtBxBal.TabIndex = 3;
            this.txtBxBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account #:";
            // 
            // lblIniBal
            // 
            this.lblIniBal.AutoSize = true;
            this.lblIniBal.Location = new System.Drawing.Point(16, 136);
            this.lblIniBal.Name = "lblIniBal";
            this.lblIniBal.Size = new System.Drawing.Size(112, 20);
            this.lblIniBal.TabIndex = 7;
            this.lblIniBal.Text = "Initial Balance:";
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(91, 165);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(160, 44);
            this.btnAddAcc.TabIndex = 8;
            this.btnAddAcc.Text = "Create Account";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Banking Application";
            // 
            // txtBxDep
            // 
            this.txtBxDep.Location = new System.Drawing.Point(98, 238);
            this.txtBxDep.Name = "txtBxDep";
            this.txtBxDep.Size = new System.Drawing.Size(100, 26);
            this.txtBxDep.TabIndex = 10;
            this.txtBxDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxDep.Visible = false;
            // 
            // txtBxWith
            // 
            this.txtBxWith.Location = new System.Drawing.Point(98, 284);
            this.txtBxWith.Name = "txtBxWith";
            this.txtBxWith.Size = new System.Drawing.Size(100, 26);
            this.txtBxWith.TabIndex = 11;
            this.txtBxWith.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxWith.Visible = false;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(3, 241);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(64, 20);
            this.lblDep.TabIndex = 12;
            this.lblDep.Text = "Deposit";
            this.lblDep.Visible = false;
            // 
            // lblWith
            // 
            this.lblWith.AutoSize = true;
            this.lblWith.Location = new System.Drawing.Point(3, 284);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(87, 20);
            this.lblWith.TabIndex = 13;
            this.lblWith.Text = "Withdrawal";
            this.lblWith.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAccBalName
            // 
            this.lblAccBalName.AutoSize = true;
            this.lblAccBalName.Location = new System.Drawing.Point(212, 244);
            this.lblAccBalName.Name = "lblAccBalName";
            this.lblAccBalName.Size = new System.Drawing.Size(134, 20);
            this.lblAccBalName.TabIndex = 15;
            this.lblAccBalName.Text = "Account Balance:";
            this.lblAccBalName.Visible = false;
            // 
            // lblAccountBal
            // 
            this.lblAccountBal.AutoSize = true;
            this.lblAccountBal.Location = new System.Drawing.Point(216, 289);
            this.lblAccountBal.Name = "lblAccountBal";
            this.lblAccountBal.Size = new System.Drawing.Size(144, 20);
            this.lblAccountBal.TabIndex = 16;
            this.lblAccountBal.Text = "Actual Account Bal";
            this.lblAccountBal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 411);
            this.Controls.Add(this.lblAccountBal);
            this.Controls.Add(this.lblAccBalName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWith);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.txtBxWith);
            this.Controls.Add(this.txtBxDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.lblIniBal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxBal);
            this.Controls.Add(this.txtBxAcc);
            this.Controls.Add(this.txtBxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAcc;
        private System.Windows.Forms.TextBox txtBxBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIniBal;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxDep;
        private System.Windows.Forms.TextBox txtBxWith;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblWith;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAccBalName;
        private System.Windows.Forms.Label lblAccountBal;
    }
}

