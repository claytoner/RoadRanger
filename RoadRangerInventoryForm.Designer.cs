namespace RoadRanger_LLC
{
    partial class RoadRangerInventoryForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PtRpt_Button = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "XR7 HeadUnit",
            "Cash Drawer",
            "Thermal Printer",
            "Scanner",
            "Scanner Cables",
            "COM Cables",
            "PIN Pad",
            "Pin Pad Scanner",
            "DUMMY Card",
            "Kiosk",
            "Kiosk MSR"});
            this.checkedListBox1.Location = new System.Drawing.Point(269, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(196, 289);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store Checklist";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PtRpt_Button
            // 
            this.PtRpt_Button.Location = new System.Drawing.Point(614, 378);
            this.PtRpt_Button.Name = "PtRpt_Button";
            this.PtRpt_Button.Size = new System.Drawing.Size(174, 60);
            this.PtRpt_Button.TabIndex = 2;
            this.PtRpt_Button.Text = "Print Report";
            this.PtRpt_Button.UseVisualStyleBackColor = true;
            this.PtRpt_Button.Click += new System.EventHandler(this.PtRpt_Button_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 378);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(174, 60);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Main Menu";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RoadRangerInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PtRpt_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "RoadRangerInventoryForm";
            this.Text = "RoadRangerInventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PtRpt_Button;
        private System.Windows.Forms.Button BackBtn;
    }
}