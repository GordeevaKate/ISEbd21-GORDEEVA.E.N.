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
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLevels:" + basaStages.Count);
                foreach (var level in basaStages)
                {
                    sw.WriteLine("Level");
                    foreach (ITransport tank in level)
                    {
                        if (tank != null)
                        {
                            if (tank.GetType().Name == "Tanks")
                            {
                                sw.Write(level.GetKey + ":Tank:");
                            }
                            if (tank.GetType().Name == "TANKVehicle")
                            {
                                sw.Write(level.GetKey + ":Vehicle:");
                            }
                            sw.WriteLine(tank);

                        }

                    }
                }
            }
        }
        public void Sort()
        {
            basaStages.Sort();
        }
        public void LoadData(string filename)
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
                bool isValid = line.Contains("CountLevels");

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
                        basaStages.Add(new Base<ITransport>(countPlaces,
        pictureWidth, pictureHeight));
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
                            tank= new TANKVehicle(splitLine[2]);
                        }
                        else
                        {
                            tank = new Tanks(splitLine[2]);
                        }
                        basaStages[counter][Convert.ToInt32(splitLine[0])] = tank;
                    }
                }

            }
        }
    }
}

