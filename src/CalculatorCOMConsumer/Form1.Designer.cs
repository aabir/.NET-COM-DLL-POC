namespace CalculatorCOMConsumer
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
            this.textVal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textVal2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textSumVal = new System.Windows.Forms.TextBox();
            this.buttonGenJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textVal1
            // 
            this.textVal1.Location = new System.Drawing.Point(206, 81);
            this.textVal1.Name = "textVal1";
            this.textVal1.Size = new System.Drawing.Size(125, 27);
            this.textVal1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number";
            // 
            // textVal2
            // 
            this.textVal2.Location = new System.Drawing.Point(207, 116);
            this.textVal2.Name = "textVal2";
            this.textVal2.Size = new System.Drawing.Size(124, 27);
            this.textVal2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sum Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSumVal
            // 
            this.textSumVal.Location = new System.Drawing.Point(206, 162);
            this.textSumVal.Name = "textSumVal";
            this.textSumVal.Size = new System.Drawing.Size(125, 27);
            this.textSumVal.TabIndex = 5;
            // 
            // buttonGenJson
            // 
            this.buttonGenJson.Location = new System.Drawing.Point(391, 83);
            this.buttonGenJson.Name = "buttonGenJson";
            this.buttonGenJson.Size = new System.Drawing.Size(202, 30);
            this.buttonGenJson.TabIndex = 6;
            this.buttonGenJson.Text = "Generate JSON";
            this.buttonGenJson.UseVisualStyleBackColor = true;
            this.buttonGenJson.Click += new System.EventHandler(this.buttonGenJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGenJson);
            this.Controls.Add(this.textSumVal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textVal2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textVal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textVal1;
        private Label label1;
        private Label label2;
        private TextBox textVal2;
        private Button button1;
        private TextBox textSumVal;
        private Button buttonGenJson;
    }
}