using SQLite;

namespace Kalendarzyk.Models.EventModels
{
    [Table("MicroTaskModel")]
    public partial class MicroTaskModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // Primary Key

        [Indexed]
        public int EventId { get; set; } // Foreign Key to EventModelId

        [MaxLength(255)]
        public string Title { get; set; }

        public bool IsCompleted { get; set; } = false;

        public MicroTaskModel() { }

        public MicroTaskModel(string title, int eventModelId, bool isCompleted = false)
        {
            Title = title;
            EventId = eventModelId;
            IsCompleted = isCompleted;
        }
        public MicroTaskModel(string title)
        {
            Title = title;
        }
    }
}
