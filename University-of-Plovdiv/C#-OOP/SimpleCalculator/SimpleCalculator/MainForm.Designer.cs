using System.Windows.Forms;

namespace SimpleCalculator
{
    partial class MainForm
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
            this.number_1 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_7 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.operatorSubstraction = new System.Windows.Forms.Button();
            this.operatorDivision = new System.Windows.Forms.Button();
            this.number_0 = new System.Windows.Forms.Button();
            this.getResult = new System.Windows.Forms.Button();
            this.operatorMultiplication = new System.Windows.Forms.Button();
            this.decSeparator = new System.Windows.Forms.Button();
            this.operatorAddition = new System.Windows.Forms.Button();
            this.startBracket = new System.Windows.Forms.Button();
            this.endBracket = new System.Windows.Forms.Button();
            this.operatorPercent = new System.Windows.Forms.Button();
            this.memoryClear = new System.Windows.Forms.Button();
            this.memoryRecall = new System.Windows.Forms.Button();
            this.memoryAddition = new System.Windows.Forms.Button();
            this.memorySubstraction = new System.Windows.Forms.Button();
            this.memoryStore = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.historyClear = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.expression = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.RichTextBox();
            this.memory = new System.Windows.Forms.ListBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number_1
            // 
            this.number_1.BackColor = System.Drawing.Color.Gainsboro;
            this.number_1.FlatAppearance.BorderSize = 0;
            this.number_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_1.Location = new System.Drawing.Point(12, 478);
            this.number_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(95, 50);
            this.number_1.TabIndex = 2;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = false;
            this.number_1.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_2
            // 
            this.number_2.BackColor = System.Drawing.Color.Gainsboro;
            this.number_2.FlatAppearance.BorderSize = 0;
            this.number_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_2.Location = new System.Drawing.Point(115, 478);
            this.number_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(95, 50);
            this.number_2.TabIndex = 4;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = false;
            this.number_2.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_7
            // 
            this.number_7.BackColor = System.Drawing.Color.Gainsboro;
            this.number_7.FlatAppearance.BorderSize = 0;
            this.number_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_7.Location = new System.Drawing.Point(12, 366);
            this.number_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(95, 50);
            this.number_7.TabIndex = 5;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = false;
            this.number_7.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_4
            // 
            this.number_4.BackColor = System.Drawing.Color.Gainsboro;
            this.number_4.FlatAppearance.BorderSize = 0;
            this.number_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_4.Location = new System.Drawing.Point(12, 422);
            this.number_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(95, 50);
            this.number_4.TabIndex = 6;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = false;
            this.number_4.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_6
            // 
            this.number_6.BackColor = System.Drawing.Color.Gainsboro;
            this.number_6.FlatAppearance.BorderSize = 0;
            this.number_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_6.Location = new System.Drawing.Point(216, 422);
            this.number_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(95, 50);
            this.number_6.TabIndex = 7;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = false;
            this.number_6.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_3
            // 
            this.number_3.BackColor = System.Drawing.Color.Gainsboro;
            this.number_3.FlatAppearance.BorderSize = 0;
            this.number_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_3.Location = new System.Drawing.Point(216, 478);
            this.number_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(95, 50);
            this.number_3.TabIndex = 8;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = false;
            this.number_3.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_5
            // 
            this.number_5.BackColor = System.Drawing.Color.Gainsboro;
            this.number_5.FlatAppearance.BorderSize = 0;
            this.number_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_5.Location = new System.Drawing.Point(115, 422);
            this.number_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(95, 50);
            this.number_5.TabIndex = 9;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = false;
            this.number_5.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_8
            // 
            this.number_8.BackColor = System.Drawing.Color.Gainsboro;
            this.number_8.FlatAppearance.BorderSize = 0;
            this.number_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_8.Location = new System.Drawing.Point(115, 366);
            this.number_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(95, 50);
            this.number_8.TabIndex = 11;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = false;
            this.number_8.Click += new System.EventHandler(this.EnterNumber);
            // 
            // number_9
            // 
            this.number_9.BackColor = System.Drawing.Color.Gainsboro;
            this.number_9.FlatAppearance.BorderSize = 0;
            this.number_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_9.Location = new System.Drawing.Point(216, 366);
            this.number_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(95, 50);
            this.number_9.TabIndex = 12;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = false;
            this.number_9.Click += new System.EventHandler(this.EnterNumber);
            // 
            // operatorSubstraction
            // 
            this.operatorSubstraction.BackColor = System.Drawing.Color.DarkGray;
            this.operatorSubstraction.FlatAppearance.BorderSize = 0;
            this.operatorSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorSubstraction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operatorSubstraction.Location = new System.Drawing.Point(317, 422);
            this.operatorSubstraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorSubstraction.Name = "operatorSubstraction";
            this.operatorSubstraction.Size = new System.Drawing.Size(95, 50);
            this.operatorSubstraction.TabIndex = 14;
            this.operatorSubstraction.Text = "-";
            this.operatorSubstraction.UseVisualStyleBackColor = false;
            this.operatorSubstraction.Click += new System.EventHandler(this.EnterOperation);
            // 
            // operatorDivision
            // 
            this.operatorDivision.BackColor = System.Drawing.Color.DarkGray;
            this.operatorDivision.FlatAppearance.BorderSize = 0;
            this.operatorDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operatorDivision.Location = new System.Drawing.Point(317, 310);
            this.operatorDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorDivision.Name = "operatorDivision";
            this.operatorDivision.Size = new System.Drawing.Size(95, 50);
            this.operatorDivision.TabIndex = 15;
            this.operatorDivision.Text = "÷";
            this.operatorDivision.UseVisualStyleBackColor = false;
            this.operatorDivision.Click += new System.EventHandler(this.EnterOperation);
            // 
            // number_0
            // 
            this.number_0.BackColor = System.Drawing.Color.Gainsboro;
            this.number_0.FlatAppearance.BorderSize = 0;
            this.number_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number_0.Location = new System.Drawing.Point(115, 534);
            this.number_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(95, 50);
            this.number_0.TabIndex = 16;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = false;
            this.number_0.Click += new System.EventHandler(this.EnterNumber);
            // 
            // getResult
            // 
            this.getResult.BackColor = System.Drawing.Color.DodgerBlue;
            this.getResult.FlatAppearance.BorderSize = 0;
            this.getResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getResult.ForeColor = System.Drawing.Color.White;
            this.getResult.Location = new System.Drawing.Point(216, 534);
            this.getResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(196, 50);
            this.getResult.TabIndex = 17;
            this.getResult.Text = "=";
            this.getResult.UseVisualStyleBackColor = false;
            this.getResult.Click += new System.EventHandler(this.getResult_Click);
            // 
            // operatorMultiplication
            // 
            this.operatorMultiplication.BackColor = System.Drawing.Color.DarkGray;
            this.operatorMultiplication.FlatAppearance.BorderSize = 0;
            this.operatorMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorMultiplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operatorMultiplication.Location = new System.Drawing.Point(317, 366);
            this.operatorMultiplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorMultiplication.Name = "operatorMultiplication";
            this.operatorMultiplication.Size = new System.Drawing.Size(95, 50);
            this.operatorMultiplication.TabIndex = 18;
            this.operatorMultiplication.Text = "x";
            this.operatorMultiplication.UseVisualStyleBackColor = false;
            this.operatorMultiplication.Click += new System.EventHandler(this.EnterOperation);
            // 
            // decSeparator
            // 
            this.decSeparator.BackColor = System.Drawing.Color.Gainsboro;
            this.decSeparator.FlatAppearance.BorderSize = 0;
            this.decSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decSeparator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decSeparator.Location = new System.Drawing.Point(12, 534);
            this.decSeparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decSeparator.Name = "decSeparator";
            this.decSeparator.Size = new System.Drawing.Size(95, 50);
            this.decSeparator.TabIndex = 19;
            this.decSeparator.Text = ".";
            this.decSeparator.UseVisualStyleBackColor = false;
            this.decSeparator.Click += new System.EventHandler(this.decSeparator_Click);
            // 
            // operatorAddition
            // 
            this.operatorAddition.BackColor = System.Drawing.Color.DarkGray;
            this.operatorAddition.FlatAppearance.BorderSize = 0;
            this.operatorAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorAddition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operatorAddition.Location = new System.Drawing.Point(317, 478);
            this.operatorAddition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorAddition.Name = "operatorAddition";
            this.operatorAddition.Size = new System.Drawing.Size(95, 50);
            this.operatorAddition.TabIndex = 20;
            this.operatorAddition.Text = "+";
            this.operatorAddition.UseVisualStyleBackColor = false;
            this.operatorAddition.Click += new System.EventHandler(this.EnterOperation);
            // 
            // startBracket
            // 
            this.startBracket.BackColor = System.Drawing.Color.DarkGray;
            this.startBracket.FlatAppearance.BorderSize = 0;
            this.startBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBracket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBracket.Location = new System.Drawing.Point(12, 310);
            this.startBracket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBracket.Name = "startBracket";
            this.startBracket.Size = new System.Drawing.Size(95, 50);
            this.startBracket.TabIndex = 21;
            this.startBracket.Text = "(";
            this.startBracket.UseVisualStyleBackColor = false;
            this.startBracket.Click += new System.EventHandler(this.startingBracket_Click);
            // 
            // endBracket
            // 
            this.endBracket.BackColor = System.Drawing.Color.DarkGray;
            this.endBracket.FlatAppearance.BorderSize = 0;
            this.endBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endBracket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endBracket.Location = new System.Drawing.Point(115, 310);
            this.endBracket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endBracket.Name = "endBracket";
            this.endBracket.Size = new System.Drawing.Size(95, 50);
            this.endBracket.TabIndex = 22;
            this.endBracket.Text = ")";
            this.endBracket.UseVisualStyleBackColor = false;
            this.endBracket.Click += new System.EventHandler(this.endingBracket_Click);
            // 
            // operatorPercent
            // 
            this.operatorPercent.BackColor = System.Drawing.Color.DarkGray;
            this.operatorPercent.FlatAppearance.BorderSize = 0;
            this.operatorPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operatorPercent.Location = new System.Drawing.Point(216, 310);
            this.operatorPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operatorPercent.Name = "operatorPercent";
            this.operatorPercent.Size = new System.Drawing.Size(95, 50);
            this.operatorPercent.TabIndex = 23;
            this.operatorPercent.Text = "%";
            this.operatorPercent.UseVisualStyleBackColor = false;
            this.operatorPercent.Click += new System.EventHandler(this.EnterOperation);
            // 
            // memoryClear
            // 
            this.memoryClear.BackColor = System.Drawing.Color.Gainsboro;
            this.memoryClear.FlatAppearance.BorderSize = 0;
            this.memoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memoryClear.Location = new System.Drawing.Point(12, 218);
            this.memoryClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoryClear.Name = "memoryClear";
            this.memoryClear.Size = new System.Drawing.Size(75, 30);
            this.memoryClear.TabIndex = 24;
            this.memoryClear.Text = "MC";
            this.memoryClear.UseVisualStyleBackColor = false;
            this.memoryClear.Click += new System.EventHandler(this.memoryClear_Click);
            // 
            // memoryRecall
            // 
            this.memoryRecall.BackColor = System.Drawing.Color.Gainsboro;
            this.memoryRecall.FlatAppearance.BorderSize = 0;
            this.memoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryRecall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memoryRecall.Location = new System.Drawing.Point(93, 218);
            this.memoryRecall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoryRecall.Name = "memoryRecall";
            this.memoryRecall.Size = new System.Drawing.Size(75, 30);
            this.memoryRecall.TabIndex = 25;
            this.memoryRecall.Text = "MR";
            this.memoryRecall.UseVisualStyleBackColor = false;
            this.memoryRecall.Click += new System.EventHandler(this.memoryRecall_Click);
            // 
            // memoryAddition
            // 
            this.memoryAddition.BackColor = System.Drawing.Color.Gainsboro;
            this.memoryAddition.FlatAppearance.BorderSize = 0;
            this.memoryAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryAddition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memoryAddition.Location = new System.Drawing.Point(173, 218);
            this.memoryAddition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoryAddition.Name = "memoryAddition";
            this.memoryAddition.Size = new System.Drawing.Size(75, 30);
            this.memoryAddition.TabIndex = 26;
            this.memoryAddition.Text = "M+";
            this.memoryAddition.UseVisualStyleBackColor = false;
            this.memoryAddition.Click += new System.EventHandler(this.memoryAddition_Click);
            // 
            // memorySubstraction
            // 
            this.memorySubstraction.BackColor = System.Drawing.Color.Gainsboro;
            this.memorySubstraction.FlatAppearance.BorderSize = 0;
            this.memorySubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memorySubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorySubstraction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memorySubstraction.Location = new System.Drawing.Point(256, 218);
            this.memorySubstraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memorySubstraction.Name = "memorySubstraction";
            this.memorySubstraction.Size = new System.Drawing.Size(75, 30);
            this.memorySubstraction.TabIndex = 27;
            this.memorySubstraction.Text = "M-";
            this.memorySubstraction.UseVisualStyleBackColor = false;
            this.memorySubstraction.Click += new System.EventHandler(this.memorySubstraction_Click);
            // 
            // memoryStore
            // 
            this.memoryStore.BackColor = System.Drawing.Color.Gainsboro;
            this.memoryStore.FlatAppearance.BorderSize = 0;
            this.memoryStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryStore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memoryStore.Location = new System.Drawing.Point(337, 218);
            this.memoryStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoryStore.Name = "memoryStore";
            this.memoryStore.Size = new System.Drawing.Size(75, 30);
            this.memoryStore.TabIndex = 28;
            this.memoryStore.Text = "MS";
            this.memoryStore.UseVisualStyleBackColor = false;
            this.memoryStore.Click += new System.EventHandler(this.memoryStore_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.Color.Gainsboro;
            this.clearEntry.FlatAppearance.BorderSize = 0;
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearEntry.Location = new System.Drawing.Point(12, 254);
            this.clearEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(128, 50);
            this.clearEntry.TabIndex = 29;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.ClearEntry);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Gainsboro;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(148, 254);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(128, 50);
            this.clear.TabIndex = 30;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.Gainsboro;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backspace.Location = new System.Drawing.Point(284, 254);
            this.backspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(128, 50);
            this.backspace.TabIndex = 31;
            this.backspace.Tag = "";
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.ClearLast);
            // 
            // historyClear
            // 
            this.historyClear.FlatAppearance.BorderSize = 0;
            this.historyClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historyClear.Location = new System.Drawing.Point(899, 518);
            this.historyClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyClear.Name = "historyClear";
            this.historyClear.Size = new System.Drawing.Size(75, 66);
            this.historyClear.TabIndex = 32;
            this.historyClear.Text = "🗑";
            this.historyClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.historyClear.UseVisualStyleBackColor = false;
            this.historyClear.Click += new System.EventHandler(this.historyClear_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(12, 116);
            this.result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.result.Size = new System.Drawing.Size(400, 46);
            this.result.TabIndex = 33;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.WordWrap = false;
            // 
            // expression
            // 
            this.expression.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.expression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.expression.Location = new System.Drawing.Point(12, 33);
            this.expression.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expression.Multiline = true;
            this.expression.Name = "expression";
            this.expression.ReadOnly = true;
            this.expression.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.expression.Size = new System.Drawing.Size(400, 78);
            this.expression.TabIndex = 36;
            this.expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expression.WordWrap = false;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.history.Location = new System.Drawing.Point(747, 89);
            this.history.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(233, 414);
            this.history.TabIndex = 38;
            this.history.Text = "";
            // 
            // memory
            // 
            this.memory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.memory.FormattingEnabled = true;
            this.memory.ItemHeight = 29;
            this.memory.Location = new System.Drawing.Point(475, 89);
            this.memory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memory.Name = "memory";
            this.memory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.memory.Size = new System.Drawing.Size(233, 406);
            this.memory.TabIndex = 39;
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(468, 33);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(117, 31);
            this.memoryLabel.TabIndex = 40;
            this.memoryLabel.Text = "Memory";
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(740, 33);
            this.historyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(107, 31);
            this.historyLabel.TabIndex = 41;
            this.historyLabel.Text = "History";
            // 
            // MainForm
            // 
            this.AcceptButton = this.getResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(988, 602);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.history);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.result);
            this.Controls.Add(this.historyClear);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.memoryStore);
            this.Controls.Add(this.memorySubstraction);
            this.Controls.Add(this.memoryAddition);
            this.Controls.Add(this.memoryRecall);
            this.Controls.Add(this.memoryClear);
            this.Controls.Add(this.operatorPercent);
            this.Controls.Add(this.endBracket);
            this.Controls.Add(this.startBracket);
            this.Controls.Add(this.operatorAddition);
            this.Controls.Add(this.decSeparator);
            this.Controls.Add(this.operatorMultiplication);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.number_0);
            this.Controls.Add(this.operatorDivision);
            this.Controls.Add(this.operatorSubstraction);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_7);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_7;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button number_6;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_8;
        private System.Windows.Forms.Button number_9;
        private System.Windows.Forms.Button operatorSubstraction;
        private System.Windows.Forms.Button operatorDivision;
        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.Button operatorMultiplication;
        private System.Windows.Forms.Button decSeparator;
        private System.Windows.Forms.Button operatorAddition;
        private System.Windows.Forms.Button startBracket;
        private System.Windows.Forms.Button endBracket;
        private System.Windows.Forms.Button operatorPercent;
        private System.Windows.Forms.Button memoryClear;
        private System.Windows.Forms.Button memoryRecall;
        private System.Windows.Forms.Button memoryAddition;
        private System.Windows.Forms.Button memorySubstraction;
        private System.Windows.Forms.Button memoryStore;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button historyClear;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.RichTextBox history;
        private ListBox memory;
        private Label memoryLabel;
        private Label historyLabel;
    }
}

