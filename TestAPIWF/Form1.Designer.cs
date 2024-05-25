namespace TestAPIWF
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
            this.tbt_weight = new System.Windows.Forms.TextBox();
            this.tbt_height = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbt_weight
            // 
            this.tbt_weight.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_weight.Location = new System.Drawing.Point(217, 46);
            this.tbt_weight.Name = "tbt_weight";
            this.tbt_weight.Size = new System.Drawing.Size(557, 38);
            this.tbt_weight.TabIndex = 0;
            // 
            // tbt_height
            // 
            this.tbt_height.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_height.Location = new System.Drawing.Point(217, 113);
            this.tbt_height.Name = "tbt_height";
            this.tbt_height.Size = new System.Drawing.Size(557, 38);
            this.tbt_height.TabIndex = 1;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculate.Location = new System.Drawing.Point(218, 185);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(220, 50);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Tính BMI";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cân nặng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chiều cao";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_result.Location = new System.Drawing.Point(223, 275);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(92, 31);
            this.lb_result.TabIndex = 5;
            this.lb_result.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 324);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.tbt_height);
            this.Controls.Add(this.tbt_weight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_weight;
        private TextBox tbt_height;
        private Button btn_calculate;
        private Label label1;
        private Label label2;
        private Label lb_result;
    }
}