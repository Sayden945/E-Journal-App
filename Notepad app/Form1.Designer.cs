namespace Notepad_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.jTitle = new System.Windows.Forms.Label();
            this.entryText = new System.Windows.Forms.TextBox();
            this.dirList = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 786);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 72);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // jTitle
            // 
            this.jTitle.AutoSize = true;
            this.jTitle.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTitle.Location = new System.Drawing.Point(177, 61);
            this.jTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jTitle.Name = "jTitle";
            this.jTitle.Size = new System.Drawing.Size(576, 65);
            this.jTitle.TabIndex = 1;
            this.jTitle.Text = "Journal System";
            this.jTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // entryText
            // 
            this.entryText.Location = new System.Drawing.Point(188, 200);
            this.entryText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entryText.Multiline = true;
            this.entryText.Name = "entryText";
            this.entryText.Size = new System.Drawing.Size(764, 460);
            this.entryText.TabIndex = 2;
            this.entryText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dirList
            // 
            this.dirList.FormattingEnabled = true;
            this.dirList.Location = new System.Drawing.Point(1112, 82);
            this.dirList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dirList.Name = "dirList";
            this.dirList.Size = new System.Drawing.Size(526, 784);
            this.dirList.TabIndex = 3;
            this.dirList.SelectedIndexChanged += new System.EventHandler(this.dirList_SelectedIndexChanged);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(748, 786);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(204, 72);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(470, 786);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(204, 72);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 940);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.dirList);
            this.Controls.Add(this.entryText);
            this.Controls.Add(this.jTitle);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1470, 1011);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label jTitle;
        private System.Windows.Forms.TextBox entryText;
        private System.Windows.Forms.ListBox dirList;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button delBtn;
    }
}

