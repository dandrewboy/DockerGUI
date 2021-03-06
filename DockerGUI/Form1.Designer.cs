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
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_OpenFile = new System.Windows.Forms.Button();
            this.b_OpenContainer = new System.Windows.Forms.Button();
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
            this.Language,
            this.IDE,
            this.Project,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "String";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            // 
            // Language
            // 
            this.Language.DataPropertyName = "String";
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // IDE
            // 
            this.IDE.DataPropertyName = "String";
            this.IDE.HeaderText = "IDE";
            this.IDE.Name = "IDE";
            // 
            // Project
            // 
            this.Project.DataPropertyName = "String";
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "String";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // b_OpenFile
            // 
            this.b_OpenFile.Location = new System.Drawing.Point(13, 12);
            this.b_OpenFile.Name = "b_OpenFile";
            this.b_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.b_OpenFile.TabIndex = 1;
            this.b_OpenFile.Text = "Open File";
            this.b_OpenFile.UseVisualStyleBackColor = true;
            this.b_OpenFile.Click += new System.EventHandler(this.b_OpenFile_Click);
            // 
            // b_OpenContainer
            // 
            this.b_OpenContainer.Location = new System.Drawing.Point(94, 12);
            this.b_OpenContainer.Name = "b_OpenContainer";
            this.b_OpenContainer.Size = new System.Drawing.Size(104, 23);
            this.b_OpenContainer.TabIndex = 2;
            this.b_OpenContainer.Text = "Open Container";
            this.b_OpenContainer.UseVisualStyleBackColor = true;
            // 
            // b_Delete
            // 
            this.b_Delete.Location = new System.Drawing.Point(204, 12);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(97, 23);
            this.b_Delete.TabIndex = 3;
            this.b_Delete.Text = "Delete Image";
            this.b_Delete.UseVisualStyleBackColor = true;
            // 
            // b_Presets
            // 
            this.b_Presets.Location = new System.Drawing.Point(367, 12);
            this.b_Presets.Name = "b_Presets";
            this.b_Presets.Size = new System.Drawing.Size(75, 23);
            this.b_Presets.TabIndex = 4;
            this.b_Presets.Text = "Presets";
            this.b_Presets.UseVisualStyleBackColor = true;
            this.b_Presets.Click += new System.EventHandler(this.b_Presets_Click);
            // 
            // b_ContainerManager
            // 
            this.b_ContainerManager.Location = new System.Drawing.Point(448, 12);
            this.b_ContainerManager.Name = "b_ContainerManager";
            this.b_ContainerManager.Size = new System.Drawing.Size(108, 23);
            this.b_ContainerManager.TabIndex = 5;
            this.b_ContainerManager.Text = "Container Manager";
            this.b_ContainerManager.UseVisualStyleBackColor = true;
            this.b_ContainerManager.Click += new System.EventHandler(this.b_ContainerManager_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_ContainerManager);
            this.Controls.Add(this.b_Presets);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_OpenContainer);
            this.Controls.Add(this.b_OpenFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainPage";
            this.Text = "Docker GUI: Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_OpenFile;
        private System.Windows.Forms.Button b_OpenContainer;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.Button b_Presets;
        private System.Windows.Forms.Button b_ContainerManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

