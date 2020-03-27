namespace AsyncAndAwait
{
    partial class MainForm
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
            this.btnQotdSync = new System.Windows.Forms.Button();
            this.btnQordThread = new System.Windows.Forms.Button();
            this.lbQotd = new System.Windows.Forms.Label();
            this.btnQotdAsyncResult = new System.Windows.Forms.Button();
            this.btnQotdAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQotdSync
            // 
            this.btnQotdSync.Location = new System.Drawing.Point(31, 47);
            this.btnQotdSync.Name = "btnQotdSync";
            this.btnQotdSync.Size = new System.Drawing.Size(134, 58);
            this.btnQotdSync.TabIndex = 0;
            this.btnQotdSync.Text = "Quote of the day sync";
            this.btnQotdSync.UseVisualStyleBackColor = true;
            this.btnQotdSync.Click += new System.EventHandler(this.btnQotdSync_Click);
            // 
            // btnQordThread
            // 
            this.btnQordThread.Location = new System.Drawing.Point(241, 47);
            this.btnQordThread.Name = "btnQordThread";
            this.btnQordThread.Size = new System.Drawing.Size(134, 58);
            this.btnQordThread.TabIndex = 1;
            this.btnQordThread.Text = "Quote of the day Thread";
            this.btnQordThread.UseVisualStyleBackColor = true;
            this.btnQordThread.Click += new System.EventHandler(this.btnQotdThread_Click);
            // 
            // lbQotd
            // 
            this.lbQotd.AutoSize = true;
            this.lbQotd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQotd.Location = new System.Drawing.Point(28, 176);
            this.lbQotd.Name = "lbQotd";
            this.lbQotd.Size = new System.Drawing.Size(105, 25);
            this.lbQotd.TabIndex = 2;
            this.lbQotd.Text = "labelQotd";
            // 
            // btnQotdAsyncResult
            // 
            this.btnQotdAsyncResult.Location = new System.Drawing.Point(471, 47);
            this.btnQotdAsyncResult.Name = "btnQotdAsyncResult";
            this.btnQotdAsyncResult.Size = new System.Drawing.Size(134, 58);
            this.btnQotdAsyncResult.TabIndex = 3;
            this.btnQotdAsyncResult.Text = "Quote of the day AsyncResult";
            this.btnQotdAsyncResult.UseVisualStyleBackColor = true;
            this.btnQotdAsyncResult.Click += new System.EventHandler(this.btnQotdAsyncResult_Click);
            // 
            // btnQotdAsync
            // 
            this.btnQotdAsync.Location = new System.Drawing.Point(692, 47);
            this.btnQotdAsync.Name = "btnQotdAsync";
            this.btnQotdAsync.Size = new System.Drawing.Size(134, 58);
            this.btnQotdAsync.TabIndex = 4;
            this.btnQotdAsync.Text = "Quote of the day Async";
            this.btnQotdAsync.UseVisualStyleBackColor = true;
            this.btnQotdAsync.Click += new System.EventHandler(this.btnQotdAsync_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.btnQotdAsync);
            this.Controls.Add(this.btnQotdAsyncResult);
            this.Controls.Add(this.lbQotd);
            this.Controls.Add(this.btnQordThread);
            this.Controls.Add(this.btnQotdSync);
            this.Name = "MainForm";
            this.Text = "Quote of the Day";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQotdSync;
        private System.Windows.Forms.Button btnQordThread;
        private System.Windows.Forms.Label lbQotd;
        private System.Windows.Forms.Button btnQotdAsyncResult;
        private System.Windows.Forms.Button btnQotdAsync;
    }
}

