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
      #region Field
      private Thread Threadtimer = null;
      private bool IsTimeRun = false;
      #endregion

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

            this.Text = "Fanuc_Practice";
            this.IsTimeRun = true;
            this.Threadtimer = new Thread(TimeCheck);
            this.Threadtimer.IsBackground = true;
            this.Threadtimer.Start();
            this.Threadtimer.Name = "ThreadTime";
         }
         catch (ThreadAbortException) { }
         catch (Exception ex)
         {
            LogController.Write(ex.ToString());
         }
      }

      private void TimeCheck()
      {
         while (this.IsTimeRun)
         {
            if (this.InvokeRequired)
            {
               this.BeginInvoke(new Action(() => LblTime.Text = $"{DateTime.Now}"));
            }
            else
            {
               this.LblTime.Text = $"{DateTime.Now}";
            }
            Thread.Sleep(1000);
         }
      }
      private void EndProcess(object sender, FormClosingEventArgs e)
      {
         try
         {
            this.IsTimeRun = false;
            if (this.Threadtimer.IsAlive) {  this.Threadtimer = null; }
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