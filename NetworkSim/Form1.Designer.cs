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
			this.trackBar1 = new System.Windows.Forms.TrackBar();
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
			this.server4 = new NetworkComponents.Controls.Server();
			this.pcGroup4 = new NetworkComponents.Controls.PCGroup();
			this.pcGroup5 = new NetworkComponents.Controls.PCGroup();
			this.pcGroup6 = new NetworkComponents.Controls.PCGroup();
			this.hub4 = new NetworkComponents.Controls.Hub();
			this.hub5 = new NetworkComponents.Controls.Hub();
			this.hub6 = new NetworkComponents.Controls.Hub();
			this.server5 = new NetworkComponents.Controls.Server();
			this.server6 = new NetworkComponents.Controls.Server();
			this.server7 = new NetworkComponents.Controls.Server();
			((System.ComponentModel.ISupportInitialize)(this.table_packages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(805, 13);
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new System.Drawing.Size(45, 486);
			this.trackBar1.TabIndex = 9;
			this.trackBar1.Value = 10;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// netDrawer1
			// 
			this.netDrawer1.BackColor = System.Drawing.Color.White;
			this.netDrawer1.Controls.Add(this.server7);
			this.netDrawer1.Controls.Add(this.server6);
			this.netDrawer1.Controls.Add(this.server5);
			this.netDrawer1.Controls.Add(this.hub6);
			this.netDrawer1.Controls.Add(this.hub5);
			this.netDrawer1.Controls.Add(this.hub4);
			this.netDrawer1.Controls.Add(this.pcGroup6);
			this.netDrawer1.Controls.Add(this.pcGroup5);
			this.netDrawer1.Controls.Add(this.pcGroup4);
			this.netDrawer1.Controls.Add(this.server4);
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
			this.netDrawer1.Size = new System.Drawing.Size(791, 486);
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
			this.server3.Location = new System.Drawing.Point(215, 144);
			this.server3.Name = "server3";
			this.server3.Size = new System.Drawing.Size(100, 100);
			this.server3.TabIndex = 11;
			// 
			// server2
			// 
			this.server2.BackColor = System.Drawing.Color.Silver;
			this.server2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server2.Location = new System.Drawing.Point(352, 144);
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
			this.pcGroup3.Location = new System.Drawing.Point(3, 282);
			this.pcGroup3.Name = "pcGroup3";
			this.pcGroup3.Size = new System.Drawing.Size(100, 132);
			this.pcGroup3.TabIndex = 15;
			// 
			// hub3
			// 
			this.hub3.BackColor = System.Drawing.Color.Silver;
			this.hub3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub3.InterfacesCount_U = 8;
			this.hub3.Location = new System.Drawing.Point(109, 282);
			this.hub3.Name = "hub3";
			this.hub3.Size = new System.Drawing.Size(100, 80);
			this.hub3.TabIndex = 16;
			// 
			// server4
			// 
			this.server4.BackColor = System.Drawing.Color.Silver;
			this.server4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server4.Location = new System.Drawing.Point(215, 282);
			this.server4.Name = "server4";
			this.server4.Size = new System.Drawing.Size(100, 100);
			this.server4.TabIndex = 17;
			// 
			// pcGroup4
			// 
			this.pcGroup4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup4.Location = new System.Drawing.Point(687, 3);
			this.pcGroup4.Name = "pcGroup4";
			this.pcGroup4.Size = new System.Drawing.Size(100, 132);
			this.pcGroup4.TabIndex = 18;
			// 
			// pcGroup5
			// 
			this.pcGroup5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup5.Location = new System.Drawing.Point(687, 144);
			this.pcGroup5.Name = "pcGroup5";
			this.pcGroup5.Size = new System.Drawing.Size(100, 132);
			this.pcGroup5.TabIndex = 19;
			// 
			// pcGroup6
			// 
			this.pcGroup6.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pcGroup6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcGroup6.Location = new System.Drawing.Point(687, 282);
			this.pcGroup6.Name = "pcGroup6";
			this.pcGroup6.Size = new System.Drawing.Size(100, 132);
			this.pcGroup6.TabIndex = 20;
			// 
			// hub4
			// 
			this.hub4.BackColor = System.Drawing.Color.Silver;
			this.hub4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub4.InterfacesCount_U = 20;
			this.hub4.Location = new System.Drawing.Point(581, 3);
			this.hub4.Name = "hub4";
			this.hub4.Size = new System.Drawing.Size(100, 80);
			this.hub4.TabIndex = 21;
			// 
			// hub5
			// 
			this.hub5.BackColor = System.Drawing.Color.Silver;
			this.hub5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub5.InterfacesCount_U = 8;
			this.hub5.Location = new System.Drawing.Point(581, 144);
			this.hub5.Name = "hub5";
			this.hub5.Size = new System.Drawing.Size(100, 80);
			this.hub5.TabIndex = 22;
			// 
			// hub6
			// 
			this.hub6.BackColor = System.Drawing.Color.Silver;
			this.hub6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub6.InterfacesCount_U = 8;
			this.hub6.Location = new System.Drawing.Point(581, 282);
			this.hub6.Name = "hub6";
			this.hub6.Size = new System.Drawing.Size(100, 80);
			this.hub6.TabIndex = 23;
			// 
			// server5
			// 
			this.server5.BackColor = System.Drawing.Color.Silver;
			this.server5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server5.Location = new System.Drawing.Point(475, 3);
			this.server5.Name = "server5";
			this.server5.Size = new System.Drawing.Size(100, 100);
			this.server5.TabIndex = 24;
			// 
			// server6
			// 
			this.server6.BackColor = System.Drawing.Color.Silver;
			this.server6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server6.Location = new System.Drawing.Point(475, 144);
			this.server6.Name = "server6";
			this.server6.Size = new System.Drawing.Size(100, 100);
			this.server6.TabIndex = 25;
			// 
			// server7
			// 
			this.server7.BackColor = System.Drawing.Color.Silver;
			this.server7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server7.Location = new System.Drawing.Point(475, 282);
			this.server7.Name = "server7";
			this.server7.Size = new System.Drawing.Size(100, 100);
			this.server7.TabIndex = 26;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1470, 700);
			this.Controls.Add(this.trackBar1);
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
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
		private System.Windows.Forms.TrackBar trackBar1;
		private NetworkComponents.Controls.Hub hub1;
		private NetworkComponents.Controls.Server server2;
		private NetworkComponents.Controls.Hub hub2;
		private NetworkComponents.Controls.Server server3;
		private NetworkComponents.Controls.Server server1;
		private NetworkComponents.Controls.Server server7;
		private NetworkComponents.Controls.Server server6;
		private NetworkComponents.Controls.Server server5;
		private NetworkComponents.Controls.Hub hub6;
		private NetworkComponents.Controls.Hub hub5;
		private NetworkComponents.Controls.Hub hub4;
		private NetworkComponents.Controls.PCGroup pcGroup6;
		private NetworkComponents.Controls.PCGroup pcGroup5;
		private NetworkComponents.Controls.PCGroup pcGroup4;
		private NetworkComponents.Controls.Server server4;
		private NetworkComponents.Controls.Hub hub3;
		private NetworkComponents.Controls.PCGroup pcGroup3;
		private NetworkComponents.Controls.PCGroup pcGroup2;
		private NetworkComponents.Controls.PCGroup pcGroup1;
	}
}

