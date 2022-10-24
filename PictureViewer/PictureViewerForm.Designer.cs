namespace PictureViewer
{
    partial class PictureViewerForm
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
            this.fullTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.thePictureBox = new System.Windows.Forms.PictureBox();
            this.streacCheckBox = new System.Windows.Forms.CheckBox();
            this.bottunsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.showAPictureButton = new System.Windows.Forms.Button();
            this.clearAPictureButton = new System.Windows.Forms.Button();
            this.setTheBackgroudColorButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.theOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.theColorDialog = new System.Windows.Forms.ColorDialog();
            this.fullTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thePictureBox)).BeginInit();
            this.bottunsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullTableLayoutPanel
            // 
            this.fullTableLayoutPanel.ColumnCount = 2;
            this.fullTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.fullTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.375F));
            this.fullTableLayoutPanel.Controls.Add(this.thePictureBox, 0, 0);
            this.fullTableLayoutPanel.Controls.Add(this.streacCheckBox, 0, 1);
            this.fullTableLayoutPanel.Controls.Add(this.bottunsTableLayoutPanel, 1, 1);
            this.fullTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.fullTableLayoutPanel.Name = "fullTableLayoutPanel";
            this.fullTableLayoutPanel.RowCount = 2;
            this.fullTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.fullTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.fullTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.fullTableLayoutPanel.TabIndex = 0;
            // 
            // thePictureBox
            // 
            this.thePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullTableLayoutPanel.SetColumnSpan(this.thePictureBox, 2);
            this.thePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thePictureBox.Location = new System.Drawing.Point(3, 3);
            this.thePictureBox.Name = "thePictureBox";
            this.thePictureBox.Size = new System.Drawing.Size(794, 394);
            this.thePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.thePictureBox.TabIndex = 0;
            this.thePictureBox.TabStop = false;
            // 
            // streacCheckBox
            // 
            this.streacCheckBox.AutoSize = true;
            this.streacCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streacCheckBox.Location = new System.Drawing.Point(3, 403);
            this.streacCheckBox.Name = "streacCheckBox";
            this.streacCheckBox.Size = new System.Drawing.Size(119, 44);
            this.streacCheckBox.TabIndex = 1;
            this.streacCheckBox.Text = "Streach";
            this.streacCheckBox.UseVisualStyleBackColor = true;
            this.streacCheckBox.CheckedChanged += new System.EventHandler(this.streacCheckBox_CheckedChanged);
            // 
            // bottunsTableLayoutPanel
            // 
            this.bottunsTableLayoutPanel.ColumnCount = 4;
            this.bottunsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottunsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottunsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottunsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bottunsTableLayoutPanel.Controls.Add(this.showAPictureButton, 0, 0);
            this.bottunsTableLayoutPanel.Controls.Add(this.clearAPictureButton, 1, 0);
            this.bottunsTableLayoutPanel.Controls.Add(this.setTheBackgroudColorButton, 2, 0);
            this.bottunsTableLayoutPanel.Controls.Add(this.closeButton, 3, 0);
            this.bottunsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottunsTableLayoutPanel.Location = new System.Drawing.Point(128, 403);
            this.bottunsTableLayoutPanel.Name = "bottunsTableLayoutPanel";
            this.bottunsTableLayoutPanel.RowCount = 1;
            this.bottunsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottunsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.bottunsTableLayoutPanel.Size = new System.Drawing.Size(669, 44);
            this.bottunsTableLayoutPanel.TabIndex = 2;
            // 
            // showAPictureButton
            // 
            this.showAPictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAPictureButton.Location = new System.Drawing.Point(3, 3);
            this.showAPictureButton.Name = "showAPictureButton";
            this.showAPictureButton.Size = new System.Drawing.Size(161, 38);
            this.showAPictureButton.TabIndex = 0;
            this.showAPictureButton.Text = "Show a picture";
            this.showAPictureButton.UseVisualStyleBackColor = true;
            this.showAPictureButton.Click += new System.EventHandler(this.showAPictureButton_Click);
            // 
            // clearAPictureButton
            // 
            this.clearAPictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearAPictureButton.Location = new System.Drawing.Point(170, 3);
            this.clearAPictureButton.Name = "clearAPictureButton";
            this.clearAPictureButton.Size = new System.Drawing.Size(161, 38);
            this.clearAPictureButton.TabIndex = 1;
            this.clearAPictureButton.Text = "Clear a picture";
            this.clearAPictureButton.UseVisualStyleBackColor = true;
            this.clearAPictureButton.Click += new System.EventHandler(this.clearAPictureButton_Click);
            // 
            // setTheBackgroudColorButton
            // 
            this.setTheBackgroudColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setTheBackgroudColorButton.Location = new System.Drawing.Point(337, 3);
            this.setTheBackgroudColorButton.Name = "setTheBackgroudColorButton";
            this.setTheBackgroudColorButton.Size = new System.Drawing.Size(161, 38);
            this.setTheBackgroudColorButton.TabIndex = 2;
            this.setTheBackgroudColorButton.Text = "Set the background Color";
            this.setTheBackgroudColorButton.UseVisualStyleBackColor = true;
            this.setTheBackgroudColorButton.Click += new System.EventHandler(this.setTheBackgroudColorButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Location = new System.Drawing.Point(504, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(162, 38);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // theOpenFileDialog
            // 
            this.theOpenFileDialog.FileName = "openFileDialog1";
            this.theOpenFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.theOpenFileDialog.Title = "Select a picture file";
            // 
            // PictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fullTableLayoutPanel);
            this.Name = "PictureViewerForm";
            this.Text = "Picture Viewer";
            this.fullTableLayoutPanel.ResumeLayout(false);
            this.fullTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thePictureBox)).EndInit();
            this.bottunsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fullTableLayoutPanel;
        private System.Windows.Forms.PictureBox thePictureBox;
        private System.Windows.Forms.CheckBox streacCheckBox;
        private System.Windows.Forms.TableLayoutPanel bottunsTableLayoutPanel;
        private System.Windows.Forms.Button showAPictureButton;
        private System.Windows.Forms.Button clearAPictureButton;
        private System.Windows.Forms.Button setTheBackgroudColorButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog theOpenFileDialog;
        private System.Windows.Forms.ColorDialog theColorDialog;
    }
}

