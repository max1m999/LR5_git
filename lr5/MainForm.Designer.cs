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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // worldPictureBox
            // 
            this.worldPictureBox.Location = new System.Drawing.Point(14, 15);
            this.worldPictureBox.Name = "worldPictureBox";
            this.worldPictureBox.Size = new System.Drawing.Size(868, 558);
            this.worldPictureBox.TabIndex = 0;
            this.worldPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(14, 592);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 55);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Создать мир";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startSimButton
            // 
            this.startSimButton.Location = new System.Drawing.Point(194, 592);
            this.startSimButton.Name = "startSimButton";
            this.startSimButton.Size = new System.Drawing.Size(150, 55);
            this.startSimButton.TabIndex = 2;
            this.startSimButton.Text = "Запустить симуляцию";
            this.startSimButton.UseVisualStyleBackColor = true;
            this.startSimButton.Click += new System.EventHandler(this.startSimButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(915, 223);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(911, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Счётчик циклов:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startSimButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.worldPictureBox);
            this.Name = "MainForm";
            this.Text = "Система обучающихся агентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.PictureBox worldPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button startSimButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer cycleDelay;
        private System.Windows.Forms.Label label1;
    }
}

