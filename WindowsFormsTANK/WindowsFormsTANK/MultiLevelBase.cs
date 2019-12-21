using System.Collections.Generic;

namespace WindowsFormsTANK
{
    public class MultiLevelBase
    {
        List<Base<ITransport>> basaStages;        private const int countPlaces = 20;
        public MultiLevelBase(int countStages, int pictureWidth, int pictureHeight)
        {
            basaStages = new List<Base<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                basaStages.Add(new Base<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
 
        public Base<ITransport> this[int ind]
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
        public ITransport this[int ind, int key]//
        {
            get
            {
                if (ind > -1 && ind < basaStages.Count)
                {
                    return basaStages[ind].GetVehicleByKey(key);
                }
                return null;
            }
        }
    }

}

