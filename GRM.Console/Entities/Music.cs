using System;

namespace GRM.Console.Entities
{
    public class Music : BaseEntity
    {
        public string Artist { get; set; }

        public string Title { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return $"{Artist}|{Title}|{Usage}|{StartDate}|{EndDate}{Environment.NewLine}";
        }
    }
}
