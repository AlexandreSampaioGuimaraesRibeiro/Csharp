/*
 * Created by SharpDevelop.
 * User: Aluno_Noite
 * Date: 25/11/2025
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Controle_de_Tarefas
{
	partial class FormTarefas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTarefa;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtTarefa;
		private System.Windows.Forms.Button btnCadastrarTarefa;
		private System.Windows.Forms.DateTimePicker DtpData;
		private System.Windows.Forms.ComboBox cmbStatus;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.btnCadastrarTarefa = new System.Windows.Forms.Button();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.GridControleTarefas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridControleTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarefa
            // 
            this.lblTarefa.Location = new System.Drawing.Point(64, 121);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(115, 40);
            this.lblTarefa.TabIndex = 0;
            this.lblTarefa.Text = "Tarefa:";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(324, 121);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(109, 40);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(630, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 40);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(164, 121);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(130, 29);
            this.txtTarefa.TabIndex = 3;
            // 
            // btnCadastrarTarefa
            // 
            this.btnCadastrarTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarTarefa.Location = new System.Drawing.Point(1039, 230);
            this.btnCadastrarTarefa.Name = "btnCadastrarTarefa";
            this.btnCadastrarTarefa.Size = new System.Drawing.Size(185, 32);
            this.btnCadastrarTarefa.TabIndex = 6;
            this.btnCadastrarTarefa.Text = "Cadastrar tarefa";
            this.btnCadastrarTarefa.UseVisualStyleBackColor = true;
            this.btnCadastrarTarefa.Click += new System.EventHandler(this.btnCadastrarTarefa_Click);
            // 
            // DtpData
            // 
            this.DtpData.Location = new System.Drawing.Point(370, 121);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(210, 29);
            this.DtpData.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Em andamento",
            "Planejando",
            "Parado"});
            this.cmbStatus.Location = new System.Drawing.Point(696, 121);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(135, 31);
            this.cmbStatus.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(393, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Controle de tarefas";
            // 
            // GridControleTarefas
            // 
            this.GridControleTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridControleTarefas.Enabled = false;
            this.GridControleTarefas.Location = new System.Drawing.Point(37, 230);
            this.GridControleTarefas.Name = "GridControleTarefas";
            this.GridControleTarefas.RowHeadersWidth = 62;
            this.GridControleTarefas.RowTemplate.Height = 28;
            this.GridControleTarefas.Size = new System.Drawing.Size(965, 195);
            this.GridControleTarefas.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(856, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Responsavel:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(986, 121);
            this.txtResponsavel.Multiline = true;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(118, 31);
            this.txtResponsavel.TabIndex = 13;
            // 
            // FormTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1254, 528);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridControleTarefas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.DtpData);
            this.Controls.Add(this.btnCadastrarTarefa);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTarefa);
            this.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTarefas";
            this.Text = "Controle_de_Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.GridControleTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView GridControleTarefas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsavel;
    }
}
