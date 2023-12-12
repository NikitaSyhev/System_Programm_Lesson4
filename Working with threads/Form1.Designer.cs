namespace Working_with_threads
{
    partial class Form1
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
            button1 = new Button();
            btnStop = new Button();
            clbThread = new CheckedListBox();
            btnResume = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(208, 32);
            button1.Name = "button1";
            button1.Size = new Size(166, 36);
            button1.TabIndex = 0;
            button1.Text = "Create Thread";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(208, 107);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(166, 38);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop Thread";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // clbThread
            // 
            clbThread.CheckOnClick = true;
            clbThread.FormattingEnabled = true;
            clbThread.Location = new Point(506, 32);
            clbThread.Name = "clbThread";
            clbThread.Size = new Size(175, 346);
            clbThread.TabIndex = 2;
            // 
            // btnResume
            // 
            btnResume.Location = new Point(208, 192);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(166, 38);
            btnResume.TabIndex = 3;
            btnResume.Text = "Resume Thread";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 486);
            Controls.Add(btnResume);
            Controls.Add(clbThread);
            Controls.Add(btnStop);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnStop;
        private CheckedListBox clbThread;
        private Button btnResume;
    }
}