using System;
using System.Windows.Forms;

namespace KursovaOOP
{
    public partial class AddRecordForm : Form
    {
        public CrimeRecord NewCrimeRecord { get; private set; }

        public AddRecordForm()
        {
            InitializeComponent();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                var crimeRecord = new CrimeRecord
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    HairColor = hairColorComboBox.SelectedItem?.ToString(),
                    Nickname = nicknameTextBox.Text,
                    Height = int.Parse(heightTextBox.Text),
                    EyeColor = eyeColorTextBox.Text,
                    Nationality = nationalityTextBox.Text,
                    BirthDate = DateTime.Parse(birthDateTextBox.Text),
                    BirthPlace = birthPlaceTextBox.Text,
                    LastKnownAddress = lastKnownAddressTextBox.Text,
                    CriminalProfession = criminalProfessionTextBox.Text
                };

                if (ValidateCrimeRecord(crimeRecord))
                {
                    NewCrimeRecord = crimeRecord;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат введення. Будь ласка, перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCrimeRecord(CrimeRecord crimeRecord)
        {
            if (string.IsNullOrWhiteSpace(crimeRecord.FirstName) ||
                string.IsNullOrWhiteSpace(crimeRecord.LastName) ||
                string.IsNullOrWhiteSpace(crimeRecord.Nickname) ||
                string.IsNullOrWhiteSpace(crimeRecord.EyeColor) ||
                string.IsNullOrWhiteSpace(crimeRecord.Nationality) ||
                string.IsNullOrWhiteSpace(crimeRecord.BirthPlace) ||
                string.IsNullOrWhiteSpace(crimeRecord.LastKnownAddress) ||
                string.IsNullOrWhiteSpace(crimeRecord.CriminalProfession) ||
                crimeRecord.Height <= 0 ||
                crimeRecord.BirthDate == null)
            {
                MessageBox.Show("Надайте всю необхідну інформацію.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void hairColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
