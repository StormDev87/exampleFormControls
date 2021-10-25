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
  public delegate void pressBtnGest(object sender, EventArgs e, string message);



  public partial class frmMaster : Form
  {
    cntCustom1 cCustom1 = new cntCustom1("Custom 1");
    cntCustom1 cCustom2 = new cntCustom1("Custom 2");
    cntCustom1 cCustom3 = new cntCustom1("Custom 3");

    public frmMaster()
    {
      InitializeComponent();
      cCustom1.MyPressBtn += CCustomX_MyPressBtn;
      cCustom2.MyPressBtn += CCustomX_MyPressBtn;
      cCustom3.MyPressBtn += CCustomX_MyPressBtn;
    }

    private void CCustomX_MyPressBtn(object sender, EventArgs e, string message)
    {
      Button tmp = (Button)sender;
      switch (tmp.Name)
      {
        case "btnClose":
          pnlContainer.Controls.Clear();
          break;
        case "btnCustom":
          MessageBox.Show(message);
          break;
      }
    }

    private void btnClick(object sender, EventArgs e)
    {
      Button tmp = (Button)sender;
      switch (tmp.Name)
      {
        case "btn1":
          pnlContainer.Controls.Clear();
          pnlContainer.Controls.Add(cCustom1);
          break;
        case "btn2":
          pnlContainer.Controls.Clear();
          pnlContainer.Controls.Add(cCustom2);
          break;
        case "btn3":
          pnlContainer.Controls.Clear();
          pnlContainer.Controls.Add(cCustom3);
          break;
      }
    }



  }
}
