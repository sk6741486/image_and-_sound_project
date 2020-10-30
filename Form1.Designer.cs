namespace image_and__sound_project
{
    partial class image_and_sound
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LOADBUTTON = new System.Windows.Forms.Button();
            this.SPINBUTTON = new System.Windows.Forms.Button();
            this.SHOOTBTTTON = new System.Windows.Forms.Button();
            this.SHOOTAWAYBUTTON = new System.Windows.Forms.Button();
            this.PLAYAGAINBUTTON = new System.Windows.Forms.Button();
            this.EXITBUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(235, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 222);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LOADBUTTON
            // 
            this.LOADBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.LOADBUTTON.Location = new System.Drawing.Point(43, 329);
            this.LOADBUTTON.Name = "LOADBUTTON";
            this.LOADBUTTON.Size = new System.Drawing.Size(116, 44);
            this.LOADBUTTON.TabIndex = 1;
            this.LOADBUTTON.Text = "LOAD";
            this.LOADBUTTON.UseVisualStyleBackColor = false;
            this.LOADBUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // SPINBUTTON
            // 
            this.SPINBUTTON.Location = new System.Drawing.Point(174, 329);
            this.SPINBUTTON.Name = "SPINBUTTON";
            this.SPINBUTTON.Size = new System.Drawing.Size(119, 44);
            this.SPINBUTTON.TabIndex = 2;
            this.SPINBUTTON.Text = "SPIN";
            this.SPINBUTTON.UseVisualStyleBackColor = true;
            // 
            // SHOOTBTTTON
            // 
            this.SHOOTBTTTON.Location = new System.Drawing.Point(308, 329);
            this.SHOOTBTTTON.Name = "SHOOTBTTTON";
            this.SHOOTBTTTON.Size = new System.Drawing.Size(115, 44);
            this.SHOOTBTTTON.TabIndex = 3;
            this.SHOOTBTTTON.Text = "SHOOT";
            this.SHOOTBTTTON.UseVisualStyleBackColor = true;
            // 
            // SHOOTAWAYBUTTON
            // 
            this.SHOOTAWAYBUTTON.Location = new System.Drawing.Point(441, 329);
            this.SHOOTAWAYBUTTON.Name = "SHOOTAWAYBUTTON";
            this.SHOOTAWAYBUTTON.Size = new System.Drawing.Size(119, 44);
            this.SHOOTAWAYBUTTON.TabIndex = 4;
            this.SHOOTAWAYBUTTON.Text = "SHOOT AWAY";
            this.SHOOTAWAYBUTTON.UseVisualStyleBackColor = true;
            // 
            // PLAYAGAINBUTTON
            // 
            this.PLAYAGAINBUTTON.Location = new System.Drawing.Point(591, 329);
            this.PLAYAGAINBUTTON.Name = "PLAYAGAINBUTTON";
            this.PLAYAGAINBUTTON.Size = new System.Drawing.Size(108, 44);
            this.PLAYAGAINBUTTON.TabIndex = 5;
            this.PLAYAGAINBUTTON.Text = "PLAY AGAIN";
            this.PLAYAGAINBUTTON.UseVisualStyleBackColor = true;
            // 
            // EXITBUTTON
            // 
            this.EXITBUTTON.Location = new System.Drawing.Point(724, 329);
            this.EXITBUTTON.Name = "EXITBUTTON";
            this.EXITBUTTON.Size = new System.Drawing.Size(98, 44);
            this.EXITBUTTON.TabIndex = 6;
            this.EXITBUTTON.Text = "EXIT";
            this.EXITBUTTON.UseVisualStyleBackColor = true;
            // 
            // image_and_sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::image_and__sound_project.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 457);
            this.Controls.Add(this.EXITBUTTON);
            this.Controls.Add(this.PLAYAGAINBUTTON);
            this.Controls.Add(this.SHOOTAWAYBUTTON);
            this.Controls.Add(this.SHOOTBTTTON);
            this.Controls.Add(this.SPINBUTTON);
            this.Controls.Add(this.LOADBUTTON);
            this.Controls.Add(this.pictureBox1);
            this.Name = "image_and_sound";
            this.Text = "sound and image form";
            this.Load += new System.EventHandler(this.image_and_sound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LOADBUTTON;
        private System.Windows.Forms.Button SPINBUTTON;
        private System.Windows.Forms.Button SHOOTBTTTON;
        private System.Windows.Forms.Button SHOOTAWAYBUTTON;
        private System.Windows.Forms.Button PLAYAGAINBUTTON;
        private System.Windows.Forms.Button EXITBUTTON;
    }
}

