namespace RacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.lose = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.coinlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(840, 670);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(373, 475);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(90, 128);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 1;
            this.car.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 19;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bg2
            // 
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(0, -630);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(840, 670);
            this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(145, -450);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(90, 128);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(345, -200);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(90, 128);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(531, -250);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(90, 128);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 5;
            this.enemy3.TabStop = false;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.BackColor = System.Drawing.Color.Transparent;
            this.lose.Font = new System.Drawing.Font("Yu Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lose.ForeColor = System.Drawing.Color.Maroon;
            this.lose.Location = new System.Drawing.Point(20, 91);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(799, 155);
            this.lose.TabIndex = 6;
            this.lose.Text = "GAME OVER";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.LimeGreen;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button.Location = new System.Drawing.Point(320, 313);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(200, 70);
            this.button.TabIndex = 7;
            this.button.Text = "Try Again";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(456, -1000);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(50, 50);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 8;
            this.coin.TabStop = false;
            // 
            // coinlbl
            // 
            this.coinlbl.AutoSize = true;
            this.coinlbl.BackColor = System.Drawing.Color.Gold;
            this.coinlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coinlbl.Font = new System.Drawing.Font("Yu Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coinlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coinlbl.Location = new System.Drawing.Point(1, 9);
            this.coinlbl.Name = "coinlbl";
            this.coinlbl.Size = new System.Drawing.Size(166, 48);
            this.coinlbl.TabIndex = 9;
            this.coinlbl.Text = "Coins: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.button);
            this.Controls.Add(this.coinlbl);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label coinlbl;
    }
}

