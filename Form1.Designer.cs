
namespace LR7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelResult = new Label();
            startButton = new Button();
            stopButton = new Button();
            labelThreadStop = new Label();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(231, 192);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(231, 349);
            startButton.Name = "startButton";
            startButton.Size = new Size(115, 29);
            startButton.TabIndex = 1;
            startButton.Text = "Запустить";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(420, 349);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(115, 29);
            stopButton.TabIndex = 2;
            stopButton.Text = "Остановить";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // labelThreadStop
            // 
            labelThreadStop.AutoSize = true;
            labelThreadStop.Location = new Point(231, 234);
            labelThreadStop.Name = "labelThreadStop";
            labelThreadStop.Size = new Size(0, 20);
            labelThreadStop.TabIndex = 3;
            labelThreadStop.Click += labelThreadStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelThreadStop);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelThreadStop_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label labelResult;
        private Button startButton;
        private Button stopButton;
        private Label labelThreadStop;
    }
}
