using POC_event_manager.Data.DataAccess.Model;
using POC_event_manager.Data.DataAccess.Context;

namespace POC_event_manager.Data.DataAccess.Repos
{
    public class EventRepo
    {
        public List<Event> GetEventsFromDB()
        {
            using(var db = new POC_DB_Context())
            {
                return db.Events.ToList();
            }
        }

        public void AddEventsToDB(Event addEvent)
        {
            using (var db = new POC_DB_Context())
            {
                db.Events.Add(addEvent);
            }
        }
    }
}
