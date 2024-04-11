using System;
namespace LectureEcriture
{
	public class LangageGestionnaire
	{
		public string Langage { get; set; }

		public static void Traductor(string mat, string language)
		{
            StreamReader sr = FilePathStreamReader("LanguageMats.csv");
            string line = "";

            while (!sr.EndOfStream)
			{
                line = sr.ReadLine();

                var values = line.Split(';');

                if (values[0] == mat)
                {
                    if (language == "french")
                        Console.WriteLine(values[2]);
                    else 
                        Console.WriteLine(values[3]);
                }
            }

            sr.Close();
        }

        public static StreamReader FilePathStreamReader(string filePath)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"../../../" + filePath;
            StreamReader sr = new StreamReader(path);
            return sr;
        }
    }
}

