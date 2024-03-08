namespace PracticeWebApp
{
    public class Startup
    {
        [Obsolete] //If compiler error then true if warning error then false
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("Privacy.cshtml");
            app.UseDefaultFiles(options);

            app.UseStaticFiles();

            //try
            //{
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("hello India!");
            });
            //}
            //catch(Exception ex)
            //{
            //    Console.Write(ex.ToString());   
            //}


        }
    }

    
}
