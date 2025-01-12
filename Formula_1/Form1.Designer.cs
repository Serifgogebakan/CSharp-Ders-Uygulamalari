namespace Formula_1
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
            this.components = new System.ComponentModel.Container();
            this.Main_panel1 = new System.Windows.Forms.Panel();
            this.Lane2_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lane1_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.My_Car_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.My_Car_Velocity_timer1 = new System.Windows.Forms.Timer(this.components);
            this.My_Car_Movement_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lane2_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lane1_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.My_Car_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel1
            // 
            this.Main_panel1.BackColor = System.Drawing.Color.Silver;
            this.Main_panel1.Controls.Add(this.Lane2_pictureBox1);
            this.Main_panel1.Controls.Add(this.Lane1_pictureBox1);
            this.Main_panel1.Controls.Add(this.My_Car_pictureBox1);
            this.Main_panel1.Location = new System.Drawing.Point(0, 0);
            this.Main_panel1.Name = "Main_panel1";
            this.Main_panel1.Size = new System.Drawing.Size(300, 500);
            this.Main_panel1.TabIndex = 0;
            this.Main_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_panel1_Paint);
            // 
            // Lane2_pictureBox1
            // 
            this.Lane2_pictureBox1.Image = global::Formula_1.Properties.Resources.Ekran_görüntüsü_2024_11_27_215213;
            this.Lane2_pictureBox1.Location = new System.Drawing.Point(270, -30000);
            this.Lane2_pictureBox1.Name = "Lane2_pictureBox1";
            this.Lane2_pictureBox1.Size = new System.Drawing.Size(30, 30500);
            this.Lane2_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lane2_pictureBox1.TabIndex = 2;
            this.Lane2_pictureBox1.TabStop = false;
            // 
            // Lane1_pictureBox1
            // 
            this.Lane1_pictureBox1.Image = global::Formula_1.Properties.Resources.Ekran_görüntüsü_2024_11_27_214654;
            this.Lane1_pictureBox1.Location = new System.Drawing.Point(0, -30000);
            this.Lane1_pictureBox1.Name = "Lane1_pictureBox1";
            this.Lane1_pictureBox1.Size = new System.Drawing.Size(30, 30500);
            this.Lane1_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lane1_pictureBox1.TabIndex = 1;
            this.Lane1_pictureBox1.TabStop = false;
            // 
            // My_Car_pictureBox1
            // 
            this.My_Car_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.My_Car_pictureBox1.Image = global::Formula_1.Properties.Resources.png_transparent_red_bull_racing_car_formula_1_scuderia_ferrari_bahrain_grand_prix_ferrari_formula_1_racing_car_vehicle_thumbnail;
            this.My_Car_pictureBox1.Location = new System.Drawing.Point(124, 430);
            this.My_Car_pictureBox1.Name = "My_Car_pictureBox1";
            this.My_Car_pictureBox1.Size = new System.Drawing.Size(52, 60);
            this.My_Car_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.My_Car_pictureBox1.TabIndex = 0;
            this.My_Car_pictureBox1.TabStop = false;
            // 
            // My_Car_Velocity_timer1
            // 
            this.My_Car_Velocity_timer1.Enabled = true;
            this.My_Car_Velocity_timer1.Interval = 500;
            this.My_Car_Velocity_timer1.Tick += new System.EventHandler(this.My_Car_Velocity_timer1_Tick);
            // 
            // My_Car_Movement_timer1
            // 
            this.My_Car_Movement_timer1.Enabled = true;
            this.My_Car_Movement_timer1.Tick += new System.EventHandler(this.My_Car_Movement_timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 503);
            this.Controls.Add(this.Main_panel1);
            this.Name = "Form1";
            this.Text = "Formula 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Main_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lane2_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lane1_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.My_Car_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel1;
        private System.Windows.Forms.PictureBox Lane1_pictureBox1;
        private System.Windows.Forms.PictureBox My_Car_pictureBox1;
        private System.Windows.Forms.PictureBox Lane2_pictureBox1;
        private System.Windows.Forms.Timer My_Car_Velocity_timer1;
        private System.Windows.Forms.Timer My_Car_Movement_timer1;
    }
}

