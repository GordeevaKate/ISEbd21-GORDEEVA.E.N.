using System.Collections.Generic;

namespace WindowsFormsTANK
{
    public class MultiLevelBase
    {
        List<Base<ITransport,IGuns>> basaStages;        private const int countPlaces = 20;
        public MultiLevelBase(int countStages, int pictureWidth, int pictureHeight)
        {
            basaStages = new List<Base<ITransport, IGuns>>();
            for (int i = 0; i < countStages; ++i)
            {
                basaStages.Add(new Base<ITransport, IGuns>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Base<ITransport, IGuns> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < basaStages.Count)
                {
                    return basaStages[ind];
                }
                return null;
            }
        }
        public ITransport this[int level, int key]
        {
            get
            {
                if (level > -1 && level < basaStages.Count)
                {
                    return basaStages[level].GetTransportByKey(key);
                }
                return null;
            }
        }
    }

}

