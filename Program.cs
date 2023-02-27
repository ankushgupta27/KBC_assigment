public class Program
{
    public static void Main(string[] args)
    {
        Questions ques = new Questions();
        var selectQue = ques.GetQuestions();
        var QuesAns = (from q in selectQue select q);
        Random rnd = new Random();
        var randomQues = QuesAns.Skip(rnd.Next(9)).Take(5);
        int count = 0;
        Console.WriteLine("HEY!!!!   START GAME");
        Console.WriteLine("NAME????");
        string name = Console.ReadLine();
       
        Console.WriteLine("START->");
        foreach (var s in randomQues)
        {
            if (count < 2)
            {
                Console.WriteLine(s.Question);
                Console.WriteLine(s.Answer);
                int ans = int.Parse(Console.ReadLine());
            
               
                if (s.CorrectAns == ans)
                {
                    Console.WriteLine("Correct");
                  
                }
                else
                {
                    Console.WriteLine("Incorrect ");
                    count++;
                }
            }
            else
            {
                break;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("Sorry, you have gave two wrong answers,have a better luck for next time");
        }
        else
        {
            Console.WriteLine("Congratulations, " + name + " you have won the game");
           
        }
    }
}