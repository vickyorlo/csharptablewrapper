namespace Table
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
            this.TableBox = new System.Windows.Forms.ListBox();
            this.AddInteger = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.InsertInteger = new System.Windows.Forms.NumericUpDown();
            this.InsertIndex = new System.Windows.Forms.NumericUpDown();
            this.InsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertInteger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // TableBox
            // 
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Location = new System.Drawing.Point(13, 13);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(120, 160);
            this.TableBox.TabIndex = 0;
            // 
            // AddInteger
            // 
            this.AddInteger.Location = new System.Drawing.Point(221, 13);
            this.AddInteger.Name = "AddInteger";
            this.AddInteger.Size = new System.Drawing.Size(120, 20);
            this.AddInteger.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(140, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add...";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertInteger
            // 
            this.InsertInteger.Location = new System.Drawing.Point(221, 42);
            this.InsertInteger.Name = "InsertInteger";
            this.InsertInteger.Size = new System.Drawing.Size(120, 20);
            this.InsertInteger.TabIndex = 3;
            // 
            // InsertIndex
            // 
            this.InsertIndex.Location = new System.Drawing.Point(221, 68);
            this.InsertIndex.Name = "InsertIndex";
            this.InsertIndex.Size = new System.Drawing.Size(120, 20);
            this.InsertIndex.TabIndex = 4;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(140, 42);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 47);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Put....\r\nIn index...";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 180);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.InsertIndex);
            this.Controls.Add(this.InsertInteger);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddInteger);
            this.Controls.Add(this.TableBox);
            this.Name = "Form1";
            this.Text = "List with events!";
            ((System.ComponentModel.ISupportInitialize)(this.AddInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertInteger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TableBox;
        private System.Windows.Forms.NumericUpDown AddInteger;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown InsertInteger;
        private System.Windows.Forms.NumericUpDown InsertIndex;
        private System.Windows.Forms.Button InsertButton;
    }
}

