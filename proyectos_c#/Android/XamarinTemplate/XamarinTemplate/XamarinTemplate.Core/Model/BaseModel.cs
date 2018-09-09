using SQLite.Net.Attributes;

namespace XamarinTemplate.Core.Model
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
