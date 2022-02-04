namespace CalculatorForm1
{
    partial class Calculator
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
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnTImes = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.ShowHistory = new System.Windows.Forms.RichTextBox();
            this.btnRemoveHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(11, 75);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(61, 36);
            this.btnSquareRoot.TabIndex = 0;
            this.btnSquareRoot.Text = "Sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(78, 75);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(61, 36);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(145, 75);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(61, 36);
            this.btnPower.TabIndex = 2;
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = true;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(212, 75);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(61, 36);
            this.btnReciprocal.TabIndex = 3;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Location = new System.Drawing.Point(11, 124);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(61, 36);
            this.btnClearEntry.TabIndex = 4;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(78, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(145, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Del.";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(212, 124);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(61, 36);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 174);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(61, 36);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.button_click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(78, 174);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(61, 36);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.button_click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(145, 174);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(61, 36);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.button_click);
            // 
            // btnTImes
            // 
            this.btnTImes.Location = new System.Drawing.Point(212, 174);
            this.btnTImes.Name = "btnTImes";
            this.btnTImes.Size = new System.Drawing.Size(61, 36);
            this.btnTImes.TabIndex = 11;
            this.btnTImes.Text = "X";
            this.btnTImes.UseVisualStyleBackColor = true;
            this.btnTImes.Click += new System.EventHandler(this.operator_click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 225);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(61, 36);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button_click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(78, 225);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(61, 36);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button_click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(145, 225);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(61, 36);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button_click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(212, 225);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(61, 36);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(11, 276);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(61, 36);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.button_click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(78, 276);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(61, 36);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.button_click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(145, 276);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(61, 36);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.button_click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(212, 276);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(61, 36);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(11, 331);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(61, 36);
            this.btnPlusMinus.TabIndex = 20;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(78, 329);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(61, 36);
            this.btnZero.TabIndex = 21;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.button_click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(145, 329);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(61, 36);
            this.btnPeriod.TabIndex = 22;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.button_click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(212, 329);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(61, 36);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 26);
            this.result.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(261, 33);
            this.result.TabIndex = 24;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.equation.Location = new System.Drawing.Point(21, 35);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 18);
            this.equation.TabIndex = 25;
            this.equation.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowHistory
            // 
            this.ShowHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowHistory.Location = new System.Drawing.Point(361, 124);
            this.ShowHistory.Name = "ShowHistory";
            this.ShowHistory.Size = new System.Drawing.Size(139, 241);
            this.ShowHistory.TabIndex = 26;
            this.ShowHistory.Text = "";
            // 
            // btnRemoveHistory
            // 
            this.btnRemoveHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveHistory.Font = new System.Drawing.Font("Wingdings 2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRemoveHistory.Location = new System.Drawing.Point(450, 371);
            this.btnRemoveHistory.Name = "btnRemoveHistory";
            this.btnRemoveHistory.Size = new System.Drawing.Size(75, 34);
            this.btnRemoveHistory.TabIndex = 27;
            this.btnRemoveHistory.Text = "";
            this.btnRemoveHistory.UseVisualStyleBackColor = false;
            this.btnRemoveHistory.Click += new System.EventHandler(this.btnRemoveHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "History";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(340, 75);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(149, 18);
            this.lblShow.TabIndex = 30;
            this.lblShow.Text = "There\'s no history yet";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 388);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveHistory);
            this.Controls.Add(this.ShowHistory);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnTImes);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSquareRoot);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnTImes;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.RichTextBox ShowHistory;
        private System.Windows.Forms.Button btnRemoveHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShow;
    }
}

