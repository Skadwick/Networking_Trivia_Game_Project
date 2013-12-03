using System;
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
       
        private static int numberOfQuestions = 30;

        //create an array for checking to make sure no questions are repeated and initialize to false
        private static bool[] boolArray = new bool[numberOfQuestions];

        //use random generator to grab a random question each time through inside questions method
        static Random rnd = new Random();

        public static void questions()
        {
            //variables to hold question, possible answers, and correct answer
            String question = null;
            String answers = null;
            String correctAnswer = null;
            int rand = 0;

            //Randomly select a question.  Do this until the randomized question has not yet been asked.
            do
            {
                rand = rnd.Next(0, numberOfQuestions);
            } while (boolArray[rand] == true);

            boolArray[rand] = true;

            //Questions, possible answers, and correct answer
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
                    question = "In the 1950s, the NFL experimented with what new color for their footballs?";
                    answers = "A: Black"
                            + Environment.NewLine + "B: Blue"
                            + Environment.NewLine + "C: Orange"
                            + Environment.NewLine + "D: White";
                    correctAnswer = "D";
                    break;

                case 13:
                    question = "What does the abbreviation CSS stand for?";
                    answers = "A: Cascading Style Sheets"
                            + Environment.NewLine + "B: Cat Style Sheets"
                            + Environment.NewLine + "C: Correct Style Sheets"
                            + Environment.NewLine + "D: Compiled Style Sheets";
                    correctAnswer = "A";
                    break;

                case 14:
                    question = "What three colours does Asparagus come in?";
                    answers = "A: Green, White, Yellow"
                            + Environment.NewLine + "B: Green, White, Purple"
                            + Environment.NewLine + "C: Gray, White, Purple"
                            + Environment.NewLine + "D: Black, Blue, Pink";
                    correctAnswer = "B";
                    break;

                case 15:
                    question = "What do the letters LG stand for in the name of the international electronics and chemical brand LG?";
                    answers = "A: Lucky-Goldstar"
                            + Environment.NewLine + "B: Lifes-Good"
                            + Environment.NewLine + "C: Little-GAP"
                            + Environment.NewLine + "D: Little-Graphics";
                    correctAnswer = "A";
                    break;

                case 16:
                    question = "Who developed the World Wide Web?";
                        answers = "A: Bill Gates"
                            + Environment.NewLine + "B: Steve Jobs"
                            + Environment.NewLine + "C: Steve Wasnac"
                            + Environment.NewLine + "D: Tim Berners-Lee";
                    correctAnswer = "D";
                    break;

                case 17:
                    question = "Who is the inventor of Coca Cola?";
                    answers = "A: Dr. Liu"
                        + Environment.NewLine + "B: Mike Cola"
                        + Environment.NewLine + "C: John Pemerton"
                        + Environment.NewLine + "D: Coco Coola";
                    correctAnswer = "C";
                    break;

                case 18:
                    question = "How did Alice enter Wonderland?";
                    answers = "A: Through a Door"
                        + Environment.NewLine + "B: Through a Rabbit Hole"
                        + Environment.NewLine + "C: Through a Tornado"
                        + Environment.NewLine + "D: Jumping into the Event Horizon of a Black Hole";
                    correctAnswer = "B";
                    break;

                case 19:
                    question = "What country did french fries come from?";
                    answers = "A: United States"
                        + Environment.NewLine + "B: France"
                        + Environment.NewLine + "C: Belgium"
                        + Environment.NewLine + "D: Germany";
                    correctAnswer = "C";
                    break;

                case 20:
                    question = "Who inveneted JAVA?";
                    answers = "A: Bill Gates"
                        + Environment.NewLine + "B: James Gosling"
                        + Environment.NewLine + "C: Oracle"
                        + Environment.NewLine + "D: Paul Allen";
                    correctAnswer = "B";
                    break;

                case 21:
                    question = "Worlds first computer programmer?";
                    answers = "A: Bill Gates"
                        + Environment.NewLine + "B: James Gosling"
                        + Environment.NewLine + "C: Ada Lovelace"
                        + Environment.NewLine + "D: Richard Swine";
                    correctAnswer = "C";
                    break;

                case 22:
                    question = "What was the name of the Earth's first artificial satellite?";
                    answers = "A: The Moon"
                        + Environment.NewLine + "B: Maverick I"
                        + Environment.NewLine + "C: Lovelace II"
                        + Environment.NewLine + "D: Sputnik I";
                    correctAnswer = "D";
                    break;

                case 23:
                    question = "What is a male witch called?";
                    answers = "A: Warlcok"
                        + Environment.NewLine + "B: Witch"
                        + Environment.NewLine + "C: Wizard"
                        + Environment.NewLine + "D: Shaman";
                    correctAnswer = "A";
                    break;

                case 24:
                    question = "What does the abbreviation USB stand for?";
                    answers = "A: None of the below"
                        + Environment.NewLine + "B: Unsorted Serial Bus"
                        + Environment.NewLine + "C: Universal Serial Bus"
                        + Environment.NewLine + "D: Universal Sectioned Bus";
                    correctAnswer = "C";
                    break;

                case 25:
                    question = "Which dinosaur never really existed?";
                    answers = "A: Mastadon"
                        + Environment.NewLine + "B: Brachiosaurus"
                        + Environment.NewLine + "C: Tyrannosaurus Rex"
                        + Environment.NewLine + "D: Brontosaurus";
                    correctAnswer = "D";
                    break;

                case 26:
                    question = "What do ladybugs feed on during hibernation?";
                    answers = "A: Leaves"
                        + Environment.NewLine + "B: Stored Mucus"
                        + Environment.NewLine + "C: Stored Fat"
                        + Environment.NewLine + "D: Table Scraps";
                    correctAnswer = "C";
                    break;

                case 27:
                    question = "How many Harry Potter movies are there?";
                    answers = "A: 6"
                        + Environment.NewLine + "B: 7"
                        + Environment.NewLine + "C: 8"
                        + Environment.NewLine + "D: 22";
                    correctAnswer = "C";

                    break;

                case 28:
                    question = "Which of the following is most closely related to a shark?";
                    answers = "A: Barracuda"
                        + Environment.NewLine + "B: Bass"
                        + Environment.NewLine + "C: Stingray"
                        + Environment.NewLine + "D: Tuna";
                    correctAnswer = "C";

                    break;

                case 29:
                    question = "In computer machinery what does the acronym HSF stand for?";
                    answers = "A: Heap Sorting Function"
                            + Environment.NewLine + "B: Heat Sink Funnel"
                            + Environment.NewLine + "C: Header Style format"
                            + Environment.NewLine + "D: Heat Sink and Fan";
                    correctAnswer = "D";
                    break;

                default:
                    question = "Who teaches Systems and Network Programming?";
                    answers = "A: Dr. Phelps"
                            + Environment.NewLine + "B: Dr. Liu"
                            + Environment.NewLine + "C: Dr. Goette"
                            + Environment.NewLine + "D: Dr. Who";
                    correctAnswer = "C";
                    break;
            }

            setNewQuestion(question);
            setNewAnswer(answers);
            setNewCorrectAnswer(correctAnswer);
        }

        private static void setNewQuestion(string ques)
        {
            newQuestion = ques;
        }

        private static void setNewAnswer(string ans)
        {
            updatedAnswers = ans;
        }

        private static void setNewCorrectAnswer(string corAns)
        {
            updatedCorrectAnswer = corAns;
        }

    }
}
