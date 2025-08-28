using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SurveyReportRE.Models
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SurveyReportREDBContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
