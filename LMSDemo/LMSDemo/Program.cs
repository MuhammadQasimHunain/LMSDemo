using LMS.Application.Course;
using LMS.Application.LectureResource;
using LMS.Application.LectureRoom;
using LMS.Application.Student;
using LMS.Domain.Course;
using LMS.Domain.LectureResource;
using LMS.Domain.LectureRoom;
using LMS.Domain.Student;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IStudentApplication, StudentApplication>();
builder.Services.AddTransient<ICourseApplication, CourseApplication>();
builder.Services.AddTransient<ILectureResourceApplication, LectureResourceApplication>();
builder.Services.AddTransient<ILectureRoomApplication, LectureRoomApplication>();

builder.Services.AddTransient<IStudentDomain, StudentDomain>();
builder.Services.AddTransient<ICourseDomain, CourseDomain>();
builder.Services.AddTransient<ILectureResourceDomain, LectureResourceDomain>();
builder.Services.AddTransient<ILectureRoomDomain, LectureRoomDomain>();


builder.Services.AddTransient<IStudentDataService, StudentDataService>();
builder.Services.AddTransient<ICourseDataService, CourseDataService>();
builder.Services.AddTransient<ILectureResourceDataService, LectureResourceDataService>();
builder.Services.AddTransient<ILectureRoomDataService, LectureRoomDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
