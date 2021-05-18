
namespace ATM
{
    partial class LoginScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxWelcome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(-2, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ATM Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(-15, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(404, 31);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Select a user below, or create a new one.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataUsers
            // 
            this.dataUsers.AllowUserToAddRows = false;
            this.dataUsers.AllowUserToDeleteRows = false;
            this.dataUsers.AllowUserToResizeColumns = false;
            this.dataUsers.AllowUserToResizeRows = false;
            this.dataUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.ColumnHeadersVisible = false;
            this.dataUsers.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataUsers.Location = new System.Drawing.Point(12, 90);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.ReadOnly = true;
            this.dataUsers.RowHeadersVisible = false;
            this.dataUsers.RowHeadersWidth = 55;
            this.dataUsers.RowTemplate.Height = 31;
            this.dataUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUsers.Size = new System.Drawing.Size(376, 106);
            this.dataUsers.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Location = new System.Drawing.Point(127, 202);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(146, 32);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 270);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 21);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(15, 302);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(142, 21);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome Message:";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(76, 267);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(313, 29);
            this.boxName.TabIndex = 7;
            // 
            // boxWelcome
            // 
            this.boxWelcome.Location = new System.Drawing.Point(15, 326);
            this.boxWelcome.Multiline = true;
            this.boxWelcome.Name = "boxWelcome";
            this.boxWelcome.Size = new System.Drawing.Size(285, 75);
            this.boxWelcome.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(15, 237);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(373, 2);
            this.lblLine.TabIndex = 10;
            // 
            // lblEvent
            // 
            this.lblEvent.Location = new System.Drawing.Point(15, 237);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(374, 27);
            this.lblEvent.TabIndex = 11;
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 413);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxWelcome);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataUsers);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxWelcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblEvent;
    }
}