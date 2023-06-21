namespace MatrisApplication
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ny = new System.Windows.Forms.NumericUpDown();
            this.nx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWriteThird = new System.Windows.Forms.Button();
            this.btnAddMatris3 = new System.Windows.Forms.Button();
            this.btnWriteSecond = new System.Windows.Forms.Button();
            this.btnWriteFirst = new System.Windows.Forms.Button();
            this.btnAddMatris2 = new System.Windows.Forms.Button();
            this.btnAddMatris1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeterminant = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubstrac = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnMultiplyParameter = new System.Windows.Forms.Button();
            this.btnTranspoze = new System.Windows.Forms.Button();
            this.btnKofaktor = new System.Windows.Forms.Button();
            this.btnMinor = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nx)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(231, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 608);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 589);
            this.listBox1.TabIndex = 0;
            // 
            // ny
            // 
            this.ny.Location = new System.Drawing.Point(63, 15);
            this.ny.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ny.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ny.Name = "ny";
            this.ny.Size = new System.Drawing.Size(32, 20);
            this.ny.TabIndex = 2;
            this.ny.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nx
            // 
            this.nx.Location = new System.Drawing.Point(7, 15);
            this.nx.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nx.Name = "nx";
            this.nx.Size = new System.Drawing.Size(32, 20);
            this.nx.TabIndex = 1;
            this.nx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWriteThird);
            this.groupBox4.Controls.Add(this.btnAddMatris3);
            this.groupBox4.Controls.Add(this.btnWriteSecond);
            this.groupBox4.Controls.Add(this.btnWriteFirst);
            this.groupBox4.Controls.Add(this.btnAddMatris2);
            this.groupBox4.Controls.Add(this.btnAddMatris1);
            this.groupBox4.Location = new System.Drawing.Point(11, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 191);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // btnWriteThird
            // 
            this.btnWriteThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteThird.Location = new System.Drawing.Point(6, 157);
            this.btnWriteThird.Name = "btnWriteThird";
            this.btnWriteThird.Size = new System.Drawing.Size(202, 27);
            this.btnWriteThird.TabIndex = 36;
            this.btnWriteThird.Text = "WRITE THIRD MATRIS";
            this.btnWriteThird.UseVisualStyleBackColor = true;
            this.btnWriteThird.Click += new System.EventHandler(this.btnWriteThird_Click);
            // 
            // btnAddMatris3
            // 
            this.btnAddMatris3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMatris3.Location = new System.Drawing.Point(6, 70);
            this.btnAddMatris3.Name = "btnAddMatris3";
            this.btnAddMatris3.Size = new System.Drawing.Size(202, 27);
            this.btnAddMatris3.TabIndex = 35;
            this.btnAddMatris3.Text = "ADD MATRIS THIRD";
            this.btnAddMatris3.UseVisualStyleBackColor = true;
            this.btnAddMatris3.Click += new System.EventHandler(this.btnAddMatris3_Click);
            // 
            // btnWriteSecond
            // 
            this.btnWriteSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteSecond.Location = new System.Drawing.Point(6, 128);
            this.btnWriteSecond.Name = "btnWriteSecond";
            this.btnWriteSecond.Size = new System.Drawing.Size(202, 27);
            this.btnWriteSecond.TabIndex = 34;
            this.btnWriteSecond.Text = "WRITE SECOND MATRIS";
            this.btnWriteSecond.UseVisualStyleBackColor = true;
            this.btnWriteSecond.Click += new System.EventHandler(this.btnWriteSecond_Click);
            // 
            // btnWriteFirst
            // 
            this.btnWriteFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteFirst.Location = new System.Drawing.Point(6, 99);
            this.btnWriteFirst.Name = "btnWriteFirst";
            this.btnWriteFirst.Size = new System.Drawing.Size(202, 27);
            this.btnWriteFirst.TabIndex = 33;
            this.btnWriteFirst.Text = "WRITE FIRST MATRIS";
            this.btnWriteFirst.UseVisualStyleBackColor = true;
            this.btnWriteFirst.Click += new System.EventHandler(this.btnWriteFirst_Click);
            // 
            // btnAddMatris2
            // 
            this.btnAddMatris2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMatris2.Location = new System.Drawing.Point(6, 41);
            this.btnAddMatris2.Name = "btnAddMatris2";
            this.btnAddMatris2.Size = new System.Drawing.Size(202, 27);
            this.btnAddMatris2.TabIndex = 32;
            this.btnAddMatris2.Text = "ADD MATRIS SECOND";
            this.btnAddMatris2.UseVisualStyleBackColor = true;
            this.btnAddMatris2.Click += new System.EventHandler(this.btnAddMatris2_Click);
            // 
            // btnAddMatris1
            // 
            this.btnAddMatris1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMatris1.Location = new System.Drawing.Point(6, 12);
            this.btnAddMatris1.Name = "btnAddMatris1";
            this.btnAddMatris1.Size = new System.Drawing.Size(202, 27);
            this.btnAddMatris1.TabIndex = 31;
            this.btnAddMatris1.Text = "ADD MATRIS FIRST";
            this.btnAddMatris1.UseVisualStyleBackColor = true;
            this.btnAddMatris1.Click += new System.EventHandler(this.btnAddMatris1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.nx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ny);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 43);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(101, 13);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAbout.Location = new System.Drawing.Point(6, 12);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(55, 16);
            this.lblAbout.TabIndex = 38;
            this.lblAbout.Text = "Wait ...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 43);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(102, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 14);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeterminant);
            this.groupBox5.Controls.Add(this.btnMultiply);
            this.groupBox5.Controls.Add(this.btnSubstrac);
            this.groupBox5.Controls.Add(this.btnSum);
            this.groupBox5.Location = new System.Drawing.Point(11, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 149);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeterminant.Location = new System.Drawing.Point(6, 113);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(202, 31);
            this.btnDeterminant.TabIndex = 34;
            this.btnDeterminant.Text = "DETERMINANT";
            this.btnDeterminant.UseVisualStyleBackColor = true;
            this.btnDeterminant.Click += new System.EventHandler(this.btnDeterminant_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiply.Location = new System.Drawing.Point(6, 79);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(202, 31);
            this.btnMultiply.TabIndex = 33;
            this.btnMultiply.Text = "MULTIPLY";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubstrac
            // 
            this.btnSubstrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubstrac.Location = new System.Drawing.Point(6, 45);
            this.btnSubstrac.Name = "btnSubstrac";
            this.btnSubstrac.Size = new System.Drawing.Size(202, 31);
            this.btnSubstrac.TabIndex = 32;
            this.btnSubstrac.Text = "SUBTRAC";
            this.btnSubstrac.UseVisualStyleBackColor = true;
            this.btnSubstrac.Click += new System.EventHandler(this.btnSubstrac_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSum.Location = new System.Drawing.Point(6, 12);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(202, 31);
            this.btnSum.TabIndex = 31;
            this.btnSum.Text = "SUM";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblAbout);
            this.groupBox6.Location = new System.Drawing.Point(11, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 35);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnMultiplyParameter);
            this.groupBox7.Controls.Add(this.btnTranspoze);
            this.groupBox7.Controls.Add(this.btnKofaktor);
            this.groupBox7.Controls.Add(this.btnMinor);
            this.groupBox7.Location = new System.Drawing.Point(11, 462);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(214, 149);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            // 
            // btnMultiplyParameter
            // 
            this.btnMultiplyParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiplyParameter.Location = new System.Drawing.Point(6, 109);
            this.btnMultiplyParameter.Name = "btnMultiplyParameter";
            this.btnMultiplyParameter.Size = new System.Drawing.Size(202, 31);
            this.btnMultiplyParameter.TabIndex = 41;
            this.btnMultiplyParameter.Text = "MULTIPLY PARAMETER";
            this.btnMultiplyParameter.UseVisualStyleBackColor = true;
            this.btnMultiplyParameter.Click += new System.EventHandler(this.btnMultiplyParameter_Click);
            // 
            // btnTranspoze
            // 
            this.btnTranspoze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTranspoze.Location = new System.Drawing.Point(6, 76);
            this.btnTranspoze.Name = "btnTranspoze";
            this.btnTranspoze.Size = new System.Drawing.Size(202, 31);
            this.btnTranspoze.TabIndex = 38;
            this.btnTranspoze.Text = "TRANSPOZE";
            this.btnTranspoze.UseVisualStyleBackColor = true;
            this.btnTranspoze.Click += new System.EventHandler(this.btnTranspoze_Click);
            // 
            // btnKofaktor
            // 
            this.btnKofaktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKofaktor.Location = new System.Drawing.Point(6, 43);
            this.btnKofaktor.Name = "btnKofaktor";
            this.btnKofaktor.Size = new System.Drawing.Size(202, 31);
            this.btnKofaktor.TabIndex = 37;
            this.btnKofaktor.Text = "KOFAKTOR";
            this.btnKofaktor.UseVisualStyleBackColor = true;
            this.btnKofaktor.Click += new System.EventHandler(this.btnKofaktor_Click);
            // 
            // btnMinor
            // 
            this.btnMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinor.Location = new System.Drawing.Point(6, 10);
            this.btnMinor.Name = "btnMinor";
            this.btnMinor.Size = new System.Drawing.Size(202, 31);
            this.btnMinor.TabIndex = 36;
            this.btnMinor.Text = "MINOR";
            this.btnMinor.UseVisualStyleBackColor = true;
            this.btnMinor.Click += new System.EventHandler(this.btnMinor_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(580, 619);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matris Operations - C3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nx)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown ny;
        private System.Windows.Forms.NumericUpDown nx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWriteSecond;
        private System.Windows.Forms.Button btnWriteFirst;
        private System.Windows.Forms.Button btnAddMatris2;
        private System.Windows.Forms.Button btnAddMatris1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeterminant;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstrac;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnWriteThird;
        private System.Windows.Forms.Button btnAddMatris3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnTranspoze;
        private System.Windows.Forms.Button btnKofaktor;
        private System.Windows.Forms.Button btnMinor;
        private System.Windows.Forms.Button btnMultiplyParameter;
    }
}

