namespace Programm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataPanel = new Panel();
            MainButton = new Button();
            MatrixSize = new TextBox();
            MatrixManual = new Label();
            ShowPanel = new Panel();
            DataTextBox = new TextBox();
            DataPanel.SuspendLayout();
            ShowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DataPanel
            // 
            DataPanel.BackColor = SystemColors.ControlLight;
            DataPanel.Controls.Add(MainButton);
            DataPanel.Controls.Add(MatrixSize);
            DataPanel.Controls.Add(MatrixManual);
            DataPanel.Dock = DockStyle.Top;
            DataPanel.Location = new Point(0, 0);
            DataPanel.Name = "DataPanel";
            DataPanel.Size = new Size(1208, 209);
            DataPanel.TabIndex = 0;
            // 
            // MainButton
            // 
            MainButton.Location = new Point(916, 86);
            MainButton.Name = "MainButton";
            MainButton.Size = new Size(112, 34);
            MainButton.TabIndex = 2;
            MainButton.Text = "Go";
            MainButton.UseVisualStyleBackColor = true;
            MainButton.Click += MainButton_Click;
            // 
            // MatrixSize
            // 
            MatrixSize.Location = new Point(231, 89);
            MatrixSize.Name = "MatrixSize";
            MatrixSize.Size = new Size(95, 31);
            MatrixSize.TabIndex = 1;
            MatrixSize.TextChanged += textBox1_TextChanged;
            // 
            // MatrixManual
            // 
            MatrixManual.AutoSize = true;
            MatrixManual.Location = new Point(180, 30);
            MatrixManual.Name = "MatrixManual";
            MatrixManual.Size = new Size(189, 25);
            MatrixManual.TabIndex = 0;
            MatrixManual.Text = "Enter matrix size (NxN)";
            MatrixManual.Click += label1_Click;
            // 
            // ShowPanel
            // 
            ShowPanel.BackColor = SystemColors.ActiveBorder;
            ShowPanel.Controls.Add(DataTextBox);
            ShowPanel.Dock = DockStyle.Fill;
            ShowPanel.Location = new Point(0, 209);
            ShowPanel.Name = "ShowPanel";
            ShowPanel.Size = new Size(1208, 988);
            ShowPanel.TabIndex = 1;
            // 
            // DataTextBox
            // 
            DataTextBox.Dock = DockStyle.Fill;
            DataTextBox.Location = new Point(0, 0);
            DataTextBox.Multiline = true;
            DataTextBox.Name = "DataTextBox";
            DataTextBox.Size = new Size(1208, 988);
            DataTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 1197);
            Controls.Add(ShowPanel);
            Controls.Add(DataPanel);
            Name = "MainForm";
            Text = "Task1";
            Load += Form1_Load;
            DataPanel.ResumeLayout(false);
            DataPanel.PerformLayout();
            ShowPanel.ResumeLayout(false);
            ShowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DataPanel;
        private Button MainButton;
        private TextBox MatrixSize;
        private Label MatrixManual;
        private Panel ShowPanel;
        private TextBox DataTextBox;
    }
}