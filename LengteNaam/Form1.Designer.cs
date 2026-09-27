namespace LengteNaam
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
            MetSpatieLabel = new Label();
            label3 = new Label();
            ZonderSpatieLabel = new Label();
            label5 = new Label();
            BerekenButton = new Button();
            NaamTextBox = new TextBox();
            label1 = new Label();
            ResultaatInclusiefSpatieLabel = new Label();
            ResultaatExclusiefSpatieLabel = new Label();
            SuspendLayout();
            // 
            // MetSpatieLabel
            // 
            MetSpatieLabel.AutoSize = true;
            MetSpatieLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MetSpatieLabel.ForeColor = Color.Maroon;
            MetSpatieLabel.Location = new Point(12, 74);
            MetSpatieLabel.Name = "MetSpatieLabel";
            MetSpatieLabel.Size = new Size(346, 21);
            MetSpatieLabel.TabIndex = 0;
            MetSpatieLabel.Text = "De lengte van jouw naam inclusief de spatie is:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 16);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // ZonderSpatieLabel
            // 
            ZonderSpatieLabel.AutoSize = true;
            ZonderSpatieLabel.ForeColor = Color.Maroon;
            ZonderSpatieLabel.Location = new Point(48, 87);
            ZonderSpatieLabel.Name = "ZonderSpatieLabel";
            ZonderSpatieLabel.Size = new Size(0, 15);
            ZonderSpatieLabel.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Maroon;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 4;
            label5.Text = "          Voornaam + Naam          ";
            // 
            // BerekenButton
            // 
            BerekenButton.Location = new Point(185, 9);
            BerekenButton.Name = "BerekenButton";
            BerekenButton.Size = new Size(134, 41);
            BerekenButton.TabIndex = 5;
            BerekenButton.Text = "Hoe lang is je naam?";
            BerekenButton.UseVisualStyleBackColor = true;
            BerekenButton.Click += BerekenButton_Click;
            // 
            // NaamTextBox
            // 
            NaamTextBox.Location = new Point(12, 27);
            NaamTextBox.Name = "NaamTextBox";
            NaamTextBox.Size = new Size(167, 23);
            NaamTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(350, 21);
            label1.TabIndex = 7;
            label1.Text = "De lengte van jouw naam exclusief de spatie is:";
            // 
            // ResultaatInclusiefSpatieLabel
            // 
            ResultaatInclusiefSpatieLabel.AutoSize = true;
            ResultaatInclusiefSpatieLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultaatInclusiefSpatieLabel.ForeColor = Color.Maroon;
            ResultaatInclusiefSpatieLabel.Location = new Point(364, 74);
            ResultaatInclusiefSpatieLabel.Name = "ResultaatInclusiefSpatieLabel";
            ResultaatInclusiefSpatieLabel.Size = new Size(17, 21);
            ResultaatInclusiefSpatieLabel.TabIndex = 8;
            ResultaatInclusiefSpatieLabel.Text = "?";
            // 
            // ResultaatExclusiefSpatieLabel
            // 
            ResultaatExclusiefSpatieLabel.AutoSize = true;
            ResultaatExclusiefSpatieLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultaatExclusiefSpatieLabel.ForeColor = Color.Maroon;
            ResultaatExclusiefSpatieLabel.Location = new Point(364, 53);
            ResultaatExclusiefSpatieLabel.Name = "ResultaatExclusiefSpatieLabel";
            ResultaatExclusiefSpatieLabel.Size = new Size(17, 21);
            ResultaatExclusiefSpatieLabel.TabIndex = 9;
            ResultaatExclusiefSpatieLabel.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 116);
            Controls.Add(ResultaatExclusiefSpatieLabel);
            Controls.Add(ResultaatInclusiefSpatieLabel);
            Controls.Add(label1);
            Controls.Add(NaamTextBox);
            Controls.Add(BerekenButton);
            Controls.Add(label5);
            Controls.Add(ZonderSpatieLabel);
            Controls.Add(label3);
            Controls.Add(MetSpatieLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MetSpatieLabel;
        private Label label3;
        private Label ZonderSpatieLabel;
        private Label label5;
        private Button BerekenButton;
        private TextBox NaamTextBox;
        private Label label1;
        private Label ResultaatInclusiefSpatieLabel;
        private Label ResultaatExclusiefSpatieLabel;
    }
}
