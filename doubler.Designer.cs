
namespace Doubler
{
    partial class Doubler
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
            this.plusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.taskValue = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(12, 86);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+ 1";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(12, 130);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 1;
            this.multiplyButton.Text = "x 2";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(106, 86);
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Size = new System.Drawing.Size(153, 22);
            this.value.TabIndex = 2;
            // 
            // taskValue
            // 
            this.taskValue.Location = new System.Drawing.Point(106, 132);
            this.taskValue.Name = "taskValue";
            this.taskValue.ReadOnly = true;
            this.taskValue.Size = new System.Drawing.Size(153, 22);
            this.taskValue.TabIndex = 3;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(151, 229);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(100, 22);
            this.count.TabIndex = 4;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(148, 213);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(104, 13);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "Попыток сделано:";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(103, 109);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(138, 13);
            this.taskLabel.TabIndex = 6;
            this.taskLabel.Text = "Необходимое значение:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(103, 70);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(158, 13);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "Значение в данный момент:";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(83, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(103, 42);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 259);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.taskValue);
            this.Controls.Add(this.value);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.plusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox taskValue;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button playButton;
    }
}

