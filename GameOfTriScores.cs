using System;
namespace LectureEcriture
{
	public class GameOfTriScores
	{
		public static void AverageScore()
		{

            StreamReader sr = LangageGestionnaire.FilePathStreamReader("ScoresGOT.csv");

            string line = "";

            int countSucessRate = 0;
            int count = 0;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                var values = line.Split(';');

                if (int.TryParse(values[2], out int result))
                {
                    if (result > 0)
                    {
                        countSucessRate += result;
                        count++;
                    }
                }
            }

            double moyenne = countSucessRate / count;
            Console.WriteLine(moyenne);

            sr.Close();
        }
	}
}

