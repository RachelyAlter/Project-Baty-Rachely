

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<BLManager>();
DBActions db=new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("PhotographyContext");
builder.Services.AddDbContext<PhotographyContext>(opt=>opt.UseSqlServer(connStr));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
