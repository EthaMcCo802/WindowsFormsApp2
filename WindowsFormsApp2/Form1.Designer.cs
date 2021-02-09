
namespace WindowsFormsApp2
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
            this.Username = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.Label();
            this.Usernameinput = new System.Windows.Forms.TextBox();
            this.pinInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(154, 285);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(153, 32);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // pin
            // 
            this.pin.AutoSize = true;
            this.pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.Location = new System.Drawing.Point(238, 362);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(69, 32);
            this.pin.TabIndex = 1;
            this.pin.Text = "PIN:";
            this.pin.Click += new System.EventHandler(this.pin_Click);
            // 
            // Usernameinput
            // 
            this.Usernameinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernameinput.Location = new System.Drawing.Point(313, 285);
            this.Usernameinput.Name = "Usernameinput";
            this.Usernameinput.Size = new System.Drawing.Size(201, 38);
            this.Usernameinput.TabIndex = 2;
            this.Usernameinput.TextChanged += new System.EventHandler(this.Usernameinput_TextChanged);
            // 
            // pinInput
            // 
            this.pinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinInput.Location = new System.Drawing.Point(313, 359);
            this.pinInput.Name = "pinInput";
            this.pinInput.Size = new System.Drawing.Size(201, 38);
            this.pinInput.TabIndex = 3;
            this.pinInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Login";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(313, 447);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(113, 58);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(172, 152);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(415, 32);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "Please enter your user and PIN.";
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(313, 523);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(113, 58);
            this.adminButton.TabIndex = 10;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 792);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pinInput);
            this.Controls.Add(this.Usernameinput);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label pin;
        private System.Windows.Forms.TextBox Usernameinput;
        private System.Windows.Forms.TextBox pinInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button adminButton;
    }
}

