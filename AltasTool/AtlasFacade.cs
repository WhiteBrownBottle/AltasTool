
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltasTool
{
    class AtlasFacade
    {
        private Loader m_Loader = null;
        private Parser m_Parser = null;
        private Cutter m_Cutter = null;

        public Bitmap[] Images { get; private set; }

        public AtlasFacade()
        {
            this.m_Loader = new Loader();
            this.m_Parser = new Parser();
            this.m_Cutter = new Cutter();
        }

        public bool Valid(string imageFile)
        {
            return imageFile.ToLower().EndsWith(".png");
        }

        public void Process(string imageFile)
        {
            //加载
            m_Loader.Load(imageFile);

            Bitmap sourceImage = m_Loader.Image;
            string config = m_Loader.Config;
            //解析
            m_Parser.Parse(sourceImage.Width, sourceImage.Height, config);
            SpriteInfo[] spriteInfos = m_Parser.SpriteInfos;

            //切割
            m_Cutter.Cut(sourceImage, spriteInfos);
            Images = m_Cutter.Images;
        }

        public void Save(string path = null)
        {
            if (path == null)
            {
                path = m_Loader.ResourceDir;
            }

            for (int i = 0; i < m_Parser.SpriteInfos.Length; i++)
            {
                SpriteInfo info = m_Parser.SpriteInfos[i];
                Bitmap image = Images[i];
                string fileName = path + "\\" + info.Name + ".png" ;
                image.Save(fileName, ImageFormat.Png);
            }
        }
    }
}