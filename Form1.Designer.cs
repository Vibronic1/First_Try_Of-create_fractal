namespace First_try_of_game
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.label_Cx = new System.Windows.Forms.TextBox();
            this.label_Bx = new System.Windows.Forms.TextBox();
            this.label_Ax = new System.Windows.Forms.TextBox();
            this.Bx = new System.Windows.Forms.Label();
            this.Ax = new System.Windows.Forms.Label();
            this.Cx = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.Cy = new System.Windows.Forms.Label();
            this.ay = new System.Windows.Forms.Label();
            this.By = new System.Windows.Forms.Label();
            this.label_Cy = new System.Windows.Forms.TextBox();
            this.label_By = new System.Windows.Forms.TextBox();
            this.label_Ay = new System.Windows.Forms.TextBox();
            this.gametime = new System.Windows.Forms.Label();
            this.gameTimer1 = new System.Windows.Forms.Timer(this.components);
            this.gameTimer2 = new System.Windows.Forms.Timer(this.components);
            this.gametimer3 = new System.Windows.Forms.Timer(this.components);
            this.gametimer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1920, 1080);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_Cx
            // 
            this.label_Cx.Location = new System.Drawing.Point(315, 25);
            this.label_Cx.Name = "label_Cx";
            this.label_Cx.Size = new System.Drawing.Size(77, 20);
            this.label_Cx.TabIndex = 16;
            this.label_Cx.TextChanged += new System.EventHandler(this.label_Cx_TextChanged);
            // 
            // label_Bx
            // 
            this.label_Bx.Location = new System.Drawing.Point(185, 25);
            this.label_Bx.Name = "label_Bx";
            this.label_Bx.Size = new System.Drawing.Size(74, 20);
            this.label_Bx.TabIndex = 15;
            this.label_Bx.TextChanged += new System.EventHandler(this.label_Bx_TextChanged);
            // 
            // label_Ax
            // 
            this.label_Ax.Location = new System.Drawing.Point(67, 25);
            this.label_Ax.Name = "label_Ax";
            this.label_Ax.Size = new System.Drawing.Size(73, 20);
            this.label_Ax.TabIndex = 14;
            this.label_Ax.TextChanged += new System.EventHandler(this.label_Ax_TextChanged);
            // 
            // Bx
            // 
            this.Bx.AutoSize = true;
            this.Bx.Location = new System.Drawing.Point(148, 28);
            this.Bx.Name = "Bx";
            this.Bx.Size = new System.Drawing.Size(31, 13);
            this.Bx.TabIndex = 4;
            this.Bx.Text = "B(x)=";
            // 
            // Ax
            // 
            this.Ax.AutoSize = true;
            this.Ax.Location = new System.Drawing.Point(30, 28);
            this.Ax.Name = "Ax";
            this.Ax.Size = new System.Drawing.Size(31, 13);
            this.Ax.TabIndex = 5;
            this.Ax.Text = "A(x)=";
            // 
            // Cx
            // 
            this.Cx.AutoSize = true;
            this.Cx.Location = new System.Drawing.Point(278, 28);
            this.Cx.Name = "Cx";
            this.Cx.Size = new System.Drawing.Size(31, 13);
            this.Cx.TabIndex = 6;
            this.Cx.Text = "C(x)=";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(398, 43);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 7;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Cy
            // 
            this.Cy.AutoSize = true;
            this.Cy.Location = new System.Drawing.Point(278, 65);
            this.Cy.Name = "Cy";
            this.Cy.Size = new System.Drawing.Size(31, 13);
            this.Cy.TabIndex = 13;
            this.Cy.Text = "C(y)=";
            // 
            // ay
            // 
            this.ay.AutoSize = true;
            this.ay.Location = new System.Drawing.Point(30, 65);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(31, 13);
            this.ay.TabIndex = 12;
            this.ay.Text = "A(y)=";
            // 
            // By
            // 
            this.By.AutoSize = true;
            this.By.Location = new System.Drawing.Point(148, 66);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(31, 13);
            this.By.TabIndex = 11;
            this.By.Text = "B(y)=";
            // 
            // label_Cy
            // 
            this.label_Cy.Location = new System.Drawing.Point(315, 62);
            this.label_Cy.Name = "label_Cy";
            this.label_Cy.Size = new System.Drawing.Size(77, 20);
            this.label_Cy.TabIndex = 10;
            this.label_Cy.TextChanged += new System.EventHandler(this.label_Cy_TextChanged);
            // 
            // label_By
            // 
            this.label_By.Location = new System.Drawing.Point(185, 63);
            this.label_By.Name = "label_By";
            this.label_By.Size = new System.Drawing.Size(74, 20);
            this.label_By.TabIndex = 9;
            this.label_By.TextChanged += new System.EventHandler(this.label_By_TextChanged);
            // 
            // label_Ay
            // 
            this.label_Ay.Location = new System.Drawing.Point(67, 63);
            this.label_Ay.Name = "label_Ay";
            this.label_Ay.Size = new System.Drawing.Size(73, 20);
            this.label_Ay.TabIndex = 8;
            this.label_Ay.TextChanged += new System.EventHandler(this.label_Ay_TextChanged);
            // 
            // gametime
            // 
            this.gametime.AutoSize = true;
            this.gametime.Location = new System.Drawing.Point(537, 43);
            this.gametime.Name = "gametime";
            this.gametime.Size = new System.Drawing.Size(35, 13);
            this.gametime.TabIndex = 17;
            this.gametime.Text = "label1";
            // 
            // gameTimer1
            // 
            this.gameTimer1.Interval = 1;
            this.gameTimer1.Tick += new System.EventHandler(this.gameTimer1_Tick);
            // 
            // gameTimer2
            // 
            this.gameTimer2.Interval = 1;
            this.gameTimer2.Tick += new System.EventHandler(this.gameTimer2_Tick);
            // 
            // gametimer3
            // 
            this.gametimer3.Interval = 1;
            this.gametimer3.Tick += new System.EventHandler(this.gametimer3_Tick);
            // 
            // gametimer4
            // 
            this.gametimer4.Interval = 1;
            this.gametimer4.Tick += new System.EventHandler(this.gametimer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.gametime);
            this.Controls.Add(this.Cy);
            this.Controls.Add(this.ay);
            this.Controls.Add(this.By);
            this.Controls.Add(this.label_Cy);
            this.Controls.Add(this.label_By);
            this.Controls.Add(this.label_Ay);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Cx);
            this.Controls.Add(this.Ax);
            this.Controls.Add(this.Bx);
            this.Controls.Add(this.label_Ax);
            this.Controls.Add(this.label_Bx);
            this.Controls.Add(this.label_Cx);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.TextBox label_Cx;
        private System.Windows.Forms.TextBox label_Bx;
        private System.Windows.Forms.TextBox label_Ax;
        private System.Windows.Forms.Label Bx;
        private System.Windows.Forms.Label Ax;
        private System.Windows.Forms.Label Cx;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label Cy;
        private System.Windows.Forms.Label ay;
        private System.Windows.Forms.Label By;
        private System.Windows.Forms.TextBox label_Cy;
        private System.Windows.Forms.TextBox label_By;
        private System.Windows.Forms.TextBox label_Ay;
        private System.Windows.Forms.Label gametime;
        private System.Windows.Forms.Timer gameTimer1;
        private System.Windows.Forms.Timer gameTimer2;
        private System.Windows.Forms.Timer gametimer3;
        private System.Windows.Forms.Timer gametimer4;
    }
}

