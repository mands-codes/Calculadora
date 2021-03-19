
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRaizQuadrada = new System.Windows.Forms.Button();
            this.buttonDeletaDigito = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonDig9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxHistorico = new System.Windows.Forms.TextBox();
            this.textBoxValorAtual = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRaizQuadrada
            // 
            this.buttonRaizQuadrada.BackColor = System.Drawing.Color.White;
            this.buttonRaizQuadrada.FlatAppearance.BorderSize = 0;
            this.buttonRaizQuadrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRaizQuadrada.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRaizQuadrada.Location = new System.Drawing.Point(12, 77);
            this.buttonRaizQuadrada.Name = "buttonRaizQuadrada";
            this.buttonRaizQuadrada.Size = new System.Drawing.Size(40, 40);
            this.buttonRaizQuadrada.TabIndex = 2;
            this.buttonRaizQuadrada.Tag = "sqrt";
            this.buttonRaizQuadrada.Text = "√";
            this.buttonRaizQuadrada.UseVisualStyleBackColor = false;
            this.buttonRaizQuadrada.Click += new System.EventHandler(this.buttonRaizQuadrada_Click);
            // 
            // buttonDeletaDigito
            // 
            this.buttonDeletaDigito.BackColor = System.Drawing.Color.White;
            this.buttonDeletaDigito.FlatAppearance.BorderSize = 0;
            this.buttonDeletaDigito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletaDigito.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeletaDigito.Location = new System.Drawing.Point(104, 77);
            this.buttonDeletaDigito.Name = "buttonDeletaDigito";
            this.buttonDeletaDigito.Size = new System.Drawing.Size(40, 40);
            this.buttonDeletaDigito.TabIndex = 3;
            this.buttonDeletaDigito.Text = "←";
            this.buttonDeletaDigito.UseVisualStyleBackColor = false;
            this.buttonDeletaDigito.Click += new System.EventHandler(this.buttonDeletaDigito_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Location = new System.Drawing.Point(58, 77);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(40, 40);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "C";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FloralWhite;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(150, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 5;
            this.button6.Tag = "×";
            this.button6.Text = "×";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonEscolherOperação);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(12, 123);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(58, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // buttonDig9
            // 
            this.buttonDig9.BackColor = System.Drawing.Color.White;
            this.buttonDig9.FlatAppearance.BorderSize = 0;
            this.buttonDig9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDig9.Location = new System.Drawing.Point(104, 123);
            this.buttonDig9.Name = "buttonDig9";
            this.buttonDig9.Size = new System.Drawing.Size(40, 40);
            this.buttonDig9.TabIndex = 9;
            this.buttonDig9.Tag = "9";
            this.buttonDig9.Text = "9";
            this.buttonDig9.UseVisualStyleBackColor = false;
            this.buttonDig9.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(150, 123);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 10;
            this.button10.Tag = "÷";
            this.button10.Text = "÷";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttonEscolherOperação);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(12, 169);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 6;
            this.button12.Tag = "4";
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(58, 169);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 13;
            this.button13.Tag = "5";
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(104, 169);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 40);
            this.button14.TabIndex = 12;
            this.button14.Tag = "6";
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(150, 169);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 40);
            this.button15.TabIndex = 14;
            this.button15.Tag = "-";
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.buttonEscolherOperação);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(12, 215);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(40, 40);
            this.button17.TabIndex = 15;
            this.button17.Tag = "1";
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(58, 215);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 40);
            this.button18.TabIndex = 18;
            this.button18.Tag = "2";
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(104, 215);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 40);
            this.button19.TabIndex = 17;
            this.button19.Tag = "3";
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // buttonSomar
            // 
            this.buttonSomar.BackColor = System.Drawing.Color.White;
            this.buttonSomar.FlatAppearance.BorderSize = 0;
            this.buttonSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSomar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSomar.Location = new System.Drawing.Point(150, 215);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(40, 40);
            this.buttonSomar.TabIndex = 19;
            this.buttonSomar.Tag = "+";
            this.buttonSomar.Text = "+";
            this.buttonSomar.UseVisualStyleBackColor = false;
            this.buttonSomar.Click += new System.EventHandler(this.buttonEscolherOperação);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(12, 261);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 40);
            this.button22.TabIndex = 20;
            this.button22.Tag = "";
            this.button22.Text = "±";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(58, 261);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 40);
            this.button23.TabIndex = 23;
            this.button23.Tag = "0";
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.buttonDig_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(104, 261);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(40, 40);
            this.button24.TabIndex = 22;
            this.button24.Tag = "";
            this.button24.Text = ",";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.Firebrick;
            this.buttonIgual.FlatAppearance.BorderSize = 0;
            this.buttonIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgual.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIgual.Location = new System.Drawing.Point(150, 261);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(40, 40);
            this.buttonIgual.TabIndex = 24;
            this.buttonIgual.Tag = "=";
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.textBoxHistorico);
            this.panel1.Controls.Add(this.textBoxValorAtual);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 59);
            this.panel1.TabIndex = 25;
            // 
            // textBoxHistorico
            // 
            this.textBoxHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHistorico.Location = new System.Drawing.Point(0, 1);
            this.textBoxHistorico.Name = "textBoxHistorico";
            this.textBoxHistorico.Size = new System.Drawing.Size(178, 22);
            this.textBoxHistorico.TabIndex = 2;
            this.textBoxHistorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxValorAtual
            // 
            this.textBoxValorAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorAtual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxValorAtual.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValorAtual.Location = new System.Drawing.Point(0, 23);
            this.textBoxValorAtual.Name = "textBoxValorAtual";
            this.textBoxValorAtual.Size = new System.Drawing.Size(178, 36);
            this.textBoxValorAtual.TabIndex = 1;
            this.textBoxValorAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(207, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRaizQuadrada);
            this.Controls.Add(this.buttonDeletaDigito);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.buttonDig9);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRaizQuadrada;
        private System.Windows.Forms.Button buttonDeletaDigito;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonDig9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxValorAtual;
        private System.Windows.Forms.TextBox textBoxHistorico;
    }
}

