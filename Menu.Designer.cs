
namespace Doubler
{
    partial class Menu
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
            this.doublerChoice = new System.Windows.Forms.Button();
            this.guessChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doublerChoice
            // 
            this.doublerChoice.Location = new System.Drawing.Point(33, 24);
            this.doublerChoice.Name = "doublerChoice";
            this.doublerChoice.Size = new System.Drawing.Size(240, 76);
            this.doublerChoice.TabIndex = 0;
            this.doublerChoice.Text = "Удвоитель";
            this.doublerChoice.UseVisualStyleBackColor = true;
            this.doublerChoice.Click += new System.EventHandler(this.doublerChoice_Click);
            // 
            // guessChoice
            // 
            this.guessChoice.Location = new System.Drawing.Point(33, 124);
            this.guessChoice.Name = "guessChoice";
            this.guessChoice.Size = new System.Drawing.Size(240, 87);
            this.guessChoice.TabIndex = 1;
            this.guessChoice.Text = "Угадай число";
            this.guessChoice.UseVisualStyleBackColor = true;
            this.guessChoice.Click += new System.EventHandler(this.guessChoice_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 223);
            this.Controls.Add(this.guessChoice);
            this.Controls.Add(this.doublerChoice);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doublerChoice;
        private System.Windows.Forms.Button guessChoice;
    }
}