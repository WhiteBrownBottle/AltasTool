using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltasTool
{
    class Parser
    {
        public SpriteInfo[] SpriteInfos { get; private set; }

        public void Parse(int Width, int Height, string config)
        {
            List<SpriteInfo> list = new List<SpriteInfo>();

            string[] lines = config.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] {' '});

                SpriteInfo info = new SpriteInfo(
                        parts[0],
                        Convert.ToSingle(parts[3]) * Width,
                        Convert.ToSingle(parts[4]) * Height,
                        Convert.ToSingle(parts[1]),
                        Convert.ToSingle(parts[2])
                    );
                list.Add(info);
            }

            SpriteInfos = list.ToArray();
        }
    }
}
