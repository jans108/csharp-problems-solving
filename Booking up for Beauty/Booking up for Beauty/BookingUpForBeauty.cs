namespace Booking_up_for_Beauty;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var date = DateTime.Parse(appointmentDateDescription);

        return date;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (appointmentDate <= DateTime.Now)
            return true;

        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        var afternoon = new TimeSpan(12, 0, 0);
        var evening = new TimeSpan(18, 0, 0);

        var appointmentTime = appointmentDate.TimeOfDay;

        return appointmentTime >= afternoon && appointmentTime < evening;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        var anniversary = new DateTime(DateTime.Now.Year, 9, 15);

        return anniversary;
    }
}