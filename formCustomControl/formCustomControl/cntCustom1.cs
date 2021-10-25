using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formCustomControl
{
  public partial class cntCustom1 : UserControl
  {
    public event pressBtnGest MyPressBtn;
    string messaggioCustom = "";
    public cntCustom1(string myMessage)
    {
      InitializeComponent();
      btnCustom.Text = myMessage;
      messaggioCustom = myMessage;
    }


    private void btnClick(object sender, EventArgs e)
    {
      MyPressBtn?.Invoke(sender, e, messaggioCustom);
    }
  }
}
