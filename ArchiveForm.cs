using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

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

            // Підписуємося на подію додавання запису до архіву
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
    }
}
