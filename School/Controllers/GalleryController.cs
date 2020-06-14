using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using NReco.VideoConverter;
using Microsoft.WindowsAPICodePack.Shell;
using System.Drawing;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;

namespace School.Controllers
{
    public class GalleryController : Controller
    {
        private SchoolContext db;
        private IHostingEnvironment env;

        public GalleryController(SchoolContext context, IHostingEnvironment environment)
        {
            db = context;
            env = environment;
        }

        public IActionResult Index()
        {
            /*List<GalleryImage> images = db.GalleryImages.ToList();
            db.GalleryImages.RemoveRange(images);*/
            /*List<GalleryVideo> videos = db.GalleryVideos.ToList();
            db.GalleryVideos.RemoveRange(videos);
            db.SaveChanges();
            return Ok("OK");*/
            List<GalleryImage> images = db.GalleryImages.ToList();
            string content = "";
            foreach(GalleryImage image in images)
            {
                content += image.Id.ToString() + " " + image.Caption + "\n";
            }
            return Content(content);            
        }

        [Route("Photos")]
        public IActionResult Photos()
        {
            BaseVM mdl = new BaseVM();
            mdl = UserToMdl(mdl);
            return View(mdl);
        }

        [HttpGet]
        [Route("Photos/Load")]
        public IActionResult GetImages()
        {
            var result = db.GalleryImages.ToList();
            return Ok(result);
        }

        [HttpPost]
        [Route("Photos/Add")]
        public async Task<IActionResult> AddPhotos(IFormCollection formdata)
        {
            int i = 0;
            string GalleryPath = env.WebRootPath + @"\Uploads\Photos";
            string dbGalleryPath = @"/Uploads/Photos";
            foreach (var file in formdata.Files)
            {
                if (file.Length > 0)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var filename = DateTime.Now.ToString("ddMMHHmmssfff");
                    var path = Path.Combine(GalleryPath, filename) + extension;
                    var dbPath = dbGalleryPath + "/" + filename + extension;
                    string ImageCaption = formdata["ImageCaption[]"][i];
                    GalleryImage image = new GalleryImage();
                    image.Caption = ImageCaption;
                    image.ImageUrl = dbPath;
                    await db.GalleryImages.AddAsync(image);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    i++;
                }
            }
            await db.SaveChangesAsync();
            return new JsonResult("Изображения загружены");
        }

        [HttpGet]
        [Route("Videos")]
        public IActionResult Videos()
        {
            BaseVM mdl = new BaseVM();
            mdl = UserToMdl(mdl);
            return View(mdl);
        }


        [HttpGet]
        [Route("Videos/Load")]
        public IActionResult GetVideos()
        {
            var result = db.GalleryVideos.ToList();
            return Ok(result);
        }

        [HttpGet]
        [Route("Videos/Load/{id:int}")]
        public IActionResult ChosenVideo(int id)
        {
            GalleryVideo video = db.GalleryVideos.First(v => v.Id == id);
            return new JsonResult(video);
        }

        [HttpPost]
        [Route("Videos/Add")]
        [DisableRequestSizeLimit]
        [RequestFormLimits(MultipartBodyLengthLimit = 100_000_000_000, ValueLengthLimit = 1048576)]
        public async Task<IActionResult> AddVideos( IFormCollection formdata)
        {
            //await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official);
            //FFmpeg.SetExecutablesPath(@"D:\Downloads\Сане\ffmpeg-20200501-39fb1e9-win64-static\ffmpeg-20200501-39fb1e9-win64-static\bin");
            int i = 0;
            string GalleryPath = env.WebRootPath + @"\Uploads\Videos";
            string dbGalleryPath = @"/Uploads/Videos";
            string VideoName = "";
            foreach (var file in formdata.Files)
            {
                if (file.Length > 0)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var filename = DateTime.Now.ToString("ddMMHHmmssfff");
                    var path = Path.Combine(GalleryPath, filename) + extension;
                    var dbPath = dbGalleryPath + "/" + filename + extension;
                    string VideoCaption = formdata["VideoCaption[]"][i];
                    VideoName = formdata["VideoName[]"][i];
                    GalleryVideo video = new GalleryVideo();
                    video.Caption = VideoCaption;
                    video.VideoUrl = dbPath;
                    video.Name = VideoName;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    i++;                    
                    string thumbPath = env.WebRootPath + @"\Uploads\Videos\Thumbnails\" + filename + ".jpeg";
                    string dbThumbPath = @"/Uploads/Videos/ThumbNails/"+filename+".jpeg";
                    video.ThumbUrl = dbThumbPath;
                    await db.GalleryVideos.AddAsync(video);
                    IConversion conversion = await FFmpeg.Conversions.FromSnippet.Snapshot(path, thumbPath, TimeSpan.FromSeconds(0));
                    IConversionResult result = await conversion.Start();
                }
            }
            await db.SaveChangesAsync();
            return new JsonResult("Видеофайл " + VideoName + " загружен");
        }


        private BaseVM UserToMdl(BaseVM mdl)
        {
            if ((User.HasClaim(c => c.Type == "UserId")) &&
                (User.HasClaim(c => c.Type == "FullName")) &&
                (User.HasClaim(c => c.Type == ClaimsIdentity.DefaultNameClaimType)) &&
                (User.HasClaim(c => c.Type == ClaimsIdentity.DefaultRoleClaimType)))
            {
                mdl.UsrId = User.FindFirst(c => c.Type == "UserId").Value;
                mdl.UsrLogin = User.FindFirst(c => c.Type == ClaimsIdentity.DefaultNameClaimType).Value;
                mdl.FullName = User.FindFirst(c => c.Type == "FullName").Value;
                mdl.UsrRole = User.FindFirst(c => c.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
                mdl.LoggedIn = true;
            }
            else
            {
                mdl.LoggedIn = false;
            }
            return mdl;
        }
    }
}