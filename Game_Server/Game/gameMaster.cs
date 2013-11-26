﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_Server.Game
{
    class GameMaster
    {

        public static String newQuestion = null;
        public static String updatedAnswers = null;
        public static String updatedCorrectAnswer = null;

        
        //used to determine game length
        static int gameRounds = 10;

        //change based of number of questions available in the pool
        static int numberOfQuestions = 12;

        //create an array for checking to make sure no questions are repeated and initialize to false
        static bool[] boolArray = new bool[numberOfQuestions];

        //use random generator to grab a random question each time through inside questions method
        static Random rnd = new Random();

        public static void questions()
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
                               + Environment.NewLine + "B: Macon"
                               + Environment.NewLine + "C: Marietta"
                               + Environment.NewLine + "D: Alpharetta";

                    correctAnswer = "A";

                    break;

                case 1:
                    question = "What is Tony the Tiger the mascot of?";

                    answers = "A: Cheerios"
                                + Environment.NewLine + "B: Kellog's Frosted Flakes"
                                + Environment.NewLine + "C: Chex"
                                + Environment.NewLine + "D: Cocoa Puffs";

                    correctAnswer = "B";

                    break;

                case 2:
                    question = "Who was the 43rd president of the United States of America?";

                    answers = "A: Bill Clinton"
                                + Environment.NewLine + "B: George W. Bush"
                                + Environment.NewLine + "C: Gerald Ford"
                                + Environment.NewLine + "D: George Washington";

                    correctAnswer = "B";

                    break;

                case 3:
                    question = "What is the length of 1 mile in meters?";

                    answers = "A: 1609"
                                + Environment.NewLine + "B: 5280"
                                + Environment.NewLine + "C: 2460"
                                + Environment.NewLine + "D: 980";

                    correctAnswer = "A";

                    break;

                case 4:
                    question = "What is the GCSU school mascot?";

                    answers = "A: Bulldog"
                                + Environment.NewLine + "B: Eagle"
                                + Environment.NewLine + "C: Bobcat"
                                + Environment.NewLine + "D: Falcon";

                    correctAnswer = "C";

                    break;

                case 5:
                    question = "What is the web-related nickname given to the first Monday after Thanksgiving?";

                    answers = "A: Cyber Monday"
                                + Environment.NewLine + "B: Programming Monday"
                                + Environment.NewLine + "C: compday"
                                + Environment.NewLine + "D: Christmas Day";

                    correctAnswer = "A";

                    break;

                case 6:
                    question = "Halloween is short for All Hallows' Eve as it's the night before what holiday once called All Hallows' Day?";

                    answers = "A: Memorial Day"
                            + Environment.NewLine + "B: Saint Hallowed Day"
                            + Environment.NewLine + "C: Goblin's Day"
                            + Environment.NewLine + "D: All Saints Day";

                    correctAnswer = "D";

                    break;

                case 7:
                    question = "What is the first astrological sign in the Zodiac?";

                    answers = "A: Gemini"
                            + Environment.NewLine + "B: Leo"
                            + Environment.NewLine + "C: Aries"
                            + Environment.NewLine + "D: Cancer";

                    correctAnswer = "C";

                    break;

                case 8:
                    question = "Which sign falls between May 21 and June 20 on the Tropical Zodiac?";

                    answers = "A: Taurus"
                            + Environment.NewLine + "B: Gemini"
                            + Environment.NewLine + "C: Leo"
                            + Environment.NewLine + "D: Cancer";

                    correctAnswer = "B";

                    break;

                case 9:
                    question = "Who was the primary developer in the popular FPS Call Of Duty Ghosts? ";

                    answers = "A: SledgeHammer Games"
                            + Environment.NewLine + "B: Rebellion Developments"
                            + Environment.NewLine + "C: Infinity Ward"
                            + Environment.NewLine + "D: Activision";

                    correctAnswer = "C";

                    break;

                case 10:
                    question = "This show holds the record for longest-running American live-action science fiction TV series.";

                    answers = "A: Doctor Who"
                            + Environment.NewLine + "B: Lost"
                            + Environment.NewLine + "C: Being Human"
                            + Environment.NewLine + "D: Stargate SG-1";

                    correctAnswer = "D";

                    break;

                case 11:
                    question = "What show features a serial killer working as a blood spatter analyst for a police department?";

                    answers = "A: Revelations"
                            + Environment.NewLine + "B: Magnum PI"
                            + Environment.NewLine + "C: Dexter"
                            + Environment.NewLine + "D: Red River Run";

                    correctAnswer = "C";

                    break;

                case 12:
                    question = "";

                    answers = "A: Taurus"
                            + Environment.NewLine + "B: Gemini"
                            + Environment.NewLine + "C: Leo"
                            + Environment.NewLine + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 13:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 14:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 15:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 16:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 17:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 18:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;

                case 19:
                    question = "";

                    answers = "A: Taurus"
                            + "B: Gemini"
                            + "C: Leo"
                            + "D: Cancer";

                    correctAnswer = "";

                    break;
            }

            newQuestionMethod(question);
            newAnswersMethod(answers);
            newCorrectAnswerMethod(correctAnswer);
        }

        private static void newQuestionMethod(string ques)
        {
            newQuestion = ques;
        }

        private static void newAnswersMethod(string ans)
        {
            updatedAnswers = ans;
        }

        private static void newCorrectAnswerMethod(string corAns)
        {
            updatedCorrectAnswer = corAns;
        }

    }
}
