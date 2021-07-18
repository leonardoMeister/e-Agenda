
namespace eAgenda.WindowsFormsApp.ContatoModule
{
    partial class FormContato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.listBoxObjetos = new System.Windows.Forms.ListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mkTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlBtn = new eAgenda.WindowsFormsApp.Shared.UserControlBtn();
            this.panel1.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTodos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(411, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(162, 450);
            this.panel1.TabIndex = 6;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(23, 98);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(121, 49);
            this.btnTodos.TabIndex = 40;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 39;
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
            this.panelCenter.Size = new System.Drawing.Size(411, 450);
            this.panelCenter.TabIndex = 7;
            // 
            // listBoxObjetos
            // 
            this.listBoxObjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxObjetos.FormattingEnabled = true;
            this.listBoxObjetos.ItemHeight = 16;
            this.listBoxObjetos.Location = new System.Drawing.Point(8, 8);
            this.listBoxObjetos.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxObjetos.Name = "listBoxObjetos";
            this.listBoxObjetos.Size = new System.Drawing.Size(393, 432);
            this.listBoxObjetos.TabIndex = 0;
            this.listBoxObjetos.SelectedIndexChanged += new System.EventHandler(this.listBoxObjetos_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 22);
            this.txtEmail.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(183, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTelefone
            // 
            this.labelTelefone.Location = new System.Drawing.Point(37, 143);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(101, 23);
            this.labelTelefone.TabIndex = 27;
            this.labelTelefone.Text = "Telefone";
            this.labelTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 22);
            this.txtNome.TabIndex = 21;
            // 
            // mkTelefone
            // 
            this.mkTelefone.Location = new System.Drawing.Point(142, 144);
            this.mkTelefone.Name = "mkTelefone";
            this.mkTelefone.Size = new System.Drawing.Size(164, 22);
            this.mkTelefone.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(242, 301);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(64, 22);
            this.txtId.TabIndex = 24;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.Location = new System.Drawing.Point(37, 199);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(101, 23);
            this.labelEmpresa.TabIndex = 29;
            this.labelEmpresa.Text = "Empresa";
            this.labelEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNome
            // 
            this.labelNome.Location = new System.Drawing.Point(34, 38);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(104, 23);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "Nome";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(142, 200);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(164, 22);
            this.txtEmpresa.TabIndex = 30;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(37, 89);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(101, 23);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCargo
            // 
            this.labelCargo.Location = new System.Drawing.Point(37, 251);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(101, 23);
            this.labelCargo.TabIndex = 32;
            this.labelCargo.Text = "Cargo";
            this.labelCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(142, 252);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(164, 22);
            this.txtCargo.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtCargo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelCargo);
            this.panel2.Controls.Add(this.labelTelefone);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.userControlBtn);
            this.panel2.Controls.Add(this.mkTelefone);
            this.panel2.Controls.Add(this.labelEmpresa);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Controls.Add(this.txtEmpresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(584, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 450);
            this.panel2.TabIndex = 8;
            // 
            // userControlBtn
            // 
            this.userControlBtn.Location = new System.Drawing.Point(12, 335);
            this.userControlBtn.Name = "userControlBtn";
            this.userControlBtn.Size = new System.Drawing.Size(303, 89);
            this.userControlBtn.TabIndex = 25;
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCenter);
            this.Name = "FormContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle Contatos";
            this.panel1.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ListBox listBoxObjetos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mkTelefone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label labelEmail;
        private Shared.UserControlBtn userControlBtn;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTodos;
    }
}