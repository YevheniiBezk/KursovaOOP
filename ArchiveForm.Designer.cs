namespace KursovaOOP
{
    partial class ArchiveForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Звільнити всі ресурси, які використовуються.
        /// </summary>
        /// <param name="disposing">істинне, якщо керовані ресурси повинні бути видалені; інакше хибне.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.archiveDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // archiveDataGridView
            // 
            this.archiveDataGridView.AllowUserToAddRows = false;
            this.archiveDataGridView.AllowUserToDeleteRows = false;
            this.archiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGridView.Location = new System.Drawing.Point(12, 12);
            this.archiveDataGridView.Name = "archiveDataGridView";
            this.archiveDataGridView.ReadOnly = true;
            this.archiveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveDataGridView.Size = new System.Drawing.Size(760, 437);
            this.archiveDataGridView.TabIndex = 0;
            // 
            // ArchiveForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.archiveDataGridView);
            this.Name = "ArchiveForm";
            this.Text = "Архів записів";
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView archiveDataGridView;
    }
}
