using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JU_Exam.Startup))]
namespace JU_Exam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
