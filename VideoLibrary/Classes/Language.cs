using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoLibrary
{
    [Serializable]
    public class Language
    {
        public static int ImageSize = 16;

        private int _id = -1;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Image _image;
        [XmlIgnore]
        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        private string _extension;
        [XmlIgnore]
        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private bool _showInStat;
        public bool ShowInStat
        {
            get { return _showInStat; }
            set { _showInStat = value; }
        }

        public Language() { }

        public Language(int id, string text, Image image, string extension)
        {
            Id = id;
            Text = text;
            Image = image;
            Extension = extension;
        }

        public override string ToString() => Text;

        public static int CompareById(Language a, Language b) => a.Id - b.Id;

        public static int CompareByText(Language a, Language b) => string.Compare(a.Text, b.Text);

        public static Image GetLanguagesPic(List<Language> languages)
        {
            List<Image> languagePics = new List<Image>();
            foreach (Language language in languages)
                if (language.Image != null)
                    languagePics.Add(language.Image);
            if (languagePics.Count == 0)
                return VideoRecord.ClearImage;

            return PicHelper.ConcatPics(languagePics);
        }
    }

    [Serializable]
    public class LanguageCollection
    {
        private static string fileName = "Languages.xml";
        private static LanguageCollection _languageCollection;

        private LanguageCollection()
        {
            Languages = new List<Language>();
        }

        public static LanguageCollection GetInstance()
        {
            if (_languageCollection == null)
                _languageCollection = Load();
            return _languageCollection;
        }

        private int _nextId = 0;
        public int NextId
        {
            get { return _nextId; }
            set { _nextId = value; }
        }

        private List<Language> _languages;
        public List<Language> Languages
        {
            get { return _languages; }
            set { _languages = value; }
        }

        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);

            FileHelper.SaveAllLanguages(Languages);
        }

        private static LanguageCollection Load()
        {
            LanguageCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<LanguageCollection>();
            }
            catch
            {
                return new LanguageCollection();
            }

            Dictionary<string, Image> languagePics = FileHelper.GetAllLanguages();
            foreach (string key in languagePics.Keys)
            {
                string idString = Path.GetFileNameWithoutExtension(key);
                Language language = result.Languages.Find(t => t.Id.ToString() == idString);
                if (language == null)
                    continue;

                language.Extension = Path.GetExtension(key);
                language.Image = languagePics[key];
            }

            result.Languages.Sort(Language.CompareById);

            return result;
        }

        public void Add(string text, Image image, string extension)
        {
            Languages.Add(new Language(NextId, text, image, extension));
            NextId++;
            Languages.Sort(Language.CompareById);
        }

        public static void Refresh() 
        { 
            _languageCollection = Load(); 
        }       
    }
}