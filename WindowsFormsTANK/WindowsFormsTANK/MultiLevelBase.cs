using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace WindowsFormsTANK
{
    public class MultiLevelBase
    {
        List<Base<ITransport>> basaStages;        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelBase(int countStages, int pictureWidth, int pictureHeight)
        {
            basaStages = new List<Base<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename, true, System.Text.Encoding.Default))
            {
                fs.WriteLine("CountLeveles:" + basaStages.Count);
               
                foreach (var level in basaStages)
                {
                    fs.WriteLine("Level");
                    foreach (ITransport tank in level)
                    {
                       
                        if (tank != null)
                        {
                             if (tank.GetType().Name == "Tanks")
                            {
                                fs.Write(level.GetKey + ":Tank:"+tank);
                             }
                            if (tank.GetType().Name == "TANKVehicle")
                            {
                                fs.Write(level.GetKey + ":Vehicle:"+tank);
                            }
                          
                         }
                    }
                }
              
            }
            return true;
        }
        public void Sort()
        {
            basaStages.Sort();
        }
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            int counter = -1;
            ITransport tank = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                int count;
                bool isValid = line.Contains("CountLeveles");
                if (isValid)
                {
                    count = Convert.ToInt32(line.Split(':')[1]);
                    if (basaStages != null)
                    {
                        basaStages.Clear();
                    }
                    basaStages = new List<Base<ITransport>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "Level")
                    {
                        counter++;
                        basaStages.Add(new  Base<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] splitLine = line.Split(':');
                    if (splitLine.Length > 2)
                    {
                        if (splitLine[1] == "Vehicle")
                        {
                            tank = new TANKVehicle(splitLine[2]);
                        }
                        else
                        {
                            tank = new Tanks(splitLine[2]);
                        }
                       basaStages[counter][Convert.ToInt32(splitLine[0])] = tank;
                    }
                }
                return true;
            }
           
        }
    }

}



