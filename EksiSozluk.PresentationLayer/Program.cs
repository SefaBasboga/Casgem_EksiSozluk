using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.BusinessLayer.Concrete;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Concrete;
using EksiSozluk.DataAccessLayer.EntityFramework;
using EksiSozluk.EntityLayer.Concrete;
using EksiSozluk.PresentationLayer.Models;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IContentDal, EfContentDal>();
builder.Services.AddScoped<IContentService, ContentManager>();

builder.Services.AddScoped<IFAQDal, EfFAQDal>();
builder.Services.AddScoped<IFAQService, FAQManager>();

builder.Services.AddScoped<IHeadingDal, EfHeadingDal>();
builder.Services.AddScoped<IHeadingService, HeadingManager>();

builder.Services.AddScoped<IPolicyDal, EfPolicyDal>();
builder.Services.AddScoped<IPolicyService, PolicyManager>();

builder.Services.AddScoped<ITermsOfUseDal, EfTermsOfUseDal>();
builder.Services.AddScoped<ITermsOfUseService, TermsOfUseManager>();

builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();


builder.Services.AddScoped<IAdminMessageDal, EfAdminMessageDal>();
builder.Services.AddScoped<IAdminMessageService, AdminMessageManager>();



builder.Services.AddDbContext<Context>();

builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
  name: "areas",
  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();
