namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelChooseObject = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelObjectValue = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxGuarantee = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxTech = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxTransmissionSpeed = new System.Windows.Forms.TextBox();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChooseObject
            // 
            this.labelChooseObject.AutoSize = true;
            this.labelChooseObject.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseObject.ForeColor = System.Drawing.Color.Snow;
            this.labelChooseObject.Location = new System.Drawing.Point(301, 52);
            this.labelChooseObject.Name = "labelChooseObject";
            this.labelChooseObject.Size = new System.Drawing.Size(186, 26);
            this.labelChooseObject.TabIndex = 0;
            this.labelChooseObject.Text = "Выберите объект";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(156, 282);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(485, 30);
            this.textBoxModel.TabIndex = 2;
            // 
            // labelObjectValue
            // 
            this.labelObjectValue.AutoSize = true;
            this.labelObjectValue.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectValue.ForeColor = System.Drawing.Color.Snow;
            this.labelObjectValue.Location = new System.Drawing.Point(251, 212);
            this.labelObjectValue.Name = "labelObjectValue";
            this.labelObjectValue.Size = new System.Drawing.Size(24, 26);
            this.labelObjectValue.TabIndex = 3;
            this.labelObjectValue.Text = "/";
            this.labelObjectValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Snow;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(315, 375);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 49);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Snow;
            this.labelError.Location = new System.Drawing.Point(279, 326);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(16, 17);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "/";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.UseMnemonic = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(156, 282);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(485, 30);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxGuarantee
            // 
            this.textBoxGuarantee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGuarantee.Location = new System.Drawing.Point(156, 282);
            this.textBoxGuarantee.Name = "textBoxGuarantee";
            this.textBoxGuarantee.Size = new System.Drawing.Size(485, 30);
            this.textBoxGuarantee.TabIndex = 7;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpeed.Location = new System.Drawing.Point(156, 282);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(485, 30);
            this.textBoxSpeed.TabIndex = 8;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVolume.Location = new System.Drawing.Point(156, 282);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(485, 30);
            this.textBoxVolume.TabIndex = 9;
            // 
            // textBoxTech
            // 
            this.textBoxTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTech.Location = new System.Drawing.Point(156, 282);
            this.textBoxTech.Name = "textBoxTech";
            this.textBoxTech.Size = new System.Drawing.Size(485, 30);
            this.textBoxTech.TabIndex = 10;
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMemory.Location = new System.Drawing.Point(156, 282);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(485, 30);
            this.textBoxMemory.TabIndex = 11;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(156, 282);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(485, 30);
            this.textBoxNumber.TabIndex = 12;
            // 
            // textBoxTransmissionSpeed
            // 
            this.textBoxTransmissionSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTransmissionSpeed.Location = new System.Drawing.Point(156, 282);
            this.textBoxTransmissionSpeed.Name = "textBoxTransmissionSpeed";
            this.textBoxTransmissionSpeed.Size = new System.Drawing.Size(485, 30);
            this.textBoxTransmissionSpeed.TabIndex = 13;
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Location = new System.Drawing.Point(156, 103);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(485, 33);
            this.comboBoxObject.TabIndex = 1;
            this.comboBoxObject.SelectedIndexChanged += new System.EventHandler(this.comboBoxObject_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Snow;
            this.label.Location = new System.Drawing.Point(349, 242);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 26);
            this.label.TabIndex = 14;
            this.label.Text = "/";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReturn.BackgroundImage")));
            this.buttonReturn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.Snow;
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.Location = new System.Drawing.Point(184, 260);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(425, 63);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Вернуться к выбору";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(321, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxTransmissionSpeed);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.textBoxTech);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxGuarantee);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelObjectValue);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboBoxObject);
            this.Controls.Add(this.labelChooseObject);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseObject;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelObjectValue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxGuarantee;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxTech;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxTransmissionSpeed;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label1;
    }
}