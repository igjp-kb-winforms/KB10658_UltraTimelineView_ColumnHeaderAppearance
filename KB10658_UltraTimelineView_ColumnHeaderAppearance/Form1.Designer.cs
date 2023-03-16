namespace KB10658_UltraTimelineView_ColumnHeaderAppearance;

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
        components = new System.ComponentModel.Container();
        ultraTimelineView1 = new Infragistics.Win.UltraWinSchedule.UltraTimelineView();
        ultraCalendarInfo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarInfo(components);
        ((System.ComponentModel.ISupportInitialize)ultraTimelineView1).BeginInit();
        SuspendLayout();
        // 
        // ultraTimelineView1
        // 
        ultraTimelineView1.Dock = DockStyle.Fill;
        ultraTimelineView1.Location = new Point(0, 0);
        ultraTimelineView1.Name = "ultraTimelineView1";
        ultraTimelineView1.Size = new Size(800, 450);
        ultraTimelineView1.TabIndex = 0;
        // 
        // ultraCalendarInfo1
        // 
        ultraCalendarInfo1.DataBindingsForAppointments.BindingContextControl = this;
        ultraCalendarInfo1.DataBindingsForOwners.BindingContextControl = this;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ultraTimelineView1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraTimelineView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.UltraWinSchedule.UltraTimelineView ultraTimelineView1;
    private Infragistics.Win.UltraWinSchedule.UltraCalendarInfo ultraCalendarInfo1;
}
