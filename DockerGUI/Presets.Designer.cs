namespace DockerGUI
{
    partial class Presets
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
            this.label2 = new System.Windows.Forms.Label();
            this.l_PresetJava = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_PresetPhP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Csharp = new System.Windows.Forms.Label();
            this.b_EditPreset = new System.Windows.Forms.Button();
            this.b_eMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Java IDE Preset:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // l_PresetJava
            // 
            this.l_PresetJava.AutoSize = true;
            this.l_PresetJava.Location = new System.Drawing.Point(99, 7);
            this.l_PresetJava.Name = "l_PresetJava";
            this.l_PresetJava.Size = new System.Drawing.Size(33, 13);
            this.l_PresetJava.TabIndex = 2;
            this.l_PresetJava.Text = "None";
            this.l_PresetJava.Click += new System.EventHandler(this.l_PresetJava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PhP IDE Preset:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // l_PresetPhP
            // 
            this.l_PresetPhP.AutoSize = true;
            this.l_PresetPhP.Location = new System.Drawing.Point(99, 29);
            this.l_PresetPhP.Name = "l_PresetPhP";
            this.l_PresetPhP.Size = new System.Drawing.Size(33, 13);
            this.l_PresetPhP.TabIndex = 4;
            this.l_PresetPhP.Text = "None";
            this.l_PresetPhP.Click += new System.EventHandler(this.l_PresetPhP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "C# IDE Preset:";
            // 
            // l_Csharp
            // 
            this.l_Csharp.AutoSize = true;
            this.l_Csharp.Location = new System.Drawing.Point(99, 51);
            this.l_Csharp.Name = "l_Csharp";
            this.l_Csharp.Size = new System.Drawing.Size(33, 13);
            this.l_Csharp.TabIndex = 6;
            this.l_Csharp.Text = "None";
            // 
            // b_EditPreset
            // 
            this.b_EditPreset.Location = new System.Drawing.Point(12, 78);
            this.b_EditPreset.Name = "b_EditPreset";
            this.b_EditPreset.Size = new System.Drawing.Size(75, 23);
            this.b_EditPreset.TabIndex = 7;
            this.b_EditPreset.Text = "Edit";
            this.b_EditPreset.UseVisualStyleBackColor = true;
            // 
            // b_eMainPage
            // 
            this.b_eMainPage.Location = new System.Drawing.Point(713, 7);
            this.b_eMainPage.Name = "b_eMainPage";
            this.b_eMainPage.Size = new System.Drawing.Size(75, 23);
            this.b_eMainPage.TabIndex = 8;
            this.b_eMainPage.Text = "Main Page";
            this.b_eMainPage.UseVisualStyleBackColor = true;
            this.b_eMainPage.Click += new System.EventHandler(this.b_eMainPage_Click);
            // 
            // Presets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_eMainPage);
            this.Controls.Add(this.b_EditPreset);
            this.Controls.Add(this.l_Csharp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_PresetPhP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_PresetJava);
            this.Controls.Add(this.label2);
            this.Name = "Presets";
            this.Text = "Docker GUI: User Presets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_PresetJava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_PresetPhP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Csharp;
        private System.Windows.Forms.Button b_EditPreset;
        private System.Windows.Forms.Button b_eMainPage;
    }
}