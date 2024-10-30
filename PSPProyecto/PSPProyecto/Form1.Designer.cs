namespace PSPProyecto
{
    partial class frmEmployee
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
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttUpdate = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttINew = new System.Windows.Forms.Button();
            this.bttLoad = new System.Windows.Forms.Button();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.pctPhoto);
            this.grpPersonalData.Controls.Add(this.bttLoad);
            this.grpPersonalData.Controls.Add(this.bttINew);
            this.grpPersonalData.Controls.Add(this.bttCancel);
            this.grpPersonalData.Controls.Add(this.bttDelete);
            this.grpPersonalData.Controls.Add(this.bttSave);
            this.grpPersonalData.Controls.Add(this.bttUpdate);
            this.grpPersonalData.Controls.Add(this.txtAddress);
            this.grpPersonalData.Controls.Add(this.lblAddress);
            this.grpPersonalData.Controls.Add(this.txtPhoneNumber);
            this.grpPersonalData.Controls.Add(this.lblPhoneNumber);
            this.grpPersonalData.Controls.Add(this.txtEmail);
            this.grpPersonalData.Controls.Add(this.lblEmail);
            this.grpPersonalData.Controls.Add(this.txtLastName);
            this.grpPersonalData.Controls.Add(this.lblLastName);
            this.grpPersonalData.Controls.Add(this.txtName);
            this.grpPersonalData.Controls.Add(this.lblName);
            this.grpPersonalData.Location = new System.Drawing.Point(12, 12);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(375, 262);
            this.grpPersonalData.TabIndex = 0;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Datos personales";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(89, 49);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(280, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellidos";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(89, 105);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(280, 22);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 111);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(61, 16);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Teléfono";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 133);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(280, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 16);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Dirección";
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(213, 161);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 10;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            // 
            // bttUpdate
            // 
            this.bttUpdate.Location = new System.Drawing.Point(294, 161);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(75, 23);
            this.bttUpdate.TabIndex = 11;
            this.bttUpdate.Text = "Modificar";
            this.bttUpdate.UseVisualStyleBackColor = true;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(213, 190);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 12;
            this.bttDelete.Text = "Eliminar";
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(294, 190);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 13;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // bttINew
            // 
            this.bttINew.Location = new System.Drawing.Point(132, 161);
            this.bttINew.Name = "bttINew";
            this.bttINew.Size = new System.Drawing.Size(75, 23);
            this.bttINew.TabIndex = 14;
            this.bttINew.Text = "Nuevo";
            this.bttINew.UseVisualStyleBackColor = true;
            // 
            // bttLoad
            // 
            this.bttLoad.Location = new System.Drawing.Point(132, 190);
            this.bttLoad.Name = "bttLoad";
            this.bttLoad.Size = new System.Drawing.Size(75, 23);
            this.bttLoad.TabIndex = 15;
            this.bttLoad.Text = "Cargar";
            this.bttLoad.UseVisualStyleBackColor = true;
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(0, 161);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(100, 95);
            this.pctPhoto.TabIndex = 16;
            this.pctPhoto.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 343);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(48, 351);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 532);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grpPersonalData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEmployee";
            this.Text = "Empleados";
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button bttINew;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttUpdate;
        private System.Windows.Forms.PictureBox pctPhoto;
        private System.Windows.Forms.Button bttLoad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

