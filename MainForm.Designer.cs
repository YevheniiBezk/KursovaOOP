namespace KursovaOOP
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadTextButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveTextButton = new System.Windows.Forms.Button();
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
            this.crimeRecordListBox = new System.Windows.Forms.ListBox();
            this.hairColorComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.viewArchiveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadTextButton
            // 
            this.loadTextButton.Location = new System.Drawing.Point(539, 366);
            this.loadTextButton.Name = "loadTextButton";
            this.loadTextButton.Size = new System.Drawing.Size(111, 37);
            this.loadTextButton.TabIndex = 0;
            this.loadTextButton.Text = "Завантажити";
            this.loadTextButton.UseVisualStyleBackColor = true;
            this.loadTextButton.Click += new System.EventHandler(this.loadTextButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 367);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Додати запис";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1035, 367);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 36);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveTextButton
            // 
            this.saveTextButton.Location = new System.Drawing.Point(428, 366);
            this.saveTextButton.Name = "saveTextButton";
            this.saveTextButton.Size = new System.Drawing.Size(105, 37);
            this.saveTextButton.TabIndex = 11;
            this.saveTextButton.Text = "Зберегти";
            this.saveTextButton.UseVisualStyleBackColor = true;
            this.saveTextButton.Click += new System.EventHandler(this.saveTextButton_Click);
            // 
            // hairColorLabel
            // 
            this.hairColorLabel.AutoSize = true;
            this.hairColorLabel.Location = new System.Drawing.Point(28, 320);
            this.hairColorLabel.Name = "hairColorLabel";
            this.hairColorLabel.Size = new System.Drawing.Size(79, 13);
            this.hairColorLabel.TabIndex = 46;
            this.hairColorLabel.Text = "Колір волосся";
            // 
            // criminalProfessionLabel
            // 
            this.criminalProfessionLabel.AutoSize = true;
            this.criminalProfessionLabel.Location = new System.Drawing.Point(28, 295);
            this.criminalProfessionLabel.Name = "criminalProfessionLabel";
            this.criminalProfessionLabel.Size = new System.Drawing.Size(121, 13);
            this.criminalProfessionLabel.TabIndex = 45;
            this.criminalProfessionLabel.Text = "Кримінальна професія";
            // 
            // lastKnownAddressLabel
            // 
            this.lastKnownAddressLabel.AutoSize = true;
            this.lastKnownAddressLabel.Location = new System.Drawing.Point(28, 269);
            this.lastKnownAddressLabel.Name = "lastKnownAddressLabel";
            this.lastKnownAddressLabel.Size = new System.Drawing.Size(126, 13);
            this.lastKnownAddressLabel.TabIndex = 44;
            this.lastKnownAddressLabel.Text = "Остання відома адреса";
            // 
            // birthPlaceLabel
            // 
            this.birthPlaceLabel.AutoSize = true;
            this.birthPlaceLabel.Location = new System.Drawing.Point(28, 239);
            this.birthPlaceLabel.Name = "birthPlaceLabel";
            this.birthPlaceLabel.Size = new System.Drawing.Size(101, 13);
            this.birthPlaceLabel.TabIndex = 43;
            this.birthPlaceLabel.Text = "Місце народження";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(28, 217);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(98, 13);
            this.birthDateLabel.TabIndex = 42;
            this.birthDateLabel.Text = "Дата народження";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(28, 191);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(84, 13);
            this.nationalityLabel.TabIndex = 41;
            this.nationalityLabel.Text = "Національність";
            // 
            // eyeColorLabel
            // 
            this.eyeColorLabel.AutoSize = true;
            this.eyeColorLabel.Location = new System.Drawing.Point(28, 165);
            this.eyeColorLabel.Name = "eyeColorLabel";
            this.eyeColorLabel.Size = new System.Drawing.Size(60, 13);
            this.eyeColorLabel.TabIndex = 40;
            this.eyeColorLabel.Text = "Колір очей";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(28, 139);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(33, 13);
            this.heightLabel.TabIndex = 39;
            this.heightLabel.Text = "Зріст";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(28, 113);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(61, 13);
            this.nicknameLabel.TabIndex = 38;
            this.nicknameLabel.Text = "Псевдонім";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(28, 87);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 37;
            this.lastNameLabel.Text = "Прізвище";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 61);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(26, 13);
            this.firstNameLabel.TabIndex = 29;
            this.firstNameLabel.Text = "Ім\'я";
            // 
            // criminalProfessionTextBox
            // 
            this.criminalProfessionTextBox.Location = new System.Drawing.Point(158, 288);
            this.criminalProfessionTextBox.Name = "criminalProfessionTextBox";
            this.criminalProfessionTextBox.Size = new System.Drawing.Size(228, 20);
            this.criminalProfessionTextBox.TabIndex = 34;
            // 
            // lastKnownAddressTextBox
            // 
            this.lastKnownAddressTextBox.Location = new System.Drawing.Point(158, 262);
            this.lastKnownAddressTextBox.Name = "lastKnownAddressTextBox";
            this.lastKnownAddressTextBox.Size = new System.Drawing.Size(228, 20);
            this.lastKnownAddressTextBox.TabIndex = 33;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.firstNameTextBox.TabIndex = 32;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 80);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.lastNameTextBox.TabIndex = 31;
            // 
            // birthPlaceTextBox
            // 
            this.birthPlaceTextBox.Location = new System.Drawing.Point(158, 236);
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            this.birthPlaceTextBox.Size = new System.Drawing.Size(228, 20);
            this.birthPlaceTextBox.TabIndex = 30;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(158, 210);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(228, 20);
            this.birthDateTextBox.TabIndex = 28;
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.Location = new System.Drawing.Point(158, 184);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(228, 20);
            this.nationalityTextBox.TabIndex = 27;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(158, 106);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(228, 20);
            this.nicknameTextBox.TabIndex = 26;
            // 
            // eyeColorTextBox
            // 
            this.eyeColorTextBox.Location = new System.Drawing.Point(158, 158);
            this.eyeColorTextBox.Name = "eyeColorTextBox";
            this.eyeColorTextBox.Size = new System.Drawing.Size(228, 20);
            this.eyeColorTextBox.TabIndex = 25;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(158, 132);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(228, 20);
            this.heightTextBox.TabIndex = 24;
            // 
            // crimeRecordListBox
            // 
            this.crimeRecordListBox.FormattingEnabled = true;
            this.crimeRecordListBox.Location = new System.Drawing.Point(422, 57);
            this.crimeRecordListBox.Name = "crimeRecordListBox";
            this.crimeRecordListBox.Size = new System.Drawing.Size(924, 303);
            this.crimeRecordListBox.TabIndex = 48;
            this.crimeRecordListBox.SelectedIndexChanged += new System.EventHandler(this.crimeRecordListBox_SelectedIndexChanged);
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
            this.hairColorComboBox.TabIndex = 49;
            this.hairColorComboBox.SelectedIndexChanged += new System.EventHandler(this.hairColorComboBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(155, 367);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(142, 36);
            this.searchButton.TabIndex = 50;
            this.searchButton.Text = "Пошук";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(303, 367);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 36);
            this.cancelButton.TabIndex = 51;
            this.cancelButton.Text = "Відміна";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(656, 366);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(142, 37);
            this.archiveButton.TabIndex = 52;
            this.archiveButton.Text = "Архів";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // viewArchiveButton
            // 
            this.viewArchiveButton.Location = new System.Drawing.Point(804, 367);
            this.viewArchiveButton.Name = "viewArchiveButton";
            this.viewArchiveButton.Size = new System.Drawing.Size(106, 36);
            this.viewArchiveButton.TabIndex = 53;
            this.viewArchiveButton.Text = "Перегляд Архіву";
            this.viewArchiveButton.UseVisualStyleBackColor = true;
            this.viewArchiveButton.Click += new System.EventHandler(this.viewArchiveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(916, 366);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(113, 37);
            this.loadButton.TabIndex = 54;
            this.loadButton.Text = "Завантаження Архіву";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 485);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.viewArchiveButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.hairColorComboBox);
            this.Controls.Add(this.crimeRecordListBox);
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
            this.Controls.Add(this.saveTextButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.loadTextButton);
            this.Name = "MainForm";
            this.Text = "Форма Записів Інтерполу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadTextButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveTextButton;
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
        private System.Windows.Forms.ListBox crimeRecordListBox;
        private System.Windows.Forms.ComboBox hairColorComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button viewArchiveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

