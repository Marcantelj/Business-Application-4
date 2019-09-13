// Programmer: Jonathan Marcantel
// Project: Assignment 4
// Due Date: 11/21/2018
// Description: Individual Assignment #4

using System;
using System.IO;
using System.Windows.Forms;

namespace Marcantel_4
{
    public partial class RegistrationForm : Form
    {
        // Constent Class Varibles they won't change. 
        private const decimal LIVE_ACTION = 79.99m;
        private const decimal ANIMATION = 99.95m;

        // Changing Class Varibles they could change. 
        private string payment;
        private string classes;
        private int countClasses;
        private decimal totalPrice;
        private string emailReceipt; 

        // Form for this program. 
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // When Code runs this event automatically runs. 
        private void Form1_Load(object sender, EventArgs e)
        {
            currentDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy"); // Enters current date into the Masked Text Box.

            // Enters Data into the Combo Box "" is the data entered. 
            statusComboBox.DataSource = new[]
            {
                "Actor",
                "Producer",
                "Director",
                "Animator",
                "Cinematographer",
                "Drama Teacher",
                "Light Technician",
                "Sound Technician"
            };
            statusComboBox.Text = ""; // sets the combo box status to show blank. 
            liveActionRadioButton.Checked = true; // Checks the live action radio button.
            cashRadioButton.Checked = true;   // Checks cash button. 
            UpdateTotals(); // UpdatesTotals when Form loads. 
        }

        // Should Take Text out of txt file  and put it in the avalibleClassesListBox and resets all items in the box before filling the boxes. 
        private void PopulateBoxes()
        {
            // try to run code to input data from files into list box. 
            try
            {
                // Should Take Text out of txt file for animation and put it in the avalibleClassesListBox. 
                if (liveActionRadioButton.Checked)
                {
                    // Should Take Text out of txt file for live action and put it in the avalibleClassesListBox. 
                    availableClassesListBox.Items.Clear(); // CLears all contents in the files

                    StreamReader inputFile;

                    inputFile = File.OpenText("Live Action.txt"); // Files that data is being taken from.
                    while (!inputFile.EndOfStream)
                    {
                        availableClassesListBox.Items.Add(inputFile.ReadLine()); //Reads and adds lines to list box.
                    }

                    // Closes File
                    inputFile.Close();
                }

                if (animationRadioButton.Checked)
                {
                    availableClassesListBox.Items.Clear(); // Clears all contents in the file

                    // Should Take Text out of txt file for animation and put it in the avalibleClassesListBox. 
                    StreamReader inputFile;

                    inputFile = File.OpenText("Animation.txt");// Files that data is being taken from. 

                    while (!inputFile.EndOfStream)
                    {
                        availableClassesListBox.Items.Add(inputFile.ReadLine()); //Reads and adds lines to list box.
                    }

                    // Closes File
                    inputFile.Close();

                }
            }
            // Catches if error is made and displays message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        // Updates all data and sets data to the correct int or strings. 
        private void UpdateTotals()
        {
            int counter = 0;
            countClasses = availableClassesListBox.SelectedItems.Count; //count classes is = to the amount of selected items that are in the list box. 
            selectedClassesLabel.Text = countClasses.ToString(); // sets classes to countClasses variable. 
            classes = ""; // clears classes string.
            if (liveActionRadioButton.Checked)
            {
                totalPrice = countClasses * LIVE_ACTION; // totalPrice = number of counted classes * ANIMATION.
                priceForEachClassLabel.Text = LIVE_ACTION.ToString("C"); // Converting Animation to string and setting it to price for each class. 
                totalPriceLabel.Text = totalPrice.ToString("C"); // Converting totalPrice to string and setting it to price for each class.
            }
            if (animationRadioButton.Checked)
            {
                totalPrice = countClasses * ANIMATION; // totalPrice = number of counted classes * ANIMATION. 
                priceForEachClassLabel.Text = ANIMATION.ToString("C"); // Converting Animation to string and setting it to price for each class. 
                totalPriceLabel.Text = totalPrice.ToString("C"); // Converting totalPrice to string and setting it to totalPrice.
            }

            // Counts classes and displayss message the will then  = classes.
            for (counter = 0; counter < availableClassesListBox.Items.Count; counter++)
            {
                if (availableClassesListBox.GetSelected(counter))
                {
                    classes += " " + availableClassesListBox.Items[counter] + "\n";
                }

            }
        }

        // Writes in the RegistrationData.Txt and fill out all files like the save message box. 
        private void writeFile()
        {
            // try's to run code to write data into file from form.
            try
            {
                StreamWriter outputFile; // Stream writing the outputFile 
                outputFile = File.AppendText("RegistrationData.Txt"); // File that it is being written in.
                 
                // Block of data that is entered in File. 
                outputFile.WriteLine("Registration Summary"); 
                outputFile.WriteLine("Registrant Date: " + enterDateMaskedTextBox.Text + "\n");
                outputFile.WriteLine("Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n");
                outputFile.WriteLine("Email: " + emailTextBox.Text + "\n");
                outputFile.WriteLine("Date of Birth: " + dateOfBirthMaskedTextBox.Text + "\n");
                outputFile.WriteLine("Status: " + statusComboBox.Text + "\n");
                outputFile.WriteLine("Classes Selected: " + "\n" + classes);
                outputFile.WriteLine("Number of Classes: " + selectedClassesLabel.Text + "\n");
                outputFile.WriteLine("Price Per Class: " + priceForEachClassLabel.Text + "\n");
                outputFile.WriteLine("Total Registration Price: " + totalPriceLabel.Text + "\n");
                outputFile.WriteLine("Payment type: " + payment + "\n");
                outputFile.WriteLine("Email Request Receipt: " + emailReceipt);
                outputFile.WriteLine(); 

                outputFile.Close(); // Closes the writing process. 
            }
            // Catches if error is made and displays message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        // UpdatesTotals and populatesBoxes for when liveaction radio button is event is activated. 
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateBoxes();
            UpdateTotals();
        }

        // UpdatesTotals and populatesBoxes for when animation radio button event is activated. 
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateBoxes();
            UpdateTotals();
        }

        // UpdatesTotals for when totalPriceLabel is changed and event activated. 
        private void totalPriceLabel_Click(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Displays exit message and closes form.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays exit message and closes program when yes is selected.
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Closes program.
            if (selection == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        // Resets all data and selection made in the form.
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Method that clears all data and selections are resets them. 
        private void ResetForm()
        {
            enterDateMaskedTextBox.Text="";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dateOfBirthMaskedTextBox.Text ="";
            statusComboBox.Text = "";
            liveActionRadioButton.Checked = true;
            emailReceiptCheckBox.Checked = false;
            availableClassesListBox.ClearSelected(); 
            selectedClassesLabel.Text = "0";
            priceForEachClassLabel.Text = "$0.00";
            totalPriceLabel.Text = "$0.00";
            cashRadioButton.Checked = true;
            emailTextBox.Focus(); 
            UpdateTotals();
        }

        // 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays error if none of these fields are not entered correctly if all are then it moves to else. 
            if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailTextBox.Text == "" || dateOfBirthMaskedTextBox.Text == "" ||  countClasses == 0 || countClasses > 5)

            {
                MessageBox.Show("Customer must fill out First Name, Last Name, Email, Date of Birth, or Number of Classes can not be 0 or greater than 4. Once these are filled out the save will run"
                    , "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Displays message with all data and fields entered. 
            else
            {
                MessageBox.Show("Registrant Date: " + enterDateMaskedTextBox.Text + "\n" +
                    "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                    "Email: " + emailTextBox.Text + "\n" + 
                    "Date of Birth: " + dateOfBirthMaskedTextBox.Text + "\n" +
                    "Status: " + statusComboBox.Text + "\n" +
                    "Classes Selected: " + "\n" + classes + 
                    "Number of Classes: " + selectedClassesLabel.Text + "\n" + 
                    "Price Per Class: " + priceForEachClassLabel.Text + "\n" +
                    "Total Registration Price: " + totalPriceLabel.Text + "\n" + "Payment type: " + payment + "\n" + 
                    "Email Request Receipt: " + emailReceipt
                    ,"Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    writeFile();
                    ResetForm();
            }
        }

        // cash radio is checked sets payment class to "Cash" if not checked then sets it to "Check".
        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cashRadioButton.Checked)
               {
                payment = "Cash";
               }
            else
               {
                payment = "Check";
               }
        }

        // sets a yes or a no to emailreceipt string then is displayed in save messagebox and writen File. 
        private void emailReceiptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           if (emailReceiptCheckBox.Checked == true)
            {
                emailReceipt = "Yes"; 
            }
           else
            {
                emailReceipt = "No"; 
            }
        }

        // Event links the aboutform menu item to the aboutform's form. 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }

        // Updates all totals for when available class list when the event is activated. 
        private void availableClassesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

    }
}
    

    
