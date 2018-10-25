namespace Final_quiz
{
    partial class temas
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
            this.btn_avac = new System.Windows.Forms.Button();
            this.btn_medio = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_avac
            // 
            this.btn_avac.Location = new System.Drawing.Point(533, 190);
            this.btn_avac.Name = "btn_avac";
            this.btn_avac.Size = new System.Drawing.Size(150, 70);
            this.btn_avac.TabIndex = 5;
            this.btn_avac.Text = "Nível Avançado";
            this.btn_avac.UseVisualStyleBackColor = true;
            this.btn_avac.Click += new System.EventHandler(this.btn_avac_Click);
            // 
            // btn_medio
            // 
            this.btn_medio.Location = new System.Drawing.Point(324, 190);
            this.btn_medio.Name = "btn_medio";
            this.btn_medio.Size = new System.Drawing.Size(150, 70);
            this.btn_medio.TabIndex = 4;
            this.btn_medio.Text = "Nível  Médio";
            this.btn_medio.UseVisualStyleBackColor = true;
            this.btn_medio.Click += new System.EventHandler(this.btn_medio_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(117, 190);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(150, 70);
            this.btn_inicio.TabIndex = 7;
            this.btn_inicio.Text = "Nível Fácil";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_avac);
            this.Controls.Add(this.btn_medio);
            this.Name = "temas";
            this.Text = "temas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avac;
        private System.Windows.Forms.Button btn_medio;
        private System.Windows.Forms.Button btn_inicio;
    }
}