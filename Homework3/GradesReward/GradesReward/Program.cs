/*参考简单工厂模式，程序实现：输入一个分数，判断分数为ABCD哪一等级，并给出奖励。*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface Grade
{
      void reward();
}
class LevelA : Grade
{
    public LevelA()
    {
        Console.WriteLine("Level A!");
    }
    public void reward()
    {
        Console.WriteLine("Reward a backpack!");
    }
}
class LevelB : Grade
{
    public LevelB()
    {
        Console.WriteLine("Level B!");
    }
    public void reward()
    {
        Console.WriteLine("Reward a book!");
    }
}
class LevelC : Grade
{
    public LevelC()
    {
        Console.WriteLine("Level C!");
    }
    public void reward()
    {
        Console.WriteLine("Reward a pen!");
    }
}
class LevelD : Grade
{
    public LevelD()
    {
        Console.WriteLine("Level D!");
    }
    public void reward()
    {
        Console.WriteLine("No reward! Keep fighting!");
    }
}
class GradeJudge
{
    public static Grade GetGrade(int score)
    {
        Grade grade = null;
        if (score >= 90)
        {
            grade = new LevelA();
        }
        else if (score >= 80 && score < 90)
        {
            grade = new LevelB();
        }
        else if (score >= 70 && score < 80)
        {
            grade = new LevelC();
        }
        else
        {
            grade = new LevelD();
        }
        return grade;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your score:");
        int score =int.Parse ( Console.ReadLine());
        Grade grade = GradeJudge.GetGrade(score);
        grade.reward();
    }
}
