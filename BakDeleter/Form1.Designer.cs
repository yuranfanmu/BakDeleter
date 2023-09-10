
namespace BakDeleter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBaks = new System.Windows.Forms.ListBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnDeleteBak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBaks
            // 
            this.lbBaks.AllowDrop = true;
            this.lbBaks.FormattingEnabled = true;
            this.lbBaks.HorizontalScrollbar = true;
            this.lbBaks.ItemHeight = 16;
            this.lbBaks.Location = new System.Drawing.Point(12, 12);
            this.lbBaks.Name = "lbBaks";
            this.lbBaks.Size = new System.Drawing.Size(1361, 420);
            this.lbBaks.TabIndex = 0;
            this.lbBaks.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbBaks_DragDrop);
            this.lbBaks.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbBaks_DragEnter);
            this.lbBaks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbBaks_KeyDown);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 435);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(0, 17);
            this.lblFolder.TabIndex = 1;
            // 
            // btnDeleteBak
            // 
            this.btnDeleteBak.Location = new System.Drawing.Point(12, 455);
            this.btnDeleteBak.Name = "btnDeleteBak";
            this.btnDeleteBak.Size = new System.Drawing.Size(1361, 48);
            this.btnDeleteBak.TabIndex = 2;
            this.btnDeleteBak.Text = "Удалить bak-файлы";
            this.btnDeleteBak.UseVisualStyleBackColor = true;
            this.btnDeleteBak.Click += new System.EventHandler(this.btnDeleteBak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 515);
            this.Controls.Add(this.btnDeleteBak);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lbBaks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BakDeleter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBaks;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnDeleteBak;
    }
}

