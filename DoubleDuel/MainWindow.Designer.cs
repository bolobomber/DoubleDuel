
namespace DoubleDuel
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Namelbl = new System.Windows.Forms.Label();
            this.FightBtn = new System.Windows.Forms.Button();
            this.ArmBtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(13, 49);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(0, 20);
            this.Namelbl.TabIndex = 0;
            // 
            // FightBtn
            // 
            this.FightBtn.BackColor = System.Drawing.Color.Transparent;
            this.FightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FightBtn.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.FightBtn.ForeColor = System.Drawing.Color.Lime;
            this.FightBtn.Location = new System.Drawing.Point(619, 430);
            this.FightBtn.Name = "FightBtn";
            this.FightBtn.Size = new System.Drawing.Size(162, 45);
            this.FightBtn.TabIndex = 1;
            this.FightBtn.Text = "Fight";
            this.FightBtn.UseVisualStyleBackColor = false;
            this.FightBtn.Click += new System.EventHandler(this.FightBtn_Click);
            // 
            // ArmBtn
            // 
            this.ArmBtn.BackColor = System.Drawing.Color.Transparent;
            this.ArmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArmBtn.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ArmBtn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.ArmBtn.Location = new System.Drawing.Point(619, 481);
            this.ArmBtn.Name = "ArmBtn";
            this.ArmBtn.Size = new System.Drawing.Size(162, 54);
            this.ArmBtn.TabIndex = 2;
            this.ArmBtn.Text = "Army";
            this.ArmBtn.UseVisualStyleBackColor = false;
            this.ArmBtn.Click += new System.EventHandler(this.ArmBtn_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(619, 541);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(162, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ArmBtn);
            this.Controls.Add(this.FightBtn);
            this.Controls.Add(this.Namelbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Button FightBtn;
        private System.Windows.Forms.Button ArmBtn;
        private System.Windows.Forms.Button Exit;
    }
}