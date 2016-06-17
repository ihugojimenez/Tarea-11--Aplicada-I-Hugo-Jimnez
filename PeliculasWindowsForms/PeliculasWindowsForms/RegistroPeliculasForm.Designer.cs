namespace PeliculasWindowsForms
{
    partial class RegistroPeliculasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPeliculasForm));
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasDataSet = new PeliculasWindowsForms.PeliculasDataSet();
            this.moviesTableAdapter = new PeliculasWindowsForms.PeliculasDataSetTableAdapters.MoviesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdPeliTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdCatTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SipnosisTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AnoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IdiomaTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SalidalistView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.peliculasDataSet;
            // 
            // peliculasDataSet
            // 
            this.peliculasDataSet.DataSetName = "PeliculasDataSet";
            this.peliculasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Pelicula";
            // 
            // IdPeliTextBox
            // 
            this.IdPeliTextBox.Location = new System.Drawing.Point(110, 13);
            this.IdPeliTextBox.Name = "IdPeliTextBox";
            this.IdPeliTextBox.Size = new System.Drawing.Size(31, 22);
            this.IdPeliTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Categoria";
            // 
            // IdCatTextBox
            // 
            this.IdCatTextBox.Location = new System.Drawing.Point(123, 51);
            this.IdCatTextBox.Name = "IdCatTextBox";
            this.IdCatTextBox.Size = new System.Drawing.Size(28, 22);
            this.IdCatTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titulo";
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(70, 91);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(193, 22);
            this.TituloTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sipnosis";
            // 
            // SipnosisTextBox
            // 
            this.SipnosisTextBox.Location = new System.Drawing.Point(91, 137);
            this.SipnosisTextBox.Multiline = true;
            this.SipnosisTextBox.Name = "SipnosisTextBox";
            this.SipnosisTextBox.Size = new System.Drawing.Size(335, 75);
            this.SipnosisTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Calificacion";
            // 
            // CalTextBox
            // 
            this.CalTextBox.Location = new System.Drawing.Point(292, 15);
            this.CalTextBox.Name = "CalTextBox";
            this.CalTextBox.Size = new System.Drawing.Size(31, 22);
            this.CalTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Año";
            // 
            // AnoTextBox
            // 
            this.AnoTextBox.Location = new System.Drawing.Point(240, 50);
            this.AnoTextBox.Name = "AnoTextBox";
            this.AnoTextBox.Size = new System.Drawing.Size(53, 22);
            this.AnoTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Idioma";
            // 
            // IdiomaTextBox
            // 
            this.IdiomaTextBox.Location = new System.Drawing.Point(353, 94);
            this.IdiomaTextBox.Name = "IdiomaTextBox";
            this.IdiomaTextBox.Size = new System.Drawing.Size(130, 22);
            this.IdiomaTextBox.TabIndex = 15;
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(365, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 54);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SalidalistView
            // 
            this.SalidalistView.Location = new System.Drawing.Point(17, 288);
            this.SalidalistView.Name = "SalidalistView";
            this.SalidalistView.Size = new System.Drawing.Size(409, 158);
            this.SalidalistView.TabIndex = 17;
            this.SalidalistView.UseCompatibleStateImageBehavior = false;
            this.SalidalistView.View = System.Windows.Forms.View.Details;
            // 
            // RegistroPeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 449);
            this.Controls.Add(this.SalidalistView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.IdiomaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AnoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SipnosisTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TituloTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdCatTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdPeliTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPeliculasForm";
            this.Text = "RegistroPeliculasForm";
            this.Load += new System.EventHandler(this.RegistroPeliculasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PeliculasDataSet peliculasDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private PeliculasDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdPeliTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdCatTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SipnosisTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AnoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdiomaTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListView SalidalistView;
    }
}