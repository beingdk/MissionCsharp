namespace SqlConnection
{
	partial class DashboardDemo
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
			this.getPeopleListbox = new System.Windows.Forms.ListBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameInsLabel = new System.Windows.Forms.Label();
			this.firstNameInsTextBox = new System.Windows.Forms.TextBox();
			this.lastNameInsLabel = new System.Windows.Forms.Label();
			this.lastNameInsTextBox = new System.Windows.Forms.TextBox();
			this.emailAddressInsLabel = new System.Windows.Forms.Label();
			this.emailAddressInsTextBox = new System.Windows.Forms.TextBox();
			this.mobileInsLabel = new System.Windows.Forms.Label();
			this.mobileInsTextBox = new System.Windows.Forms.TextBox();
			this.insertButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// getPeopleListbox
			// 
			this.getPeopleListbox.FormattingEnabled = true;
			this.getPeopleListbox.Location = new System.Drawing.Point(30, 122);
			this.getPeopleListbox.Name = "getPeopleListbox";
			this.getPeopleListbox.Size = new System.Drawing.Size(468, 316);
			this.getPeopleListbox.TabIndex = 0;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(132, 48);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(207, 20);
			this.lastNameTextBox.TabIndex = 1;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(132, 84);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(131, 32);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lastNameLabel.Location = new System.Drawing.Point(44, 48);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
			this.lastNameLabel.TabIndex = 3;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameInsLabel
			// 
			this.firstNameInsLabel.AutoSize = true;
			this.firstNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.firstNameInsLabel.Location = new System.Drawing.Point(504, 162);
			this.firstNameInsLabel.Name = "firstNameInsLabel";
			this.firstNameInsLabel.Size = new System.Drawing.Size(76, 17);
			this.firstNameInsLabel.TabIndex = 5;
			this.firstNameInsLabel.Text = "First Name";
			// 
			// firstNameInsTextBox
			// 
			this.firstNameInsTextBox.Location = new System.Drawing.Point(618, 159);
			this.firstNameInsTextBox.Name = "firstNameInsTextBox";
			this.firstNameInsTextBox.Size = new System.Drawing.Size(170, 20);
			this.firstNameInsTextBox.TabIndex = 4;
			// 
			// lastNameInsLabel
			// 
			this.lastNameInsLabel.AutoSize = true;
			this.lastNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lastNameInsLabel.Location = new System.Drawing.Point(504, 200);
			this.lastNameInsLabel.Name = "lastNameInsLabel";
			this.lastNameInsLabel.Size = new System.Drawing.Size(76, 17);
			this.lastNameInsLabel.TabIndex = 7;
			this.lastNameInsLabel.Text = "Last Name";
			// 
			// lastNameInsTextBox
			// 
			this.lastNameInsTextBox.Location = new System.Drawing.Point(618, 197);
			this.lastNameInsTextBox.Name = "lastNameInsTextBox";
			this.lastNameInsTextBox.Size = new System.Drawing.Size(170, 20);
			this.lastNameInsTextBox.TabIndex = 6;
			// 
			// emailAddressInsLabel
			// 
			this.emailAddressInsLabel.AutoSize = true;
			this.emailAddressInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.emailAddressInsLabel.Location = new System.Drawing.Point(504, 238);
			this.emailAddressInsLabel.Name = "emailAddressInsLabel";
			this.emailAddressInsLabel.Size = new System.Drawing.Size(98, 17);
			this.emailAddressInsLabel.TabIndex = 9;
			this.emailAddressInsLabel.Text = "Email Address";
			// 
			// emailAddressInsTextBox
			// 
			this.emailAddressInsTextBox.Location = new System.Drawing.Point(618, 235);
			this.emailAddressInsTextBox.Name = "emailAddressInsTextBox";
			this.emailAddressInsTextBox.Size = new System.Drawing.Size(170, 20);
			this.emailAddressInsTextBox.TabIndex = 8;
			// 
			// mobileInsLabel
			// 
			this.mobileInsLabel.AutoSize = true;
			this.mobileInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.mobileInsLabel.Location = new System.Drawing.Point(504, 273);
			this.mobileInsLabel.Name = "mobileInsLabel";
			this.mobileInsLabel.Size = new System.Drawing.Size(49, 17);
			this.mobileInsLabel.TabIndex = 11;
			this.mobileInsLabel.Text = "Mobile";
			// 
			// mobileInsTextBox
			// 
			this.mobileInsTextBox.Location = new System.Drawing.Point(618, 270);
			this.mobileInsTextBox.Name = "mobileInsTextBox";
			this.mobileInsTextBox.Size = new System.Drawing.Size(170, 20);
			this.mobileInsTextBox.TabIndex = 10;
			// 
			// insertButton
			// 
			this.insertButton.Location = new System.Drawing.Point(547, 317);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(131, 32);
			this.insertButton.TabIndex = 12;
			this.insertButton.Text = "Insert";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
			// 
			// DashboardDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.insertButton);
			this.Controls.Add(this.mobileInsLabel);
			this.Controls.Add(this.mobileInsTextBox);
			this.Controls.Add(this.emailAddressInsLabel);
			this.Controls.Add(this.emailAddressInsTextBox);
			this.Controls.Add(this.lastNameInsLabel);
			this.Controls.Add(this.lastNameInsTextBox);
			this.Controls.Add(this.firstNameInsLabel);
			this.Controls.Add(this.firstNameInsTextBox);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.getPeopleListbox);
			this.Name = "DashboardDemo";
			this.Text = "DashboardDemo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox getPeopleListbox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label firstNameInsLabel;
		private System.Windows.Forms.TextBox firstNameInsTextBox;
		private System.Windows.Forms.Label lastNameInsLabel;
		private System.Windows.Forms.TextBox lastNameInsTextBox;
		private System.Windows.Forms.Label emailAddressInsLabel;
		private System.Windows.Forms.TextBox emailAddressInsTextBox;
		private System.Windows.Forms.Label mobileInsLabel;
		private System.Windows.Forms.TextBox mobileInsTextBox;
		private System.Windows.Forms.Button insertButton;
	}
}

