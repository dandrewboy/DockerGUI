namespace DockerGUI
{
    partial class ContainerManager
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
            this.b_RunContainer = new System.Windows.Forms.Button();
            this.b_DeleteContainer = new System.Windows.Forms.Button();
            this.b_cmMainPage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // b_RunContainer
            // 
            this.b_RunContainer.Location = new System.Drawing.Point(13, 8);
            this.b_RunContainer.Name = "b_RunContainer";
            this.b_RunContainer.Size = new System.Drawing.Size(75, 23);
            this.b_RunContainer.TabIndex = 2;
            this.b_RunContainer.Text = "Run";
            this.b_RunContainer.UseVisualStyleBackColor = true;
            // 
            // b_DeleteContainer
            // 
            this.b_DeleteContainer.Location = new System.Drawing.Point(105, 8);
            this.b_DeleteContainer.Name = "b_DeleteContainer";
            this.b_DeleteContainer.Size = new System.Drawing.Size(75, 23);
            this.b_DeleteContainer.TabIndex = 3;
            this.b_DeleteContainer.Text = "Delete";
            this.b_DeleteContainer.UseVisualStyleBackColor = true;
            // 
            // b_cmMainPage
            // 
            this.b_cmMainPage.Location = new System.Drawing.Point(713, 8);
            this.b_cmMainPage.Name = "b_cmMainPage";
            this.b_cmMainPage.Size = new System.Drawing.Size(75, 23);
            this.b_cmMainPage.TabIndex = 4;
            this.b_cmMainPage.Text = "Main Page";
            this.b_cmMainPage.UseVisualStyleBackColor = true;
            this.b_cmMainPage.Click += new System.EventHandler(this.b_cmMainPage_Click);
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
            // ContainerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_cmMainPage);
            this.Controls.Add(this.b_DeleteContainer);
            this.Controls.Add(this.b_RunContainer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ContainerManager";
            this.Text = "ContainerManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_RunContainer;
        private System.Windows.Forms.Button b_DeleteContainer;
        private System.Windows.Forms.Button b_cmMainPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}