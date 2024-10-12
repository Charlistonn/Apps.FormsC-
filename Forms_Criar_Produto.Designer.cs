namespace aula_app.form
{
    partial class Forms_Criar_Produto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNome = new TextBox();
            TextBoxFabricante = new TextBox();
            inputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            Ok1 = new Button();
            Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(112, 48);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(112, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(112, 117);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "Preço de Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(112, 158);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Preço de Venda";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(246, 45);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // TextBoxFabricante
            // 
            TextBoxFabricante.Location = new Point(246, 80);
            TextBoxFabricante.Name = "TextBoxFabricante";
            TextBoxFabricante.Size = new Size(100, 23);
            TextBoxFabricante.TabIndex = 1;
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.ForeColor = Color.Blue;
            inputPrecoCompra.Location = new Point(246, 117);
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(120, 23);
            inputPrecoCompra.TabIndex = 2;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.ForeColor = Color.FromArgb(0, 0, 192);
            inputPrecoVenda.Location = new Point(246, 156);
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(120, 23);
            inputPrecoVenda.TabIndex = 2;
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // Ok1
            // 
            Ok1.BackColor = Color.Aqua;
            Ok1.Location = new Point(112, 209);
            Ok1.Name = "Ok1";
            Ok1.Size = new Size(75, 23);
            Ok1.TabIndex = 3;
            Ok1.Text = "Ok";
            Ok1.UseVisualStyleBackColor = false;
            Ok1.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Red;
            Cancel.ForeColor = SystemColors.ControlText;
            Cancel.Location = new Point(291, 209);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 3;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += button2_Click;
            // 
            // Forms_Criar_Produto
            // 
            AcceptButton = Ok1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Cancel;
            ClientSize = new Size(420, 265);
            Controls.Add(Cancel);
            Controls.Add(Ok1);
            Controls.Add(inputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(TextBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.HotTrack;
            Name = "Forms_Criar_Produto";
            Text = "Forms_Criar_Produto";
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNome;
        private TextBox TextBoxFabricante;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private Button Ok1;
        private Button Cancel;
    }
}