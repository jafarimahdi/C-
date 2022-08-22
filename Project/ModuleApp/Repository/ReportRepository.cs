using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleApp.Models;


namespace ModuleApp.Repository
{
    class ReportRepository
    {
        private List<Report> reports;

        public ReportRepository()
        {
            reports = new List<Report>();

        }

        public bool RegisterReport(Report report)
        {
            try
            {
                reports.Add(report);

                Console.WriteLine(" Report Registered ....");
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void showAllReportByUserId(int userId)
        {
            reports.Where(t => t.UserId == userId).ToList().ForEach(report => Console.Write(report));
            Console.ReadKey();
        }

        public int GetNewReportId()
        {
            int id = 0;
            if (reports.Count > 0)
            {
                id = reports.Last().ReportId;
            }
            return id + 1;
        }
    }
}

