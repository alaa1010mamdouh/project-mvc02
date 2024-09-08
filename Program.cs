namespace mvc2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //    endpoints.MapGet("/product/{id:int?}", async context =>
            //    {
            //        var  id = context.Request.RouteValues["id"];
            //        if (id is not null)
            //        {
            //            await context.Response.WriteAsync($"your product id=>{id}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"your product page ");

            //        }
            //    });
            //    endpoints.MapGet("/books/{id}/{author:alpha:minlength(5):maxlength(10)}", async context =>//default string
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();

            //        await context.Response.WriteAsync($"you in a book page id=>{id} , at author ={author}");
            //    });
            //});
            app.MapControllerRoute(
                name:"default",
                pattern: "/{controller=home}/{Action =Index}",
                defaults: new { controller = "home", Action = "Index" }
                );
           // app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("not foun product"); });
            // app.MapGet("/home", () => "Hello World!");

            app.Run();
        }
    }
}
