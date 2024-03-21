using A1Monitor;

var builder = WebApplication.CreateBuilder(args);


//Add watch Monitor for folder
WatchFolder wf = new WatchFolder(true, @"C:\dev\A1.Monitor\A1Monitor", "*.xml", true);

var app = builder.Build();

app.MapGet(
    "/MonitorStatus",
    () =>
    {


        //Console.WriteLine("Monitor Status: " + wf.MonitorStatus());


        return Results.Ok(       
    
            "Monitor Status: " + wf.MonitorStatus() 
    
            );

    }
);

app.MapGet("/", () => "Sistema de Monitoramento NFe");

app.Run();
