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
			this.btnReset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.trace_details = new System.Windows.Forms.TextBox();
			this.table_packages = new System.Windows.Forms.DataGridView();
			this.column_package = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.column_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.netDrawer1 = new NetworkComponents.Controls.NetDrawer();
			this.hub2 = new NetworkComponents.Controls.Hub();
			this.server1 = new NetworkComponents.Controls.Server();
			this.hub1 = new NetworkComponents.Controls.Hub();
			this.pc1 = new NetworkComponents.Controls.PC();
			this.pc2 = new NetworkComponents.Controls.PC();
			this.pc3 = new NetworkComponents.Controls.PC();
			this.pc4 = new NetworkComponents.Controls.PC();
			((System.ComponentModel.ISupportInitialize)(this.table_packages)).BeginInit();
			this.netDrawer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.Location = new System.Drawing.Point(857, 665);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(284, 23);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
			// trace_details
			// 
			this.trace_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trace_details.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.trace_details.Location = new System.Drawing.Point(1147, 38);
			this.trace_details.Multiline = true;
			this.trace_details.Name = "trace_details";
			this.trace_details.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.trace_details.Size = new System.Drawing.Size(311, 650);
			this.trace_details.TabIndex = 7;
			// 
			// table_packages
			// 
			this.table_packages.AllowUserToAddRows = false;
			this.table_packages.AllowUserToDeleteRows = false;
			this.table_packages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.table_packages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.table_packages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table_packages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_package,
            this.column_status});
			this.table_packages.Location = new System.Drawing.Point(857, 38);
			this.table_packages.Name = "table_packages";
			this.table_packages.ReadOnly = true;
			this.table_packages.Size = new System.Drawing.Size(284, 621);
			this.table_packages.TabIndex = 8;
			// 
			// column_package
			// 
			this.column_package.HeaderText = "Package";
			this.column_package.Name = "column_package";
			this.column_package.ReadOnly = true;
			// 
			// column_status
			// 
			this.column_status.HeaderText = "status";
			this.column_status.Name = "column_status";
			this.column_status.ReadOnly = true;
			// 
			// netDrawer1
			// 
			this.netDrawer1.BackColor = System.Drawing.Color.White;
			this.netDrawer1.Controls.Add(this.pc4);
			this.netDrawer1.Controls.Add(this.pc3);
			this.netDrawer1.Controls.Add(this.pc2);
			this.netDrawer1.Controls.Add(this.pc1);
			this.netDrawer1.Controls.Add(this.hub2);
			this.netDrawer1.Controls.Add(this.server1);
			this.netDrawer1.Controls.Add(this.hub1);
			this.netDrawer1.Location = new System.Drawing.Point(12, 12);
			this.netDrawer1.Name = "netDrawer1";
			this.netDrawer1.Size = new System.Drawing.Size(839, 486);
			this.netDrawer1.TabIndex = 0;
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
			// pc1
			// 
			this.pc1.BackColor = System.Drawing.Color.Silver;
			this.pc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc1.Gateway = null;
			this.pc1.Location = new System.Drawing.Point(23, 32);
			this.pc1.Name = "pc1";
			this.pc1.Size = new System.Drawing.Size(115, 147);
			this.pc1.TabIndex = 5;
			// 
			// pc2
			// 
			this.pc2.BackColor = System.Drawing.Color.Silver;
			this.pc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc2.Gateway = null;
			this.pc2.Location = new System.Drawing.Point(23, 220);
			this.pc2.Name = "pc2";
			this.pc2.Size = new System.Drawing.Size(115, 147);
			this.pc2.TabIndex = 6;
			// 
			// pc3
			// 
			this.pc3.BackColor = System.Drawing.Color.Silver;
			this.pc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc3.Gateway = null;
			this.pc3.Location = new System.Drawing.Point(688, 32);
			this.pc3.Name = "pc3";
			this.pc3.Size = new System.Drawing.Size(115, 147);
			this.pc3.TabIndex = 7;
			// 
			// pc4
			// 
			this.pc4.BackColor = System.Drawing.Color.Silver;
			this.pc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc4.Gateway = null;
			this.pc4.Location = new System.Drawing.Point(688, 220);
			this.pc4.Name = "pc4";
			this.pc4.Size = new System.Drawing.Size(115, 147);
			this.pc4.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1470, 700);
			this.Controls.Add(this.table_packages);
			this.Controls.Add(this.trace_details);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.netDrawer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.table_packages)).EndInit();
			this.netDrawer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private NetworkComponents.Controls.NetDrawer netDrawer1;
		private NetworkComponents.Controls.Hub hub2;
		private NetworkComponents.Controls.Server server1;
		private NetworkComponents.Controls.Hub hub1;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox trace_details;
		private System.Windows.Forms.DataGridView table_packages;
		private System.Windows.Forms.DataGridViewTextBoxColumn column_package;
		private System.Windows.Forms.DataGridViewTextBoxColumn column_status;
		private NetworkComponents.Controls.PC pc4;
		private NetworkComponents.Controls.PC pc3;
		private NetworkComponents.Controls.PC pc2;
		private NetworkComponents.Controls.PC pc1;
	}
}

