using LMS.DataAccess.Course;
using LMS.DataAccess.Enrollment;
using LMS.DataAccess.LectureResource;
using LMS.DataAccess.LectureRoom;
using LMS.DataAccess.Student;
using LMS.Domain.Course;
using LMS.Domain.Enrollment;
using LMS.Domain.LectureResource;
using LMS.Domain.LectureRoom;
using LMS.Domain.Student;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IStudentDomain, StudentDomain>();
builder.Services.AddTransient<ICourseDomain, CourseDomain>();
builder.Services.AddTransient<ILectureResourceDomain, LectureResourceDomain>();
builder.Services.AddTransient<IEnrollmentDomain, EnrollmentDomain>();
builder.Services.AddTransient<ILectureRoomDomain, LectureRoomDomain>();


builder.Services.AddTransient<IStudentDataLayer, StudentDataLayer>();
builder.Services.AddTransient<ICourseDataLayer, CourseDataLayer>();
builder.Services.AddTransient<ILectureResourceDataLayer, LectureResourceDataLayer>();
builder.Services.AddTransient<IEnrollmentDataLayer, EnrollmentDataLayer>();
builder.Services.AddTransient<ILectureRoomDataLayer, LectureRoomDataLayer>();

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
