using NJsonSchema;
using SwaggerTest.test;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerDocument();

builder.Services.AddOpenApiDocument(s =>
{
    s.SchemaType = SchemaType.OpenApi3;
    s.SchemaProcessors.Add(new InheritanceSchemaProcessor());
    s.FlattenInheritanceHierarchy = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
