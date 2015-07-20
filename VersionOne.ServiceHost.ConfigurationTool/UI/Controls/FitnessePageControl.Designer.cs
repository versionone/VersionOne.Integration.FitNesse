namespace VersionOne.ServiceHost.ConfigurationTool.UI.Controls {
    partial class FitnessePageControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.numIntervalMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblPollIntervalPrefix = new System.Windows.Forms.Label();
            this.lblPollIntervalSuffix = new System.Windows.Forms.Label();
            this.pscWatchFolder = new VersionOne.ServiceHost.ConfigurationTool.UI.Controls.PathSelectorControl();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDisabled.Location = new System.Drawing.Point(408, 19);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkDisabled.TabIndex = 0;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(147, 115);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(328, 20);
            this.txtFilter.TabIndex = 5;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(16, 118);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(95, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Filter (usually *.xml)";
            // 
            // numIntervalMinutes
            // 
            this.numIntervalMinutes.Location = new System.Drawing.Point(147, 158);
            this.numIntervalMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numIntervalMinutes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numIntervalMinutes.Name = "numIntervalMinutes";
            this.numIntervalMinutes.Size = new System.Drawing.Size(52, 20);
            this.numIntervalMinutes.TabIndex = 7;
            this.numIntervalMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblPollIntervalPrefix
            // 
            this.lblPollIntervalPrefix.AutoSize = true;
            this.lblPollIntervalPrefix.Location = new System.Drawing.Point(17, 160);
            this.lblPollIntervalPrefix.Name = "lblPollIntervalPrefix";
            this.lblPollIntervalPrefix.Size = new System.Drawing.Size(128, 13);
            this.lblPollIntervalPrefix.TabIndex = 6;
            this.lblPollIntervalPrefix.Text = "Poll watch directory every";
            // 
            // lblPollIntervalSuffix
            // 
            this.lblPollIntervalSuffix.AutoSize = true;
            this.lblPollIntervalSuffix.Location = new System.Drawing.Point(212, 160);
            this.lblPollIntervalSuffix.Name = "lblPollIntervalSuffix";
            this.lblPollIntervalSuffix.Size = new System.Drawing.Size(43, 13);
            this.lblPollIntervalSuffix.TabIndex = 8;
            this.lblPollIntervalSuffix.Text = "minutes";
            // 
            // pscWatchFolder
            // 
            this.pscWatchFolder.AllowDrop = true;
            this.pscWatchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pscWatchFolder.DialogType = VersionOne.ServiceHost.ConfigurationTool.UI.Controls.PathSelectorControl.DialogTypes.Folder;
            this.pscWatchFolder.Location = new System.Drawing.Point(20, 49);
            this.pscWatchFolder.Name = "pscWatchFolder";
            this.pscWatchFolder.SelectedPath = "";
            this.pscWatchFolder.Size = new System.Drawing.Size(471, 60);
            this.pscWatchFolder.TabIndex = 9;
            this.pscWatchFolder.TextBoxLeft = 127;
            // 
            // FitnessePageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pscWatchFolder);
            this.Controls.Add(this.lblPollIntervalSuffix);
            this.Controls.Add(this.lblPollIntervalPrefix);
            this.Controls.Add(this.numIntervalMinutes);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.chkDisabled);
            this.Name = "FitnessePageControl";
            this.Size = new System.Drawing.Size(540, 203);
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.NumericUpDown numIntervalMinutes;
        private System.Windows.Forms.Label lblPollIntervalPrefix;
        private System.Windows.Forms.Label lblPollIntervalSuffix;
        private PathSelectorControl pscWatchFolder;
    }
}
