namespace KursovaOOP
{
    partial class AddRecordForm
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
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

        #region Код, створений конструктором форм Windows

        /// <summary>
        /// Необхідний метод для підтримки конструктора — не змінюйте
        /// вміст цього методу за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.hairColorComboBox = new System.Windows.Forms.ComboBox();
            this.hairColorLabel = new System.Windows.Forms.Label();
            this.criminalProfessionLabel = new System.Windows.Forms.Label();
            this.lastKnownAddressLabel = new System.Windows.Forms.Label();
            this.birthPlaceLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.eyeColorLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.criminalProfessionTextBox = new System.Windows.Forms.TextBox();
            this.lastKnownAddressTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.eyeColorTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hairColorComboBox
            // 
            this.hairColorComboBox.FormattingEnabled = true;
            this.hairColorComboBox.Items.AddRange(new object[] {
            "Чорний",
            "Карий",
            "Блондин",
            "Рудий",
            "Сивий"});
            this.hairColorComboBox.Location = new System.Drawing.Point(158, 320);
            this.hairColorComboBox.Name = "hairColorComboBox";
            this.hairColorComboBox.Size = new System.Drawing.Size(228, 21);
            this.hairColorComboBox.TabIndex = 72;
            this.hairColorComboBox.SelectedIndexChanged += new System.EventHandler(this.hairColorComboBox_SelectedIndexChanged);
            // 
            // hairColorLabel
            // 
            this.hairColorLabel.AutoSize = true;
            this.hairColorLabel.Location = new System.Drawing.Point(28, 320);
            this.hairColorLabel.Name = "hairColorLabel";
            this.hairColorLabel.Size = new System.Drawing.Size(79, 13);
            this.hairColorLabel.TabIndex = 71;
            this.hairColorLabel.Text = "Колір волосся";
            // 
            // criminalProfessionLabel
            // 
            this.criminalProfessionLabel.AutoSize = true;
            this.criminalProfessionLabel.Location = new System.Drawing.Point(28, 295);
            this.criminalProfessionLabel.Name = "criminalProfessionLabel";
            this.criminalProfessionLabel.Size = new System.Drawing.Size(121, 13);
            this.criminalProfessionLabel.TabIndex = 70;
            this.criminalProfessionLabel.Text = "Кримінальна професія";
            // 
            // lastKnownAddressLabel
            // 
            this.lastKnownAddressLabel.AutoSize = true;
            this.lastKnownAddressLabel.Location = new System.Drawing.Point(28, 269);
            this.lastKnownAddressLabel.Name = "lastKnownAddressLabel";
            this.lastKnownAddressLabel.Size = new System.Drawing.Size(126, 13);
            this.lastKnownAddressLabel.TabIndex = 69;
            this.lastKnownAddressLabel.Text = "Остання відома адреса";
            // 
            // birthPlaceLabel
            // 
            this.birthPlaceLabel.AutoSize = true;
            this.birthPlaceLabel.Location = new System.Drawing.Point(28, 239);
            this.birthPlaceLabel.Name = "birthPlaceLabel";
            this.birthPlaceLabel.Size = new System.Drawing.Size(101, 13);
            this.birthPlaceLabel.TabIndex = 68;
            this.birthPlaceLabel.Text = "Місце народження";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(28, 217);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(98, 13);
            this.birthDateLabel.TabIndex = 67;
            this.birthDateLabel.Text = "Дата народження";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(28, 191);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(84, 13);
            this.nationalityLabel.TabIndex = 66;
            this.nationalityLabel.Text = "Національність";
            // 
            // eyeColorLabel
            // 
            this.eyeColorLabel.AutoSize = true;
            this.eyeColorLabel.Location = new System.Drawing.Point(28, 165);
            this.eyeColorLabel.Name = "eyeColorLabel";
            this.eyeColorLabel.Size = new System.Drawing.Size(60, 13);
            this.eyeColorLabel.TabIndex = 65;
            this.eyeColorLabel.Text = "Колір очей";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(28, 139);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(33, 13);
            this.heightLabel.TabIndex = 64;
            this.heightLabel.Text = "Зріст";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(28, 113);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(61, 13);
            this.nicknameLabel.TabIndex = 63;
            this.nicknameLabel.Text = "Псевдонім";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(28, 87);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 62;
            this.lastNameLabel.Text = "Прізвище";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 61);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(26, 13);
            this.firstNameLabel.TabIndex = 61;
            this.firstNameLabel.Text = "Ім'я";
            // 
            // criminalProfessionTextBox
            // 
            this.criminalProfessionTextBox.Location = new System.Drawing.Point(158, 288);
            this.criminalProfessionTextBox.Name = "criminalProfessionTextBox";
            this.criminalProfessionTextBox.Size = new System.Drawing.Size(228, 20);
            this.criminalProfessionTextBox.TabIndex = 60;
            // 
            // lastKnownAddressTextBox
            // 
            this.lastKnownAddressTextBox.Location = new System.Drawing.Point(158, 262);
            this.lastKnownAddressTextBox.Name = "lastKnownAddressTextBox";
            this.lastKnownAddressTextBox.Size = new System.Drawing.Size(228, 20);
            this.lastKnownAddressTextBox.TabIndex = 59;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.firstNameTextBox.TabIndex = 58;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 80);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.lastNameTextBox.TabIndex = 57;
            // 
            // birthPlaceTextBox
            // 
            this.birthPlaceTextBox.Location = new System.Drawing.Point(158, 236);
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            this.birthPlaceTextBox.Size = new System.Drawing.Size(228, 20);
            this.birthPlaceTextBox.TabIndex = 56;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(158, 210);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(228, 20);
            this.birthDateTextBox.TabIndex = 55;
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.Location = new System.Drawing.Point(158, 184);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(228, 20);
            this.nationalityTextBox.TabIndex = 54;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(158, 106);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(228, 20);
            this.nicknameTextBox.TabIndex = 53;
            // 
            // eyeColorTextBox
            // 
            this.eyeColorTextBox.Location = new System.Drawing.Point(158, 158);
            this.eyeColorTextBox.Name = "eyeColorTextBox";
            this.eyeColorTextBox.Size = new System.Drawing.Size(228, 20);
            this.eyeColorTextBox.TabIndex = 52;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(158, 132);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(228, 20);
            this.heightTextBox.TabIndex = 51;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(158, 367);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(123, 36);
            this.addRecordButton.TabIndex = 73;
            this.addRecordButton.Text = "Додати запис";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(287, 367);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 36);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.Text = "Відміна";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddRecordForm
            // 
            this.ClientSize = new System.Drawing.Size(418, 421);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.hairColorComboBox);
            this.Controls.Add(this.hairColorLabel);
            this.Controls.Add(this.criminalProfessionLabel);
            this.Controls.Add(this.lastKnownAddressLabel);
            this.Controls.Add(this.birthPlaceLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.nationalityLabel);
            this.Controls.Add(this.eyeColorLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.criminalProfessionTextBox);
            this.Controls.Add(this.lastKnownAddressTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.birthPlaceTextBox);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.nationalityTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.eyeColorTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Name = "AddRecordForm";
            this.Text = "Додати новий запис";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hairColorComboBox;
        private System.Windows.Forms.Label hairColorLabel;
        private System.Windows.Forms.Label criminalProfessionLabel;
        private System.Windows.Forms.Label lastKnownAddressLabel;
        private System.Windows.Forms.Label birthPlaceLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.Label eyeColorLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox criminalProfessionTextBox;
        private System.Windows.Forms.TextBox lastKnownAddressTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox nationalityTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox eyeColorTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
