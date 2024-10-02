namespace Pogodziak
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
            lat = new Label();
            lon = new Label();
            time = new Label();
            temp = new Label();
            weather = new Label();
            hum = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lat
            // 
            lat.AutoSize = true;
            lat.Font = new Font("Segoe UI", 8F);
            lat.Location = new Point(331, 147);
            lat.Name = "lat";
            lat.Size = new Size(20, 13);
            lat.TabIndex = 0;
            lat.Text = "lat";
            lat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lon
            // 
            lon.AutoSize = true;
            lon.Font = new Font("Segoe UI", 8F);
            lon.Location = new Point(431, 147);
            lon.Name = "lon";
            lon.Size = new Size(31, 13);
            lon.TabIndex = 0;
            lon.Text = "long";
            lon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 20F);
            time.Location = new Point(356, 96);
            time.Name = "time";
            time.Size = new Size(83, 37);
            time.TabIndex = 2;
            time.Text = "00:00";
            time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Segoe UI", 25F);
            temp.Location = new Point(367, 174);
            temp.Name = "temp";
            temp.Size = new Size(72, 46);
            temp.TabIndex = 3;
            temp.Text = "0℃";
            temp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weather
            // 
            weather.AutoSize = true;
            weather.Font = new Font("Segoe UI", 12F);
            weather.Location = new Point(367, 246);
            weather.Name = "weather";
            weather.Size = new Size(66, 21);
            weather.TabIndex = 4;
            weather.Text = "weather";
            // 
            // hum
            // 
            hum.AutoSize = true;
            hum.Font = new Font("Segoe UI", 20F);
            hum.Location = new Point(429, 288);
            hum.Name = "hum";
            hum.Size = new Size(54, 37);
            hum.TabIndex = 5;
            hum.Text = "0%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(331, 301);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 6;
            label1.Text = "wilgotność: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(weather);
            Controls.Add(temp);
            Controls.Add(label1);
            Controls.Add(hum);
            Controls.Add(lon);
            Controls.Add(lat);
            Controls.Add(time);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lat;
        private Label lon;
        private Label time;
        private Label temp;
        private Label weather;
        private Label hum;
        private Label label1;
    }
}
