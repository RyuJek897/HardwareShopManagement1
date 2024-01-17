namespace HardwareShopManagement1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidepanel = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.BackColor = SystemColors.GrayText;
            sidepanel.Controls.Add(button1);
            sidepanel.Controls.Add(panel2);
            sidepanel.Location = new Point(0, -2);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(234, 609);
            sidepanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 74);
            button1.Name = "button1";
            button1.Size = new Size(234, 55);
            button1.TabIndex = 0;
            button1.Text = "Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(235, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(825, 606);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(1059, 607);
            Controls.Add(sidepanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "HardShop";
            Load += Form1_Load;
            sidepanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidepanel;
        private Button button1;
        private Panel panel2;
    }
}
