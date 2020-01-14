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
        public bool SaveData(string filename)
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
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var tank = level[i];
                        if (tank != null)
                        {
                            if(tank.GetType().Name == "Tanks")
                            {
                                sw.Write(i + ":Tank:");
                            }
                            if (tank.GetType().Name == "TANKVehicle")
                            {
                                sw.Write(i + ":Vehicle:");
                            }
                            sw.WriteLine(tank);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
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
                    return false;
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
                return true;
            }
        }
        public bool SaveLevel(int levelIndex, string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            if (levelIndex < 0 || levelIndex >= basaStages.Count)
            {
                return false;
            }

            if (basaStages[levelIndex] == null)
            {
                return false;
            }

            var level = basaStages[levelIndex];

            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < countPlaces; i++)
                {
                    var tank = level[i];
                    if (tank != null)
                    {
                        if (tank.GetType().Name == "Tanks")
                        {
                            sw.Write(i + ":Tank:");
                        }
                        if (tank.GetType().Name == "TANKVehicle")
                        {
                            sw.Write(i + ":Vehicle:" );
                        }
                        sw.WriteLine(tank);
                    }
                }
            }
            return true;
        }

        public bool LoadLevel(int levelIndex, string filename)
        {
            if (levelIndex < 0 || levelIndex >= basaStages.Count)
            {
                return false;
            }

            if (!File.Exists(filename) || basaStages[levelIndex] == null)
            {
                return false;
            }
            basaStages[levelIndex].Clear();

            ITransport tank = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
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
                        if (tank != null)
                        {
                            basaStages[levelIndex][Convert.ToInt32(splitLine[0])] = tank;
                        }
                    }
                }
                return true;
            }
        }
    }
}

