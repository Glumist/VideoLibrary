using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace VideoLibrary
{
    [Serializable]
    public class VideoTag
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

        public VideoTag() { }

        public VideoTag(int id, string text, Image image, string extension)
        {
            Id = id;
            Text = text;
            Image = image;
            Extension = extension;
        }

        public override string ToString() => Text;

        public static int CompareById(VideoTag a, VideoTag b) => a.Id - b.Id;

        public static int CompareByText(VideoTag a, VideoTag b) => string.Compare(a.Text, b.Text);

        public static Image GetTagsPic(List<VideoTag> tags)
        {
            List<Image> tagPics = new List<Image>();
            foreach (VideoTag tag in tags)
                if (tag.Image != null)
                    tagPics.Add(tag.Image);
            if (tagPics.Count == 0)
                return VideoRecord.ClearImage;

            return PicHelper.ConcatPics(tagPics);
        }
    }

    [Serializable]
    public class VideoTagCollection
    {
        private static string fileName = "Tags.xml";
        private static VideoTagCollection _videoTagCollection;

        private VideoTagCollection()
        {
            Tags = new List<VideoTag>();
        }

        public static VideoTagCollection GetInstance()
        {
            if (_videoTagCollection == null)
                _videoTagCollection = Load();
            return _videoTagCollection;
        }

        private int _nextId = 0;
        public int NextId
        {
            get { return _nextId; }
            set { _nextId = value; }
        }

        private List<VideoTag> _tags;
        public List<VideoTag> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        public void Save()
        {
            XmlSerializeHelper.SerializeAndSave(fileName, this);

            FileHelper.SaveAllTags(Tags);
        }

        private static VideoTagCollection Load()
        {
            VideoTagCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<VideoTagCollection>();
            }
            catch
            {
                return new VideoTagCollection();
            }

            Dictionary<string, Image> tagPics = FileHelper.GetAllTags();
            foreach (string key in tagPics.Keys)
            {
                string idString = Path.GetFileNameWithoutExtension(key);
                VideoTag tag = result.Tags.Find(t => t.Id.ToString() == idString);
                if (tag == null)
                    continue;

                tag.Extension = Path.GetExtension(key);
                tag.Image = tagPics[key];
            }

            result.Tags.Sort(VideoTag.CompareById);

            return result;
        }

        public void Add(string text, Image image, string extension)
        {
            Tags.Add(new VideoTag(NextId, text, image, extension));
            NextId++;
            Tags.Sort(VideoTag.CompareById);
        }

        public static void Refresh()
        { 
            _videoTagCollection = Load(); 
        }
    }
}