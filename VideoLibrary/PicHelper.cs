using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoLibrary
{
    public class PicHelper
    {
        public static Image ConcatPics(List<Image> pics)
        {
            Bitmap pic = new Bitmap(VideoTag.ImageSize * pics.Count, VideoTag.ImageSize);
            using (Graphics g = Graphics.FromImage(pic))
                for (int i = 0; i < pics.Count; i++)
                    g.DrawImage(pics[i], i * VideoTag.ImageSize, 0, VideoTag.ImageSize, VideoTag.ImageSize);

            return pic;
        }

        public static Image MakeComplexRecordImage(Image origImage, VideoRecord record, int infoWidth = 60)
        {
            if (record == null)
                return origImage;

            Bitmap pic = new Bitmap(origImage.Width + infoWidth, origImage.Height);
            Font font =  new Font(FontFamily.GenericSansSerif, 14);

            int lineHeight = (int)(origImage.Height * 0.1);

            using (Graphics g = Graphics.FromImage(pic))
            {
                g.DrawImage(origImage, 0, 0, origImage.Width, origImage.Height);
                TextRenderer.DrawText(g, record.Year, font, new Point(origImage.Width + 5, 3), Color.Black);
                TextRenderer.DrawText(g, record.DurationStr, font, new Point(origImage.Width + 5, lineHeight), Color.Black);
                TextRenderer.DrawText(g, "" + record.Score, font, new Point(origImage.Width + 5, lineHeight * 2), Color.Black);
                TextRenderer.DrawText(g, "" + record.Size, font, new Point(origImage.Width + 5, lineHeight * 3), Color.Black);

                g.CompositingQuality = CompositingQuality.HighQuality;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                g.DrawString((record.UserScore > 0 ? "" + record.UserScore : "?"), font, 
                    new SolidBrush(VideoRecord.GetColorByUserScore(record.UserScore)), origImage.Width + 5, lineHeight * 4);
                //TextRenderer.DrawText(g, (record.UserScore > 0 ? "" + record.UserScore : "?"), 
                    //font, new Point(origImage.Width + 5, lineHeight * 4), VideoRecord.GetColorByUserScore(record.UserScore), Color.Transparent);

                Image tagsPic = record.TagsPic;
                g.DrawImage(tagsPic, origImage.Width + 5, lineHeight * 5, tagsPic.Width, tagsPic.Height);

                Image soundPic = record.SoundLanguagesPic;
                g.DrawImage(soundPic, origImage.Width + 5, lineHeight * 6, soundPic.Width, soundPic.Height);

                Image subsPic = record.SubLanguagesPic;
                g.DrawImage(subsPic, origImage.Width + 5, lineHeight * 7, subsPic.Width, subsPic.Height);

                Image resolutionPic = record.ResolutionImage;
                g.DrawImage(resolutionPic, origImage.Width + 5, lineHeight * 8, resolutionPic.Width, resolutionPic.Height);
                
                Image hdrPic = record.IsHdrImage;
                g.DrawImage(hdrPic, origImage.Width + 5, lineHeight * 9, hdrPic.Width, hdrPic.Height);
            }

            return pic;
        }
    }
}