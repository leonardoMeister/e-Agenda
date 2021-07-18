
namespace eAgenda.WindowsFormsApp.TarefaModule
{
    partial class FormTarefa
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
            this.listBoxObjetos = new System.Windows.Forms.ListBox();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPercentual = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSemConcluir = new System.Windows.Forms.Button();
            this.btnConcluida = new System.Windows.Forms.Button();
            this.btnPriori3 = new System.Windows.Forms.Button();
            this.btnPriori2 = new System.Windows.Forms.Button();
            this.btnPriori1 = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.txtPercentual = new System.Windows.Forms.ComboBox();
            this.userControlBtn = new eAgenda.WindowsFormsApp.Shared.UserControlBtn();
            this.btnTodos = new System.Windows.Forms.Button();
            this.panelFundo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxObjetos
            // 
            this.listBoxObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxObjetos.FormattingEnabled = true;
            this.listBoxObjetos.ItemHeight = 16;
            this.listBoxObjetos.Location = new System.Drawing.Point(8, 8);
            this.listBoxObjetos.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxObjetos.Name = "listBoxObjetos";
            this.listBoxObjetos.Size = new System.Drawing.Size(401, 416);
            this.listBoxObjetos.TabIndex = 0;
            this.listBoxObjetos.SelectedIndexChanged += new System.EventHandler(this.listBoxObjetos_SelectedIndexChanged);
            // 
            // panelFundo
            // 
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFundo.Controls.Add(this.panel2);
            this.panelFundo.Controls.Add(this.panel1);
            this.panelFundo.Controls.Add(this.panelCenter);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Padding = new System.Windows.Forms.Padding(7);
            this.panelFundo.Size = new System.Drawing.Size(931, 450);
            this.panelFundo.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPercentual);
            this.panel2.Controls.Add(this.userControlBtn);
            this.panel2.Controls.Add(this.labelPrioridade);
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.comboBoxPrioridade);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelPercentual);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(585, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 434);
            this.panel2.TabIndex = 5;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.Location = new System.Drawing.Point(41, 179);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(94, 23);
            this.labelPrioridade.TabIndex = 20;
            this.labelPrioridade.Text = "Prioridade";
            this.labelPrioridade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(143, 40);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(160, 22);
            this.txtTitulo.TabIndex = 14;
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Prioridade Baixa",
            "Prioridade Normal",
            "Prioridade Alta"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(143, 178);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPrioridade.TabIndex = 19;
            // 
            // labelNome
            // 
            this.labelNome.Location = new System.Drawing.Point(35, 39);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(100, 23);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "Titulo";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(184, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPercentual
            // 
            this.labelPercentual.Location = new System.Drawing.Point(38, 111);
            this.labelPercentual.Name = "labelPercentual";
            this.labelPercentual.Size = new System.Drawing.Size(97, 23);
            this.labelPercentual.TabIndex = 16;
            this.labelPercentual.Text = "Percentual";
            this.labelPercentual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(243, 248);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 22);
            this.txtId.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTodos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSemConcluir);
            this.panel1.Controls.Add(this.btnConcluida);
            this.panel1.Controls.Add(this.btnPriori3);
            this.panel1.Controls.Add(this.btnPriori2);
            this.panel1.Controls.Add(this.btnPriori1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(426, 7);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(153, 434);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Filtros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSemConcluir
            // 
            this.btnSemConcluir.Location = new System.Drawing.Point(26, 147);
            this.btnSemConcluir.Name = "btnSemConcluir";
            this.btnSemConcluir.Size = new System.Drawing.Size(103, 42);
            this.btnSemConcluir.TabIndex = 4;
            this.btnSemConcluir.Text = "Sem Concluir";
            this.btnSemConcluir.UseVisualStyleBackColor = true;
            this.btnSemConcluir.Click += new System.EventHandler(this.btnSemConcluir_Click);
            // 
            // btnConcluida
            // 
            this.btnConcluida.Location = new System.Drawing.Point(26, 201);
            this.btnConcluida.Name = "btnConcluida";
            this.btnConcluida.Size = new System.Drawing.Size(103, 42);
            this.btnConcluida.TabIndex = 3;
            this.btnConcluida.Text = "Concluida";
            this.btnConcluida.UseVisualStyleBackColor = true;
            this.btnConcluida.Click += new System.EventHandler(this.btnConcluida_Click);
            // 
            // btnPriori3
            // 
            this.btnPriori3.Location = new System.Drawing.Point(26, 255);
            this.btnPriori3.Name = "btnPriori3";
            this.btnPriori3.Size = new System.Drawing.Size(103, 42);
            this.btnPriori3.TabIndex = 2;
            this.btnPriori3.Text = "Prioridade 3";
            this.btnPriori3.UseVisualStyleBackColor = true;
            this.btnPriori3.Click += new System.EventHandler(this.btnPriori3_Click);
            // 
            // btnPriori2
            // 
            this.btnPriori2.Location = new System.Drawing.Point(26, 309);
            this.btnPriori2.Name = "btnPriori2";
            this.btnPriori2.Size = new System.Drawing.Size(103, 42);
            this.btnPriori2.TabIndex = 1;
            this.btnPriori2.Text = "Prioridade 2";
            this.btnPriori2.UseVisualStyleBackColor = true;
            this.btnPriori2.Click += new System.EventHandler(this.btnPriori2_Click);
            // 
            // btnPriori1
            // 
            this.btnPriori1.Location = new System.Drawing.Point(26, 363);
            this.btnPriori1.Name = "btnPriori1";
            this.btnPriori1.Size = new System.Drawing.Size(103, 42);
            this.btnPriori1.TabIndex = 0;
            this.btnPriori1.Text = "Prioridade 1";
            this.btnPriori1.UseVisualStyleBackColor = true;
            this.btnPriori1.Click += new System.EventHandler(this.btnPriori1_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Controls.Add(this.listBoxObjetos);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCenter.Location = new System.Drawing.Point(7, 7);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Padding = new System.Windows.Forms.Padding(8);
            this.panelCenter.Size = new System.Drawing.Size(419, 434);
            this.panelCenter.TabIndex = 4;
            // 
            // txtPercentual
            // 
            this.txtPercentual.FormattingEnabled = true;
            this.txtPercentual.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.txtPercentual.Location = new System.Drawing.Point(143, 111);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(56, 24);
            this.txtPercentual.TabIndex = 26;
            // 
            // userControlBtn
            // 
            this.userControlBtn.Location = new System.Drawing.Point(13, 326);
            this.userControlBtn.Name = "userControlBtn";
            this.userControlBtn.Size = new System.Drawing.Size(299, 89);
            this.userControlBtn.TabIndex = 23;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(26, 92);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(103, 42);
            this.btnTodos.TabIndex = 41;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.panelFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle Tarefas";
            this.panelFundo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxObjetos;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSemConcluir;
        private System.Windows.Forms.Button btnConcluida;
        private System.Windows.Forms.Button btnPriori3;
        private System.Windows.Forms.Button btnPriori2;
        private System.Windows.Forms.Button btnPriori1;
        private Shared.UserControlBtn userControlBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelPercentual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtPercentual;
        private System.Windows.Forms.Button btnTodos;
    }
}