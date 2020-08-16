using System;

namespace Models.Entities
{
    public class SignTimeLog : BaseEntity
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public DateTime RequestBegin { get; set; }
        public DateTime RequestEnd { get; set; }
        public double TotalTime { get; set; }
        public string Guid { get; set; }
    }
}
