using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using VideoLibrary.Properties;

namespace VideoLibrary
{
    public class VideoRecord
    {
        #region Properties

        #region Common

        private int _id = 0;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _origName = "";
        public string OrigName
        {
            get { return _origName; }
            set { _origName = value; }
        }

        private string _year = "";
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _duration = 0;
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int FullDuration
        {
            get 
            {
                if (Type == VideoType.Series || Type == VideoType.MiniSeries)
                    return Duration * EpisodesCount;
                else
                    return Duration;
            }
        }

        public string DurationStr
        {
            get
            {
                if (Type == VideoType.Series || Type == VideoType.MiniSeries)                
                    return EpisodesCount + "x" + Duration;                

                string minutes = "" + (Duration % 60);
                if (minutes.Length == 1)
                    minutes = "0" + minutes;
                return Math.Floor((double)Duration / 60) + ":" + minutes;
            }
        }

        private double _score = 0;
        public double Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private string _synopsis = "";
        public string Synopsis
        {
            get { return _synopsis; }
            set { _synopsis = value; }
        }

        private VideoType _type = VideoType.Unknown;
        [XmlIgnore]
        public VideoType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string TypeString
        {
            get { return TypeToString(Type); }
            set { Type = StringToType(value); }
        }

        private string _url = "";
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        #endregion

        #region User's

        private int _userScore = 0;
        public int UserScore
        {
            get { return _userScore; }
            set { _userScore = value; }
        }

        private string _comment = "";
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        List<VideoTag> _tags;
        [XmlIgnore]
        public List<VideoTag> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        public int[] TagsIds
        {
            get
            {
                List<int> result = new List<int>();
                Tags.ForEach(t => result.Add(t.Id));
                return result.ToArray();
            }
            set
            {
                foreach (int id in value)
                    Tags.AddRange(VideoTagCollection.GetInstance().Tags.FindAll(t => t.Id == id));
            }
        }

        [XmlIgnore]
        public Image TagsPic
        {
            get { return VideoTag.GetTagsPic(Tags); }
        }

        private DateTime? _dateStart;
        public DateTime? DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }

        private DateTime? _dateEnd;
        public DateTime? DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }

        public DateTime? Date
        {
            get
            {
                if (DateEnd.HasValue)
                    return DateEnd;
                else if (DateStart.HasValue)
                    return DateStart;
                else if (Type == VideoType.Series || Type == VideoType.MiniSeries)
                {
                    foreach (SeasonDates dates in SeasonDates)
                        if (dates.DateEnd.HasValue)
                            return dates.DateEnd;
                        else if (dates.DateStart.HasValue)
                            return dates.DateStart;
                }

                return null;
            }
        }

        #endregion

        #region Series

        private int _season = 1;
        public int Season
        {
            get { return _season; }
            set { _season = value; }
        }

        private List<SeasonDates> _seasonDates;
        public List<SeasonDates> SeasonDates
        {
            get { return _seasonDates; }
            set { _seasonDates = value; }
        }

        private int _episodesCount = 1;
        public int EpisodesCount
        {
            get { return _episodesCount; }
            set { _episodesCount = value; }
        }

        #endregion

        #region File

        private bool _isHdr = false;
        public bool IsHdr
        {
            get { return _isHdr; }
            set { _isHdr = value; }
        }

        [XmlIgnore]
        public Image IsHdrImage
        {
            get
            {
                if (IsHdr)
                    return Resources.IconHDR;
                else
                    return ClearImage;
            }
        }

        private Existence _existence = Existence.Unknown;
        [XmlIgnore]
        public Existence Existence
        {
            get { return _existence; }
            set { _existence = value; }
        }

        public string ExistenceString
        {
            get { return ExistenceToString(Existence); }
            set { Existence = StringToExistence(value); }
        }

        private string _path = "";
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string DirectoryPath
        {
            get
            {
                FileAttributes? attr = GetFileAttributes(Path);
                if (!attr.HasValue)
                    return "";
                return attr.Value.HasFlag(FileAttributes.Directory) ? Path : System.IO.Path.GetDirectoryName(Path);
            }
        }

        public bool CanPlay { get { return CanPlayFile(Path); } }

        public bool CanBrowse
        {
            get
            {
                return !string.IsNullOrEmpty(DirectoryPath) && Directory.Exists(DirectoryPath);
            }
        }

        private Resolution _resolution = Resolution.Unknown;
        public Resolution Resolution
        {
            get { return _resolution; }
            set { _resolution = value; }
        }

        [XmlIgnore]
        public Image ResolutionImage
        {
            get
            {
                switch (Resolution)
                {
                    case Resolution.UHD: return Resources.IconUHD;
                    case Resolution.FHD: return Resources.IconFHD;
                    case Resolution.HD: return Resources.IconHD;
                    case Resolution.SD: return Resources.IconSD;
                    default: return ClearImage;
                }
            }
        }

        public long FileSize
        {
            get
            {
                if (CanPlay)
                    return new FileInfo(Path).Length;
                return 0;
            }
        }

        public long DirectorySize
        {
            get
            {
                if (!CanPlay && CanBrowse)
                    return GetDirectorySize(Path);
                return 0;
            }
        }

        public string Size { get { return GetReadableSize(SizeNum); } }

        private long _sizeNum = -1;
        private long SizeNum
        {
            get
            {
                if (_sizeNum == -1)
                {
                    if (CanPlay)
                        _sizeNum = FileSize;
                    else if (CanBrowse)
                        _sizeNum = DirectorySize;
                    else
                        _sizeNum = 0;
                }
                return _sizeNum;
            }
        }

        private long GetDirectorySize(string path)
        {
            long result = 0;
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
                result += fi.Length;
            foreach (DirectoryInfo child in d.GetDirectories())
                result += GetDirectorySize(child.FullName);
            return result;
        }
        private static string GetReadableSize(long size)
        {
            if (size == 0)
                return "";
            if (size < 1024L)
                return "" + size + " B";
            if (size < 1024L * 1024)
                return "" + Math.Round(((double)size / 1024), 1) + " KB";
            if (size < 1024L * 1024 * 1024)
                return "" + Math.Round(((double)size / 1024 / 1024), 1) + " MB";
            if (size < 1024L * 1024 * 1024 * 1024)
                return "" + Math.Round(((double)size / 1024 / 1024 / 1024), 1) + " GB";
            //if (size < 1024L * 1024 * 1024 * 1024 * 1024)
            return "" + Math.Round(((double)size / 1024 / 1024 / 1024 / 1024), 1) + " TB";
        }

        private static FileAttributes? GetFileAttributes(string path)
        {
            if (string.IsNullOrEmpty(path) || (!File.Exists(path) && !Directory.Exists(path)))
                return null;
            return File.GetAttributes(path);
        }

        List<Language> _subLanguages;
        [XmlIgnore]
        public List<Language> SubLanguages
        {
            get { return _subLanguages; }
            set { _subLanguages = value; }
        }

        public int[] SubLanguagesIds
        {
            get
            {
                List<int> result = new List<int>();
                SubLanguages.ForEach(t => result.Add(t.Id));
                return result.ToArray();
            }
            set
            {
                foreach (int id in value)
                    SubLanguages.AddRange(LanguageCollection.GetInstance().Languages.FindAll(t => t.Id == id));
            }
        }

        [XmlIgnore]
        public Image SubLanguagesPic
        {
            get { try { return Language.GetLanguagesPic(SubLanguages); } catch { return ClearImage; } }
        }

        List<Language> _soundLanguages;
        [XmlIgnore]
        public List<Language> SoundLanguages
        {
            get { return _soundLanguages; }
            set { _soundLanguages = value; }
        }

        public int[] SoundLanguagesIds
        {
            get
            {
                List<int> result = new List<int>();
                SoundLanguages.ForEach(t => result.Add(t.Id));
                return result.ToArray();
            }
            set
            {
                foreach (int id in value)
                    SoundLanguages.AddRange(LanguageCollection.GetInstance().Languages.FindAll(t => t.Id == id));
            }
        }

        [XmlIgnore]
        public Image SoundLanguagesPic
        {
            get { return Language.GetLanguagesPic(SoundLanguages); }
        }

        #endregion

        #endregion

        public VideoRecord()
        {
            Tags = new List<VideoTag>();
            SubLanguages = new List<Language>();
            SoundLanguages = new List<Language>();
            SeasonDates = new List<SeasonDates>();
        }

        public override string ToString() => ToString(false);        

        public string ToString(bool full)
        {
            int seasonNum = 1;
            if (Type == VideoType.Series || Type == VideoType.MiniSeries)
            {
                seasonNum = Season;
                if (Existence == Existence.WillHave)
                    seasonNum++;
            }

            string name = Name;
            if (seasonNum > 1)
            {
                if (full)
                    name = seasonNum + " сезон " + name;
                else
                    name += " s" + seasonNum;
            }
            if (!string.IsNullOrWhiteSpace(OrigName) && OrigName != Name)
                name += " (" + OrigName + ")";

            return name;
        }

        public void ResetSizeNum() => _sizeNum = -1;        

        public static Image ClearImage { get { return new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb); } }

        public static bool CanPlayFile(string path)
        {
            FileAttributes? attr = GetFileAttributes(path);
            if (!attr.HasValue)
                return false;
            return !attr.Value.HasFlag(FileAttributes.Directory) && File.Exists(path);
        }

        public static void AddSeasonDates(List<SeasonDates> seasonDates, SeasonDates newSeasonDates)
        {
            seasonDates.Add(newSeasonDates);
            seasonDates.Sort(VideoLibrary.SeasonDates.CompareBySeason);
        }

        #region Convert

        public static string TypeToString(VideoType type)
        {
            switch (type)
            {
                case VideoType.Movie: return "Фильм";
                case VideoType.Cartoon: return "Мульт";
                case VideoType.Series: return "Сериал";
                case VideoType.MiniSeries: return "МиниСериал";
                default: return "ХЗ";
            }
        }

        public static VideoType StringToType(string type)
        {
            switch (type)
            {
                case "Фильм": return VideoType.Movie;
                case "Мульт": return VideoType.Cartoon;
                case "Сериал": return VideoType.Series;
                case "МиниСериал": return VideoType.MiniSeries;
                default: return VideoType.Unknown;
            }
        }

        public static string ExistenceToString(Existence existence)
        {
            switch (existence)
            {
                case Existence.Had: return "Had";
                case Existence.Have: return "Have";
                case Existence.WillHave: return "Will have";
                case Existence.Collection: return "Collection";
                default: return "Unknown";
            }
        }

        public static Existence StringToExistence(string existence)
        {
            switch (existence)
            {
                case "Had": return Existence.Had;
                case "Have": return Existence.Have;
                case "Will have": return Existence.WillHave;
                case "Collection": return Existence.Collection;
                default: return Existence.Unknown;
            }
        }

        public static Color GetColorByUserScore(int userscore)
        {
            switch (userscore)
            {
                case 1: return Color.Red;
                case 2: return Color.DarkOrange;
                case 3: return Color.DeepSkyBlue;
                case 4: return Color.GreenYellow;
                case 5: return Color.FromArgb(0, 192, 0);
                default: return Color.Black;
            }
        }

        #endregion

        #region Compare

        public static int CompareByScore(VideoRecord a, VideoRecord b)
        {
            if (a.Score == b.Score)
                return CompareByName(a, b);
            return (int)((b.Score - a.Score) * 100);
        }

        public static int CompareByName(VideoRecord a, VideoRecord b) => string.Compare(a.Name, b.Name);        

        public static int CompareByOrigName(VideoRecord a, VideoRecord b) => string.Compare(a.OrigName, b.OrigName);        

        public static int CompareByType(VideoRecord a, VideoRecord b)
        {
            if (a.Type == b.Type)
                return CompareByName(a, b);
            if (a.Type == VideoType.Movie)
                return -1;
            if (b.Type == VideoType.Movie)
                return 1;
            if (a.Type == VideoType.Cartoon)
                return -1;
            if (b.Type == VideoType.Cartoon)
                return 1;
            if (a.Type == VideoType.MiniSeries)
                return -1;
            if (b.Type == VideoType.MiniSeries)
                return 1;
            if (a.Type == VideoType.Series)
                return -1;
            if (b.Type == VideoType.Series)
                return 1;
            return 0;
        }

        public static int CompareByUserScore(VideoRecord a, VideoRecord b)
        {
            if (a.UserScore == b.UserScore)
                return CompareByName(a, b);
            return (int)((b.UserScore - a.UserScore) * 100);
        }

        public static int CompareByDuration(VideoRecord a, VideoRecord b)
        {
            if (a.FullDuration == b.FullDuration)
                return CompareByName(a, b);
            return (int)((b.FullDuration - a.FullDuration) * 100);
        }

        public static int CompareByYear(VideoRecord a, VideoRecord b)
        {
            string aYearString = a.Year.Substring(0, 4);
            string bYearString = b.Year.Substring(0, 4);
            if (aYearString == bYearString)
                return CompareByName(a, b);
            int aYear = 0;
            int bYear = 0;
            if (int.TryParse(aYearString, out aYear) && int.TryParse(bYearString, out bYear))
                return (int)((bYear - aYear) * 100);

            return CompareByName(a, b);
        }

        public static int CompareBySize(VideoRecord a, VideoRecord b)
        {
            if (a.Type != b.Type)
                return CompareByType(a, b);
            if (a.SizeNum == b.SizeNum)
                return CompareByName(a, b);
            else if (a.SizeNum < b.SizeNum)
                return 1;
            else
                return -1;
        }

        public static int CompareByQuality(VideoRecord a, VideoRecord b)
        {
            if (a.Type != b.Type)
                return CompareByType(a, b);

            int res = CompareByResolution(a, b);
            if (res != 0)
                return res;

            int hdr = CompareByHdr(a, b);
            if (hdr != 0)
                return hdr;

            return CompareByName(a, b);
        }

        private static int CompareByResolution(VideoRecord a, VideoRecord b) => (int)b.Resolution - (int)a.Resolution;        

        private static int CompareByHdr(VideoRecord a, VideoRecord b)
        {
            if (a.IsHdr == b.IsHdr)
                return 0;
            else if (a.IsHdr)
                return -1;
            else
                return 1;
        }

        public static int CompareByDateView(VideoRecord a, VideoRecord b)
        {
            if (a.Date == b.Date)
                return string.Compare(a.Name, b.Name);
            else if (a.Date.HasValue && !b.Date.HasValue)
                return -1;
            else if (!a.Date.HasValue && b.Date.HasValue)
                return 1;
            return DateTime.Compare(b.Date.Value, a.Date.Value);
        }

        #endregion
    }

    public class VideoDataCollection
    {
        private static string fileName = "VideoList.xml";
        private static VideoDataCollection _videoDataCollection;

        private List<VideoRecord> _videoList;
        public List<VideoRecord> VideoList
        {
            get { return _videoList; }
            set { _videoList = value; }
        }

        public VideoDataCollection()
        {
            VideoList = new List<VideoRecord>();
        }

        public static VideoDataCollection GetInstance()
        {
            if (_videoDataCollection == null)
                _videoDataCollection = Load();
            return _videoDataCollection;
        }

        public bool Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);
            return Check();
        }

        private bool Check()
        {
            try
            {
                VideoDataCollection toCheck = fileName.LoadAndDeserialize<VideoDataCollection>();
                if (toCheck.VideoList.Count != VideoList.Count)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static VideoDataCollection Load()
        {
            VideoDataCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<VideoDataCollection>();
            }
            catch
            {
                return new VideoDataCollection();
            }

            result.VideoList.Sort(VideoRecord.CompareByType);

            foreach (VideoRecord record in result.VideoList)
                if (string.IsNullOrWhiteSpace(record.OrigName))
                {
                    int first = record.Name.IndexOf('(');
                    int last = record.Name.IndexOf(')');
                    if (first != -1 && last != -1 && first < last)
                    {
                        record.OrigName = record.Name.Substring(first + 1, last - first - 1);
                        record.Name = record.Name.Substring(0, first - 1);
                    }
                }

            return result;
        }

        public void Add(VideoRecord record)
        {
            VideoList.Add(record);
            VideoList.Sort(VideoRecord.CompareByType);
        }
    }

    public enum VideoType
    {
        Movie,
        Cartoon,
        Series,
        MiniSeries,
        Unknown
    }

    public enum Existence
    {
        Had,
        Have,
        WillHave,
        Collection,
        Unknown
    }

    public enum Resolution
    {
        Unknown = 0,
        SD = 540,
        HD = 720,
        FHD = 1080,
        UHD = 2160
    }

    public class SeasonDates
    {
        private int _season = 1;
        public int Season
        {
            get { return _season; }
            set { _season = value; }
        }

        private DateTime? _dateStart;
        public DateTime? DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }

        private DateTime? _dateEnd;
        public DateTime? DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }

        public static int CompareByDateEnd(SeasonDates a, SeasonDates b)
        {
            if (a.DateEnd == b.DateEnd)
                return 0;
            else if (a.DateEnd.HasValue && !b.DateEnd.HasValue)
                return -1;
            else if (!a.DateEnd.HasValue && b.DateEnd.HasValue)
                return 1;
            return DateTime.Compare(b.DateEnd.Value, a.DateEnd.Value);
        }

        public static int CompareBySeason(SeasonDates a, SeasonDates b)
        {
            if (a.Season == b.Season)
                return CompareByDateEnd(a, b);
            return (int)((b.Season - a.Season) * 100);
        }
    }
}