﻿namespace FinancialManager_VukJan
{
    partial class FrmAddExpense
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
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.lblExpenseDate = new System.Windows.Forms.Label();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpenseDate = new System.Windows.Forms.TextBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.cbmNeeded = new System.Windows.Forms.ComboBox();
            this.lblExpenseDescription = new System.Windows.Forms.Label();
            this.txtExpenseDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblExpenseName
            // 
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(49, 46);
            this.lblExpenseName.Name = "lblExpenseName";
            this.lblExpenseName.Size = new System.Drawing.Size(93, 13);
            this.lblExpenseName.TabIndex = 0;
            this.lblExpenseName.Text = "Name of expense:";
            this.lblExpenseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblExpenseDate
            // 
            this.lblExpenseDate.AutoSize = true;
            this.lblExpenseDate.Location = new System.Drawing.Point(437, 46);
            this.lblExpenseDate.Name = "lblExpenseDate";
            this.lblExpenseDate.Size = new System.Drawing.Size(141, 13);
            this.lblExpenseDate.TabIndex = 1;
            this.lblExpenseDate.Text = "Date of adding the expense:";
            // 
            // lblExpenseAmount
            // 
            this.lblExpenseAmount.AutoSize = true;
            this.lblExpenseAmount.Location = new System.Drawing.Point(188, 46);
            this.lblExpenseAmount.Name = "lblExpenseAmount";
            this.lblExpenseAmount.Size = new System.Drawing.Size(46, 13);
            this.lblExpenseAmount.TabIndex = 2;
            this.lblExpenseAmount.Text = "Amount:";
            this.lblExpenseAmount.Click += new System.EventHandler(this.lblExpenseAmount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Was it needed?";
            // 
            // txtExpenseDate
            // 
            this.txtExpenseDate.Location = new System.Drawing.Point(440, 77);
            this.txtExpenseDate.Name = "txtExpenseDate";
            this.txtExpenseDate.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseDate.TabIndex = 5;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(191, 78);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 6;
            // 
            // txtExpenseName
            // 
            this.txtExpenseName.Location = new System.Drawing.Point(52, 78);
            this.txtExpenseName.Name = "txtExpenseName";
            this.txtExpenseName.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseName.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(602, 183);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(118, 23);
            this.btnAddExpense.TabIndex = 9;
            this.btnAddExpense.Text = "Add the expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbmNeeded
            // 
            this.cbmNeeded.FormattingEnabled = true;
            this.cbmNeeded.Location = new System.Drawing.Point(581, 76);
            this.cbmNeeded.Name = "cbmNeeded";
            this.cbmNeeded.Size = new System.Drawing.Size(139, 21);
            this.cbmNeeded.TabIndex = 10;
            this.cbmNeeded.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblExpenseDescription
            // 
            this.lblExpenseDescription.AutoSize = true;
            this.lblExpenseDescription.Location = new System.Drawing.Point(315, 46);
            this.lblExpenseDescription.Name = "lblExpenseDescription";
            this.lblExpenseDescription.Size = new System.Drawing.Size(63, 13);
            this.lblExpenseDescription.TabIndex = 11;
            this.lblExpenseDescription.Text = "Description:";
            // 
            // txtExpenseDescription
            // 
            this.txtExpenseDescription.Location = new System.Drawing.Point(318, 78);
            this.txtExpenseDescription.Name = "txtExpenseDescription";
            this.txtExpenseDescription.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseDescription.TabIndex = 12;
            // 
            // FrmAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 236);
            this.Controls.Add(this.txtExpenseDescription);
            this.Controls.Add(this.lblExpenseDescription);
            this.Controls.Add(this.cbmNeeded);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.txtExpenseDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExpenseAmount);
            this.Controls.Add(this.lblExpenseDate);
            this.Controls.Add(this.lblExpenseName);
            this.Name = "FrmAddExpense";
            this.Text = "Aplikacija za praćenje financija";
            this.Load += new System.EventHandler(this.FrmAddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.Label lblExpenseDate;
        private System.Windows.Forms.Label lblExpenseAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpenseDate;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ComboBox cbmNeeded;
        private System.Windows.Forms.Label lblExpenseDescription;
        private System.Windows.Forms.TextBox txtExpenseDescription;
    }
}