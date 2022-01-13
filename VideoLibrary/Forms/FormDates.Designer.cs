namespace VideoLibrary
{
    partial class FormDates
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
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.rbHave = new System.Windows.Forms.RadioButton();
            this.rbWillHave = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateEnd.Location = new System.Drawing.Point(12, 95);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.ShowCheckBox = true;
            this.dtpDateEnd.Size = new System.Drawing.Size(225, 26);
            this.dtpDateEnd.TabIndex = 38;
            this.dtpDateEnd.TabStop = false;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateStart.Location = new System.Drawing.Point(12, 37);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.ShowCheckBox = true;
            this.dtpDateStart.Size = new System.Drawing.Size(225, 26);
            this.dtpDateStart.TabIndex = 37;
            this.dtpDateStart.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 72);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Конец просмотра";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Начало просмотра";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(132, 169);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 35);
            this.btCancel.TabIndex = 42;
            this.btCancel.Text = "Oтмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOk.Location = new System.Drawing.Point(12, 169);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 35);
            this.btOk.TabIndex = 41;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // rbHave
            // 
            this.rbHave.AutoSize = true;
            this.rbHave.Location = new System.Drawing.Point(24, 133);
            this.rbHave.Name = "rbHave";
            this.rbHave.Size = new System.Drawing.Size(71, 24);
            this.rbHave.TabIndex = 43;
            this.rbHave.Text = "Есть";
            this.rbHave.UseVisualStyleBackColor = true;
            // 
            // rbWillHave
            // 
            this.rbWillHave.AutoSize = true;
            this.rbWillHave.Checked = true;
            this.rbWillHave.Location = new System.Drawing.Point(145, 133);
            this.rbWillHave.Name = "rbWillHave";
            this.rbWillHave.Size = new System.Drawing.Size(81, 24);
            this.rbWillHave.TabIndex = 44;
            this.rbWillHave.TabStop = true;
            this.rbWillHave.Text = "Будет";
            this.rbWillHave.UseVisualStyleBackColor = true;
            // 
            // FormDates
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(249, 218);
            this.Controls.Add(this.rbWillHave);
            this.Controls.Add(this.rbHave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDates";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Даты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.RadioButton rbHave;
        private System.Windows.Forms.RadioButton rbWillHave;
    }
}