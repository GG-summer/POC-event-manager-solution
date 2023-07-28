namespace POC_event_manager.Data.DataAccess.Model
{
    public class Participant
    {
        public Participant(string userName, string discordID, string location, string organizer, string organizerContactInfo, string discordServerLink, List<Event> events)
        {
            UserName = userName;
            DiscordID = discordID;
            Location = location;
            Organizer = organizer;
            OrganizerContactInfo = organizerContactInfo;
            DiscordServerLink = discordServerLink;
            Events = events;
        }

        public Participant(string userName, string discordID, string location, string organizer, string organizerContactInfo, string discordServerLink)
        {
            UserName = userName;
            DiscordID = discordID;
            Location = location;
            Organizer = organizer;
            OrganizerContactInfo = organizerContactInfo;
            DiscordServerLink = discordServerLink;
        }

        public int ParticipantId { get; set; }
        public string UserName { get; set; }
        public string DiscordID { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }
        public string OrganizerContactInfo { get; set; }
        public string DiscordServerLink { get; set; }
        public List<Event> Events { get; set; }
    }
}
