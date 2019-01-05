namespace VyosSetRoutes
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRoutes = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRoutes
            // 
            this.txtRoutes.Location = new System.Drawing.Point(12, 12);
            this.txtRoutes.Multiline = true;
            this.txtRoutes.Name = "txtRoutes";
            this.txtRoutes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRoutes.Size = new System.Drawing.Size(205, 403);
            this.txtRoutes.TabIndex = 0;
            this.txtRoutes.Text = "routes";
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(223, 12);
            this.txtGateway.Multiline = true;
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGateway.Size = new System.Drawing.Size(205, 403);
            this.txtGateway.TabIndex = 1;
            this.txtGateway.Text = "gateways";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 421);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(875, 21);
            this.txtComment.TabIndex = 2;
            this.txtComment.Text = "comment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(434, 12);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScript.Size = new System.Drawing.Size(453, 403);
            this.txtScript.TabIndex = 4;
            this.txtScript.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 478);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtRoutes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoutes;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtScript;
    }
}

