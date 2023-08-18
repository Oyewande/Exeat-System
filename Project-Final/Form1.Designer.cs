namespace Project_Final
{
    partial class Application_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application_form));
            this.label1 = new System.Windows.Forms.Label();
            this.dayexeat = new System.Windows.Forms.Button();
            this.homeexeat = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXEAT APPLICATION";
            // 
            // dayexeat
            // 
            this.dayexeat.BackColor = System.Drawing.Color.Green;
            this.dayexeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayexeat.Location = new System.Drawing.Point(197, 211);
            this.dayexeat.Name = "dayexeat";
            this.dayexeat.Size = new System.Drawing.Size(160, 94);
            this.dayexeat.TabIndex = 1;
            this.dayexeat.Text = "DAY EXEAT";
            this.dayexeat.UseVisualStyleBackColor = false;
            this.dayexeat.Click += new System.EventHandler(this.dayexeat_Click);
            // 
            // homeexeat
            // 
            this.homeexeat.BackColor = System.Drawing.Color.ForestGreen;
            this.homeexeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeexeat.Location = new System.Drawing.Point(520, 210);
            this.homeexeat.Name = "homeexeat";
            this.homeexeat.Size = new System.Drawing.Size(168, 94);
            this.homeexeat.TabIndex = 2;
            this.homeexeat.Text = "HOME EXEAT";
            this.homeexeat.UseVisualStyleBackColor = false;
            this.homeexeat.Click += new System.EventHandler(this.homeexeat_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(390, 380);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(99, 58);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Application_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.homeexeat);
            this.Controls.Add(this.dayexeat);
            this.Controls.Add(this.label1);
            this.Name = "Application_form";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Application_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dayexeat;
        private System.Windows.Forms.Button homeexeat;
        private System.Windows.Forms.Button exitbtn;
    }
}

