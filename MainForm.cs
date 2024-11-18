using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KursovaOOP
{
    public partial class MainForm : Form
    {
        private BindingList<CrimeRecord> crimeRecords;
        private CrimeRecordArchive archive;

        public MainForm()
        {
            InitializeComponent();
            crimeRecords = new BindingList<CrimeRecord>();
            archive = new CrimeRecordArchive();
            AddDefaultCriminals();
            crimeRecordDataGridView.DataSource = crimeRecords;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddRecordForm addRecordForm = new AddRecordForm();
            if (addRecordForm.ShowDialog() == DialogResult.OK)
            {
                CrimeRecord newRecord = addRecordForm.NewCrimeRecord;
                crimeRecords.Add(newRecord);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crimeRecordDataGridView.SelectedRows.Count > 0)
            {
                List<CrimeRecord> recordsToRemove = new List<CrimeRecord>();
                foreach (DataGridViewRow row in crimeRecordDataGridView.SelectedRows)
                {
                    CrimeRecord selectedRecord = row.DataBoundItem as CrimeRecord;
                    if (selectedRecord != null)
                    {
                        recordsToRemove.Add(selectedRecord);
                    }
                }
                foreach (var record in recordsToRemove)
                {
                    crimeRecords.Remove(record);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть запис про злочинця для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if (crimeRecordDataGridView.SelectedRows.Count > 0)
            {
                List<CrimeRecord> recordsToArchive = new List<CrimeRecord>();
                foreach (DataGridViewRow row in crimeRecordDataGridView.SelectedRows)
                {
                    CrimeRecord selectedRecord = row.DataBoundItem as CrimeRecord;
                    if (selectedRecord != null)
                    {
                        recordsToArchive.Add(selectedRecord);
                    }
                }
                foreach (var record in recordsToArchive)
                {
                    archive.AddToArchive(record);
                    crimeRecords.Remove(record);
                }
                archive.SaveToFile("archive.xml");
                MessageBox.Show("Вибрані записи архівовано.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть запис(и) для архівування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewArchiveButton_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm(archive);
            archiveForm.ShowDialog();
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    foreach (var record in crimeRecords)
                    {
                        writer.WriteLine($"{record.FirstName}\t{record.LastName}\t{record.Nickname}\t{record.Height}\t{record.EyeColor}\t{record.Nationality}\t{record.BirthDate}\t{record.BirthPlace}\t{record.LastKnownAddress}\t{record.CriminalProfession}\t{record.HairColor}");
                    }
                }
                MessageBox.Show("Записи про злочини збережено у текстовий файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadTextButton_Click(object sender, EventArgs e)
        {
          
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            openFileDialog.Title = "Відкрити дані з текстового файлу";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                crimeRecords.Clear();

                using (StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length >= 11)
                        {
                            CrimeRecord record = new CrimeRecord
                            {
                                FirstName = parts[0],
                                LastName = parts[1],
                                Nickname = parts[2],
                                Height = int.Parse(parts[3]),
                                EyeColor = parts[4],
                                Nationality = parts[5],
                                BirthDate = DateTime.Parse(parts[6]),
                                BirthPlace = parts[7],
                                LastKnownAddress = parts[8],
                                CriminalProfession = parts[9],
                                HairColor = parts[10]
                            };
                            crimeRecords.Add(record);
                        }
                    }
                }
                MessageBox.Show("Записи про злочини завантажено з текстового файлу.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            archive.LoadFromFile("archive.xml");
            MessageBox.Show("Архів завантажено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchCriteria = CreateSearchCriteria();
            var matchingRecords = crimeRecords.Where(record => record.Matches(searchCriteria)).ToList();
            crimeRecordDataGridView.DataSource = new BindingList<CrimeRecord>(matchingRecords);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            crimeRecordDataGridView.DataSource = crimeRecords;
        }

        private CrimeRecord CreateSearchCriteria()
        {
            return new CrimeRecord
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Nickname = nicknameTextBox.Text,
                Height = string.IsNullOrWhiteSpace(heightTextBox.Text) ? (int?)null : int.Parse(heightTextBox.Text),
                EyeColor = eyeColorTextBox.Text,
                Nationality = nationalityTextBox.Text,
                BirthDate = string.IsNullOrWhiteSpace(birthDateTextBox.Text) ? (DateTime?)null : DateTime.Parse(birthDateTextBox.Text),
                BirthPlace = birthPlaceTextBox.Text,
                LastKnownAddress = lastKnownAddressTextBox.Text,
                CriminalProfession = criminalProfessionTextBox.Text,
                HairColor = hairColorComboBox.SelectedItem?.ToString(),
            };
        }

        private void hairColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddDefaultCriminals()
        {
            var criminals = new List<CrimeRecord>
            {
                new CrimeRecord {
                    FirstName = "Джон",
                    LastName = "Доу",
                    Nickname = "Тінь",
                    Height = 180,
                    EyeColor = "Карі",
                    Nationality = "Американець",
                    BirthDate = new DateTime(1985, 7, 15),
                    BirthPlace = "Нью-Йорк, США"
                },
                new CrimeRecord {
                    FirstName = "Джейн",
                    LastName = "Сміт",
                    Nickname = "Лисиця",
                    Height = 165,
                    EyeColor = "Зелені",
                    Nationality = "Британка",
                    BirthDate = new DateTime(1990, 4, 22),
                    BirthPlace = "Лондон, Велика Британія",
                    LastKnownAddress = "456 Таємна вулиця, Лондон",
                    CriminalProfession = "Міжнародний шпигун",
                    HairColor = "Блондинка"
                },
                new CrimeRecord {
                    FirstName = "Карлос",
                    LastName = "Рамірес",
                    Nickname = "Кобра",
                    Height = 175,
                    EyeColor = "Карі",
                    Nationality = "Іспанець",
                    BirthDate = new DateTime(1988, 7, 29),
                    BirthPlace = "Барселона, Іспанія",
                    LastKnownAddress = "Пасео-де-Грасія, 34, Барселона",
                    CriminalProfession = "Контрабандист наркотиків",
                    HairColor = "Чорне"
},

            };

            foreach (var criminal in criminals)
            {
                crimeRecords.Add(criminal);
            }
        }
    }
}
