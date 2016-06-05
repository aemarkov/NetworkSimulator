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
			this.server1 = new NetworkComponents.Controls.Server();
			this.pc3 = new NetworkComponents.Controls.PC();
			this.pc2 = new NetworkComponents.Controls.PC();
			this.hub1 = new NetworkComponents.Controls.Hub();
			this.pc1 = new NetworkComponents.Controls.PC();
			this.SuspendLayout();
			// 
			// server1
			// 
			this.server1.BackColor = System.Drawing.Color.White;
			this.server1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.server1.InterfacesCount_U = 2;
			this.server1.Location = new System.Drawing.Point(130, 55);
			this.server1.Name = "server1";
			this.server1.Size = new System.Drawing.Size(100, 100);
			this.server1.TabIndex = 4;
			// 
			// pc3
			// 
			this.pc3.BackColor = System.Drawing.Color.White;
			this.pc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc3.Location = new System.Drawing.Point(247, 174);
			this.pc3.Name = "pc3";
			this.pc3.Size = new System.Drawing.Size(100, 100);
			this.pc3.TabIndex = 3;
			// 
			// pc2
			// 
			this.pc2.BackColor = System.Drawing.Color.White;
			this.pc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc2.Location = new System.Drawing.Point(247, 296);
			this.pc2.Name = "pc2";
			this.pc2.Size = new System.Drawing.Size(100, 100);
			this.pc2.TabIndex = 2;
			// 
			// hub1
			// 
			this.hub1.BackColor = System.Drawing.Color.White;
			this.hub1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hub1.InterfacesCount_U = 8;
			this.hub1.Location = new System.Drawing.Point(247, 55);
			this.hub1.Name = "hub1";
			this.hub1.Size = new System.Drawing.Size(100, 100);
			this.hub1.TabIndex = 1;
			// 
			// pc1
			// 
			this.pc1.BackColor = System.Drawing.Color.White;
			this.pc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pc1.Location = new System.Drawing.Point(12, 55);
			this.pc1.Name = "pc1";
			this.pc1.Size = new System.Drawing.Size(100, 100);
			this.pc1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 408);
			this.Controls.Add(this.server1);
			this.Controls.Add(this.pc3);
			this.Controls.Add(this.pc2);
			this.Controls.Add(this.hub1);
			this.Controls.Add(this.pc1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private NetworkComponents.Controls.PC pc1;
		private NetworkComponents.Controls.Hub hub1;
		private NetworkComponents.Controls.PC pc2;
		private NetworkComponents.Controls.PC pc3;
		private NetworkComponents.Controls.Server server1;
	}
}

