
namespace Doubler
{
    partial class RandomGuess
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
            this.startButton = new System.Windows.Forms.Button();
            this.vaultLabel = new System.Windows.Forms.Label();
            this.valuePersonal = new System.Windows.Forms.TextBox();
            this.taskValue = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(152, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(131, 51);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // vaultLabel
            // 
            this.vaultLabel.AutoSize = true;
            this.vaultLabel.Location = new System.Drawing.Point(149, 67);
            this.vaultLabel.Name = "vaultLabel";
            this.vaultLabel.Size = new System.Drawing.Size(84, 13);
            this.vaultLabel.TabIndex = 1;
            this.vaultLabel.Text = "Введите число";
            // 
            // valuePersonal
            // 
            this.valuePersonal.Location = new System.Drawing.Point(152, 84);
            this.valuePersonal.Name = "valuePersonal";
            this.valuePersonal.Size = new System.Drawing.Size(100, 22);
            this.valuePersonal.TabIndex = 2;
            // 
            // taskValue
            // 
            this.taskValue.Location = new System.Drawing.Point(152, 187);
            this.taskValue.Name = "taskValue";
            this.taskValue.ReadOnly = true;
            this.taskValue.Size = new System.Drawing.Size(100, 22);
            this.taskValue.TabIndex = 3;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(355, 257);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(100, 22);
            this.count.TabIndex = 4;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(352, 241);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(101, 13);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Попыток сделано";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(259, 84);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(98, 22);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Сравнить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // RandomGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 291);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.taskValue);
            this.Controls.Add(this.valuePersonal);
            this.Controls.Add(this.vaultLabel);
            this.Controls.Add(this.startButton);
            this.Name = "RandomGuess";
            this.Text = "RandomGuess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label vaultLabel;
        private System.Windows.Forms.TextBox valuePersonal;
        private System.Windows.Forms.TextBox taskValue;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button checkButton;
    }
}