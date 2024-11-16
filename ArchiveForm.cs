using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaOOP
{
    public partial class ArchiveForm : Form
    {
        private CrimeRecordArchive archive;

        public ArchiveForm(CrimeRecordArchive archive)
        {
            InitializeComponent();
            this.archive = archive;
            this.archive.RecordAdded += Archive_RecordAdded;

            this.HandleCreated += ArchiveForm_HandleCreated;
        }

        private void ArchiveForm_HandleCreated(object sender, EventArgs e)
        {
            this.HandleCreated -= ArchiveForm_HandleCreated;

            if (!this.IsDisposed && !this.Disposing)
            {
                UpdateArchiveList();
            }
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {
        }

        private void Archive_RecordAdded(object sender, CrimeRecord record)
        {
            if (archiveListBox.InvokeRequired)
            {
                archiveListBox.BeginInvoke(new Action(() => {
                    archiveListBox.Items.Add(record.GetInfo());
                }));
            }
            else
            {
                archiveListBox.Items.Add(record.GetInfo());
            }
        }

        private void UpdateArchiveList()
        {
            archiveListBox.Items.Clear();
            var archivedRecords = archive.GetArchivedRecords();
            foreach (var record in archivedRecords)
            {
                archiveListBox.Items.Add(record.GetInfo());
            }
        }

        private void archiveListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




