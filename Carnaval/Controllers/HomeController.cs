using Carnaval.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carnaval.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Одесский карнавал";
            ViewBag.Description = "Ярмарка будет проходить с 28.06 по 29.06 (2 дня). Яррмарка организована благотворительным фондом \"Детская улыбка\", компанией \"Roshen\" и городским советом в поддержку детям-сиротам. Вырученные деньги пойдут в приют \"Малыш\"";
            ViewBag.About = "Чтобы протестировать класс, написанный на PHP, с использованием фреймворка PHPUnit, необходимо создать тестовый класс, расширяющий базовый класс PHPUnit_Framework_TestCase. Затем создать в этом классе публичные методы, начинающиеся со слова test (если создать метод, который будет называться по-другому, он не будет автоматически вызван при прогоне тестов), и поместить в них код, выполняющий действия с объектами тестируемого класса и проверяющий результат. На этом можно закончить и скормить полученный класс phpunit, который, в свою очередь, последовательно вызовет все тестовые методы и любезно предоставит отчет об их работе. Однако в большинстве случаев в каждом из тестовых методов будет повторяющийся код, подготавливающий систему для работы с тестируемым объектом";

            ViewBag.Events = new List<EventModel>
            {
                new EventModel
                {
                    ImagePath = "~/Images/event_img1.jpg",
                    ShortDescription= "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ",
                    RestOfDescription = "Libero fuga facilis vel consectetur quos sapiente deleniti eveniet dolores tempore eos deserunt officia quis ab? Excepturi vero tempore minus beatae voluptatem!"
                },
                new EventModel
                {
                    ImagePath = "~/Images/event_img2.jpg",
                    ShortDescription= "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ",
                    RestOfDescription = "Libero fuga facilis vel consectetur quos sapiente deleniti eveniet dolores tempore eos deserunt officia quis ab? Excepturi vero tempore minus beatae voluptatem!"
                },
                new EventModel
                {
                    ImagePath = "~/Images/event_img3.jpg",
                    ShortDescription= "Lorem ipsum dolor sit amet, consectetur adipisicing elit. ",
                    RestOfDescription = "Libero fuga facilis vel consectetur quos sapiente deleniti eveniet dolores tempore eos deserunt officia quis ab? Excepturi vero tempore minus beatae voluptatem!"
                }
            };
            ViewBag.Schedules = new List<Schedule>
            {
                new Schedule
                {
                    EventName = "Дессерты",
                    Time = "15:00",
                    Place = "Горсад"
                },
                new Schedule
                {
                    EventName = "Клоуны",
                    Time = "16:00",
                    Place = "Дерибасовская"
                },
                new Schedule
                {
                    EventName = "Детский концерт",
                    Time = "17:00",
                    Place = "Приморский бульвар"
                },
                new Schedule
                {
                    EventName = "Вручение призов",
                    Time = "18:00",
                    Place = "Приморский бульвар"
                }
            };
            ViewBag.GalleryImages = new List<string>()
            {
                "~/Images/gallery_img1.jpg",
                "~/Images/gallery_img2.jpg",
                "~/Images/gallery_img3.jpg",
                "~/Images/gallery_img4.jpg",
                "~/Images/gallery_img5.jpg"
            };

            return View();
        }
    }
}