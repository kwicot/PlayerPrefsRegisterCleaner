namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("0000");
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.button_Reload = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.comboBox_Projects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_DeleteSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(133, 11);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Company.TabIndex = 0;
            this.comboBox_Company.SelectedIndexChanged += new System.EventHandler(this.comboBox_Company_SelectedIndexChanged);
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(322, 11);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(87, 21);
            this.button_Reload.TabIndex = 1;
            this.button_Reload.Text = "Reload";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2});
            this.listView1.FullRowSelect = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {listViewItem1});
            this.listView1.Location = new System.Drawing.Point(8, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 439);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 265;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 413;
            // 
            // comboBox_Projects
            // 
            this.comboBox_Projects.FormattingEnabled = true;
            this.comboBox_Projects.Location = new System.Drawing.Point(133, 38);
            this.comboBox_Projects.Name = "comboBox_Projects";
            this.comboBox_Projects.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Projects.TabIndex = 3;
            this.comboBox_Projects.SelectedIndexChanged += new System.EventHandler(this.comboBox_Projects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_DeleteSelected
            // 
            this.button_DeleteSelected.Location = new System.Drawing.Point(457, 514);
            this.button_DeleteSelected.Name = "button_DeleteSelected";
            this.button_DeleteSelected.Size = new System.Drawing.Size(130, 22);
            this.button_DeleteSelected.TabIndex = 6;
            this.button_DeleteSelected.Text = "Delete selected";
            this.button_DeleteSelected.UseVisualStyleBackColor = true;
            this.button_DeleteSelected.Click += new System.EventHandler(this.button_DeleteSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.button_DeleteSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Projects);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Reload);
            this.Controls.Add(this.comboBox_Company);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button_DeleteSelected;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBox_Projects;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox comboBox_Company;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

        private System.Windows.Forms.ListView listView1;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Reload;

        #endregion
    }
}