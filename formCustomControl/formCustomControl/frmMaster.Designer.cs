
namespace formCustomControl
{
  partial class frmMaster
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
      this.pnlContainer = new System.Windows.Forms.Panel();
      this.btn1 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // pnlContainer
      // 
      this.pnlContainer.Location = new System.Drawing.Point(12, 100);
      this.pnlContainer.Name = "pnlContainer";
      this.pnlContainer.Size = new System.Drawing.Size(547, 338);
      this.pnlContainer.TabIndex = 0;
      // 
      // btn1
      // 
      this.btn1.Location = new System.Drawing.Point(12, 35);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(72, 59);
      this.btn1.TabIndex = 1;
      this.btn1.Text = "Custom 1";
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Click += new System.EventHandler(this.btnClick);
      // 
      // btn2
      // 
      this.btn2.Location = new System.Drawing.Point(90, 35);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(72, 59);
      this.btn2.TabIndex = 1;
      this.btn2.Text = "Custom 2";
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.btnClick);
      // 
      // btn3
      // 
      this.btn3.Location = new System.Drawing.Point(168, 35);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(72, 59);
      this.btn3.TabIndex = 1;
      this.btn3.Text = "Custom 3";
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Click += new System.EventHandler(this.btnClick);
      // 
      // frmMaster
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(571, 450);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.pnlContainer);
      this.Name = "frmMaster";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlContainer;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
  }
}

