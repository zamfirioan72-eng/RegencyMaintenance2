namespace RegencyMaintenance.Models;

public class Intervention
{
    public int Id { get; set; }
    public string Room { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public string Timestamp { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string Operator { get; set; } = string.Empty;

    public string DisplayDate =>
        DateTime.TryParseExact(Date, "yyyy-MM-dd", null,
            System.Globalization.DateTimeStyles.None, out var d)
            ? d.ToString("dd/MM/yyyy") : Date;

    public string DisplayTime =>
        Timestamp.Contains(' ') ? Timestamp.Split(' ')[1] : Timestamp;
}