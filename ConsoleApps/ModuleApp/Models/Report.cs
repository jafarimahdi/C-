using System;
namespace ModuleApp.Models
{
    class Report
    {
        public int ReportId { get; set; }

        public string ReportText { get; set; }

        public DateTime ReportDate { get; set; }

        public int UserId { get; set; }


        public override string ToString()
        {
            return string.Format("ReportId: {0}\t\t Date: {1}\t\t UserId: {2}\n ReportText: {3}", ReportId, ReportDate, UserId, ReportText);
        }
    }
}

