namespace POC_event_manager.Data.DataAccess.Model
{
    public class Event
    {
        public Event(string name, string description, string location, string organizer, string organizerContactInfo, string discordServerLink, List<Participant> participants)
        {
            Name = name;
            Description = description;
            Location = location;
            Organizer = organizer;
            OrganizerContactInfo = organizerContactInfo;
            DiscordServerLink = discordServerLink;
            //Participants = participants;
        }

        public Event(string name, string description, string location, string organizer, string organizerContactInfo, string discordServerLink)
        {
            Name = name;
            Description = description;
            Location = location;
            Organizer = organizer;
            OrganizerContactInfo = organizerContactInfo;
            DiscordServerLink = discordServerLink;
        }


        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }
        public string OrganizerContactInfo { get; set; }
        public string DiscordServerLink { get; set; }
        //public List<Participant> Participants { get; set; }
    }
}
