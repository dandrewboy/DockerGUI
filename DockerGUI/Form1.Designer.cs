namespace DockerGUI
{
    partial class MainPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_OpenFile = new System.Windows.Forms.Button();
            this.b_Delete = new System.Windows.Forms.Button();
            this.b_Presets = new System.Windows.Forms.Button();
            this.b_ContainerManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.IDE,
            this.Project,
            this.Language});
            this.dataGridView1.Location = new System.Drawing.Point(14, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "String";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            // 
            // IDE
            // 
            this.IDE.HeaderText = "IDE";
            this.IDE.Name = "IDE";
            // 
            // Project
            // 
            this.Project.DataPropertyName = "String";
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // b_OpenFile
            // 
            this.b_OpenFile.Location = new System.Drawing.Point(15, 14);
            this.b_OpenFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_OpenFile.Name = "b_OpenFile";
            this.b_OpenFile.Size = new System.Drawing.Size(88, 27);
            this.b_OpenFile.TabIndex = 1;
            this.b_OpenFile.Text = "Open File";
            this.b_OpenFile.UseVisualStyleBackColor = true;
            this.b_OpenFile.Click += new System.EventHandler(this.b_OpenFile_Click);
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(122, 14);
            this.b_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(113, 27);
            this.b_Delete.TabIndex = 3;
            this.b_Delete.Text = "Delete Container";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // b_Presets
            // 
            this.b_Presets.Location = new System.Drawing.Point(13, 481);
            this.b_Presets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_Presets.Name = "b_Presets";
            this.b_Presets.Size = new System.Drawing.Size(88, 27);
            this.b_Presets.TabIndex = 4;
            this.b_Presets.Text = "Presets";
            this.b_Presets.UseVisualStyleBackColor = true;
            this.b_Presets.Click += new System.EventHandler(this.b_Presets_Click);
            // 
            // b_ContainerManager
            // 
            this.b_ContainerManager.Location = new System.Drawing.Point(109, 481);
            this.b_ContainerManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_ContainerManager.Name = "b_ContainerManager";
            this.b_ContainerManager.Size = new System.Drawing.Size(126, 27);
            this.b_ContainerManager.TabIndex = 5;
            this.b_ContainerManager.Text = "Image Manager";
            this.b_ContainerManager.UseVisualStyleBackColor = true;
            this.b_ContainerManager.Click += new System.EventHandler(this.b_ContainerManager_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 519);
            this.Controls.Add(this.b_ContainerManager);
            this.Controls.Add(this.b_Presets);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_OpenFile);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainPage";
            this.Text = "Docker GUI: Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_OpenFile;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Button b_Presets;
        private System.Windows.Forms.Button b_ContainerManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
    }
}

