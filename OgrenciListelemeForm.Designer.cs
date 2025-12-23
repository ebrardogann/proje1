namespace OgrKayitApp.Forms
{
    partial class OgrenciListelemeForm
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
            lblAra = new Label();
            txtArama = new TextBox();
            dataGridView1 = new DataGridView();
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.Location = new Point(78, 66);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(91, 20);
            lblAra.TabIndex = 0;
            lblAra.Text = "Öğrenci Ara:";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(193, 63);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(120, 26);
            txtArama.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(475, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(288, 180);
            dataGridView1.TabIndex = 2;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(340, 61);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(90, 28);
            btnAra.TabIndex = 3;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // OgrenciListelemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAra);
            Controls.Add(dataGridView1);
            Controls.Add(txtArama);
            Controls.Add(lblAra);
            Name = "OgrenciListelemeForm";
            Text = "OgrenciListelemeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAra;
        private TextBox txtArama;
        private DataGridView dataGridView1;
        private Button btnAra;
    }
}