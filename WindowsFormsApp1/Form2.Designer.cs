namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewCust = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewCust
            // 
            this.NewCust.Location = new System.Drawing.Point(306, 280);
            this.NewCust.Name = "NewCust";
            this.NewCust.Size = new System.Drawing.Size(162, 70);
            this.NewCust.TabIndex = 0;
            this.NewCust.Text = "New Customer";
            this.NewCust.UseVisualStyleBackColor = true;
            this.NewCust.Click += new System.EventHandler(this.NewCust_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search Customers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(795, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search Classes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AccessibleName = "MainMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1334, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewCust);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewCust;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}