﻿
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnOpSum = new System.Windows.Forms.Button();
            this.btnOpRest = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnOpMult = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnOpDiv = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(16, 90);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(107, 98);
            this.btnNum7.TabIndex = 0;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(131, 90);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(107, 98);
            this.btnNum8.TabIndex = 1;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(245, 90);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(107, 98);
            this.btnNum9.TabIndex = 2;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpSum
            // 
            this.btnOpSum.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpSum.Location = new System.Drawing.Point(360, 90);
            this.btnOpSum.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpSum.Name = "btnOpSum";
            this.btnOpSum.Size = new System.Drawing.Size(107, 98);
            this.btnOpSum.TabIndex = 3;
            this.btnOpSum.Text = "+";
            this.btnOpSum.UseVisualStyleBackColor = false;
            this.btnOpSum.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnOpRest
            // 
            this.btnOpRest.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpRest.Location = new System.Drawing.Point(360, 196);
            this.btnOpRest.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpRest.Name = "btnOpRest";
            this.btnOpRest.Size = new System.Drawing.Size(107, 98);
            this.btnOpRest.TabIndex = 7;
            this.btnOpRest.Text = "-";
            this.btnOpRest.UseVisualStyleBackColor = false;
            this.btnOpRest.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(245, 196);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(107, 98);
            this.btnNum6.TabIndex = 6;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(131, 196);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(107, 98);
            this.btnNum5.TabIndex = 5;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(16, 196);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(107, 98);
            this.btnNum4.TabIndex = 4;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpMult
            // 
            this.btnOpMult.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpMult.Location = new System.Drawing.Point(360, 302);
            this.btnOpMult.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpMult.Name = "btnOpMult";
            this.btnOpMult.Size = new System.Drawing.Size(107, 98);
            this.btnOpMult.TabIndex = 11;
            this.btnOpMult.Text = "*";
            this.btnOpMult.UseVisualStyleBackColor = false;
            this.btnOpMult.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(245, 302);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(107, 98);
            this.btnNum3.TabIndex = 10;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(131, 302);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(107, 98);
            this.btnNum2.TabIndex = 9;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(16, 302);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(107, 98);
            this.btnNum1.TabIndex = 8;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpDiv
            // 
            this.btnOpDiv.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpDiv.Location = new System.Drawing.Point(360, 407);
            this.btnOpDiv.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpDiv.Name = "btnOpDiv";
            this.btnOpDiv.Size = new System.Drawing.Size(107, 98);
            this.btnOpDiv.TabIndex = 15;
            this.btnOpDiv.Text = "/";
            this.btnOpDiv.UseVisualStyleBackColor = false;
            this.btnOpDiv.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(246, 408);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(107, 98);
            this.btnEqual.TabIndex = 14;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(131, 407);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(107, 98);
            this.btnNum0.TabIndex = 13;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 407);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 98);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(16, 27);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(449, 41);
            this.txtValue.TabIndex = 16;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 554);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnOpDiv);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpMult);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnOpRest);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnOpSum);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnOpSum;
        private System.Windows.Forms.Button btnOpRest;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnOpMult;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnOpDiv;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtValue;
    }
}

