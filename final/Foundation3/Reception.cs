using System;


class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription() {
        return $"Type: Reception\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}

