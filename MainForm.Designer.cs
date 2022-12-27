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
            this.SuspendLayout();
            // 
            // buttonSpendingTracker
            // 
            this.buttonSpendingTracker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSpendingTracker.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSpendingTracker.Depth = 0;
            this.buttonSpendingTracker.HighEmphasis = true;
            this.buttonSpendingTracker.Icon = null;
            this.buttonSpendingTracker.Location = new System.Drawing.Point(134, 219);
            this.buttonSpendingTracker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSpendingTracker.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSpendingTracker.Name = "buttonSpendingTracker";
            this.buttonSpendingTracker.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSpendingTracker.Size = new System.Drawing.Size(161, 36);
            this.buttonSpendingTracker.TabIndex = 0;
            this.buttonSpendingTracker.Text = "Spending Tracker";
            this.buttonSpendingTracker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSpendingTracker.UseAccentColor = false;
            this.buttonSpendingTracker.UseVisualStyleBackColor = true;
            this.buttonSpendingTracker.Click += new System.EventHandler(this.buttonSpendingTracker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 596);
            this.Controls.Add(this.buttonSpendingTracker);
            this.Name = "MainForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonSpendingTracker;
    }
}