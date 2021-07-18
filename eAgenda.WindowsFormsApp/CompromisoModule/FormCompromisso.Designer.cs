
namespace eAgenda.WindowsFormsApp.CompromisoModule
{
    partial class FormCompromisso
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.horaFim = new System.Windows.Forms.DateTimePicker();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.horaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtLink = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.userControlBtn = new eAgenda.WindowsFormsApp.Shared.UserControlBtn();
            this.btnFuturos = new System.Windows.Forms.Button();
            this.btnPassados = new System.Windows.Forms.Button();
            this.btnProximoMes = new System.Windows.Forms.Button();
            this.btnProximaSemana = new System.Windows.Forms.Button();
            this.btnHoje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.listBoxObjetos = new System.Windows.Forms.ListBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.horaFim);
            this.panel2.Controls.Add(this.txtLocal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelFinal);
            this.panel2.Controls.Add(this.labelLink);
            this.panel2.Controls.Add(this.txtAssunto);
            this.panel2.Controls.Add(this.horaInicio);
            this.panel2.Controls.Add(this.txtLink);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelData);
            this.panel2.Controls.Add(this.labelAssunto);
            this.panel2.Controls.Add(this.data);
            this.panel2.Controls.Add(this.labelLocal);
            this.panel2.Controls.Add(this.labelCargo);
            this.panel2.Controls.Add(this.comboBoxContato);
            this.panel2.Controls.Add(this.userControlBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(594, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 446);
            this.panel2.TabIndex = 11;
            // 
            // horaFim
            // 
            this.horaFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaFim.Location = new System.Drawing.Point(119, 224);
            this.horaFim.Name = "horaFim";
            this.horaFim.ShowUpDown = true;
            this.horaFim.Size = new System.Drawing.Size(104, 22);
            this.horaFim.TabIndex = 37;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(119, 66);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(160, 22);
            this.txtLocal.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(170, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFinal
            // 
            this.labelFinal.Location = new System.Drawing.Point(14, 223);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(97, 23);
            this.labelFinal.TabIndex = 36;
            this.labelFinal.Text = "Hora Final";
            this.labelFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLink
            // 
            this.labelLink.Location = new System.Drawing.Point(14, 105);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(97, 23);
            this.labelLink.TabIndex = 27;
            this.labelLink.Text = "Link";
            this.labelLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(119, 27);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(160, 22);
            this.txtAssunto.TabIndex = 21;
            // 
            // horaInicio
            // 
            this.horaInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.horaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.horaInicio.Location = new System.Drawing.Point(119, 186);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ShowUpDown = true;
            this.horaInicio.Size = new System.Drawing.Size(104, 22);
            this.horaInicio.TabIndex = 35;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(119, 106);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(160, 22);
            this.txtLink.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(229, 301);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 22);
            this.txtId.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Hora Inicio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelData
            // 
            this.labelData.Location = new System.Drawing.Point(14, 145);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(97, 23);
            this.labelData.TabIndex = 29;
            this.labelData.Text = "Data";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAssunto
            // 
            this.labelAssunto.Location = new System.Drawing.Point(11, 26);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(100, 23);
            this.labelAssunto.TabIndex = 20;
            this.labelAssunto.Text = "Assunto";
            this.labelAssunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(119, 145);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(160, 22);
            this.data.TabIndex = 33;
            // 
            // labelLocal
            // 
            this.labelLocal.Location = new System.Drawing.Point(14, 65);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(97, 23);
            this.labelLocal.TabIndex = 22;
            this.labelLocal.Text = "Local";
            this.labelLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCargo
            // 
            this.labelCargo.Location = new System.Drawing.Point(14, 263);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(97, 23);
            this.labelCargo.TabIndex = 32;
            this.labelCargo.Text = "Contato";
            this.labelCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.Location = new System.Drawing.Point(119, 263);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(160, 24);
            this.comboBoxContato.TabIndex = 31;
            // 
            // userControlBtn
            // 
            this.userControlBtn.Location = new System.Drawing.Point(3, 338);
            this.userControlBtn.Name = "userControlBtn";
            this.userControlBtn.Size = new System.Drawing.Size(299, 89);
            this.userControlBtn.TabIndex = 25;
            // 
            // btnFuturos
            // 
            this.btnFuturos.Location = new System.Drawing.Point(32, 142);
            this.btnFuturos.Name = "btnFuturos";
            this.btnFuturos.Size = new System.Drawing.Size(101, 51);
            this.btnFuturos.TabIndex = 4;
            this.btnFuturos.Text = "Futuros";
            this.btnFuturos.UseVisualStyleBackColor = true;
            this.btnFuturos.Click += new System.EventHandler(this.btnFuturos_Click);
            // 
            // btnPassados
            // 
            this.btnPassados.Location = new System.Drawing.Point(32, 201);
            this.btnPassados.Name = "btnPassados";
            this.btnPassados.Size = new System.Drawing.Size(101, 51);
            this.btnPassados.TabIndex = 3;
            this.btnPassados.Text = "Passados";
            this.btnPassados.UseVisualStyleBackColor = true;
            this.btnPassados.Click += new System.EventHandler(this.btnPassados_Click);
            // 
            // btnProximoMes
            // 
            this.btnProximoMes.Location = new System.Drawing.Point(32, 260);
            this.btnProximoMes.Name = "btnProximoMes";
            this.btnProximoMes.Size = new System.Drawing.Size(101, 51);
            this.btnProximoMes.TabIndex = 2;
            this.btnProximoMes.Text = "Proximo Mês";
            this.btnProximoMes.UseVisualStyleBackColor = true;
            this.btnProximoMes.Click += new System.EventHandler(this.btnProximoMes_Click);
            // 
            // btnProximaSemana
            // 
            this.btnProximaSemana.Location = new System.Drawing.Point(32, 318);
            this.btnProximaSemana.Name = "btnProximaSemana";
            this.btnProximaSemana.Size = new System.Drawing.Size(101, 51);
            this.btnProximaSemana.TabIndex = 1;
            this.btnProximaSemana.Text = "Proxima Semana";
            this.btnProximaSemana.UseVisualStyleBackColor = true;
            this.btnProximaSemana.Click += new System.EventHandler(this.btnProximaSemana_Click);
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(32, 377);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(101, 51);
            this.btnHoje.TabIndex = 0;
            this.btnHoje.Text = "Proximas 24H";
            this.btnHoje.UseVisualStyleBackColor = true;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTodos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFuturos);
            this.panel1.Controls.Add(this.btnPassados);
            this.panel1.Controls.Add(this.btnProximoMes);
            this.panel1.Controls.Add(this.btnProximaSemana);
            this.panel1.Controls.Add(this.btnHoje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(163, 446);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Filtros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCenter
            // 
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Controls.Add(this.listBoxObjetos);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Padding = new System.Windows.Forms.Padding(8);
            this.panelCenter.Size = new System.Drawing.Size(425, 446);
            this.panelCenter.TabIndex = 10;
            // 
            // listBoxObjetos
            // 
            this.listBoxObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxObjetos.FormattingEnabled = true;
            this.listBoxObjetos.ItemHeight = 16;
            this.listBoxObjetos.Location = new System.Drawing.Point(8, 8);
            this.listBoxObjetos.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxObjetos.Name = "listBoxObjetos";
            this.listBoxObjetos.Size = new System.Drawing.Size(407, 428);
            this.listBoxObjetos.TabIndex = 0;
            this.listBoxObjetos.SelectedIndexChanged += new System.EventHandler(this.listBoxObjetos_SelectedIndexChanged);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(32, 83);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(101, 51);
            this.btnTodos.TabIndex = 39;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // FormCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCenter);
            this.Name = "FormCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle Compromisso";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFuturos;
        private System.Windows.Forms.Button btnPassados;
        private System.Windows.Forms.Button btnProximoMes;
        private System.Windows.Forms.Button btnProximaSemana;
        private System.Windows.Forms.Button btnHoje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCargo;
        private Shared.UserControlBtn userControlBtn;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox txtLink;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ListBox listBoxObjetos;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.DateTimePicker horaFim;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horaInicio;
        private System.Windows.Forms.Button btnTodos;
    }
}