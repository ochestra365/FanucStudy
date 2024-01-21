namespace Fanuc_focas1
{
   partial class Form1
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
         TplMain = new TableLayoutPanel();
         TplHeader = new TableLayoutPanel();
         TplFooter = new TableLayoutPanel();
         LblTime = new Label();
         TabMain = new TabControl();
         tabPage1 = new TabPage();
         tabPage2 = new TabPage();
         TplMain.SuspendLayout();
         TplFooter.SuspendLayout();
         TabMain.SuspendLayout();
         SuspendLayout();
         // 
         // TplMain
         // 
         TplMain.ColumnCount = 1;
         TplMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
         TplMain.Controls.Add(TplHeader, 0, 0);
         TplMain.Controls.Add(TplFooter, 0, 2);
         TplMain.Controls.Add(TabMain, 0, 1);
         TplMain.Dock = DockStyle.Fill;
         TplMain.Location = new Point(0, 0);
         TplMain.Name = "TplMain";
         TplMain.RowCount = 3;
         TplMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
         TplMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
         TplMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
         TplMain.Size = new Size(1438, 826);
         TplMain.TabIndex = 1;
         // 
         // TplHeader
         // 
         TplHeader.ColumnCount = 2;
         TplHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
         TplHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
         TplHeader.Dock = DockStyle.Fill;
         TplHeader.Location = new Point(3, 3);
         TplHeader.Name = "TplHeader";
         TplHeader.RowCount = 1;
         TplHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
         TplHeader.Size = new Size(1432, 76);
         TplHeader.TabIndex = 0;
         // 
         // TplFooter
         // 
         TplFooter.ColumnCount = 5;
         TplFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
         TplFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
         TplFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
         TplFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
         TplFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
         TplFooter.Controls.Add(LblTime, 0, 0);
         TplFooter.Dock = DockStyle.Fill;
         TplFooter.Location = new Point(3, 745);
         TplFooter.Name = "TplFooter";
         TplFooter.RowCount = 1;
         TplFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
         TplFooter.Size = new Size(1432, 78);
         TplFooter.TabIndex = 1;
         // 
         // LblTime
         // 
         LblTime.AutoSize = true;
         LblTime.Dock = DockStyle.Fill;
         LblTime.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
         LblTime.Location = new Point(3, 0);
         LblTime.Name = "LblTime";
         LblTime.Size = new Size(280, 78);
         LblTime.TabIndex = 0;
         LblTime.Text = "TIME";
         LblTime.TextAlign = ContentAlignment.MiddleCenter;
         // 
         // TabMain
         // 
         TabMain.Controls.Add(tabPage1);
         TabMain.Controls.Add(tabPage2);
         TabMain.Dock = DockStyle.Fill;
         TabMain.Location = new Point(3, 85);
         TabMain.Name = "TabMain";
         TabMain.SelectedIndex = 0;
         TabMain.Size = new Size(1432, 654);
         TabMain.TabIndex = 2;
         // 
         // tabPage1
         // 
         tabPage1.Location = new Point(4, 24);
         tabPage1.Name = "tabPage1";
         tabPage1.Padding = new Padding(3);
         tabPage1.Size = new Size(1424, 626);
         tabPage1.TabIndex = 0;
         tabPage1.Text = "tabPage1";
         tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         tabPage2.Location = new Point(4, 24);
         tabPage2.Name = "tabPage2";
         tabPage2.Padding = new Padding(3);
         tabPage2.Size = new Size(1424, 626);
         tabPage2.TabIndex = 1;
         tabPage2.Text = "tabPage2";
         tabPage2.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1438, 826);
         Controls.Add(TplMain);
         Name = "Form1";
         Text = "Form1";
         FormClosing += EndProcess;
         Load += Form1_Load;
         TplMain.ResumeLayout(false);
         TplFooter.ResumeLayout(false);
         TplFooter.PerformLayout();
         TabMain.ResumeLayout(false);
         ResumeLayout(false);
      }

      #endregion

      private TableLayoutPanel TplMain;
      private TableLayoutPanel TplHeader;
      private TableLayoutPanel TplFooter;
      private TabControl TabMain;
      private TabPage tabPage1;
      private TabPage tabPage2;
      private Label LblTime;
   }
}