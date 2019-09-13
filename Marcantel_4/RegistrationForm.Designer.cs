namespace Marcantel_4
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.filmPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.currentDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registrantInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.priceForEachClassLabel = new System.Windows.Forms.Label();
            this.selectedClassesLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.availableClassesListBox = new System.Windows.Forms.ListBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.emailReceiptCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).BeginInit();
            this.registrantInfoGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmPictureBox
            // 
            this.filmPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("filmPictureBox.Image")));
            this.filmPictureBox.Location = new System.Drawing.Point(12, 27);
            this.filmPictureBox.Name = "filmPictureBox";
            this.filmPictureBox.Size = new System.Drawing.Size(273, 114);
            this.filmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filmPictureBox.TabIndex = 0;
            this.filmPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(327, 64);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(194, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Hopkins Film School";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Date:";
            // 
            // enterDateMaskedTextBox
            // 
            this.enterDateMaskedTextBox.Location = new System.Drawing.Point(75, 147);
            this.enterDateMaskedTextBox.Mask = "00/00/0000";
            this.enterDateMaskedTextBox.Name = "enterDateMaskedTextBox";
            this.enterDateMaskedTextBox.Size = new System.Drawing.Size(64, 20);
            this.enterDateMaskedTextBox.TabIndex = 3;
            this.enterDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // currentDateMaskedTextBox
            // 
            this.currentDateMaskedTextBox.Location = new System.Drawing.Point(221, 147);
            this.currentDateMaskedTextBox.Mask = "00/00/0000";
            this.currentDateMaskedTextBox.Name = "currentDateMaskedTextBox";
            this.currentDateMaskedTextBox.Size = new System.Drawing.Size(64, 20);
            this.currentDateMaskedTextBox.TabIndex = 5;
            this.currentDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // registrantInfoGroupBox
            // 
            this.registrantInfoGroupBox.Controls.Add(this.statusLabel);
            this.registrantInfoGroupBox.Controls.Add(this.statusComboBox);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.emailTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.registrantInfoGroupBox.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.emailLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInfoGroupBox.Location = new System.Drawing.Point(12, 173);
            this.registrantInfoGroupBox.Name = "registrantInfoGroupBox";
            this.registrantInfoGroupBox.Size = new System.Drawing.Size(544, 100);
            this.registrantInfoGroupBox.TabIndex = 0;
            this.registrantInfoGroupBox.TabStop = false;
            this.registrantInfoGroupBox.Text = "Registrant Information";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(186, 56);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status: ";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(235, 53);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(95, 21);
            this.statusComboBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(77, 27);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(85, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(235, 27);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(85, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(377, 30);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(104, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(6, 56);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 6;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(77, 53);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(64, 20);
            this.dateOfBirthMaskedTextBox.TabIndex = 7;
            this.dateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(333, 30);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email: ";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(168, 30);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalPriceLabel);
            this.groupBox2.Controls.Add(this.priceForEachClassLabel);
            this.groupBox2.Controls.Add(this.selectedClassesLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.selectedLabel);
            this.groupBox2.Controls.Add(this.availableClassesListBox);
            this.groupBox2.Controls.Add(this.classLabel);
            this.groupBox2.Controls.Add(this.animationRadioButton);
            this.groupBox2.Controls.Add(this.liveActionRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registration Information";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(483, 69);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(36, 15);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "$0.00";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // priceForEachClassLabel
            // 
            this.priceForEachClassLabel.AutoSize = true;
            this.priceForEachClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceForEachClassLabel.Location = new System.Drawing.Point(483, 45);
            this.priceForEachClassLabel.Name = "priceForEachClassLabel";
            this.priceForEachClassLabel.Size = new System.Drawing.Size(36, 15);
            this.priceForEachClassLabel.TabIndex = 7;
            this.priceForEachClassLabel.Text = "$0.00";
            this.priceForEachClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectedClassesLabel
            // 
            this.selectedClassesLabel.AutoSize = true;
            this.selectedClassesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedClassesLabel.Location = new System.Drawing.Point(483, 21);
            this.selectedClassesLabel.Name = "selectedClassesLabel";
            this.selectedClassesLabel.Size = new System.Drawing.Size(15, 15);
            this.selectedClassesLabel.TabIndex = 5;
            this.selectedClassesLabel.Text = "0";
            this.selectedClassesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Total Price: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Price for each class:";
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(386, 21);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(91, 13);
            this.selectedLabel.TabIndex = 4;
            this.selectedLabel.Text = "Selected Classes:";
            // 
            // availableClassesListBox
            // 
            this.availableClassesListBox.FormattingEnabled = true;
            this.availableClassesListBox.Location = new System.Drawing.Point(235, 19);
            this.availableClassesListBox.Name = "availableClassesListBox";
            this.availableClassesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.availableClassesListBox.Size = new System.Drawing.Size(120, 95);
            this.availableClassesListBox.Sorted = true;
            this.availableClassesListBox.TabIndex = 3;
            this.toolTip.SetToolTip(this.availableClassesListBox, "A maximum of four classes should be picked. If you pick more than four then an er" +
        "ror would appear.");
            this.availableClassesListBox.SelectedIndexChanged += new System.EventHandler(this.availableClassesListBox_SelectedIndexChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(14, 21);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class:";
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(139, 19);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(71, 17);
            this.animationRadioButton.TabIndex = 2;
            this.animationRadioButton.TabStop = true;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(55, 19);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(78, 17);
            this.liveActionRadioButton.TabIndex = 1;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(67, 418);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 2;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.cashRadioButton_CheckedChanged);
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(151, 418);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(56, 17);
            this.checkRadioButton.TabIndex = 3;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailReceiptCheckBox
            // 
            this.emailReceiptCheckBox.AutoSize = true;
            this.emailReceiptCheckBox.Location = new System.Drawing.Point(67, 441);
            this.emailReceiptCheckBox.Name = "emailReceiptCheckBox";
            this.emailReceiptCheckBox.Size = new System.Drawing.Size(146, 17);
            this.emailReceiptCheckBox.TabIndex = 4;
            this.emailReceiptCheckBox.Text = "Email Receipt Requested";
            this.emailReceiptCheckBox.UseVisualStyleBackColor = true;
            this.emailReceiptCheckBox.CheckedChanged += new System.EventHandler(this.emailReceiptCheckBox_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(572, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "When ran displays a summary box of registration information and writes registrati" +
    "on summary information to the RegistrationData.Txt file.\r\n \r\n";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.ToolTipText = "Clears all enter data or changes and turns it to it\'s original state.";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Exits out of the program. ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.ToolTipText = "Opens a seperate window. ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "Learn more about this form. ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 483);
            this.Controls.Add(this.emailReceiptCheckBox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.registrantInfoGroupBox);
            this.Controls.Add(this.currentDateMaskedTextBox);
            this.Controls.Add(this.enterDateMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.filmPictureBox);
            this.Controls.Add(this.menuStrip);
            this.Name = "RegistrationForm";
            this.Text = "Hopkins Film School";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmPictureBox)).EndInit();
            this.registrantInfoGroupBox.ResumeLayout(false);
            this.registrantInfoGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filmPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox enterDateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox currentDateMaskedTextBox;
        private System.Windows.Forms.GroupBox registrantInfoGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ListBox availableClassesListBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label priceForEachClassLabel;
        private System.Windows.Forms.Label selectedClassesLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.CheckBox emailReceiptCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

