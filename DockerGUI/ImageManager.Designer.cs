namespace DockerGUI
{
    partial class ImageManager
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
            this.dgv_ImageList = new System.Windows.Forms.DataGridView();
            this.b_DeleteContainer = new System.Windows.Forms.Button();
            this.b_cmMainPage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImageList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ImageList
            // 
            this.dgv_ImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ImageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Port,
            this.Password});
            this.dgv_ImageList.Location = new System.Drawing.Point(14, 43);
            this.dgv_ImageList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_ImageList.Name = "dgv_ImageList";
            this.dgv_ImageList.Size = new System.Drawing.Size(444, 464);
            this.dgv_ImageList.TabIndex = 1;
            // 
            // b_DeleteContainer
            // 
            this.b_DeleteContainer.Location = new System.Drawing.Point(14, 9);
            this.b_DeleteContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_DeleteContainer.Name = "b_DeleteContainer";
            this.b_DeleteContainer.Size = new System.Drawing.Size(88, 27);
            this.b_DeleteContainer.TabIndex = 3;
            this.b_DeleteContainer.Text = "Delete";
            this.b_DeleteContainer.UseVisualStyleBackColor = true;
            this.b_DeleteContainer.Click += new System.EventHandler(this.b_DeleteContainer_Click);
            // 
            // b_cmMainPage
            // 
            this.b_cmMainPage.Location = new System.Drawing.Point(110, 9);
            this.b_cmMainPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_cmMainPage.Name = "b_cmMainPage";
            this.b_cmMainPage.Size = new System.Drawing.Size(88, 27);
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
            // IDE
            // 
            this.IDE.HeaderText = "IDE";
            this.IDE.Name = "IDE";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IDE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Project
            // 
            this.Project.HeaderText = "Project";
            this.Project.Name = "Project";
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "IDE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // ImageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 519);
            this.Controls.Add(this.b_cmMainPage);
            this.Controls.Add(this.b_DeleteContainer);
            this.Controls.Add(this.dgv_ImageList);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name.Name = "ImageManager";
            this.Text = "Image Manager";
            this.Load += new System.EventHandler(this.ImageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ImageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ImageList;
        private System.Windows.Forms.Button b_DeleteContainer;
        private System.Windows.Forms.Button b_cmMainPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}