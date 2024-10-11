namespace projetoluiz
{
    partial class FormCriarproduto
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
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            InputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            buttonOk = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            Fabricante = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)InputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(132, 11);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(120, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(132, 35);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(120, 23);
            textBoxFabricante.TabIndex = 1;
            // 
            // InputPrecoCompra
            // 
            InputPrecoCompra.DecimalPlaces = 2;
            InputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            InputPrecoCompra.Location = new Point(132, 64);
            InputPrecoCompra.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            InputPrecoCompra.Name = "InputPrecoCompra";
            InputPrecoCompra.Size = new Size(120, 23);
            InputPrecoCompra.TabIndex = 2;
            InputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoVenda.Location = new Point(132, 93);
            inputPrecoVenda.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(120, 23);
            inputPrecoVenda.TabIndex = 3;
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(16, 122);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(177, 122);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome do produto";
            // 
            // Fabricante
            // 
            Fabricante.AutoSize = true;
            Fabricante.Location = new Point(16, 42);
            Fabricante.Name = "Fabricante";
            Fabricante.Size = new Size(62, 15);
            Fabricante.TabIndex = 7;
            Fabricante.Text = "Fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 8;
            label3.Text = "preço de Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 101);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 9;
            label4.Text = "Preco de venda";
            // 
            // FormCriarproduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(278, 175);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Fabricante);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(inputPrecoVenda);
            Controls.Add(InputPrecoCompra);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Name = "FormCriarproduto";
            Text = "FormCriarproduto";
            ((System.ComponentModel.ISupportInitialize)InputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private NumericUpDown InputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private Button buttonOk;
        private Button buttonCancelar;
        private Label label1;
        private Label Fabricante;
        private Label label3;
        private Label label4;
    }
}