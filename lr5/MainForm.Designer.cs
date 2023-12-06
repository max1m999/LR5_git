namespace lr5
{
    partial class MainForm
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
            this.worldPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.startSimButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cycleDelay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // worldPictureBox
            // 
            this.worldPictureBox.Location = new System.Drawing.Point(9, 10);
            this.worldPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.worldPictureBox.Name = "worldPictureBox";
            this.worldPictureBox.Size = new System.Drawing.Size(579, 363);
            this.worldPictureBox.TabIndex = 0;
            this.worldPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(9, 385);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Создать мир";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startSimButton
            // 
            this.startSimButton.Location = new System.Drawing.Point(129, 385);
            this.startSimButton.Margin = new System.Windows.Forms.Padding(2);
            this.startSimButton.Name = "startSimButton";
            this.startSimButton.Size = new System.Drawing.Size(100, 36);
            this.startSimButton.TabIndex = 2;
            this.startSimButton.Text = "Запустить симуляцию";
            this.startSimButton.UseVisualStyleBackColor = true;
            this.startSimButton.Click += new System.EventHandler(this.startSimButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // cycleDelay
            // 
            this.cycleDelay.Tick += new System.EventHandler(this.cycleDelay_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 465);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startSimButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.worldPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Система обучающихся агентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox worldPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button startSimButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer cycleDelay;
    }
}

