
namespace eAgenda.WindowsFormsApp.Shared
{
    partial class MenuForm
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listBoxObjetos = new System.Windows.Forms.ListBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.panelRight.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.btnCadastrar);
            this.panelRight.Controls.Add(this.groupBoxLista);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(275, 7);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20, 20, 20, 7);
            this.panelRight.Size = new System.Drawing.Size(735, 545);
            this.panelRight.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(598, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 67);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.listBoxObjetos);
            this.groupBoxLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxLista.Location = new System.Drawing.Point(20, 140);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Padding = new System.Windows.Forms.Padding(7, 3, 7, 0);
            this.groupBoxLista.Size = new System.Drawing.Size(693, 396);
            this.groupBoxLista.TabIndex = 0;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Preview";
            // 
            // listBoxObjetos
            // 
            this.listBoxObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxObjetos.FormattingEnabled = true;
            this.listBoxObjetos.ItemHeight = 16;
            this.listBoxObjetos.Location = new System.Drawing.Point(7, 18);
            this.listBoxObjetos.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxObjetos.Name = "listBoxObjetos";
            this.listBoxObjetos.Size = new System.Drawing.Size(679, 378);
            this.listBoxObjetos.TabIndex = 0;
            this.listBoxObjetos.SelectedIndexChanged += new System.EventHandler(this.listBoxObjetos_SelectedIndexChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.panelFooter);
            this.panelLeft.Controls.Add(this.btnTarefas);
            this.panelLeft.Controls.Add(this.btnContato);
            this.panelLeft.Controls.Add(this.btnCompromisso);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelLeft.Location = new System.Drawing.Point(7, 7);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10, 10, 10, 4);
            this.panelLeft.Size = new System.Drawing.Size(262, 545);
            this.panelLeft.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnConfig);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(10, 427);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelFooter.Size = new System.Drawing.Size(240, 112);
            this.panelFooter.TabIndex = 4;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.Location = new System.Drawing.Point(20, 54);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 48);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(13, 181);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(237, 65);
            this.btnTarefas.TabIndex = 2;
            this.btnTarefas.Text = "Controle Tarefas";
            this.btnTarefas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(13, 96);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(237, 65);
            this.btnContato.TabIndex = 1;
            this.btnContato.Text = "Controle Contato";
            this.btnContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Location = new System.Drawing.Point(13, 12);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(237, 65);
            this.btnCompromisso.TabIndex = 0;
            this.btnCompromisso.Text = "Controle Compromissos";
            this.btnCompromisso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompromisso.UseVisualStyleBackColor = true;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 559);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "MenuForm";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelRight.ResumeLayout(false);
            this.groupBoxLista.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.ListBox listBoxObjetos;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Button btnCadastrar;
    }
}