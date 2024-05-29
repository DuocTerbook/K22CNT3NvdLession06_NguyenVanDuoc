using NVD_lession06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVD_lession06.Controllers
{
    public class NvdSongController : Controller
    {
        private static List<NvdSong> nvdSongs = new List<NvdSong>()
        {
            new NvdSong{Id=221090016,NvdTitle="Nguyễn Văn Được",NvdAuThor="K22CNT3",NvdArtist="NTU",NvdYearRelease=2024},
            new NvdSong{Id=1,NvdTitle="Phan Viết Vượng",NvdAuThor="K22CNT3",NvdArtist="NTU",NvdYearRelease=2024}
        };
        // GET: NvdSong
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Author: Nguyễn Văn Được
        /// </summary>
        /// <returns></returns>
        public ActionResult NvdIndex()
        {
            return View(nvdSongs);
        }
        //  GET: NvdCreate
        /// <summary>
        /// From thêm mới bài hát
        /// Author: Nguyễn Văn Được
        /// </summary>
        /// <returns></returns>
        public ActionResult NvdCreate()
        {
            var NvdSong = new NvdSong();
            return View();
        }
    }
}