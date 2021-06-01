
namespace WindowsFormsApp5
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DataLabel = new System.Windows.Forms.Label();
            this.StateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StateConnectionLabel = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VIDTextBox = new System.Windows.Forms.TextBox();
            this.VIDEnterTextBox = new System.Windows.Forms.TextBox();
            this.PIDTextBox = new System.Windows.Forms.TextBox();
            this.PIDEnterTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.StateTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainTableLayoutPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(482, 653);
            this.MainPanel.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.DataLabel, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.StateTableLayoutPanel, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.LogButton, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.CloseButton, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.OpenButton, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 6;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(482, 653);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.White;
            this.DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLabel.Location = new System.Drawing.Point(3, 453);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(476, 200);
            this.DataLabel.TabIndex = 0;
            // 
            // StateTableLayoutPanel
            // 
            this.StateTableLayoutPanel.ColumnCount = 2;
            this.StateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StateTableLayoutPanel.Controls.Add(this.StatusLabel, 0, 0);
            this.StateTableLayoutPanel.Controls.Add(this.StateConnectionLabel, 1, 0);
            this.StateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTableLayoutPanel.Location = new System.Drawing.Point(3, 359);
            this.StateTableLayoutPanel.Name = "StateTableLayoutPanel";
            this.StateTableLayoutPanel.RowCount = 1;
            this.StateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StateTableLayoutPanel.Size = new System.Drawing.Size(476, 91);
            this.StateTableLayoutPanel.TabIndex = 1;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(3, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(232, 91);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Состояние подключения: ";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StateConnectionLabel
            // 
            this.StateConnectionLabel.AutoSize = true;
            this.StateConnectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StateConnectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateConnectionLabel.Location = new System.Drawing.Point(241, 0);
            this.StateConnectionLabel.Name = "StateConnectionLabel";
            this.StateConnectionLabel.Size = new System.Drawing.Size(232, 91);
            this.StateConnectionLabel.TabIndex = 1;
            this.StateConnectionLabel.Text = "отключено";
            this.StateConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButton.Location = new System.Drawing.Point(3, 262);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(476, 91);
            this.LogButton.TabIndex = 2;
            this.LogButton.Text = "Открыть журнал";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(3, 165);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(476, 91);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Отключиться";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenButton.Location = new System.Drawing.Point(3, 68);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(476, 91);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Подключиться";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.VIDTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VIDEnterTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PIDTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PIDEnterTextBox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 59);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // VIDTextBox
            // 
            this.VIDTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VIDTextBox.Location = new System.Drawing.Point(3, 3);
            this.VIDTextBox.Multiline = true;
            this.VIDTextBox.Name = "VIDTextBox";
            this.VIDTextBox.ReadOnly = true;
            this.VIDTextBox.Size = new System.Drawing.Size(113, 53);
            this.VIDTextBox.TabIndex = 0;
            this.VIDTextBox.Text = "VID:";
            // 
            // VIDEnterTextBox
            // 
            this.VIDEnterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VIDEnterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VIDEnterTextBox.Location = new System.Drawing.Point(122, 3);
            this.VIDEnterTextBox.MaxLength = 4;
            this.VIDEnterTextBox.Multiline = true;
            this.VIDEnterTextBox.Name = "VIDEnterTextBox";
            this.VIDEnterTextBox.Size = new System.Drawing.Size(113, 53);
            this.VIDEnterTextBox.TabIndex = 1;
            this.VIDEnterTextBox.Text = "2803";
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PIDTextBox.Location = new System.Drawing.Point(241, 3);
            this.PIDTextBox.Multiline = true;
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.ReadOnly = true;
            this.PIDTextBox.Size = new System.Drawing.Size(113, 53);
            this.PIDTextBox.TabIndex = 2;
            this.PIDTextBox.Text = "PID:";
            // 
            // PIDEnterTextBox
            // 
            this.PIDEnterTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIDEnterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PIDEnterTextBox.Location = new System.Drawing.Point(360, 3);
            this.PIDEnterTextBox.MaxLength = 4;
            this.PIDEnterTextBox.Multiline = true;
            this.PIDEnterTextBox.Name = "PIDEnterTextBox";
            this.PIDEnterTextBox.Size = new System.Drawing.Size(113, 53);
            this.PIDEnterTextBox.TabIndex = 3;
            this.PIDEnterTextBox.Text = "0013";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "Form1";
            this.Text = "CP2110";
            this.MainPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            this.StateTableLayoutPanel.ResumeLayout(false);
            this.StateTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.TableLayoutPanel StateTableLayoutPanel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StateConnectionLabel;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox VIDTextBox;
        private System.Windows.Forms.TextBox VIDEnterTextBox;
        private System.Windows.Forms.TextBox PIDTextBox;
        private System.Windows.Forms.TextBox PIDEnterTextBox;
    }
}

