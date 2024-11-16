namespace KursovaOOP
{
    partial class ArchiveForm
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
            this.archiveListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // archiveListBox
            // 
            this.archiveListBox.FormattingEnabled = true;
            this.archiveListBox.Location = new System.Drawing.Point(12, 25);
            this.archiveListBox.Name = "archiveListBox";
            this.archiveListBox.Size = new System.Drawing.Size(312, 303);
            this.archiveListBox.TabIndex = 0;
            this.archiveListBox.SelectedIndexChanged += new System.EventHandler(this.archiveListBox_SelectedIndexChanged);
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.archiveListBox);
            this.Name = "ArchiveForm";
            this.Text = "Crime Record Archive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox archiveListBox;
    }
}