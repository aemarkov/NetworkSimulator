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
			this.server1 = new NetworkComponents.Controls.Server();
			this.server3 = new NetworkComponents.Controls.Server();
			this.server2 = new NetworkComponents.Controls.Server();
			this.hub2 = new NetworkComponents.Controls.Hub();
			this.hub1 = new NetworkComponents.Controls.Hub();
			this.pcGroup1 = new NetworkComponents.Controls.PCGroup();
			this.pcGroup2 = new NetworkComponents.Controls.PCGroup();
			this.pcGroup3 = new NetworkComponents.Controls.PCGroup();
			this.hub3 = new NetworkComponents.Controls.Hub();
			this.label3 = new System.Windows.Forms.Label();
			this.pcGroup5 = new NetworkComponents.Controls.PCGroup();
			this.server21 = new NetworkComponents.Controls.Server();
			this.hub21 = new NetworkComponents.Controls.Hub();
			this.server4 = new NetworkComponents.Controls.Server();
			this.admin = new NetworkComponents.Controls.PC();
			this.gate1 = new NetworkComponents.Controls.Gate();
			((System.ComponentModel.ISupportInitialize)(this.table_packages)).BeginInit();
			this.netDrawer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtLog.Location = new System.Drawing.Point(1379, 385);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(373, 312);
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
			this.btnReset.Location = new System.Drawing.Point(1089, 683);
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
			this.label1.Location = new System.Drawing.Point(1086, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Пакеты";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1376, 15);
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
			this.trace_details.Location = new System.Drawing.Point(1379, 38);
			this.trace_details.Multiline = true;
			this.trace_details.Name = "trace_details";
			this.trace_details.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.trace_details.Size = new System.Drawing.Size(373, 318);
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
			this.table_packages.Location = new System.Drawing.Point(1089, 38);
			this.table_packages.Name = "table_packages";
			this.table_packages.ReadOnly = true;
			this.table_packages.Size = new System.Drawing.Size(284, 639);
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
			this.netDrawer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.netDrawer1.BackColor = System.Drawing.Color.White;
			this.netDrawer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.netDrawer1.Controls.Add(this.gate1);
			this.netDrawer1.Controls.Add(this.admin);
			this.netDrawer1.Controls.Add(this.server4);
			this.netDrawer1.Controls.Add(this.hub21);
			this.netDrawer1.Controls.Add(this.server21);
			this.netDrawer1.Controls.Add(this.pcGroup5);
			this.netDrawer1.Controls.Add(this.hub3);
			this.netDrawer1.Controls.Add(this.pcGroup3);
			this.netDrawer1.Controls.Add(this.pcGroup2);
			this.netDrawer1.Controls.Add(this.pcGroup1);
			this.netDrawer1.Controls.Add(this.server1);
			this.netDrawer1.Controls.Add(this.server3);
			this.netDrawer1.Controls.Add(this.server2);
			this.netDrawer1.Controls.Add(this.hub2);
			this.netDrawer1.Controls.Add(this.hub1);
			this.netDrawer1.Location = new System.Drawing.Point(12, 12);
			this.netDrawer1.Name = "netDrawer1";
			this.netDrawer1.Size = new System.Drawing.Size(1068, 694);
			this.netDrawer1.TabIndex = 0;
			// 
			// server1
			// 
			this.server1.BackColor = System.Drawing.Color.Silver;
			this.server1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server1.Location = new System.Drawing.Point(215, 3);
			this.server1.Name = "server1";
			this.server1.Size = new System.Drawing.Size(100, 100);
			this.server1.TabIndex = 12;
			// 
			// server3
			// 
			this.server3.BackColor = System.Drawing.Color.Silver;
			this.server3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server3.Location = new System.Drawing.Point(215, 440);
			this.server3.Name = "server3";
			this.server3.Size = new System.Drawing.Size(100, 100);
			this.server3.TabIndex = 11;
			// 
			// server2
			// 
			this.server2.BackColor = System.Drawing.Color.Silver;
			this.server2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server2.Location = new System.Drawing.Point(215, 144);
			this.server2.Name = "server2";
			this.server2.Size = new System.Drawing.Size(100, 100);
			this.server2.TabIndex = 10;
			// 
			// hub2
			// 
			this.hub2.BackColor = System.Drawing.Color.Silver;
			this.hub2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub2.InterfacesCount_U = 8;
			this.hub2.Location = new System.Drawing.Point(109, 144);
			this.hub2.Name = "hub2";
			this.hub2.Size = new System.Drawing.Size(100, 80);
			this.hub2.TabIndex = 8;
			// 
			// hub1
			// 
			this.hub1.BackColor = System.Drawing.Color.Silver;
			this.hub1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub1.InterfacesCount_U = 20;
			this.hub1.Location = new System.Drawing.Point(109, 3);
			this.hub1.Name = "hub1";
			this.hub1.Size = new System.Drawing.Size(100, 80);
			this.hub1.TabIndex = 7;
			// 
			// pcGroup1
			// 
			this.pcGroup1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup1.Location = new System.Drawing.Point(3, 3);
			this.pcGroup1.Name = "pcGroup1";
			this.pcGroup1.Size = new System.Drawing.Size(100, 132);
			this.pcGroup1.TabIndex = 13;
			// 
			// pcGroup2
			// 
			this.pcGroup2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup2.Location = new System.Drawing.Point(3, 144);
			this.pcGroup2.Name = "pcGroup2";
			this.pcGroup2.Size = new System.Drawing.Size(100, 132);
			this.pcGroup2.TabIndex = 14;
			// 
			// pcGroup3
			// 
			this.pcGroup3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup3.Location = new System.Drawing.Point(3, 440);
			this.pcGroup3.Name = "pcGroup3";
			this.pcGroup3.Size = new System.Drawing.Size(100, 132);
			this.pcGroup3.TabIndex = 15;
			// 
			// hub3
			// 
			this.hub3.BackColor = System.Drawing.Color.Silver;
			this.hub3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub3.InterfacesCount_U = 8;
			this.hub3.Location = new System.Drawing.Point(109, 440);
			this.hub3.Name = "hub3";
			this.hub3.Size = new System.Drawing.Size(100, 80);
			this.hub3.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1379, 369);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Общий лог";
			// 
			// pcGroup5
			// 
			this.pcGroup5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup5.Location = new System.Drawing.Point(3, 282);
			this.pcGroup5.Name = "pcGroup5";
			this.pcGroup5.Size = new System.Drawing.Size(100, 132);
			this.pcGroup5.TabIndex = 27;
			// 
			// server21
			// 
			this.server21.BackColor = System.Drawing.Color.Silver;
			this.server21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server21.Location = new System.Drawing.Point(215, 282);
			this.server21.Name = "server21";
			this.server21.Size = new System.Drawing.Size(100, 100);
			this.server21.TabIndex = 28;
			// 
			// hub21
			// 
			this.hub21.BackColor = System.Drawing.Color.Silver;
			this.hub21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub21.InterfacesCount_U = 8;
			this.hub21.Location = new System.Drawing.Point(109, 282);
			this.hub21.Name = "hub21";
			this.hub21.Size = new System.Drawing.Size(100, 80);
			this.hub21.TabIndex = 29;
			// 
			// server4
			// 
			this.server4.BackColor = System.Drawing.Color.Silver;
			this.server4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server4.Location = new System.Drawing.Point(501, 211);
			this.server4.Name = "server4";
			this.server4.Size = new System.Drawing.Size(100, 100);
			this.server4.TabIndex = 30;
			// 
			// admin
			// 
			this.admin.BackColor = System.Drawing.Color.Silver;
			this.admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.admin.Gateway = null;
			this.admin.Location = new System.Drawing.Point(492, 338);
			this.admin.Name = "admin";
			this.admin.Size = new System.Drawing.Size(130, 140);
			this.admin.TabIndex = 31;
			// 
			// gate1
			// 
			this.gate1.BackColor = System.Drawing.Color.Silver;
			this.gate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gate1.Location = new System.Drawing.Point(715, 193);
			this.gate1.Name = "gate1";
			this.gate1.Size = new System.Drawing.Size(130, 118);
			this.gate1.TabIndex = 32;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1764, 718);
			this.Controls.Add(this.label3);
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
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox trace_details;
		private System.Windows.Forms.DataGridView table_packages;
		private System.Windows.Forms.DataGridViewTextBoxColumn column_package;
		private System.Windows.Forms.DataGridViewTextBoxColumn column_status;
		private NetworkComponents.Controls.Hub hub1;
		private NetworkComponents.Controls.Server server2;
		private NetworkComponents.Controls.Hub hub2;
		private NetworkComponents.Controls.Server server3;
		private NetworkComponents.Controls.Server server1;
		private NetworkComponents.Controls.Hub hub3;
		private NetworkComponents.Controls.PCGroup pcGroup3;
		private NetworkComponents.Controls.PCGroup pcGroup2;
		private NetworkComponents.Controls.PCGroup pcGroup1;
		private System.Windows.Forms.Label label3;
		private NetworkComponents.Controls.Gate gate1;
		private NetworkComponents.Controls.PC admin;
		private NetworkComponents.Controls.Server server4;
		private NetworkComponents.Controls.Hub hub21;
		private NetworkComponents.Controls.Server server21;
		private NetworkComponents.Controls.PCGroup pcGroup5;
	}
}

