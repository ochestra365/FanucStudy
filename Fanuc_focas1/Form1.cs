using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Fanuc_focas1.Class.INI;
using Fanuc_focas1.Class.Log;
namespace Fanuc_focas1
{
   public partial class Form1 : Form
   {
      #region Constructor
      public Form1()
      {
         InitializeComponent();
      }
      #endregion
      #region event
      private void Form1_Load(object sender, EventArgs e)
      {
         Init();
         
      }


      #endregion

      #region method
      private void Init()
      {
         try
         {
            this.TabMain.TabPages.RemoveAt(1);
            this.tabPage1.Text = "Main";

            
         }
         catch (ThreadAbortException) { }
         catch (Exception ex)
         {
            LogController.Write(ex.ToString());
         }
      }
      #endregion
   }
}