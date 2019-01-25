namespace RoadRanger_LLC
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
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_Due = new System.Windows.Forms.Label();
            this.DueDateCldr = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(21, 378);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(150, 60);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_Title.Location = new System.Drawing.Point(93, 35);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(570, 36);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "Road Ranger Store Organization System";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(598, 378);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(150, 60);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Print Due Date";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Due
            // 
            this.Lbl_Due.AutoSize = true;
            this.Lbl_Due.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Due.Location = new System.Drawing.Point(570, 137);
            this.Lbl_Due.Name = "Lbl_Due";
            this.Lbl_Due.Size = new System.Drawing.Size(135, 36);
            this.Lbl_Due.TabIndex = 4;
            this.Lbl_Due.Text = "Date Due";
            // 
            // DueDateCldr
            // 
            this.DueDateCldr.Location = new System.Drawing.Point(521, 182);
            this.DueDateCldr.Name = "DueDateCldr";
            this.DueDateCldr.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "STO 000",
            "STO 144",
            "STO 145",
            "STO 211",
            "STO 265",
            "STO 185",
            "STO 263",
            "STO 999"});
            this.comboBox1.Location = new System.Drawing.Point(12, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select a Store Number.....";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Take Inventory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label1.Location = new System.Drawing.Point(-3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Store Locations under Conversion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DueDateCldr);
            this.Controls.Add(this.Lbl_Due);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Btn_Exit);
            this.Name = "Form1";
            this.Text = "Road Ranger Organizer Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Lbl_Due;
        private System.Windows.Forms.MonthCalendar DueDateCldr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

