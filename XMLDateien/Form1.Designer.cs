namespace XMLDateien
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
            this.btnSchreiben = new System.Windows.Forms.Button();
            this.btnLesen = new System.Windows.Forms.Button();
            this.btnObjekteIn = new System.Windows.Forms.Button();
            this.btnObjekteAus = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSchreiben
            // 
            this.btnSchreiben.Location = new System.Drawing.Point(226, 12);
            this.btnSchreiben.Name = "btnSchreiben";
            this.btnSchreiben.Size = new System.Drawing.Size(167, 23);
            this.btnSchreiben.TabIndex = 0;
            this.btnSchreiben.Text = "XML-Datei schreiben";
            this.btnSchreiben.UseVisualStyleBackColor = true;
            this.btnSchreiben.Click += new System.EventHandler(this.btnSchreiben_Click);
            // 
            // btnLesen
            // 
            this.btnLesen.Location = new System.Drawing.Point(226, 41);
            this.btnLesen.Name = "btnLesen";
            this.btnLesen.Size = new System.Drawing.Size(167, 23);
            this.btnLesen.TabIndex = 0;
            this.btnLesen.Text = "XML-Datei lesen";
            this.btnLesen.UseVisualStyleBackColor = true;
            this.btnLesen.Click += new System.EventHandler(this.btnLesen_Click);
            // 
            // btnObjekteIn
            // 
            this.btnObjekteIn.Location = new System.Drawing.Point(226, 103);
            this.btnObjekteIn.Name = "btnObjekteIn";
            this.btnObjekteIn.Size = new System.Drawing.Size(167, 23);
            this.btnObjekteIn.TabIndex = 0;
            this.btnObjekteIn.Text = "Objekte in XML-Datei";
            this.btnObjekteIn.UseVisualStyleBackColor = true;
            this.btnObjekteIn.Click += new System.EventHandler(this.btnObjekteIn_Click);
            // 
            // btnObjekteAus
            // 
            this.btnObjekteAus.Location = new System.Drawing.Point(226, 132);
            this.btnObjekteAus.Name = "btnObjekteAus";
            this.btnObjekteAus.Size = new System.Drawing.Size(167, 23);
            this.btnObjekteAus.TabIndex = 0;
            this.btnObjekteAus.Text = "Objekte aus XML-Datei";
            this.btnObjekteAus.UseVisualStyleBackColor = true;
            this.btnObjekteAus.Click += new System.EventHandler(this.btnObjekteAus_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(12, 12);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(16, 15);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 277);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnObjekteAus);
            this.Controls.Add(this.btnObjekteIn);
            this.Controls.Add(this.btnLesen);
            this.Controls.Add(this.btnSchreiben);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSchreiben;
        private Button btnLesen;
        private Button btnObjekteIn;
        private Button btnObjekteAus;
        private Label lblDisplay;
    }
}