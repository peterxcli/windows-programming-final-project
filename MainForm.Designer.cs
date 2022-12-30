namespace life_assistant
{
    partial class MainForm
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
            this.buttonSpendingTracker = new MaterialSkin.Controls.MaterialButton();
            this.buttonToDoList = new MaterialSkin.Controls.MaterialButton();
            this.textboxUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.buttonRandomLunchHelper = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // buttonSpendingTracker
            // 
            this.buttonSpendingTracker.AutoSize = false;
            this.buttonSpendingTracker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSpendingTracker.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSpendingTracker.Depth = 0;
            this.buttonSpendingTracker.HighEmphasis = true;
            this.buttonSpendingTracker.Icon = null;
            this.buttonSpendingTracker.Location = new System.Drawing.Point(104, 193);
            this.buttonSpendingTracker.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonSpendingTracker.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSpendingTracker.Name = "buttonSpendingTracker";
            this.buttonSpendingTracker.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSpendingTracker.Size = new System.Drawing.Size(171, 49);
            this.buttonSpendingTracker.TabIndex = 0;
            this.buttonSpendingTracker.Text = "Spending Tracker";
            this.buttonSpendingTracker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSpendingTracker.UseAccentColor = false;
            this.buttonSpendingTracker.UseVisualStyleBackColor = true;
            this.buttonSpendingTracker.Click += new System.EventHandler(this.buttonSpendingTracker_Click);
            // 
            // buttonToDoList
            // 
            this.buttonToDoList.AutoSize = false;
            this.buttonToDoList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonToDoList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonToDoList.Depth = 0;
            this.buttonToDoList.HighEmphasis = true;
            this.buttonToDoList.Icon = null;
            this.buttonToDoList.Location = new System.Drawing.Point(104, 274);
            this.buttonToDoList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonToDoList.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonToDoList.Name = "buttonToDoList";
            this.buttonToDoList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonToDoList.Size = new System.Drawing.Size(171, 49);
            this.buttonToDoList.TabIndex = 1;
            this.buttonToDoList.Text = "To do List";
            this.buttonToDoList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonToDoList.UseAccentColor = false;
            this.buttonToDoList.UseVisualStyleBackColor = true;
            this.buttonToDoList.Click += new System.EventHandler(this.buttonToDoList_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.AnimateReadOnly = false;
            this.textboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxUsername.Depth = 0;
            this.textboxUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textboxUsername.Hint = "username";
            this.textboxUsername.LeadingIcon = null;
            this.textboxUsername.Location = new System.Drawing.Point(96, 77);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxUsername.MaxLength = 50;
            this.textboxUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.textboxUsername.Multiline = false;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(179, 50);
            this.textboxUsername.TabIndex = 2;
            this.textboxUsername.Text = "";
            this.textboxUsername.TrailingIcon = null;
            this.textboxUsername.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.Hint = "password";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(395, 77);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(179, 50);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            this.textBoxPassword.Visible = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(104, 354);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(171, 49);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "To do List(MaterialSkin)";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // buttonRandomLunchHelper
            // 
            this.buttonRandomLunchHelper.AutoSize = false;
            this.buttonRandomLunchHelper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRandomLunchHelper.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRandomLunchHelper.Depth = 0;
            this.buttonRandomLunchHelper.HighEmphasis = true;
            this.buttonRandomLunchHelper.Icon = null;
            this.buttonRandomLunchHelper.Location = new System.Drawing.Point(403, 193);
            this.buttonRandomLunchHelper.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonRandomLunchHelper.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRandomLunchHelper.Name = "buttonRandomLunchHelper";
            this.buttonRandomLunchHelper.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRandomLunchHelper.Size = new System.Drawing.Size(171, 49);
            this.buttonRandomLunchHelper.TabIndex = 5;
            this.buttonRandomLunchHelper.Text = "random lunch helper";
            this.buttonRandomLunchHelper.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonRandomLunchHelper.UseAccentColor = false;
            this.buttonRandomLunchHelper.UseVisualStyleBackColor = true;
            this.buttonRandomLunchHelper.Click += new System.EventHandler(this.buttonRandomLunchHelper_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 471);
            this.Controls.Add(this.buttonRandomLunchHelper);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.buttonToDoList);
            this.Controls.Add(this.buttonSpendingTracker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 51, 2, 2);
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonSpendingTracker;
        private MaterialSkin.Controls.MaterialButton buttonToDoList;
        private MaterialSkin.Controls.MaterialTextBox textboxUsername;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton buttonRandomLunchHelper;
    }
}