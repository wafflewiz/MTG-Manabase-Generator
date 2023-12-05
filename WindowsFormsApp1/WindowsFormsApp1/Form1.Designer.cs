namespace WindowsFormsApp1
{
    partial class manaBaseGeneratorEDH
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.blackCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            this.whiteCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.redRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.blackRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.blueRadioBtn3 = new System.Windows.Forms.RadioButton();
            this.whiteRadioBtn4 = new System.Windows.Forms.RadioButton();
            this.greenRadioBtn5 = new System.Windows.Forms.RadioButton();
            this.radioBtnLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(354, 425);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(219, 46);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.Text = "Generate My Mana Base!";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Location = new System.Drawing.Point(35, 174);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(55, 20);
            this.redCheckBox.TabIndex = 2;
            this.redCheckBox.Text = "Red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            // 
            // blackCheckBox
            // 
            this.blackCheckBox.AutoSize = true;
            this.blackCheckBox.Location = new System.Drawing.Point(144, 174);
            this.blackCheckBox.Name = "blackCheckBox";
            this.blackCheckBox.Size = new System.Drawing.Size(63, 20);
            this.blackCheckBox.TabIndex = 3;
            this.blackCheckBox.Text = "Black";
            this.blackCheckBox.UseVisualStyleBackColor = true;
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Location = new System.Drawing.Point(252, 174);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(56, 20);
            this.blueCheckBox.TabIndex = 4;
            this.blueCheckBox.Text = "Blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            // 
            // whiteCheckBox
            // 
            this.whiteCheckBox.AutoSize = true;
            this.whiteCheckBox.Location = new System.Drawing.Point(383, 174);
            this.whiteCheckBox.Name = "whiteCheckBox";
            this.whiteCheckBox.Size = new System.Drawing.Size(63, 20);
            this.whiteCheckBox.TabIndex = 5;
            this.whiteCheckBox.Text = "White";
            this.whiteCheckBox.UseVisualStyleBackColor = true;
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.Location = new System.Drawing.Point(519, 174);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Size = new System.Drawing.Size(66, 20);
            this.greenCheckBox.TabIndex = 6;
            this.greenCheckBox.Text = "Green";
            this.greenCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(684, 492);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(134, 44);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(93, 492);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(190, 46);
            this.saveToFileBtn.TabIndex = 9;
            this.saveToFileBtn.Text = "Save Results to File!";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            this.saveToFileBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pull Results from File!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redRadioBtn1
            // 
            this.redRadioBtn1.AutoSize = true;
            this.redRadioBtn1.Location = new System.Drawing.Point(35, 79);
            this.redRadioBtn1.Name = "redRadioBtn1";
            this.redRadioBtn1.Size = new System.Drawing.Size(54, 20);
            this.redRadioBtn1.TabIndex = 11;
            this.redRadioBtn1.TabStop = true;
            this.redRadioBtn1.Text = "Red";
            this.redRadioBtn1.UseVisualStyleBackColor = true;
            this.redRadioBtn1.CheckedChanged += new System.EventHandler(this.redRadioBtn_CheckedChanged);
            // 
            // blackRadioBtn2
            // 
            this.blackRadioBtn2.AutoSize = true;
            this.blackRadioBtn2.Location = new System.Drawing.Point(144, 79);
            this.blackRadioBtn2.Name = "blackRadioBtn2";
            this.blackRadioBtn2.Size = new System.Drawing.Size(62, 20);
            this.blackRadioBtn2.TabIndex = 12;
            this.blackRadioBtn2.TabStop = true;
            this.blackRadioBtn2.Text = "Black";
            this.blackRadioBtn2.UseVisualStyleBackColor = true;
            this.blackRadioBtn2.CheckedChanged += new System.EventHandler(this.blackRadioBtn_CheckedChanged);
            // 
            // blueRadioBtn3
            // 
            this.blueRadioBtn3.AutoSize = true;
            this.blueRadioBtn3.Location = new System.Drawing.Point(252, 79);
            this.blueRadioBtn3.Name = "blueRadioBtn3";
            this.blueRadioBtn3.Size = new System.Drawing.Size(55, 20);
            this.blueRadioBtn3.TabIndex = 13;
            this.blueRadioBtn3.TabStop = true;
            this.blueRadioBtn3.Text = "Blue";
            this.blueRadioBtn3.UseVisualStyleBackColor = true;
            this.blueRadioBtn3.CheckedChanged += new System.EventHandler(this.blueRadioBtn_CheckedChanged);
            // 
            // whiteRadioBtn4
            // 
            this.whiteRadioBtn4.AutoSize = true;
            this.whiteRadioBtn4.Location = new System.Drawing.Point(383, 79);
            this.whiteRadioBtn4.Name = "whiteRadioBtn4";
            this.whiteRadioBtn4.Size = new System.Drawing.Size(62, 20);
            this.whiteRadioBtn4.TabIndex = 14;
            this.whiteRadioBtn4.TabStop = true;
            this.whiteRadioBtn4.Text = "White";
            this.whiteRadioBtn4.UseVisualStyleBackColor = true;
            this.whiteRadioBtn4.CheckedChanged += new System.EventHandler(this.whiteRadioBtn_CheckedChanged);
            // 
            // greenRadioBtn5
            // 
            this.greenRadioBtn5.AutoSize = true;
            this.greenRadioBtn5.Location = new System.Drawing.Point(520, 79);
            this.greenRadioBtn5.Name = "greenRadioBtn5";
            this.greenRadioBtn5.Size = new System.Drawing.Size(65, 20);
            this.greenRadioBtn5.TabIndex = 15;
            this.greenRadioBtn5.TabStop = true;
            this.greenRadioBtn5.Text = "Green";
            this.greenRadioBtn5.UseVisualStyleBackColor = true;
            this.greenRadioBtn5.CheckedChanged += new System.EventHandler(this.greenRadioBtn_CheckedChanged);
            // 
            // radioBtnLabel
            // 
            this.radioBtnLabel.AutoSize = true;
            this.radioBtnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnLabel.Location = new System.Drawing.Point(31, 25);
            this.radioBtnLabel.Name = "radioBtnLabel";
            this.radioBtnLabel.Size = new System.Drawing.Size(423, 20);
            this.radioBtnLabel.TabIndex = 16;
            this.radioBtnLabel.Text = "Please select the main color for your mana base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select any additional colors you\'d like to run in your deck:";
            // 
            // manaBaseGeneratorEDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnLabel);
            this.Controls.Add(this.greenRadioBtn5);
            this.Controls.Add(this.whiteRadioBtn4);
            this.Controls.Add(this.blueRadioBtn3);
            this.Controls.Add(this.blackRadioBtn2);
            this.Controls.Add(this.redRadioBtn1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveToFileBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenCheckBox);
            this.Controls.Add(this.whiteCheckBox);
            this.Controls.Add(this.blueCheckBox);
            this.Controls.Add(this.blackCheckBox);
            this.Controls.Add(this.redCheckBox);
            this.Controls.Add(this.calculateBtn);
            this.Name = "manaBaseGeneratorEDH";
            this.Text = "Rami A - MTG Commander Mana Base Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox blackCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
        private System.Windows.Forms.CheckBox whiteCheckBox;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton redRadioBtn1;
        private System.Windows.Forms.RadioButton blackRadioBtn2;
        private System.Windows.Forms.RadioButton blueRadioBtn3;
        private System.Windows.Forms.RadioButton whiteRadioBtn4;
        private System.Windows.Forms.RadioButton greenRadioBtn5;
        private System.Windows.Forms.Label radioBtnLabel;
        private System.Windows.Forms.Label label2;
    }
}

