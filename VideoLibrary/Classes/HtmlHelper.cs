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
            if (_client == null)
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

        public static string GetHtmlString(string url)
        {
            WebClient client = GetWebClient();

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

            //client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0");
            //return client.DownloadString(url);
            return client.DownloadString(url);
        }

        private static void UploadUrl(Uri url, string data)
        {
            WebClient client = GetWebClient();
            client.UploadString(url, data);
            Console.WriteLine(client.ResponseHeaders[HttpRequestHeader.Cookie]);
        }

        private const string pictureAddress = "https://www.kinopoisk.ru/images/film_big/";
        private const string infoAddress = "https://plus.kinopoisk.ru/film/";

        public static string GetInfoAddress(int id)
        {
            return infoAddress + id;
        }

        public static void SaveVideoPicture(int id)
        {
            string address = pictureAddress + id + ".jpg";

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
            result.Name = GetTitle(doc, type);
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

        private static string GetType(HtmlDocument doc)
        {
            string xpath = "//html//head";
            xpath += "//meta[@property='og:type']";

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
            string xpath = "//html//body";
            xpath += "//div[@class='page-wrapper']";
            xpath += "//div[@class='page-content page__content']";
            xpath += "//div[@itemprop='mainEntityOfPage']";
            xpath += "//div[@class='film-header film-header_type_" + type + " i-bem']";
            xpath += "//div[@class='film-header__wrapper']";
            xpath += "//div[@class='film-header__wrapper-row']";

            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);

            string xpath2 = "//header[@class='film-header__wrapper-head']";
            xpath2 += "//div[@class='film-header__title' and @itemprop='name']";

            foreach (HtmlNode node in nodes)
            {
                HtmlNode titleNode = node.SelectSingleNode(xpath2);
                if (titleNode != null)
                    return titleNode.InnerText;
            }

            return "";
        }

        private static double GetScore(HtmlDocument doc, string type)
        {
            string xpath = "//html//body";
            xpath += "//div[@class='page-wrapper']";
            xpath += "//div[@class='page-content page__content']";
            xpath += "//div[@itemprop='mainEntityOfPage']";
            xpath += "//div[@class='film-header film-header_type_" + type + " i-bem']";
            xpath += "//div[@class='film-header__wrapper']";
            xpath += "//div[@class='film-header__wrapper-row']";

            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);

            string xpath2 = "//header[@class='film-header__wrapper-head']";
            xpath2 += "//div[@class='film-header__rating-wrapper']";
            xpath2 += "//div[@class='film-header__rating']";
            xpath2 += "//div[@class='rating-button rating-button_size_l rating-button_rating_yes']";
            xpath2 += "//div[contains(@class,'rating-button__left')]";
            xpath2 += "//div[@class='rating-button__rating']";

            foreach (HtmlNode node in nodes)
            {
                HtmlNode scoreNode = node.SelectSingleNode(xpath2);
                if (scoreNode != null)
                {
                    double score;
                    if (double.TryParse(scoreNode.InnerText, NumberStyles.Number, CultureInfo.InvariantCulture, out score))
                        return score;
                    break;
                }
            }

            return 0;
        }

        private static string GetYear(HtmlDocument doc)
        {
            string xpath = "//html//body";
            xpath += "//div[@class='page-wrapper']";
            xpath += "//div[@class='page-content page__content']";
            xpath += "//div[@itemprop='mainEntityOfPage']";
            xpath += "//div[@class='movie-wrapper i-bem']";
            xpath += "//div[@class='col-left']";
            xpath += "//div[@class='kinoisland i-bem']";
            xpath += "//div[@class='kinoisland__content']";
            xpath += "//table[@class='film-info film-info_mini film-info_main']";
            xpath += "//tr[@class='film-info__row']";

            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);

            string xpath2 = "//td[@class='film-info__type' and text()='Год производства']";
            xpath2 += "//..//td[@class='film-info__value']";

            foreach (HtmlNode node in nodes)
            {
                HtmlNode yearNode = node.SelectSingleNode(xpath2);
                if (yearNode != null)
                    return yearNode.InnerText.Replace("&thinsp;", "").Replace("&ndash;", "-");
            }

            return "";
        }

        private static int GetDuration(HtmlDocument doc)
        {
            string xpath = "//html//body";
            xpath += "//div[@class='page-wrapper']";
            xpath += "//div[@class='page-content page__content']";
            xpath += "//div[@itemprop='mainEntityOfPage']";
            xpath += "//div[@class='movie-wrapper i-bem']";
            xpath += "//div[@class='col-left']";
            xpath += "//div[@class='kinoisland i-bem']";
            xpath += "//div[@class='kinoisland__content']";
            xpath += "//table[@class='film-info film-info_mini film-info_main']";
            xpath += "//tr[@class='film-info__row']";

            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);

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
            }

            return 0;
        }

        private static string GetSynopsis(HtmlDocument doc)
        {
            string xpath = "//html//body";
            xpath += "//div[@class='page-wrapper']";
            xpath += "//div[@class='page-content page__content']";
            xpath += "//div[@itemprop='mainEntityOfPage']";
            xpath += "//div[@class='movie-wrapper i-bem']";
            xpath += "//div[@class='col-content']";
            xpath += "//div[@class='kinoisland kinoisland_movie-description film-description i-bem']";
            xpath += "//div[@class='kinoisland__content' and @itemprop='description']";

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