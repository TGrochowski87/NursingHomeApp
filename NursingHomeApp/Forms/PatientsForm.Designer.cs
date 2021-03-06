namespace NursingHomeApp
{
    partial class PatientsForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.InformationsTab = new System.Windows.Forms.TabPage();
            this.textBoxAlergies = new System.Windows.Forms.TextBox();
            this.labelAlergies = new System.Windows.Forms.Label();
            this.labelCaregiver = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxCaregiver = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelPersonId = new System.Windows.Forms.Label();
            this.textBoxPersonId = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFistName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxFilterOptions = new System.Windows.Forms.ComboBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.dataGridViewPatientSchedule = new System.Windows.Forms.DataGridView();
            this.Tabs.SuspendLayout();
            this.InformationsTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.InformationsTab);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1071, 555);
            this.Tabs.TabIndex = 0;
            // 
            // InformationsTab
            // 
            this.InformationsTab.Controls.Add(this.textBoxAlergies);
            this.InformationsTab.Controls.Add(this.labelAlergies);
            this.InformationsTab.Controls.Add(this.labelCaregiver);
            this.InformationsTab.Controls.Add(this.textBoxPhoneNumber);
            this.InformationsTab.Controls.Add(this.labelContactNumber);
            this.InformationsTab.Controls.Add(this.textBoxContactNumber);
            this.InformationsTab.Controls.Add(this.labelPhoneNumber);
            this.InformationsTab.Controls.Add(this.textBoxCaregiver);
            this.InformationsTab.Controls.Add(this.labelAge);
            this.InformationsTab.Controls.Add(this.textBoxAge);
            this.InformationsTab.Controls.Add(this.labelPersonId);
            this.InformationsTab.Controls.Add(this.textBoxPersonId);
            this.InformationsTab.Controls.Add(this.labelLastName);
            this.InformationsTab.Controls.Add(this.textBoxLastName);
            this.InformationsTab.Controls.Add(this.labelFirstName);
            this.InformationsTab.Controls.Add(this.textBoxFistName);
            this.InformationsTab.Location = new System.Drawing.Point(4, 25);
            this.InformationsTab.Margin = new System.Windows.Forms.Padding(4);
            this.InformationsTab.Name = "InformationsTab";
            this.InformationsTab.Padding = new System.Windows.Forms.Padding(4);
            this.InformationsTab.Size = new System.Drawing.Size(1063, 526);
            this.InformationsTab.TabIndex = 0;
            this.InformationsTab.Text = "Informations";
            this.InformationsTab.UseVisualStyleBackColor = true;
            // 
            // textBoxAlergies
            // 
            this.textBoxAlergies.Location = new System.Drawing.Point(285, 242);
            this.textBoxAlergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlergies.Multiline = true;
            this.textBoxAlergies.Name = "textBoxAlergies";
            this.textBoxAlergies.ReadOnly = true;
            this.textBoxAlergies.Size = new System.Drawing.Size(233, 80);
            this.textBoxAlergies.TabIndex = 16;
            // 
            // labelAlergies
            // 
            this.labelAlergies.AutoSize = true;
            this.labelAlergies.Location = new System.Drawing.Point(24, 246);
            this.labelAlergies.Name = "labelAlergies";
            this.labelAlergies.Size = new System.Drawing.Size(63, 17);
            this.labelAlergies.TabIndex = 15;
            this.labelAlergies.Text = "Alergies:";
            // 
            // labelCaregiver
            // 
            this.labelCaregiver.AutoSize = true;
            this.labelCaregiver.Location = new System.Drawing.Point(24, 217);
            this.labelCaregiver.Name = "labelCaregiver";
            this.labelCaregiver.Size = new System.Drawing.Size(73, 17);
            this.labelCaregiver.TabIndex = 13;
            this.labelCaregiver.Text = "Caregiver:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(285, 183);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(233, 22);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Location = new System.Drawing.Point(24, 158);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(114, 17);
            this.labelContactNumber.TabIndex = 11;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(285, 154);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.ReadOnly = true;
            this.textBoxContactNumber.Size = new System.Drawing.Size(233, 22);
            this.textBoxContactNumber.TabIndex = 10;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(24, 187);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.labelPhoneNumber.TabIndex = 9;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxCaregiver
            // 
            this.textBoxCaregiver.Location = new System.Drawing.Point(285, 213);
            this.textBoxCaregiver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCaregiver.Name = "textBoxCaregiver";
            this.textBoxCaregiver.ReadOnly = true;
            this.textBoxCaregiver.Size = new System.Drawing.Size(233, 22);
            this.textBoxCaregiver.TabIndex = 8;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(24, 128);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 17);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(285, 124);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(233, 22);
            this.textBoxAge.TabIndex = 6;
            // 
            // labelPersonId
            // 
            this.labelPersonId.AutoSize = true;
            this.labelPersonId.Location = new System.Drawing.Point(24, 98);
            this.labelPersonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonId.Name = "labelPersonId";
            this.labelPersonId.Size = new System.Drawing.Size(68, 17);
            this.labelPersonId.TabIndex = 5;
            this.labelPersonId.Text = "Person Id";
            // 
            // textBoxPersonId
            // 
            this.textBoxPersonId.Location = new System.Drawing.Point(285, 95);
            this.textBoxPersonId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPersonId.Name = "textBoxPersonId";
            this.textBoxPersonId.ReadOnly = true;
            this.textBoxPersonId.Size = new System.Drawing.Size(233, 22);
            this.textBoxPersonId.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(24, 69);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 17);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(285, 65);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(233, 22);
            this.textBoxLastName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(24, 38);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFistName
            // 
            this.textBoxFistName.Location = new System.Drawing.Point(285, 34);
            this.textBoxFistName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFistName.Name = "textBoxFistName";
            this.textBoxFistName.ReadOnly = true;
            this.textBoxFistName.Size = new System.Drawing.Size(233, 22);
            this.textBoxFistName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonFilter);
            this.tabPage2.Controls.Add(this.comboBoxFilterOptions);
            this.tabPage2.Controls.Add(this.buttonShowAll);
            this.tabPage2.Controls.Add(this.dataGridViewPatientSchedule);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1063, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(911, 483);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(140, 36);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxFilterOptions
            // 
            this.comboBoxFilterOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterOptions.FormattingEnabled = true;
            this.comboBoxFilterOptions.Location = new System.Drawing.Point(700, 486);
            this.comboBoxFilterOptions.Name = "comboBoxFilterOptions";
            this.comboBoxFilterOptions.Size = new System.Drawing.Size(205, 33);
            this.comboBoxFilterOptions.TabIndex = 5;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.Location = new System.Drawing.Point(8, 485);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(140, 36);
            this.buttonShowAll.TabIndex = 4;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // dataGridViewPatientSchedule
            // 
            this.dataGridViewPatientSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientSchedule.Location = new System.Drawing.Point(-5, 0);
            this.dataGridViewPatientSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPatientSchedule.Name = "dataGridViewPatientSchedule";
            this.dataGridViewPatientSchedule.ReadOnly = true;
            this.dataGridViewPatientSchedule.RowHeadersWidth = 51;
            this.dataGridViewPatientSchedule.Size = new System.Drawing.Size(1071, 478);
            this.dataGridViewPatientSchedule.TabIndex = 0;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientsForm";
            this.Text = "Patient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientsForm_FormClosed);
            this.Tabs.ResumeLayout(false);
            this.InformationsTab.ResumeLayout(false);
            this.InformationsTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage InformationsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFistName;
        private System.Windows.Forms.DataGridView dataGridViewPatientSchedule;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCaregiver;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelPersonId;
        private System.Windows.Forms.TextBox textBoxPersonId;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAlergies;
        private System.Windows.Forms.Label labelAlergies;
        private System.Windows.Forms.Label labelCaregiver;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterOptions;
    }
}

