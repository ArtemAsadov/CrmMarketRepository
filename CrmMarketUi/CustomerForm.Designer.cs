
namespace CrmMarketUi
{
    partial class CustomerForm
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
            this.FieldName = new System.Windows.Forms.TextBox();
            this.LableName = new System.Windows.Forms.Label();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FieldName
            // 
            this.FieldName.Location = new System.Drawing.Point(107, 12);
            this.FieldName.Name = "FieldName";
            this.FieldName.Size = new System.Drawing.Size(165, 20);
            this.FieldName.TabIndex = 0;
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Location = new System.Drawing.Point(12, 15);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(72, 13);
            this.LableName.TabIndex = 1;
            this.LableName.Text = "Введите имя";
            // 
            // Button_Ok
            // 
            this.Button_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Ok.Location = new System.Drawing.Point(197, 226);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Button_Ok.TabIndex = 2;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.LableName);
            this.Controls.Add(this.FieldName);
            this.Name = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldName;
        private System.Windows.Forms.Label LableName;
        private System.Windows.Forms.Button Button_Ok;
    }
}