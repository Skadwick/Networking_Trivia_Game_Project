using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriviaGameMaster
{
    class gameMaster
    {
        static String newQuestion = null;
        static String updatedAnswers = null;
        static String updatedCorrectAnswer = null;

        //All Debug, delete below before use in program
        static int points = 0;
        static int totalPoints = points;
        static int missed = 0;
        //Delete above, part of debugging to console//

        //used to determine game length
        static int gameRounds = 10;

        //change based of number of questions available in the pool
        static int numberOfQuestions = 12;

        //create an array for checking to make sure no questions are repeated and initialize to false
        static bool[] boolArray = new bool[numberOfQuestions];

        //use random generator to grab a random question each time through inside questions method
        static Random rnd = new Random();

        static void questions()
        {
                //variables to hold question, possible answers, and correct answer
                //send question and answers to GUI for display to users, store correctAnswer for comparison with user input
                String question = null;
                String answers = null;
                String correctAnswer = null;

                //At the beginning of each loop I need to implement an error check to ensure questions aren't repeated


                //get a random number for selecting a group from the switch statement
                int rand = rnd.Next(0, numberOfQuestions);

                //check to make sure the question hasn't been visited before
                while (boolArray[rand] == true)
                {
                    rand = rnd.Next(0, numberOfQuestions);
                }

                boolArray[rand] = true;

                //Questions, possible answers, and correct answer
                //Note: I was thinking on how we wold display the possible answers, if we have 4 different checkbox's for answers I can just assign
                //      each possible answer to those checkbox's, I have them set up all in one var for debugging in the console
                //using switch
                switch (rand)
                {
                    case 0:
                        question = "What is the capital of the state Georgia in the United States of America?";

                        answers = "A: Atlanta"
                                   + "\nB: Macon"
                                   + "\nC: Marietta"
                                   + "\nD: Alpharetta";

                        correctAnswer = "A";

                        break;

                    case 1:
                        question = "What is Tony the Tiger the mascot of?";

                        answers = "A: Cheerios"
                                    + "\nB: Kellog's Frosted Flakes"
                                    + "\nC: Chex"
                                    + "\nD: Cocoa Puffs";

                        correctAnswer = "B";

                        break;

                    case 2:
                        question = "Who was the 43rd president of the United States of America?";

                        answers = "A: Bill Clinton"
                                    + "\nB: George W. Bush"
                                    + "\nC: Gerald Ford"
                                    + "\nD: George Washington";

                        correctAnswer = "B";

                        break;

                    case 3:
                        question = "What is the length of 1 mile in meters?";

                        answers = "A: 1609"
                                    + "\nB: 5280"
                                    + "\nC: 2460"
                                    + "\nD: 980";

                        correctAnswer = "A";

                        break;

                    case 4:
                        question = "What is the GCSU school mascot?";

                        answers = "A: Bulldog"
                                    + "\nB: Eagle"
                                    + "\nC: Bobcat"
                                    + "\nD: Falcon";

                        correctAnswer = "C";

                        break;

                    case 5:
                        question = "What is the web-related nickname given to the first Monday after Thanksgiving?";

                        answers = "A: Cyber Monday"
                                    + "\nB: Programming Monday"
                                    + "\nC: compday"
                                    + "\nD: Christmas Day";

                        correctAnswer = "A";

                        break;

                    case 6:
                        question = "Halloween is short for All Hallows' Eve as it's the night before what holiday once called All Hallows' Day?";

                        answers = "A: Memorial Day"
                                + "\nB: Saint Hallowed Day"
                                + "\nC: Goblin's Day"
                                + "\nD: All Saints Day";

                        correctAnswer = "D";

                        break;

                    case 7:
                        question = "What is the first astrological sign in the Zodiac?";

                        answers = "A: Gemini"
                                + "\nB: Leo"
                                + "\nC: Aries"
                                + "\nD: Cancer";

                        correctAnswer = "C";

                        break;

                    case 8:
                        question = "Which sign falls between May 21 and June 20 on the Tropical Zodiac?";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "B";

                        break;

                    case 9:
                        question = "Who was the primary developer in the popular FPS Call Of Duty Ghosts? ";

                        answers = "A: SledgeHammer Games"
                                + "\nB: Rebellion Developments"
                                + "\nC: Infinity Ward"
                                + "\nD: Activision";

                        correctAnswer = "C";

                        break;

                    case 10:
                        question = "This show holds the record for longest-running American live-action science fiction TV series.";

                        answers = "A: Doctor Who"
                                + "\nB: Lost"
                                + "\nC: Being Human"
                                + "\nD: Stargate SG-1";

                        correctAnswer = "D";

                        break;

                    case 11:
                        question = "What show features a serial killer working as a blood spatter analyst for a police department?";

                        answers = "A: Revelations"
                                + "\nB: Magnum PI"
                                + "\nC: Dexter"
                                + "\nD: Red River Run";

                        correctAnswer = "C";

                        break;

                    case 12:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 13:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 14:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 15:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 16:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 17:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 18:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;

                    case 19:
                        question = "";

                        answers = "A: Taurus"
                                + "\nB: Gemini"
                                + "\nC: Leo"
                                + "\nD: Cancer";

                        correctAnswer = "";

                        break;
                }
                
                newQuestion(question);
                newAnswers(answers);
                newCorrectAnswer(correctAnswer);
        }
        
        public static void newQuestion(string ques)
        {
            newQuestion = ques;
        }
        
        public static void newAnswers(string ans)
        {
            updatedAnswers = ans;
        }

        public static void newCorrectAnswers(string corAns)
        {
            updatedCorrectAnswer = corAns;
        }
        
        
//DEBUG SECTION
        public static void Main(String[] args)
        {
            String userInput;

//Set up boolArray with all false for questions visited, only done once
            for (int x = 0; x < boolArray.Length; x++)
            {
                boolArray[x] = false;
            }

//this loop will run 10 times or equivelent to gameRounds variable
            for (int r = 0; r < gameRounds; r++)
            {
                //call questions method each run to get new data
                questions();

//newQuestion
                Console.Out.WriteLine((r + 1) + ". " + newQuestion);
                Console.Out.WriteLine(updatedAnswers);
                Console.Out.WriteLine();
                Console.Out.WriteLine("Answer with a, b, c, or d:");
                userInput = Console.ReadLine();

                if (userInput.ToUpper() == updatedCorrectAnswer.ToUpper())
                {
                    points = 100;
                }
                else
                {
                    missed++;
                    points = 0;
                }
                //add up points
                totalPoints += points;
                Console.Out.WriteLine();
            }

            //Debugging
            Console.Out.WriteLine("You scored: " + totalPoints);
            Console.Out.WriteLine("You missed: " + missed + " questions.");
            Console.Read();

        }
    }
}
