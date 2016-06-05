namespace NetworkSim
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
			this.components = new System.ComponentModel.Container();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.listBoxPackages = new System.Windows.Forms.ListBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.trace_details = new System.Windows.Forms.ListBox();
			this.netDrawer1 = new NetworkComponents.Controls.NetDrawer();
			this.pc4 = new NetworkComponents.Controls.PC();
			this.pc3 = new NetworkComponents.Controls.PC();
			this.hub2 = new NetworkComponents.Controls.Hub();
			this.server1 = new NetworkComponents.Controls.Server();
			this.hub1 = new NetworkComponents.Controls.Hub();
			this.pc2 = new NetworkComponents.Controls.PC();
			this.pc1 = new NetworkComponents.Controls.PC();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.netDrawer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLog
			// 
			this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtLog.Location = new System.Drawing.Point(13, 505);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(837, 183);
			this.txtLog.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// listBoxPackages
			// 
			this.listBoxPackages.FormattingEnabled = true;
			this.listBoxPackages.Location = new System.Drawing.Point(857, 38);
			this.listBoxPackages.Name = "listBoxPackages";
			this.listBoxPackages.Size = new System.Drawing.Size(177, 615);
			this.listBoxPackages.TabIndex = 2;
			this.listBoxPackages.SelectedIndexChanged += new System.EventHandler(this.listBoxPackages_SelectedIndexChanged);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(857, 665);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(177, 23);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// trace_details
			// 
			this.trace_details.FormattingEnabled = true;
			this.trace_details.Location = new System.Drawing.Point(1041, 39);
			this.trace_details.Name = "trace_details";
			this.trace_details.Size = new System.Drawing.Size(417, 615);
			this.trace_details.TabIndex = 4;
			// 
			// netDrawer1
			// 
			this.netDrawer1.BackColor = System.Drawing.Color.White;
			this.netDrawer1.Controls.Add(this.pc4);
			this.netDrawer1.Controls.Add(this.pc3);
			this.netDrawer1.Controls.Add(this.hub2);
			this.netDrawer1.Controls.Add(this.server1);
			this.netDrawer1.Controls.Add(this.hub1);
			this.netDrawer1.Controls.Add(this.pc2);
			this.netDrawer1.Controls.Add(this.pc1);
			this.netDrawer1.Location = new System.Drawing.Point(12, 12);
			this.netDrawer1.Name = "netDrawer1";
			this.netDrawer1.Size = new System.Drawing.Size(839, 486);
			this.netDrawer1.TabIndex = 0;
			// 
			// pc4
			// 
			this.pc4.BackColor = System.Drawing.Color.Silver;
			this.pc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc4.Gateway = null;
			this.pc4.Location = new System.Drawing.Point(656, 244);
			this.pc4.Name = "pc4";
			this.pc4.Size = new System.Drawing.Size(100, 100);
			this.pc4.TabIndex = 6;
			// 
			// pc3
			// 
			this.pc3.BackColor = System.Drawing.Color.Silver;
			this.pc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc3.Gateway = null;
			this.pc3.Location = new System.Drawing.Point(656, 119);
			this.pc3.Name = "pc3";
			this.pc3.Size = new System.Drawing.Size(100, 100);
			this.pc3.TabIndex = 5;
			// 
			// hub2
			// 
			this.hub2.BackColor = System.Drawing.Color.Silver;
			this.hub2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub2.InterfacesCount_U = 8;
			this.hub2.Location = new System.Drawing.Point(518, 186);
			this.hub2.Name = "hub2";
			this.hub2.Size = new System.Drawing.Size(100, 100);
			this.hub2.TabIndex = 4;
			// 
			// server1
			// 
			this.server1.BackColor = System.Drawing.Color.Silver;
			this.server1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server1.InterfacesCount_U = 2;
			this.server1.Location = new System.Drawing.Point(352, 32);
			this.server1.Name = "server1";
			this.server1.Size = new System.Drawing.Size(100, 100);
			this.server1.TabIndex = 3;
			// 
			// hub1
			// 
			this.hub1.BackColor = System.Drawing.Color.Silver;
			this.hub1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub1.InterfacesCount_U = 8;
			this.hub1.Location = new System.Drawing.Point(190, 186);
			this.hub1.Name = "hub1";
			this.hub1.Size = new System.Drawing.Size(100, 100);
			this.hub1.TabIndex = 2;
			// 
			// pc2
			// 
			this.pc2.BackColor = System.Drawing.Color.Silver;
			this.pc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc2.Gateway = null;
			this.pc2.Location = new System.Drawing.Point(58, 244);
			this.pc2.Name = "pc2";
			this.pc2.Size = new System.Drawing.Size(100, 100);
			this.pc2.TabIndex = 1;
			// 
			// pc1
			// 
			this.pc1.BackColor = System.Drawing.Color.Silver;
			this.pc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc1.Gateway = null;
			this.pc1.Location = new System.Drawing.Point(58, 119);
			this.pc1.Name = "pc1";
			this.pc1.Size = new System.Drawing.Size(100, 100);
			this.pc1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(857, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Пакеты";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1038, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Маршрут пакета";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1470, 700);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trace_details);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.listBoxPackages);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.netDrawer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.netDrawer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private NetworkComponents.Controls.NetDrawer netDrawer1;
		private NetworkComponents.Controls.PC pc4;
		private NetworkComponents.Controls.PC pc3;
		private NetworkComponents.Controls.Hub hub2;
		private NetworkComponents.Controls.Server server1;
		private NetworkComponents.Controls.Hub hub1;
		private NetworkComponents.Controls.PC pc2;
		private NetworkComponents.Controls.PC pc1;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ListBox listBoxPackages;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ListBox trace_details;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

