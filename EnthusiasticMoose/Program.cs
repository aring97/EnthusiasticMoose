using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            // Ask a question
            AskQuestions();
            AcceptQuestions();
        }
        static void AskQuestions()
        {
            string[,] questions={{"Is Canada real?","Really? It seems very unlikely.","I  K N E W  I T !!!"},
            {"Are you enthusiastic?","Yay!", "You should try it!"},
            {"Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will..."},
            {"Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!"}};
            for(int i =0; i<3; i++){
                bool response=MooseAsks(questions[i,0]);
                if(response){
                    MooseSays(questions[i,1]);
                }
                else{
                    MooseSays(questions[i,2]);
                }
            }
        }
        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
        static bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void AcceptQuestions(){
    MooseSays("Ok now you ask a question?");
    string response =Console.ReadLine();
    while(response.Length>0){
        Random random=new Random();
        int number=random.Next(1,20);
        switch (number){
            case 1:
            System.Console.WriteLine("As I see it, yes.");
            break;
            case 2:
            System.Console.WriteLine("Ask again later.");
            break;
            case 3:
            System.Console.WriteLine("Better not tell you now.");
            break;
            case 4:
            System.Console.WriteLine("Cannot predict now.");
            break;
            case 5:
            System.Console.WriteLine("Concentrate and ask again.");
            break;
            case 6:
            System.Console.WriteLine("Don’t count on it.");
            break;
            case 7:
            System.Console.WriteLine("It is certain.");
            break;
            case 8:
            System.Console.WriteLine("It is decidedly so.");
            break;
            case 9:
            System.Console.WriteLine("Most likely.");
            break;
            case 10:
            System.Console.WriteLine("My reply is no.");
            break;
            case 11:
            System.Console.WriteLine("My sources say no.");
            break;
            case 12:
            System.Console.WriteLine("Outlook not so good.");
            break;
            case 13:
            System.Console.WriteLine("Outlook good.");
            break;
            case 14:
            System.Console.WriteLine("Reply hazy, try again.");
            break;
            case 15:
            System.Console.WriteLine("Signs point to yes.");
            break;
            case 16:
            System.Console.WriteLine("Very doubtful.");
            break;
            case 17:
            System.Console.WriteLine("Without a doubt.");
            break;
            case 18:
            System.Console.WriteLine("Yes.");
            break;
            case 19:
            System.Console.WriteLine("Yes – definitely.");
            break;
            case 20:
            System.Console.WriteLine("You may rely on it.");
            break;
        }
        MooseSays("Ask another?");
        response=Console.ReadLine();
    }
}
    }
}
