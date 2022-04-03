
namespace LI1_RegionChanger
{
    partial class LIRChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIRChange));
            this.cdpathButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.Label();
            this.CDLabel = new System.Windows.Forms.Label();
            this.diskPathL = new System.Windows.Forms.Label();
            this.pathsTitle = new System.Windows.Forms.Label();
            this.installPathB = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.desB = new System.Windows.Forms.Label();
            this.savecheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cdpathButton
            // 
            this.cdpathButton.Location = new System.Drawing.Point(93, 211);
            this.cdpathButton.Name = "cdpathButton";
            this.cdpathButton.Size = new System.Drawing.Size(83, 32);
            this.cdpathButton.TabIndex = 0;
            this.cdpathButton.Text = " CD Path";
            this.cdpathButton.UseVisualStyleBackColor = true;
            this.cdpathButton.Click += new System.EventHandler(this.cdpathButton_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(140, 8);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(357, 29);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "LEGO Island Region Changer";
            // 
            // descText
            // 
            this.descText.AutoSize = true;
            this.descText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descText.Location = new System.Drawing.Point(102, 68);
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(436, 36);
            this.descText.TabIndex = 2;
            this.descText.Text = "Basically changes the path that the game reads for data, hopefully\r\nmaking versio" +
    "n management much less painful";
            this.descText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CDLabel
            // 
            this.CDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDLabel.Location = new System.Drawing.Point(204, 211);
            this.CDLabel.Name = "CDLabel";
            this.CDLabel.Size = new System.Drawing.Size(334, 32);
            this.CDLabel.TabIndex = 3;
            this.CDLabel.Text = "nul";
            this.CDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskPathL
            // 
            this.diskPathL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskPathL.Location = new System.Drawing.Point(204, 256);
            this.diskPathL.Name = "diskPathL";
            this.diskPathL.Size = new System.Drawing.Size(334, 32);
            this.diskPathL.TabIndex = 4;
            this.diskPathL.Text = "nul";
            this.diskPathL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathsTitle
            // 
            this.pathsTitle.AutoSize = true;
            this.pathsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathsTitle.Location = new System.Drawing.Point(276, 157);
            this.pathsTitle.Name = "pathsTitle";
            this.pathsTitle.Size = new System.Drawing.Size(78, 29);
            this.pathsTitle.TabIndex = 5;
            this.pathsTitle.Text = "Paths";
            // 
            // installPathB
            // 
            this.installPathB.Location = new System.Drawing.Point(93, 256);
            this.installPathB.Name = "installPathB";
            this.installPathB.Size = new System.Drawing.Size(83, 32);
            this.installPathB.TabIndex = 6;
            this.installPathB.Text = "Install Path";
            this.installPathB.UseVisualStyleBackColor = true;
            this.installPathB.Click += new System.EventHandler(this.installPathB_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(260, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // desB
            // 
            this.desB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desB.Location = new System.Drawing.Point(423, 434);
            this.desB.Name = "desB";
            this.desB.Size = new System.Drawing.Size(197, 36);
            this.desB.TabIndex = 8;
            this.desB.Text = "designed by a literal idiot\r\n(twitter.com/GwladysDev)\r\n";
            this.desB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // savecheck
            // 
            this.savecheck.AutoSize = true;
            this.savecheck.Location = new System.Drawing.Point(287, 297);
            this.savecheck.Name = "savecheck";
            this.savecheck.Size = new System.Drawing.Size(136, 17);
            this.savecheck.TabIndex = 9;
            this.savecheck.Text = "Custom save directory?";
            this.savecheck.UseVisualStyleBackColor = true;
            this.savecheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LIRChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LI1_RegionChanger.Properties.Resources.bgLI;
            this.ClientSize = new System.Drawing.Size(640, 479);
            this.Controls.Add(this.savecheck);
            this.Controls.Add(this.desB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.installPathB);
            this.Controls.Add(this.pathsTitle);
            this.Controls.Add(this.diskPathL);
            this.Controls.Add(this.CDLabel);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.cdpathButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LIRChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEGO Island Region Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cdpathButton;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label descText;
        private System.Windows.Forms.Label CDLabel;
        private System.Windows.Forms.Label diskPathL;
        private System.Windows.Forms.Label pathsTitle;
        private System.Windows.Forms.Button installPathB;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label desB;
        private System.Windows.Forms.CheckBox savecheck;
    }
}

