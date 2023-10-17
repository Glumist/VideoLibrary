using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    public class FileHelper
    {
        public static string GetAppDirectory()
        {
            return Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        }

        public static void SaveImage(Image image, int id)
        {
            image.Save(GetFilename(id));
        }

        public static Image GetImage(int id)
        {
            string filename = GetFilename(id);
            if (!string.IsNullOrEmpty(filename) && File.Exists(filename))
                return new Bitmap(Image.FromFile(filename));
            else
                return null;
        }

        public static Image GetImage(int id, int height)
        {
            Image image = GetImage(id);

            if (image == null)
                return null;

            return GetResizedByHeightImage(image, height);
        }

        public static Image GetTagImage(string filename)
        {
            Image loadedImage = new Bitmap(Image.FromFile(filename));
            return GetResizedImage(loadedImage, VideoTag.ImageSize);
        }

        public static Dictionary<string, Image> GetAllPics(List<string> currentIds, int height)
        {
            Dictionary<string, Image> pics = new Dictionary<string, Image>();
            Dictionary<string, Image> notSizedPics = new Dictionary<string, Image>();

            //MainForm.log += "start open pic files " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;
            string picsDirectory = GetPicsDirectory();

            string[] picFiles = Directory.GetFiles(picsDirectory);
            foreach (string picFile in picFiles)
            {
                string picId = Path.GetFileNameWithoutExtension(picFile);
                if (!currentIds.Contains(picId))
                    try
                    {
                        notSizedPics.Add(picId, new Bitmap(Image.FromFile(picFile)));
                    }
                    catch
                    {
                    }
            }
            //MainForm.log += "resizing images " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;
            foreach (string id in notSizedPics.Keys)
                pics.Add(id, GetResizedByHeightImage(notSizedPics[id], height));
            //MainForm.log += "end resizing " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;

            return pics;
        }

        public static Dictionary<string, Image> GetAllTags()
        {
            Dictionary<string, Image> tags = new Dictionary<string, Image>();
            Dictionary<string, Image> notSizedTags = new Dictionary<string, Image>();

            string tagsDirectory = GetTagsDirectory();
            string[] tagFiles = Directory.GetFiles(tagsDirectory);
            foreach (string tagFile in tagFiles)
            {
                string tagId = tagFile;
                try
                {
                    using (var fs = new FileStream(tagFile, FileMode.Open, FileAccess.Read))
                        notSizedTags.Add(tagId, Image.FromStream(fs));
                }
                catch
                {
                }
            }
            foreach (string id in notSizedTags.Keys)
                tags.Add(id, GetResizedImage(notSizedTags[id], VideoTag.ImageSize));

            return tags;
        }

        public static void SaveAllTags(List<VideoTag> tags)
        {
            string tagsDirectory = GetTagsDirectory();
            if (!Directory.Exists(tagsDirectory))
                Directory.CreateDirectory(tagsDirectory);

            foreach (VideoTag tag in tags)
            {
                string filename = Path.Combine(GetTagsDirectory(), "" + tag.Id + tag.Extension);
                try
                {
                    if (File.Exists(filename))
                        File.Delete(filename);
                    tag.Image.Save(filename);
                }
                catch
                { }
            }
        }

        public static Dictionary<string, Image> GetAllLanguages()
        {
            Dictionary<string, Image> languages = new Dictionary<string, Image>();
            Dictionary<string, Image> notSizedLanguages = new Dictionary<string, Image>();

            string languagesDirectory = GetLanguagesDirectory();
            string[] languageFiles = Directory.GetFiles(languagesDirectory);
            foreach (string languageFile in languageFiles)
            {
                string languageId = languageFile;
                try
                {
                    using (var fs = new FileStream(languageFile, FileMode.Open, FileAccess.Read))
                        notSizedLanguages.Add(languageId, Image.FromStream(fs));
                }
                catch
                {
                }
            }
            foreach (string id in notSizedLanguages.Keys)
                languages.Add(id, GetResizedImage(notSizedLanguages[id], Language.ImageSize));

            return languages;
        }

        public static void SaveAllLanguages(List<Language> languages)
        {
            string languagesDirectory = GetLanguagesDirectory();
            if (!Directory.Exists(languagesDirectory))
                Directory.CreateDirectory(languagesDirectory);

            foreach (Language language in languages)
            {
                string filename = Path.Combine(GetLanguagesDirectory(), "" + language.Id + language.Extension);
                try
                {
                    if (File.Exists(filename))
                        File.Delete(filename);
                    language.Image.Save(filename);
                }
                catch
                { }
            }
        }

        private static string GetPicsDirectory()
        {
            string result = Path.Combine(GetAppDirectory(), "Pics");
            if (!Directory.Exists(result))
                Directory.CreateDirectory(result);

            return result;
        }

        private static string GetTagsDirectory()
        {
            string result = Path.Combine(GetAppDirectory(), "Tags");
            if (!Directory.Exists(result))
                Directory.CreateDirectory(result);

            return result;
        }

        private static string GetLanguagesDirectory()
        {
            string result = Path.Combine(GetAppDirectory(), "Languages");
            if (!Directory.Exists(result))
                Directory.CreateDirectory(result);

            return result;
        }

        private static string GetFilename(int id)
        {
            string picsDirectory = GetPicsDirectory();
            if (!string.IsNullOrEmpty(picsDirectory))
                return Path.Combine(picsDirectory, id + ".jpg");
            else
                return null;
        }

        private static Image GetResizedByHeightImage(Image image, int height)
        {
            if (image.Height > height)
                return image.GetThumbnailImage(height * image.Width / image.Height, height, null, IntPtr.Zero);
            else
                return image;
        }

        private static Image GetResizedImage(Image image, int imageSize)
        {
            Image sizedImage = image;
            if (image.Width > image.Height)
            {
                if (image.Width > imageSize)
                {
                    sizedImage = image.GetThumbnailImage(imageSize, image.Height * imageSize / image.Width, null, IntPtr.Zero);
                }
            }
            else
            {
                if (image.Height > imageSize)
                {
                    sizedImage = image.GetThumbnailImage(image.Width * imageSize / image.Height, imageSize, null, IntPtr.Zero);
                }
            }

            return sizedImage;
        }

        public static void DeleteImages(List<string> ids)
        {
            string picsDirectory = GetPicsDirectory();
            string[] picFiles = Directory.GetFiles(picsDirectory);
            foreach (string picFile in picFiles)
            {
                string picId = Path.GetFileNameWithoutExtension(picFile);
                if (ids.Contains(picId))
                    try
                    {
                        File.Delete(picFile);
                    }
                    catch
                    {
                    }
            }
        }
    }
}
