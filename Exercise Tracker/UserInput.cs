using Exercise_Tracker.Controller;
using Exercise_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker
{
    internal class UserInput
    {
        private readonly ExcerciseController excerciseController;

        public UserInput(ExcerciseController excerciseController )
        {
            this.excerciseController = excerciseController;
        }


        public void Run()
        {
            while (true) {

                Console.WriteLine("Welcome What exercise would you like to track? Select with the numpad.");
                Console.WriteLine("1 - Push-Ups");
                Console.WriteLine("2 - Cardio");
                Console.WriteLine("3 - Exit");

                var key = Console.ReadKey(false).Key;

                if (key == ConsoleKey.NumPad1)
                {
                    ExerciseInfo(ExerciseEnum.PushUp); 
                    break;

                } else if (key == ConsoleKey.NumPad2)
                {
                    ExerciseInfo(ExerciseEnum.Cardio);
                    break;

                } else if ( key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine("Bye!");
                    return;

                } else {
                    Console.Clear();
                    Console.WriteLine("Invalid input."); 
                }
            }
        }

        private void ExerciseInfo(ExerciseEnum exerciseType)
        {
            var exercise = new Exercise();


            Console.WriteLine("Insert the start time");
            Console.WriteLine("\nMake sure the ending time is higher than the starting time!");

            string startTime = excerciseController.checkTimeValidity(Console.ReadLine());

            Console.WriteLine("Insert the end time");
            Console.WriteLine("\nMake sure the ending time is higher than the starting time!");

            string endTime = excerciseController.checkTimeValidity(Console.ReadLine());

            endTime = excerciseController.checkTimeChronology(startTime, endTime);

            DateTime startingTimeDate = DateTime.ParseExact($"{DateTime.Today} {startTime}", "dd-MM-yyyy HH:mm",
                                          System.Globalization.CultureInfo.InvariantCulture);

            DateTime endTimeDate = DateTime.ParseExact($"{DateTime.Today} {endTime}", "dd-MM-yyyy HH:mm",
                                          System.Globalization.CultureInfo.InvariantCulture);

            exercise.ExerciseType = exerciseType;
            exercise.DateEnd = startingTimeDate;
            exercise.DateStart = endTimeDate;
            exercise.Duration = endTimeDate - startingTimeDate;

            Console.WriteLine("Woul you like to add any extra comments? Type anything");

            string? comment = Console.ReadLine();

            exercise.Comments = comment;

            excerciseController.AddExercise(exercise);

        }
    }
}
