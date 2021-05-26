
namespace G_ignore_Generator
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitleA = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.chkListItems = new System.Windows.Forms.CheckedListBox();
            this.browseFiles = new System.Windows.Forms.WebBrowser();
            this.btnPathSelect = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleA
            // 
            this.lblTitleA.AutoSize = true;
            this.lblTitleA.Location = new System.Drawing.Point(96, 90);
            this.lblTitleA.Name = "lblTitleA";
            this.lblTitleA.Size = new System.Drawing.Size(193, 20);
            this.lblTitleA.TabIndex = 1;
            this.lblTitleA.Text = "Select Your Repository Path!";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(13, 113);
            this.txtPath.MaxLength = 1000;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(334, 27);
            this.txtPath.TabIndex = 2;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipMenu.SetToolTip(this.txtPath, "Double Click: Open Path Dialog\r\nYou can Paste your Path*");
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            this.txtPath.DoubleClick += new System.EventHandler(this.txtPath_DoubleClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(266, 307);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 43);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(297, 1);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(86, 34);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(130, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(124, 85);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // tipMenu
            // 
            this.tipMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.tipMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            // 
            // chkListItems
            // 
            this.chkListItems.Enabled = false;
            this.chkListItems.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkListItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.chkListItems.FormattingEnabled = true;
            this.chkListItems.Location = new System.Drawing.Point(12, 143);
            this.chkListItems.Name = "chkListItems";
            this.chkListItems.Size = new System.Drawing.Size(360, 158);
            this.chkListItems.TabIndex = 7;
            this.tipMenu.SetToolTip(this.chkListItems, "Double Click: Open Path Dialog");
            this.chkListItems.DoubleClick += new System.EventHandler(this.chkListItems_DoubleClick);
            this.chkListItems.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chkListItems_PreviewKeyDown);
            // 
            // browseFiles
            // 
            this.browseFiles.Location = new System.Drawing.Point(301, 56);
            this.browseFiles.MinimumSize = new System.Drawing.Size(20, 20);
            this.browseFiles.Name = "browseFiles";
            this.browseFiles.Size = new System.Drawing.Size(58, 51);
            this.browseFiles.TabIndex = 8;
            this.tipMenu.SetToolTip(this.browseFiles, "Double Click: Open Path Dialog");
            this.browseFiles.Url = new System.Uri("", System.UriKind.Relative);
            this.browseFiles.Visible = false;
            this.browseFiles.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.browseFiles_PreviewKeyDown);
            // 
            // btnPathSelect
            // 
            this.btnPathSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathSelect.Location = new System.Drawing.Point(12, 306);
            this.btnPathSelect.Name = "btnPathSelect";
            this.btnPathSelect.Size = new System.Drawing.Size(106, 43);
            this.btnPathSelect.TabIndex = 9;
            this.btnPathSelect.Text = "Select Path";
            this.btnPathSelect.UseVisualStyleBackColor = true;
            this.btnPathSelect.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInfo.Location = new System.Drawing.Point(350, 110);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnPathSelect);
            this.Controls.Add(this.browseFiles);
            this.Controls.Add(this.chkListItems);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblTitleA);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-ignore Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleA;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip tipMenu;
        private System.Windows.Forms.CheckedListBox chkListItems;
        private System.Windows.Forms.WebBrowser browseFiles;
        private System.Windows.Forms.Button btnPathSelect;
        private System.Windows.Forms.Button btnInfo;
    }
}

