namespace Working_with_threads
{
    partial class Form2
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
            lblPrc = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // lblPrc
            // 
            lblPrc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrc.Location = new Point(239, 21);
            lblPrc.Name = "lblPrc";
            lblPrc.Size = new Size(100, 23);
            lblPrc.TabIndex = 1;
            lblPrc.Text = "0";
            lblPrc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 60);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(559, 41);
            progressBar.Step = 1;
            progressBar.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 120);
            Controls.Add(progressBar);
            Controls.Add(lblPrc);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrc;
        private ProgressBar progressBar;
    }
}