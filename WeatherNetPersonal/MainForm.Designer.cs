﻿namespace WeatherNetPersonal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCityNameCountry = new System.Windows.Forms.Label();
            this.pbWeatherIcone = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.tbExtraWeatherInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(324, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Laika ģids! ";
            // 
            // lblCityNameCountry
            // 
            this.lblCityNameCountry.AutoSize = true;
            this.lblCityNameCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityNameCountry.Location = new System.Drawing.Point(119, 68);
            this.lblCityNameCountry.Name = "lblCityNameCountry";
            this.lblCityNameCountry.Size = new System.Drawing.Size(74, 20);
            this.lblCityNameCountry.TabIndex = 1;
            this.lblCityNameCountry.Text = "Rīga, LV";
            // 
            // pbWeatherIcone
            // 
            this.pbWeatherIcone.Location = new System.Drawing.Point(123, 91);
            this.pbWeatherIcone.Name = "pbWeatherIcone";
            this.pbWeatherIcone.Size = new System.Drawing.Size(70, 50);
            this.pbWeatherIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeatherIcone.TabIndex = 2;
            this.pbWeatherIcone.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(7, 105);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(61, 36);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "21*";
            // 
            // tbExtraWeatherInfo
            // 
            this.tbExtraWeatherInfo.Location = new System.Drawing.Point(12, 168);
            this.tbExtraWeatherInfo.Multiline = true;
            this.tbExtraWeatherInfo.Name = "tbExtraWeatherInfo";
            this.tbExtraWeatherInfo.Size = new System.Drawing.Size(181, 89);
            this.tbExtraWeatherInfo.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(764, 534);
            this.Controls.Add(this.tbExtraWeatherInfo);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.pbWeatherIcone);
            this.Controls.Add(this.lblCityNameCountry);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Laika ģids";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCityNameCountry;
        private System.Windows.Forms.PictureBox pbWeatherIcone;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox tbExtraWeatherInfo;
    }
}

