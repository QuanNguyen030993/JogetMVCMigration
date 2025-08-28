 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SurveyReportRE.Models
{
    public class SurveyReportREDBContextFactory : IDesignTimeDbContextFactory<SurveyReportREDBContext>
    {
        public SurveyReportREDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SurveyReportREDBContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLSERVER2022;Database=RESurveyToolUserCheck;uid=sa;pwd=password@123;Connection Timeout=60;MultipleActiveResultSets=true;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server=localhost\\SQLSERVER2022;Database=RESurveyToolUATLocal;uid=sa;pwd=password@123;Connection Timeout=60;MultipleActiveResultSets=true;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server=appuat-sgn01;Database=RESurveyToolUAT;uid=userlocal;pwd=1234567890;Connection Timeout=60;MultipleActiveResultSets=true;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Persist Security Info=True;Server=192.168.0.15;Database=RESurveyTool;uid=userapp;pwd=1234567890aA;Connection Timeout=60;MultipleActiveResultSets=true;TrustServerCertificate=True");
            return new SurveyReportREDBContext(optionsBuilder.Options);
        }
    }
}
