namespace PR_18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblResultPositive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckPositive = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblProductResult = new System.Windows.Forms.Label();
            this.btnCalculateDifference = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtArrayElements = new System.Windows.Forms.TextBox();
            this.lblArrayResult = new System.Windows.Forms.Label();
            this.btnReverseSubarray = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultDifference = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResultSumRange = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalculateSumRange = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblResultReverse = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(23, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 621);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtC);
            this.tabPage1.Controls.Add(this.lblResultPositive);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnCheckPositive);
            this.tabPage1.Controls.Add(this.txtA);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(247, 51);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 5;
            // 
            // lblResultPositive
            // 
            this.lblResultPositive.AutoSize = true;
            this.lblResultPositive.Location = new System.Drawing.Point(197, 161);
            this.lblResultPositive.Name = "lblResultPositive";
            this.lblResultPositive.Size = new System.Drawing.Size(0, 13);
            this.lblResultPositive.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(32, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Введите A";
            // 
            // btnCheckPositive
            // 
            this.btnCheckPositive.Location = new System.Drawing.Point(141, 102);
            this.btnCheckPositive.Name = "btnCheckPositive";
            this.btnCheckPositive.Size = new System.Drawing.Size(100, 23);
            this.btnCheckPositive.TabIndex = 6;
            this.btnCheckPositive.Text = "Проверить";
            this.btnCheckPositive.UseVisualStyleBackColor = true;
            this.btnCheckPositive.Click += new System.EventHandler(this.btnCheckPositive_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(35, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Введите B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Введите C";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(141, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblResultDifference);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblProductResult);
            this.tabPage2.Controls.Add(this.btnCalculateDifference);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtNumber);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblProductResult
            // 
            this.lblProductResult.AutoSize = true;
            this.lblProductResult.Location = new System.Drawing.Point(365, 275);
            this.lblProductResult.Name = "lblProductResult";
            this.lblProductResult.Size = new System.Drawing.Size(0, 13);
            this.lblProductResult.TabIndex = 11;
            // 
            // btnCalculateDifference
            // 
            this.btnCalculateDifference.Location = new System.Drawing.Point(44, 118);
            this.btnCalculateDifference.Name = "btnCalculateDifference";
            this.btnCalculateDifference.Size = new System.Drawing.Size(148, 23);
            this.btnCalculateDifference.TabIndex = 10;
            this.btnCalculateDifference.Text = "Вычислить разницу";
            this.btnCalculateDifference.UseVisualStyleBackColor = true;
            this.btnCalculateDifference.Click += new System.EventHandler(this.btnCalculateDifference_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Введите пятизначное число";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(44, 59);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(148, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.lblResultSumRange);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btnCalculateSumRange);
            this.tabPage3.Controls.Add(this.txtStart);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtEnd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1165, 595);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.lblResultReverse);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.txtArrayElements);
            this.tabPage4.Controls.Add(this.lblArrayResult);
            this.tabPage4.Controls.Add(this.btnReverseSubarray);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtArraySize);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1165, 595);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Задание 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(115, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Элементы массива (через пробел)";
            // 
            // txtArrayElements
            // 
            this.txtArrayElements.Location = new System.Drawing.Point(118, 35);
            this.txtArrayElements.Name = "txtArrayElements";
            this.txtArrayElements.Size = new System.Drawing.Size(622, 20);
            this.txtArrayElements.TabIndex = 8;
            // 
            // lblArrayResult
            // 
            this.lblArrayResult.AutoSize = true;
            this.lblArrayResult.Location = new System.Drawing.Point(218, 261);
            this.lblArrayResult.Name = "lblArrayResult";
            this.lblArrayResult.Size = new System.Drawing.Size(0, 13);
            this.lblArrayResult.TabIndex = 7;
            // 
            // btnReverseSubarray
            // 
            this.btnReverseSubarray.Location = new System.Drawing.Point(36, 87);
            this.btnReverseSubarray.Name = "btnReverseSubarray";
            this.btnReverseSubarray.Size = new System.Drawing.Size(159, 23);
            this.btnReverseSubarray.TabIndex = 6;
            this.btnReverseSubarray.Text = "Перевернуть подмассив";
            this.btnReverseSubarray.UseVisualStyleBackColor = true;
            this.btnReverseSubarray.Click += new System.EventHandler(this.btnReverseSubarray_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Размер массива";
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(22, 35);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(90, 20);
            this.txtArraySize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(138, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ответ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(814, 3);
            this.label2.MaximumSize = new System.Drawing.Size(350, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 85);
            this.label2.TabIndex = 9;
            this.label2.Text = "Задание:\r\n\r\nДаны три целых числа: A, B, C. Проверить истинность высказывания: «Ка" +
    "ждое из чисел A, B, C положительное».";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(814, 3);
            this.label3.MaximumSize = new System.Drawing.Size(350, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 85);
            this.label3.TabIndex = 12;
            this.label3.Text = "Задание:\r\n\r\nДано целое положительное пятизначное число N (N > 0). Найти разницу м" +
    "ежду суммой всех его цифр и произведением четных цифр.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(44, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ответ:";
            // 
            // lblResultDifference
            // 
            this.lblResultDifference.AutoSize = true;
            this.lblResultDifference.Location = new System.Drawing.Point(103, 159);
            this.lblResultDifference.Name = "lblResultDifference";
            this.lblResultDifference.Size = new System.Drawing.Size(0, 13);
            this.lblResultDifference.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Location = new System.Drawing.Point(73, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ответ:";
            // 
            // lblResultSumRange
            // 
            this.lblResultSumRange.AutoSize = true;
            this.lblResultSumRange.Location = new System.Drawing.Point(132, 148);
            this.lblResultSumRange.Name = "lblResultSumRange";
            this.lblResultSumRange.Size = new System.Drawing.Size(0, 13);
            this.lblResultSumRange.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Location = new System.Drawing.Point(27, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Начало диапазона";
            // 
            // btnCalculateSumRange
            // 
            this.btnCalculateSumRange.Location = new System.Drawing.Point(30, 95);
            this.btnCalculateSumRange.Name = "btnCalculateSumRange";
            this.btnCalculateSumRange.Size = new System.Drawing.Size(206, 23);
            this.btnCalculateSumRange.TabIndex = 13;
            this.btnCalculateSumRange.Text = "Вычислить сумму";
            this.btnCalculateSumRange.UseVisualStyleBackColor = true;
            this.btnCalculateSumRange.Click += new System.EventHandler(this.btnCalculateSumRange_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(30, 46);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Конец диапазона";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(136, 46);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(817, 3);
            this.label10.MaximumSize = new System.Drawing.Size(350, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 119);
            this.label10.TabIndex = 16;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(815, 3);
            this.label13.MaximumSize = new System.Drawing.Size(350, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(349, 119);
            this.label13.TabIndex = 19;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(54, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ответ:";
            // 
            // lblResultReverse
            // 
            this.lblResultReverse.AutoSize = true;
            this.lblResultReverse.Location = new System.Drawing.Point(113, 130);
            this.lblResultReverse.Name = "lblResultReverse";
            this.lblResultReverse.Size = new System.Drawing.Size(0, 13);
            this.lblResultReverse.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 664);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblResultPositive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckPositive;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblProductResult;
        private System.Windows.Forms.Button btnCalculateDifference;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtArrayElements;
        private System.Windows.Forms.Label lblArrayResult;
        private System.Windows.Forms.Button btnReverseSubarray;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultDifference;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResultSumRange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalculateSumRange;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblResultReverse;
    }
}

