
namespace eAgenda.WindowsFormsApp.Shared
{
    partial class UserControlBtn
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Image = global::eAgenda.WindowsFormsApp.Properties.Resources._32;
            this.btnLimpar.Location = new System.Drawing.Point(233, 13);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 76);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Clean";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeletar.Image = global::eAgenda.WindowsFormsApp.Properties.Resources.deletar_42;
            this.btnDeletar.Location = new System.Drawing.Point(159, 13);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(69, 76);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Delete";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Image = global::eAgenda.WindowsFormsApp.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(85, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 76);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Save";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.Image = global::eAgenda.WindowsFormsApp.Properties.Resources.file_add_114479__1_1;
            this.btnAdicionar.Location = new System.Drawing.Point(11, 13);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(69, 76);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Add";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // UserControlBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "UserControlBtn";
            this.Size = new System.Drawing.Size(313, 103);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAdicionar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnDeletar;
        public System.Windows.Forms.Button btnLimpar;
    }
}
