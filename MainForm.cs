using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaOOP
{
    public partial class MainForm : Form
    {
        private List<CrimeRecord> crimeRecords;
        private CrimeRecordArchive archive; public MainForm()
        {
            InitializeComponent();
            crimeRecords = new List<CrimeRecord>();
            archive = new CrimeRecordArchive();
            AddDefaultCriminals();
            UpdateCrimeRecordListBox(crimeRecords);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            deleteButton.Click += deleteButton_Click;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (crimeRecordListBox.SelectedIndex != -1)
            {
                var selectedRecord = crimeRecords[crimeRecordListBox.SelectedIndex];
                crimeRecords.Remove(selectedRecord);
                UpdateCrimeRecordListBox(crimeRecords);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть запис про злочинця для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    Height = 165,
    EyeColor = "Зелені",
    Nationality = "Британець",
    BirthDate = new DateTime(1990, 4, 22),
    BirthPlace = "Лондон, Велика Британія",
    LastKnownAddress = "456 Таємна вулиця, Лондон",
    CriminalProfession = "Міжнародний шпигун",
    HairColor = "Блондин"
},

new CrimeRecord {
    FirstName = "Макс",
    LastName = "Джонсон",
    Nickname = "Хакер",
    Height = 175,
    EyeColor = "Блакитні",
    LastKnownAddress = "789 Підземний сховок, Торонто",
    CriminalProfession = "Кіберзлочинець",
    HairColor = "Карий"
},

new CrimeRecord {
    FirstName = "Елена",
    LastName = "Гарсія",
    Nickname = "Чорна Вдова",
    Height = 170,
    EyeColor = "Карі",
    LastKnownAddress = "321 Темний кут, Мадрид",
    CriminalProfession = "Убивця",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Михайло",
    LastName = "Іванов",
    Nationality = "Росіянин",
    BirthDate = new DateTime(1975, 6, 18),
    BirthPlace = "Москва, Росія",
    LastKnownAddress = "567 Кремлівська вулиця, Москва",
    CriminalProfession = "Бос мафії",
    HairColor = "Карий"
},

new CrimeRecord {
    FirstName = "Луна",
    LastName = "Чанг",
    Nickname = "Нічна Тінь",
    Height = 160,
    EyeColor = "Карі",
    Nationality = "Китаянка",
    BirthDate = new DateTime(1995, 2, 28),
    BirthPlace = "Пекін, Китай",
    LastKnownAddress = "876 Тіньова вулиця, Пекін"
},

new CrimeRecord {
    FirstName = "Антоніо",
    LastName = "Морено",
    Nickname = "Ель Діабло",
    Height = 175,
    EyeColor = "Зелені",
    Nationality = "Мексиканець",
    BirthDate = new DateTime(1980, 11, 3),
    BirthPlace = "Мехіко, Мексика",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Софія",
    LastName = "Андерссон",
    Nickname = "Крижана Королева",
    BirthDate = new DateTime(1987, 10, 12),
    BirthPlace = "Стокгольм, Швеція",
    LastKnownAddress = "543 Замерзле озеро, Стокгольм",
    CriminalProfession = "Крадійка мистецтва",
    HairColor = "Блондинка"
},

new CrimeRecord {
    Nickname = "Привид",
    Height = 180,
    EyeColor = "Карі",
    Nationality = "Єгиптянин",
    BirthDate = new DateTime(1982, 4, 30),
    BirthPlace = "Каїр, Єгипет",
    LastKnownAddress = "654 Примарна вулиця, Каїр",
    CriminalProfession = "Контрабандист",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Марія",
    LastName = "Сантос",
    Nickname = "Вовчиця",
    Height = 163,
    EyeColor = "Карі",
    Nationality = "Бразилійка",
    BirthDate = new DateTime(1993, 8, 25),
    CriminalProfession = "Викрадачка",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Олексій",
    LastName = "Петров",
    Nickname = "М'ясник",
    BirthDate = new DateTime(1970, 5, 14),
    BirthPlace = "Санкт-Петербург, Росія",
    LastKnownAddress = "876 Кривавий провулок, Санкт-Петербург",
    CriminalProfession = "Серійний убивця",
    HairColor = "Сивий"
},

new CrimeRecord {
    FirstName = "Хлоя",
    LastName = "Леклерк",
    Nickname = "Мадемуазель Веном",
    Height = 165,
    EyeColor = "Зелені",
    BirthPlace = "Париж, Франція",
    LastKnownAddress = "567 Отруйна вулиця, Париж",
    CriminalProfession = "Шантажистка",
    HairColor = "Карий"
},

new CrimeRecord {
    FirstName = "ххх",
    LastName = "ххх",
    Nickname = "Ель Гато",
    Height = 175,
    EyeColor = "Карі",
    Nationality = "Іспанець",
    BirthDate = new DateTime(1984, 3, 19),
    BirthPlace = "Барселона, Іспанія",
    LastKnownAddress = "ххх",
    CriminalProfession = "Грабіжник",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Анастасія",
    LastName = "Іванова",
    Nickname = "Скарлет",
    Height = 170,
    BirthDate = new DateTime(1986, 9, 28),
    BirthPlace = "Москва, Росія",
    LastKnownAddress = "321 Бульвар Кривавий, Москва",
    CriminalProfession = "Чорна вдова",
    HairColor = "Рудий"
},

new CrimeRecord {
    FirstName = "Джек",
    LastName = "Мерфі",
    Nickname = "Спектр",
    Height = 185,
    EyeColor = "Блакитні",
    Nationality = "Ірландець",
    BirthDate = new DateTime(1978, 12, 3),
    BirthPlace = "Дублін, Ірландія",
    LastKnownAddress = "654 Будинок з привидами, Дублін"
},

new CrimeRecord {
    FirstName = "Аіко",
    LastName = "Танака",
    Nickname = "Оні",
    Nationality = "Японка",
    BirthDate = new DateTime(1992, 2, 14),
    BirthPlace = "Токіо, Японія",
    LastKnownAddress = "789 Вулиця Демонів, Токіо",
    CriminalProfession = "Якудза"
},

new CrimeRecord {
    FirstName = "Віктор",
    LastName = "Іл'їн",
    Nickname = "Ведмідь",
    Height = 190,
    EyeColor = "Карі",
    Nationality = "Росіянин",
    LastKnownAddress = "876 Ведмежа берлога, Москва",
    CriminalProfession = "Торговець зброєю",
    HairColor = "Карий"
},

new CrimeRecord {
    FirstName = "Луїс",
    LastName = "Сільва",
    Nickname = "Божевільний",
    Height = 180,
    EyeColor = "ххх",
    Nationality = "ххх",
    BirthDate = new DateTime(1981, 10, 20),
    BirthPlace = "Богота, Колумбія",
    LastKnownAddress = "543 Божевільна вулиця, Богота",
    CriminalProfession = "ххх",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Хана",
    LastName = "Квон",
    Nickname = "Тигрова Лілія",
    Height = 162,
    EyeColor = "Чорні",
    Nationality = "ххх",
    BirthDate = new DateTime(1991, 5, 17),
    BirthPlace = "Сеул, Південна Корея",
    LastKnownAddress = "321 Квіткова вулиця, Сеул",
    CriminalProfession = "ххх",
    HairColor = "Чорний"
},

new CrimeRecord {
    FirstName = "Ігор",
    LastName = "Ніколаєв",
    Nickname = "Звір",
    Height = 195,
    EyeColor = "Сірі",
    Nationality = "Українець",
    BirthDate = new DateTime(1973, 1, 22),
    BirthPlace = "Київ, Україна",
    LastKnownAddress = "ххх",
    CriminalProfession = "ххх",
    HairColor = "Сивий"
}

        };

            foreach (var criminal in criminals)
            {
                crimeRecords.Add(criminal);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
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
                    crimeRecords.Add(crimeRecord);
                    crimeRecordListBox.Items.Add(crimeRecord.GetInfo());
                    ClearInputFields();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат введення. Будь ласка, перевірте введені дані..", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if (crimeRecords.Any())
            {
                foreach (var record in crimeRecords.ToList())
                {
                    archive.AddToArchive(record);
                    crimeRecords.Remove(record);
                    crimeRecordListBox.Items.Remove(record.GetInfo());
                }
                archive.SaveToFile("archive.xml");
            }
            else
            {
                MessageBox.Show("Немає записів про злочини для архівування.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchCriteria = CreateSearchCriteria();
            var matchingRecords = crimeRecords.Where(record => record.Matches(searchCriteria)).ToList();
            UpdateCrimeRecordListBox(matchingRecords);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            UpdateCrimeRecordListBox(crimeRecords);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            archive.LoadFromFile("archive.xml");
            var archivedRecords = archive.GetArchivedRecords();
            crimeRecords.AddRange(archivedRecords);
            UpdateCrimeRecordListBox(crimeRecords);
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            string fileName = "crime_records.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var record in crimeRecords)
                {
                    writer.WriteLine($"First Name: {record.FirstName}");
                    writer.WriteLine($"Last Name: {record.LastName}");
                    writer.WriteLine($"Nickname: {record.Nickname}");
                    writer.WriteLine($"Height: {record.Height}");
                    writer.WriteLine($"Eye color: {record.EyeColor}");
                    writer.WriteLine($"Nationality: {record.Nationality}");
                    writer.WriteLine($"Birth Date: {record.BirthDate.GetValueOrDefault().ToShortDateString()}");
                    writer.WriteLine($"Birth Place: {record.BirthPlace}");
                    writer.WriteLine($"Last Known Address: {record.LastKnownAddress}");
                    writer.WriteLine($"Criminal Profession: {record.CriminalProfession}");
                    writer.WriteLine($"Hair Color: {record.HairColor}");
                    writer.WriteLine(); 
                }
            }
            MessageBox.Show("Записи про злочини збережено у текстовий файл.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadTextButton_Click(object sender, EventArgs e)
        {
            string fileName = "crime_records.txt";
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                var records = new List<CrimeRecord>();
                var currentRecord = new CrimeRecord();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        records.Add(currentRecord);
                        currentRecord = new CrimeRecord();
                    }
                    else
                    {
                        string[] parts = line.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length != 2) continue;
                        string fieldName = parts[0];
                        string fieldValue = parts[1];

                        switch (fieldName)
                        {
                            case "First Name":
                                currentRecord.FirstName = fieldValue;
                                break;
                            case "Last Name":
                                currentRecord.LastName = fieldValue;
                                break;
                            case "Nickname":
                                currentRecord.Nickname = fieldValue;
                                break;
                            case "Height":
                                currentRecord.Height = int.Parse(fieldValue);
                                break;
                            case "Eye Color":
                                currentRecord.EyeColor = fieldValue;
                                break;
                            case "Nationality":
                                currentRecord.Nationality = fieldValue;
                                break;
                            case "Birth Date":
                                currentRecord.BirthDate = DateTime.Parse(fieldValue);
                                break;
                            case "Birth Place":
                                currentRecord.BirthPlace = fieldValue;
                                break;
                            case "Last Known Address":
                                currentRecord.LastKnownAddress = fieldValue;
                                break;
                            case "Criminal Profession":
                                currentRecord.CriminalProfession = fieldValue;
                                break;
                            case "Hair Color":
                                currentRecord.HairColor = fieldValue;
                                break;
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(lines.Last()))
                {
                    records.Add(currentRecord);
                }

                crimeRecords.AddRange(records);
                UpdateCrimeRecordListBox(crimeRecords);

                MessageBox.Show("Записи про злочини завантажено з текстового файлу.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Текстовий файл не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewArchiveButton_Click(object sender, EventArgs e)
        {
            ArchiveForm archiveForm = new ArchiveForm(archive);
            archiveForm.ShowDialog();
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

        private void UpdateCrimeRecordListBox(List<CrimeRecord> records)
        {
            crimeRecordListBox.Items.Clear();
            foreach (var record in records)
            {
                crimeRecordListBox.Items.Add(record.GetInfo());
            }
        }

        private void ClearInputFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            nicknameTextBox.Clear();
            heightTextBox.Clear();
            eyeColorTextBox.Clear();
            nationalityTextBox.Clear();
            birthDateTextBox.Clear();
            birthPlaceTextBox.Clear();
            lastKnownAddressTextBox.Clear();
            criminalProfessionTextBox.Clear();
            hairColorComboBox.SelectedIndex = -1;
        }

        private void hairColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crimeRecordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}






