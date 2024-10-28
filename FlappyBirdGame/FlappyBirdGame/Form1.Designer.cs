namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_grown = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_control = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pictureBox_top.Location = new System.Drawing.Point(537, -4);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(129, 195);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 0;
            this.pictureBox_top.TabStop = false;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pictureBox_down.Location = new System.Drawing.Point(436, 402);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(129, 180);
            this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_down.TabIndex = 1;
            this.pictureBox_down.TabStop = false;
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.pictureBox_bird.Location = new System.Drawing.Point(39, 210);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(82, 69);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 2;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_grown
            // 
            this.pictureBox_grown.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.pictureBox_grown.Location = new System.Drawing.Point(0, 579);
            this.pictureBox_grown.Name = "pictureBox_grown";
            this.pictureBox_grown.Size = new System.Drawing.Size(782, 79);
            this.pictureBox_grown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_grown.TabIndex = 3;
            this.pictureBox_grown.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE :";
            // 
            // timer_control
            // 
            this.timer_control.Enabled = true;
            this.timer_control.Interval = 20;
            this.timer_control.Tick += new System.EventHandler(this.GameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(782, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_grown);
            this.Controls.Add(this.pictureBox_bird);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_top);
            this.Name = "Form1";
            this.Text = "Flappy Birds";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_grown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_grown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_control;
    }
}

