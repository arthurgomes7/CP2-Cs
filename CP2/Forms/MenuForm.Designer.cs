namespace LojaInstrumentos.Forms
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnVenda = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(420, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menu Principal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnVenda
            //
            btnVenda.BackColor = Color.FromArgb(60, 90, 160);
            btnVenda.Cursor = Cursors.Hand;
            btnVenda.FlatStyle = FlatStyle.Flat;
            btnVenda.Font = new Font("Segoe UI", 12F);
            btnVenda.ForeColor = Color.White;
            btnVenda.Location = new Point(70, 90);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(280, 50);
            btnVenda.TabIndex = 1;
            btnVenda.Text = "Venda de Instrumentos";
            btnVenda.UseVisualStyleBackColor = false;
            btnVenda.Click += btnVenda_Click;
            //
            // btnRelatorio
            //
            btnRelatorio.BackColor = Color.FromArgb(60, 90, 160);
            btnRelatorio.Cursor = Cursors.Hand;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI", 12F);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(70, 160);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(280, 50);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatório de Vendas";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            //
            // btnSair
            //
            btnSair.BackColor = Color.FromArgb(200, 70, 70);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(70, 230);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(280, 50);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            //
            // MenuForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 250);
            ClientSize = new Size(420, 320);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnVenda);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal - Loja de Instrumentos";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnVenda;
        private Button btnRelatorio;
        private Button btnSair;
    }
}
