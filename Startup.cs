using BusinessLayer.Bases;
using BusinessLayer.Implements;
using BusinessLayer.Models;

namespace QLGP_Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<Settings>(Configuration.GetSection("Settings"));

            services.AddSingleton<IUserBase, User>();
            services.AddSingleton<IRoleBase, Role>();

            services.AddControllersWithViews();
            services.AddMvc();
        }
    }
}