namespace PeliculasWindowsForms
{
    partial class ShowMoviesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SipnosisButton = new System.Windows.Forms.Button();
            this.SalidalistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peliculas Registradas";
            // 
            // SipnosisButton
            // 
            this.SipnosisButton.Location = new System.Drawing.Point(705, 245);
            this.SipnosisButton.Name = "SipnosisButton";
            this.SipnosisButton.Size = new System.Drawing.Size(93, 33);
            this.SipnosisButton.TabIndex = 2;
            this.SipnosisButton.Text = "Sipnosis";
            this.SipnosisButton.UseVisualStyleBackColor = true;
            this.SipnosisButton.Click += new System.EventHandler(this.SipnosisButton_Click);
            // 
            // SalidalistView
            // 
            this.SalidalistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.SalidalistView.Location = new System.Drawing.Point(13, 99);
            this.SalidalistView.Name = "SalidalistView";
            this.SalidalistView.Size = new System.Drawing.Size(593, 179);
            this.SalidalistView.TabIndex = 3;
            this.SalidalistView.UseCompatibleStateImageBehavior = false;
            this.SalidalistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Categoria";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Titulo";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Calificacion";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Año";
            this.columnHeader5.Width = 42;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Idioma";
            this.columnHeader6.Width = 75;
            // 
            // ShowMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 290);
            this.Controls.Add(this.SalidalistView);
            this.Controls.Add(this.SipnosisButton);
            this.Controls.Add(this.label1);
            this.Name = "ShowMoviesForm";
            this.Text = "Consultas de Peliculas";
            this.Load += new System.EventHandler(this.ShowMoviesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SipnosisButton;
        private System.Windows.Forms.ListView SalidalistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}