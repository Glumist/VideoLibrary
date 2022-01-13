using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    public class HtmlHelper
    {
        static CookieContainer _cookieContainer;

        class CookieAwareWebClient : WebClient
        {
            private CookieContainer cc = new CookieContainer();
            private string lastPage;

            protected override WebRequest GetWebRequest(System.Uri address)
            {
                WebRequest R = base.GetWebRequest(address);
                if (R is HttpWebRequest)
                {
                    HttpWebRequest WR = (HttpWebRequest)R;
                    WR.CookieContainer = cc;
                    if (lastPage != null)
                    {
                        WR.Referer = lastPage;
                    }
                }
                lastPage = address.ToString();
                return R;
            }
        }

        private static WebClient _client;

        private static WebClient GetWebClient()
        {
            //if (_client == null)
            {
                _client = new WebClient();
                _client.Proxy = null;
                _client.Encoding = Encoding.GetEncoding("utf-8");
                _client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.97 Safari/537.11";
                _client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                _client.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,*//**;q=0.8";
                _client.Headers[HttpRequestHeader.AcceptCharset] = "ISO-8859-1,utf-8;q=0.7,*;q=0.3";
            }
            return _client;
        }

        /*public static string GetHtmlString(string url)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept-Language", "ru-Ru,ru;q=0.5");
                client.DefaultRequestHeaders.Add("Accept-Charset", "Windows-1252,utf-8;q=0.7,*;q=0.7");
                client.DefaultRequestHeaders.Add("UserAgent", "Opera/9.80 (Windows NT 6.1; WOW64; MRA 8.2 (build 6870)) Presto/2.12.388 Version/12.16");
                return (client.GetStringAsync(url)).Result;
            }
        }*/

        /*public static string GetHtmlString(string url)
        {
            WebClient client = GetWebClient();
*/

            /*if (System.Web.HttpContext.Current.Session["cookie"] != null)
                _cookies = System.Web.HttpContext.Current.Session["cookie"].ToString();

            using (WebClient wc = new WebClient())
            {

                wc.Headers.Add("Cookie", _cookies);
                string HtmlResult = wc.UploadString(bridge_url, myParameters);
                _cookies = wc.ResponseHeaders["Set-Cookie"];
                Debug.WriteLine("Headers" + _cookies);

                System.Web.HttpContext.Current.Session["cookie"] = _cookies;

            }*/

            /*client.Headers.Add(HttpRequestHeader.Cookie, "spravka=dD0xNDYyMjE1OTU1O2k9MTc4LjE1NS40LjE0ODt1PTE0NjIyMTU5NTU4OTQ4OTYyNjE7aD02MzE3MzM5M2NmZGMzZWE3ZGU0ZjcyY2Y4NGViY2I3OA==;" +
                "csrftoken=s%3ABchhFKDv1fTKpTIBVLhn7uEM.0GosU8cxOa0wNyLRbTXNM2aYD8C%2F2zQ6ntAJDAYCUjg;" +
                "_ym_uid=1493751959901745063;" + "_ym_isad=1;" + "_ym_visorc_10630330=w");*/
                
            /*client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0");
            return client.DownloadString(url);
        }*/

        public static string GetHtmlString(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.AllowAutoRedirect = true;
            req.ContentType = "application/x-www-form-urlencoded";
            req.Referer = "http://google.com";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0";

            if (_cookieContainer == null)
            {
                _cookieContainer = new CookieContainer();
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_d", "1609170128"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_isad", "1"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_uid", "1609162596484861180"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_10630330", "b"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_22663942", "b"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_238724", "w"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_238735", "w"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_26812653", "b"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_56177992", "b"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("cmtchd", "MTYwOTE2OTE1OTMwOQ"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("crookie", "D8yRMv4OHAQd3fhZjuKRhaLPuSCyDzYh/GehxpmL+fABjB398fHmvlvoZ8ooz6QXhmsqurAv+/XXrfWIRTEWiZKL08I="));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("gdpr", "0"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("yandexuid", "6276612201542871157"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("yandex_gid", "35"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("i", "J8dgPYD8cVXqny6MRj7Cw5tmzRmabXnjg4k7OH0qUt5aVcz/IBpKIxlcrts4J7rpZgEPeK61p2QCJEo0AhHU9ipr7sM="));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("kpunk", "1"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("mda", "0"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("mda2_beacon", "1609169716037"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("spravka", "dD0xNjA5MTY5MjAwO2k9MTg1LjUyLjEzNC4xMTI7dT0xNjA5MTY5MjAwMDUxNjU5NTk1O2g9MDVmYmZlNzg3NmNkYjEzOTkzMjRiOGFjM2RhMGY4N2Q="));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("sso_status", "sso.passport.yandex.ru:synchronized"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("tc", "431"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("user_country", "ru"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("ya_sess_id", "noauth:1609169716"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("yuidss", "6276612201542871157"));
                _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("ys", "c_chck.2458526112"));
            }

            req.CookieContainer = _cookieContainer;

            var resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            return sr.ReadToEnd();
        }

        private static void UploadUrl(Uri url, string data)
        {
            WebClient client = GetWebClient();
            client.UploadString(url, data);
            Console.WriteLine(client.ResponseHeaders[HttpRequestHeader.Cookie]);
        }

        private const string pictureAddress = "https://www.kinopoisk.ru/images/film_big/";
        private const string infoAddress = "https://www.kinopoisk.ru/film/";

        public static string GetInfoAddress(int id)
        {
            return infoAddress + id;
        }

        public static void SaveVideoPicture(int id)
        {
            string address = pictureAddress + id + ".jpg";
            SaveVideoPicture(id, address);

            /*string path = GetPicDirectory();
            string fileName = GetFilename(id);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            //if (!File.Exists(fileName))
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(address, GetFilename(id));
            }*/
        }

        public static void SaveVideoPicture(int id, string address)
        {
            //string address = pictureAddress + id + ".jpg";

            string path = GetPicDirectory();
            string fileName = GetFilename(id);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            //if (!File.Exists(fileName))
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(address, GetFilename(id));
            }
        }

        public static VideoRecord GetVideoRecord(int id)
        {
            string address = GetInfoAddress(id);

            HtmlDocument doc = new HtmlDocument();
            string htmlString = GetHtmlString(address);
            doc.LoadHtml(htmlString);

            VideoRecord result = new VideoRecord();

            result.Id = id;
            string type;
            if (IsCaptcha(doc))
                throw new Exception("Капча");
            try
            {
                type = GetType(doc);
            }
            catch
            {
                throw new Exception("Попробуйте позже");
                try
                {
                    SendCaptcha(doc);

                    htmlString = GetHtmlString(address);
                    doc.LoadHtml(htmlString);
                    type = GetType(doc);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("err " + ex.Message);
                    throw new Exception(htmlString);
                }
            }
            string title = GetTitle(doc, type);
            string origTitle = GetOriginalTitle(doc, type);
            result.Name = (string.IsNullOrWhiteSpace(origTitle) || title == origTitle) ? title : title + " (" + origTitle + ")";
            result.Score = GetScore(doc, type);
            result.Year = GetYear(doc);
            result.Duration = GetDuration(doc);
            result.Synopsis = GetSynopsis(doc);

            if (type == "movie")
                result.Type = VideoType.Movie;
            else if (type == "show")
                result.Type = VideoType.Series;

            return result;
        }

        private static bool IsCaptcha(HtmlDocument doc)
        {
            string xpath = "//head/title";
            HtmlNode typeNode = doc.DocumentNode.SelectSingleNode(xpath);
            return (typeNode != null && typeNode.InnerText == "Ой!");                
        }

        private static string GetType(HtmlDocument doc)
        {
            string xpath = "//meta[@property='og:type']";

            HtmlNode typeNode = doc.DocumentNode.SelectSingleNode(xpath);
            if (typeNode != null)
            {
                foreach (HtmlAttribute attribute in typeNode.Attributes)
                    if (attribute.Name == "content")
                    {
                        if (attribute.Value == "video.movie")
                            return "movie";
                        else if (attribute.Value == "video.tv_show")
                            return "show";
                    }
            }

            throw new NotImplementedException();
        }

        private static string GetTitle(HtmlDocument doc, string type)
        {
            string xpath = "//span[contains(@class, 'styles_title')]";
            //HtmlNode titleNode = doc.DocumentNode.SelectSingleNode(xpath);
            HtmlNodeCollection titleNodes = doc.DocumentNode.SelectNodes(xpath);
            if (titleNodes.Count > 1 && !string.IsNullOrWhiteSpace(titleNodes[1].InnerText))
                return titleNodes[1].InnerText;
            else if (titleNodes.Count > 0)
                return titleNodes[0].InnerText;

            return "";
        }

        private static string GetOriginalTitle(HtmlDocument doc, string type)
        {
            string xpath = "//span[contains(@class, 'styles_originalTitle')]";
            HtmlNode titleNode = doc.DocumentNode.SelectSingleNode(xpath);
            if (titleNode != null)
                return titleNode.InnerText.Replace("&#x27;", "'"); 

            return "";
        }

        private static double GetScore(HtmlDocument doc, string type)
        {
            string xpath = "//span[contains(@class,'film-rating-value')]";

            HtmlNode scoreNode = doc.DocumentNode.SelectSingleNode(xpath);
            if (scoreNode != null)
            {
                double score;
                if (double.TryParse(scoreNode.InnerText, NumberStyles.Number, CultureInfo.InvariantCulture, out score))
                    return score;
            }

            return 0;
        }

        private static string GetYear(HtmlDocument doc)
        {
            string xpath = "//h3[contains(@class,'film-page-section-title')]";

            HtmlNode yearNode = doc.DocumentNode.SelectSingleNode(xpath).NextSibling.FirstChild.LastChild;
            if (yearNode != null)
                return yearNode.InnerText.Replace("&thinsp;", "").Replace("&ndash;", "-");
            
            return "";
        }

        private static int GetDuration(HtmlDocument doc)
        {
            string xpath = "//h3[contains(@class,'film-page-section-title')]";

            HtmlNode durationNode = doc.DocumentNode.SelectSingleNode(xpath).NextSibling.LastChild.LastChild;

            if (durationNode != null)
            {
                int parsed;
                if (int.TryParse(durationNode.InnerText.Split(' ')[0], out parsed)) // продолжительность должна быть до первого пробела
                    return parsed;
            }

            /*HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);

            string xpath2 = "//td[@class='film-info__type' and text()='Время']";
            xpath2 += "//..//td[@class='film-info__value']";

            foreach (HtmlNode node in nodes)
            {
                HtmlNode durationNode = node.SelectSingleNode(xpath2);
                if (durationNode != null)
                {
                    // парсим строку вида "2 часа 1 минута" или "Серия ~ 1 час"
                    string[] strings = durationNode.InnerText.Split(' ');

                    int minutes = 0;
                    int hours = 0;

                    for (int count = 0; count < 2; count++)
                    {
                        if (strings.Length > count * 2 + 1)
                        {
                            int parsed;
                            if (int.TryParse(strings[strings.Length - count * 2 - 2], out parsed))
                            {
                                string measure = strings[strings.Length - count * 2 - 1];
                                if (measure.Contains("час"))
                                    hours = parsed;
                                else if (measure.Contains("минут"))
                                    minutes = parsed;
                            }
                        }
                    }

                    return hours * 60 + minutes;
                }
            }*/

            return 0;
        }

        private static string GetSynopsis(HtmlDocument doc)
        {
            string xpath = "//p[contains(@class,'styles_paragraph')]";

            HtmlNode synopsisNode = doc.DocumentNode.SelectSingleNode(xpath);
            if (synopsisNode != null)
                return synopsisNode.InnerText;

            return "";
        }

        private static string GetPicDirectory()
        {
            return Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "Pics");
        }

        private static string GetFilename(int id)
        {
            return Path.Combine(GetPicDirectory(), "" + id + ".jpg");
        }

        #region Captcha

        private static void SendCaptcha(HtmlDocument doc)
        {
            string capcthaImageAddress = GetCaptchaImageAddress(doc);
            FormCaptcha form = new FormCaptcha(capcthaImageAddress);
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                throw new Exception();

            Uri captchaAddress = new Uri("https://plus.kinopoisk.ru/checkcaptcha?"
            + "key=" + GetCaptchaKey(doc)
            + "&retpath=" + GetCaptchaRetpath(doc)
            + "&rep=" + WebUtility.UrlEncode(form.EnteredText));

            UploadUrl(captchaAddress, "");
        }

        private static string GetCaptchaImageAddress(HtmlDocument doc)
        {
            string xpath = "//img[@class='image form__captcha']";
            HtmlNode imgNode = doc.DocumentNode.SelectSingleNode(xpath);

            if (imgNode != null)
                foreach (HtmlAttribute attribute in imgNode.Attributes)
                    if (attribute.Name == "src")
                        return attribute.Value;

            throw new Exception();
        }

        private static string GetCaptchaKey(HtmlDocument doc)
        {
            string xpath = "//input[@class='form__key']";
            HtmlNode keyNode = doc.DocumentNode.SelectSingleNode(xpath);

            if (keyNode != null)
                foreach (HtmlAttribute attribute in keyNode.Attributes)
                    if (attribute.Name == "value")
                        return WebUtility.UrlEncode(attribute.Value);

            throw new Exception();
        }

        private static string GetCaptchaRetpath(HtmlDocument doc)
        {
            string xpath = "//input[@class='form__retpath']";
            HtmlNode keyNode = doc.DocumentNode.SelectSingleNode(xpath);

            if (keyNode != null)
                foreach (HtmlAttribute attribute in keyNode.Attributes)
                    if (attribute.Name == "value")
                        return WebUtility.UrlEncode(attribute.Value);

            throw new Exception();
        }

        #endregion
    }
}
// doc -> html -> body -> div class="page-wrapper" -> div class="page-content page__content" -> div itemprop="mainEntityOfPage"
//    -> div class="film-header film-header_type_movie i-bem" -> div class="film-header__wrapper" -> div class="film-header__wrapper-row" (несколько)
//      -> header class="film-header__wrapper-head"
// title  -> div class="film-header__title" itemprop="name" InnerText
//        -> div class="film-header__rating-wrapper" -> div class="film-header__rating" -> div class="rating-button rating-button_size_l rating-button_rating_yes"
// rating   -> div class="rating-button__left rating-button__left_high" -> div class="rating-button__rating" InnerText
//    -> div class="movie-wrapper i-bem" 
//      -> div class="col-left" -> div class="kinoisland i-bem" -> div class="kinoisland__content"
//        -> table class="film-info film-info_mini film-info_main" -> tr class="film-info__row" (несколько)
// year     -> td class="film-info__type" InnerText == "Год производства" => td class="film-info__value" InnerText
// time     -> td class="film-info__type" InnerText == "Время" => td class="film-info__value" InnerText (2 часа 1 минута)
//      -> div class="col-content" -> div class="kinoisland kinoisland_movie-description film-description i-bem"
// description  -> div class="kinoisland__content" itemprop="description"  InnerText

// html -> head -> meta -> content="video.tv_show" & property="og:type" movie