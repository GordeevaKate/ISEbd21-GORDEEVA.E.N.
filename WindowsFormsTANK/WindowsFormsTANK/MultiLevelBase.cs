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
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
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
                //Записываем количество уровней
               
                foreach (var level in basaStages)
                {
                    fs.WriteLine("Level");
                    //Начинаем уровень
                //    WriteToFile("Level" + Environment.NewLine, fs);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var tank = level[i];
                        if (tank != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (tank.GetType().Name == "Tanks")
                            {
                                fs.Write(i + ":Tank:");
                              //  WriteToFile(i + ":Tank:", fs);
                            }
                            if (tank.GetType().Name == "TANKVehicle")
                            {
                                fs.Write(i + ":Vehicle:");
                             //   WriteToFile(i + ":Vehicle:", fs);
                            }
                            fs.WriteLine(tank);
                            //Записываемые параметры
                         //   WriteToFile(tank + Environment.NewLine, fs);
                        }
                    }
                }
              
            }
            return true;
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
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
                    return false;
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



