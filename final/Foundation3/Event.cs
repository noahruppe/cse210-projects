using System;


class Event
{
    protected string title;
    private string description;
    protected DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date:MM-dd-yyyy}\nTime: {time.Hours:D1}:{time.Minutes:D2} {((time.Hours < 12) ? "AM" : "PM")}\nAddress: {address}";
    }



    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Generic\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}

