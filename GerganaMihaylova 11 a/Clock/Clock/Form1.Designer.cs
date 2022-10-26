
namespace Clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labeltime = new System.Windows.Forms.Label();
            this.labelsec = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelday = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltime.Location = new System.Drawing.Point(251, 20);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(286, 110);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "22:22";
            this.labeltime.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelsec
            // 
            this.labelsec.AutoSize = true;
            this.labelsec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsec.Location = new System.Drawing.Point(365, 149);
            this.labelsec.Name = "labelsec";
            this.labelsec.Size = new System.Drawing.Size(62, 44);
            this.labelsec.TabIndex = 1;
            this.labelsec.Text = "22";
            this.labelsec.Click += new System.EventHandler(this.label2_Click);
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldate.Location = new System.Drawing.Point(238, 201);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(319, 57);
            this.labeldate.TabIndex = 2;
            this.labeldate.Text = "June 25 2021";
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelday.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelday.Location = new System.Drawing.Point(307, 281);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(203, 57);
            this.labelday.TabIndex = 3;
            this.labelday.Text = "Satuday";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelday);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelsec);
            this.Controls.Add(this.labeltime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label labelsec;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelday;
        private System.Windows.Forms.Timer timer;
    }
}

