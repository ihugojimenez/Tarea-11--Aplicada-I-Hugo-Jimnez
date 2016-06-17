namespace PeliculasWindowsForms
{
    partial class SipnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SipnosisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.IdSearchTextBox = new System.Windows.Forms.TextBox();
            this.SipnosisListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SalidaTextBox = new System.Windows.Forms.TextBox();
            this.NullTextIdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NullTextIdErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IdSearchTextBox
            // 
            this.IdSearchTextBox.Location = new System.Drawing.Point(41, 13);
            this.IdSearchTextBox.Name = "IdSearchTextBox";
            this.IdSearchTextBox.Size = new System.Drawing.Size(120, 22);
            this.IdSearchTextBox.TabIndex = 1;
            this.IdSearchTextBox.TextChanged += new System.EventHandler(this.IdSearchTextBox_TextChanged);
            // 
            // SipnosisListView
            // 
            this.SipnosisListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SipnosisListView.Location = new System.Drawing.Point(12, 96);
            this.SipnosisListView.Name = "SipnosisListView";
            this.SipnosisListView.Size = new System.Drawing.Size(149, 168);
            this.SipnosisListView.TabIndex = 2;
            this.SipnosisListView.UseCompatibleStateImageBehavior = false;
            this.SipnosisListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titulo";
            this.columnHeader2.Width = 99;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(189, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sipnosis";
            // 
            // SalidaTextBox
            // 
            this.SalidaTextBox.Location = new System.Drawing.Point(265, 96);
            this.SalidaTextBox.Multiline = true;
            this.SalidaTextBox.Name = "SalidaTextBox";
            this.SalidaTextBox.Size = new System.Drawing.Size(267, 168);
            this.SalidaTextBox.TabIndex = 6;
            // 
            // NullTextIdErrorProvider
            // 
            this.NullTextIdErrorProvider.ContainerControl = this;
            // 
            // SipnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 288);
            this.Controls.Add(this.SalidaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SipnosisListView);
            this.Controls.Add(this.IdSearchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SipnosisForm";
            this.Text = "Sipnosis de Peliculas";
            this.Load += new System.EventHandler(this.SipnosisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NullTextIdErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdSearchTextBox;
        private System.Windows.Forms.ListView SipnosisListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox SalidaTextBox;
        private System.Windows.Forms.ErrorProvider NullTextIdErrorProvider;
    }
}