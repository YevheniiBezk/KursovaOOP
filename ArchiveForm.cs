using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using KursovaOOP;
using static KursovaOOP.MainForm;

namespace KursovaOOP
{
    public partial class ArchiveForm : Form
    {
        private CrimeRecordArchive archive;
        private BindingList<CrimeRecord> archivedRecords;

        public ArchiveForm(CrimeRecordArchive archive)
        {
            InitializeComponent();
            this.archive = archive;

            archivedRecords = new BindingList<CrimeRecord>(archive.GetArchivedRecords());
            archiveDataGridView.DataSource = archivedRecords;

            
            this.archive.RecordAdded += Archive_RecordAdded;
        }

        private void Archive_RecordAdded(object sender, CrimeRecord record)
        {
            if (archiveDataGridView.InvokeRequired)
            {
                archiveDataGridView.Invoke(new Action(() => archivedRecords.Add(record)));
            }
            else
            {
                archivedRecords.Add(record);
            }
        }

        private void deleteButton_Click1(object sender, EventArgs e)
        {
            {
                if (archiveDataGridView.SelectedRows.Count > 0)
                {
                    var selectedRows = archiveDataGridView.SelectedRows;
                    List<CrimeRecord> recordsToDelete = new List<CrimeRecord>();

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var record = row.DataBoundItem as CrimeRecord;
                        if (record != null)
                        {
                            recordsToDelete.Add(record);
                        }
                    }

                    foreach (var record in recordsToDelete)
                    {
                        archivedRecords.Remove(record); 
                    }

                    MessageBox.Show($"{recordsToDelete.Count} запис(ів) видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть запис для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
