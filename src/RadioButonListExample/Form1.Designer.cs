namespace RadioButonListExample
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
            this.radioButtonList5 = new RadioButonListExample.RadioButtonList();
            this.radioButtonList2 = new RadioButonListExample.RadioButtonList();
            this.radioButtonList4 = new RadioButonListExample.RadioButtonList();
            this.radioButtonList3 = new RadioButonListExample.RadioButtonList();
            this.radioButtonList1 = new RadioButonListExample.RadioButtonList();
            this.SuspendLayout();
            // 
            // radioButtonList5
            // 
            this.radioButtonList5.Enabled = false;
            this.radioButtonList5.FormattingEnabled = true;
            this.radioButtonList5.Location = new System.Drawing.Point(187, 321);
            this.radioButtonList5.Name = "radioButtonList5";
            this.radioButtonList5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonList5.Size = new System.Drawing.Size(168, 186);
            this.radioButtonList5.TabIndex = 0;
            // 
            // radioButtonList2
            // 
            this.radioButtonList2.Enabled = false;
            this.radioButtonList2.FormattingEnabled = true;
            this.radioButtonList2.Location = new System.Drawing.Point(187, 15);
            this.radioButtonList2.Name = "radioButtonList2";
            this.radioButtonList2.Size = new System.Drawing.Size(168, 186);
            this.radioButtonList2.TabIndex = 0;
            // 
            // radioButtonList4
            // 
            this.radioButtonList4.FormattingEnabled = true;
            this.radioButtonList4.Location = new System.Drawing.Point(13, 321);
            this.radioButtonList4.Name = "radioButtonList4";
            this.radioButtonList4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonList4.Size = new System.Drawing.Size(168, 186);
            this.radioButtonList4.TabIndex = 0;
            // 
            // radioButtonList3
            // 
            this.radioButtonList3.FormattingEnabled = true;
            this.radioButtonList3.Location = new System.Drawing.Point(12, 207);
            this.radioButtonList3.MultiColumn = true;
            this.radioButtonList3.Name = "radioButtonList3";
            this.radioButtonList3.Size = new System.Drawing.Size(342, 108);
            this.radioButtonList3.TabIndex = 0;
            // 
            // radioButtonList1
            // 
            this.radioButtonList1.FormattingEnabled = true;
            this.radioButtonList1.Location = new System.Drawing.Point(13, 15);
            this.radioButtonList1.Name = "radioButtonList1";
            this.radioButtonList1.Size = new System.Drawing.Size(168, 186);
            this.radioButtonList1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 524);
            this.Controls.Add(this.radioButtonList5);
            this.Controls.Add(this.radioButtonList2);
            this.Controls.Add(this.radioButtonList4);
            this.Controls.Add(this.radioButtonList3);
            this.Controls.Add(this.radioButtonList1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonList radioButtonList1;
        private RadioButtonList radioButtonList2;
        private RadioButtonList radioButtonList3;
        private RadioButtonList radioButtonList4;
        private RadioButtonList radioButtonList5;
    }
}

