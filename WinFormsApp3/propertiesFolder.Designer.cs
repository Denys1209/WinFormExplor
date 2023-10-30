namespace WinFormsApp3
{
    partial class propertiesFolder
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(propertiesFolder));
            label1 = new Label();
            imageList1 = new ImageList(components);
            name = new TextBox();
            label2 = new Label();
            label5 = new Label();
            created = new Label();
            type = new Label();
            Ok = new Button();
            apply = new Button();
            label3 = new Label();
            label4 = new Label();
            location = new Label();
            loc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ImageIndex = 0;
            label1.ImageList = imageList1;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 79);
            label1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "3.png");
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(108, 34);
            name.Name = "name";
            name.Size = new Size(294, 29);
            name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 130);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 5;
            label5.Text = "Created:";
            // 
            // created
            // 
            created.AutoSize = true;
            created.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            created.Location = new Point(108, 130);
            created.Name = "created";
            created.Size = new Size(82, 25);
            created.TabIndex = 9;
            created.Text = "Created:";
            // 
            // type
            // 
            type.AutoSize = true;
            type.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            type.Location = new Point(108, 105);
            type.Name = "type";
            type.Size = new Size(55, 25);
            type.TabIndex = 6;
            type.Text = "Type:";
            // 
            // Ok
            // 
            Ok.Location = new Point(27, 183);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 10;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // apply
            // 
            apply.Location = new Point(108, 183);
            apply.Name = "apply";
            apply.Size = new Size(75, 23);
            apply.TabIndex = 11;
            apply.Text = "apply";
            apply.UseVisualStyleBackColor = true;
            apply.Click += apply_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 5;
            label3.Text = "Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(108, 130);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 9;
            label4.Text = "Created:";
            // 
            // location
            // 
            location.AutoSize = true;
            location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            location.Location = new Point(108, 155);
            location.Name = "location";
            location.Size = new Size(82, 25);
            location.TabIndex = 13;
            location.Text = "Created:";
            // 
            // loc
            // 
            loc.AutoSize = true;
            loc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loc.Location = new Point(12, 155);
            loc.Name = "loc";
            loc.Size = new Size(88, 25);
            loc.TabIndex = 12;
            loc.Text = "Location:";
            // 
            // propertiesFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 302);
            Controls.Add(location);
            Controls.Add(loc);
            Controls.Add(apply);
            Controls.Add(Ok);
            Controls.Add(label4);
            Controls.Add(created);
            Controls.Add(label3);
            Controls.Add(type);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "propertiesFolder";
            Text = "propertiesFolder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageList1;
        private TextBox name;
        private Label label2;
        private Label label5;
        private Label created;
        private Label type;
        private Button Ok;
        private Button apply;
        private Label label3;
        private Label label4;
        private Label location;
        private Label loc;
    }
}