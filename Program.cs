namespace Project;

class Project
{ 
    static void Main(string[] args)
    { 
        //member variables
        int score = 0;
        string choice = "";
        string response = "";

        //Lists that store answer options, correct answers per question, and the questions themselves
        List<string> options = new List<string>();
        options.Add("A");
        options.Add("B");
        options.Add("C");

        List<string> correctAnswers = new List<string>();
        correctAnswers.Add("B");
        correctAnswers.Add("A");
        correctAnswers.Add("A");
        correctAnswers.Add("C");
        correctAnswers.Add("B");
        correctAnswers.Add("B");
        correctAnswers.Add("B");
        correctAnswers.Add("C");
        correctAnswers.Add("A");
        correctAnswers.Add("A");

        List<string> questions = new List<string>();
        questions.Add("What is a for loop?\nA. A loop around a track\nB. A way to repeat a specific block of code a known number of times.\nC. A way to repeat a specifc block of code an unkown number of times.");
        questions.Add("Define computational thinking.\nA. An interrelated set of skills and practices for solving complex problems.\nB. A more spiritual way to think of things.\nC. The way computer scientists use to think.");
        questions.Add("Which of these correctly initializes an array?\nA. int[] numbers;\nB. int{} numbers;\nC. numbers[] int; ");
        questions.Add("What is a variable?\nA. various numbers\nB. math numbers\nC. storage locations");
        questions.Add("How do you read in user input?\nA. Console.WriteLine();\nB. Console.ReadLine();\nC. Console.PrintLine();");
        questions.Add("What is a nested for loop?\nA. a loop outside of a loop\nB. a loop inside another loop\nC. a loop in a nest");
        questions.Add("How are arrays and lists similar?\nA. both can change size\nB. both store collections of data\nC. the way they're declared");
        questions.Add("What is an if/else statement?\nA. tests integers\nB. tests strings\nC. tests booleans, if the the variable meets the conditional, it evaluates as true, if not it evaluates as false");
        questions.Add("What is a do while loop?\nA.runs once even if it isn't true, provides for the action's ongoing execution until the condition is no longer true\nB. sets the truth of a statement as a necessary condition\nC. a loop that executes based on a known number of times");
        questions.Add("What is a while loop?\nA. sets the truth of a statement as a necessary condition\nB. a loop that iterates based on a known number of times\nC. provides for the action's ongoing execution until the condition is no longer true");


        //for loop that iterates based on the size of the questions list
        //and also checks each iteration if the choice the user input
        //is correct or incorrect
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine(questions[i]);
            choice = Console.ReadLine();


            if (choice == correctAnswers[i])
            {
                Console.WriteLine("Correct! " + correctAnswers[i] + " Would you like to continue?");
                score += 1;
                response = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Incorrect, the answer should've been " + correctAnswers[i] + " Would you like to continue?");
                score += 0;
                response = Console.ReadLine();
            }

            if (response == "no")
            {
                break;
            }




            
            //prints out total score when done
            Console.WriteLine("Score = " + score);

        }

    }
}
   
