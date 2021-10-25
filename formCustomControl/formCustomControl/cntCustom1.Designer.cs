
namespace formCustomControl
{
  partial class cntCustom1
  {
    /// <summary> 
    /// Variabile di progettazione necessaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Pulire le risorse in uso.
    /// </summary>
    /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Codice generato da Progettazione componenti

    /// <summary> 
    /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
    /// il contenuto del metodo con l'editor di codice.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnClose = new System.Windows.Forms.Button();
      this.btnCustom = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(372, 3);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(99, 55);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Chiudimi!";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClick);
      // 
      // btnCustom
      // 
      this.btnCustom.Location = new System.Drawing.Point(175, 132);
      this.btnCustom.Name = "btnCustom";
      this.btnCustom.Size = new System.Drawing.Size(99, 55);
      this.btnCustom.TabIndex = 0;
      this.btnCustom.Text = "Messaggio del Custom";
      this.btnCustom.UseVisualStyleBackColor = true;
      this.btnCustom.Click += new System.EventHandler(this.btnClick);
      // 
      // cntCustom1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.Controls.Add(this.btnCustom);
      this.Controls.Add(this.btnClose);
      this.Name = "cntCustom1";
      this.Size = new System.Drawing.Size(474, 332);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnCustom;
  }
}
