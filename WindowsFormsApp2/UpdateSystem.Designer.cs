
namespace WindowsFormsApp2
{
    partial class UpdateSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSystem));
            this.btn_load = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.checkBox_doc = new System.Windows.Forms.CheckBox();
            this.checkBox_patient = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Black;
            this.btn_load.Location = new System.Drawing.Point(490, 46);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(160, 42);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Load Information";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 298);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Red;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(600, 457);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(142, 40);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // checkBox_doc
            // 
            this.checkBox_doc.AutoSize = true;
            this.checkBox_doc.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_doc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_doc.Location = new System.Drawing.Point(206, 34);
            this.checkBox_doc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_doc.Name = "checkBox_doc";
            this.checkBox_doc.Size = new System.Drawing.Size(263, 24);
            this.checkBox_doc.TabIndex = 7;
            this.checkBox_doc.Text = "Update Doctors information";
            this.checkBox_doc.UseVisualStyleBackColor = false;
            // 
            // checkBox_patient
            // 
            this.checkBox_patient.AutoSize = true;
            this.checkBox_patient.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_patient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_patient.Location = new System.Drawing.Point(202, 74);
            this.checkBox_patient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_patient.Name = "checkBox_patient";
            this.checkBox_patient.Size = new System.Drawing.Size(265, 24);
            this.checkBox_patient.TabIndex = 8;
            this.checkBox_patient.Text = "Update Patients information";
            this.checkBox_patient.UseVisualStyleBackColor = false;
            // 
            // UpdateSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 522);
            this.Controls.Add(this.checkBox_patient);
            this.Controls.Add(this.checkBox_doc);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_load);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateSystem";
            this.Text = "Update System Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox checkBox_doc;
        private System.Windows.Forms.CheckBox checkBox_patient;
    }
}