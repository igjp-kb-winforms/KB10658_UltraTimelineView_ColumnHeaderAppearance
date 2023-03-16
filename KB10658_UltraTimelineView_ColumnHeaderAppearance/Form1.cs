using Infragistics.Win.UltraWinSchedule;

namespace KB10658_UltraTimelineView_ColumnHeaderAppearance;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraTimelineView1.CalendarInfo = ultraCalendarInfo1;
        ultraTimelineView1.EnsureDateTimeVisible(DateTime.Today.AddHours(9));

        Appointment appointment = ultraCalendarInfo1.Appointments.Add(new Appointment(DateTime.Today.AddHours(9), DateTime.Today.AddHours(10)));
        appointment.Subject = "—\’è";

        ultraTimelineView1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
        Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();
        appearance.BackColor = Color.LightBlue;
        appearance.ForeColor = Color.DarkBlue;
        appearance.FontData.Name = "Verdana";
        ultraTimelineView1.ColumnHeaderAppearance = appearance;
    }
}
