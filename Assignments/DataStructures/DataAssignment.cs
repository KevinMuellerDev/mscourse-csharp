using System;
namespace MSCourse.Assignments.DataStructures;

public static class DataAssignment
{
    public static void Assignment()
    {
        // initialize variables - graded assignments 
        int examAssignments = 5;
        int[][] scores = [
            [90, 86, 87, 98, 100, 94, 90],
            [92, 89, 81, 96, 90, 89],
            [90, 85, 87, 98, 68, 89, 89, 89],
            [90, 95, 87, 88, 96, 96],
            [92, 91, 90, 91, 92, 92, 92],
            [84, 86, 88, 90, 92, 94, 96, 98],
            [80, 90, 100, 80, 90, 100, 80, 90],
            [91, 91, 91, 91, 91, 91, 91]
        ];
        
        string[] studentNames =  ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" ];
        int[] studentScores;
        string currentStudentLetterGrade = "";
        
        Console.WriteLine("Student\t\tGrade\n");
        
        foreach (var name in studentNames)
        {
            string currentStudent = name;

            studentScores = GetStudentScores(currentStudent, scores);

            int sumAssignmentScores = 0;
            decimal currentStudentGrade;
            int gradedAssignments = 0;
            
            foreach (int score in studentScores)
            {
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                    sumAssignmentScores += score;

                else
                    sumAssignmentScores += score / 10;
            }
            
            currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
            currentStudentLetterGrade = GetStudentLetterGrade(currentStudentGrade);
            
            Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }

    private static int[] GetStudentScores(string currentStudent,int[][] scores)
    {
        if (currentStudent == "Sophia")
            return scores[0];
        if (currentStudent == "Andrew")
            return scores[1];
        if(currentStudent == "Emma")
            return scores[2];
        if(currentStudent == "Logan")
            return scores[3];
        if (currentStudent == "Becky")
            return scores[4];
        if (currentStudent == "Chris")
            return scores[5];
        if (currentStudent == "Eric")
            return scores[6];
        if (currentStudent == "Gregor")
            return scores[7];

        return new int[0];
    }
    
    private static string GetStudentLetterGrade(decimal currentStudentGrade)
    {
        string currentStudentLetterGrade = "";
        if (currentStudentGrade >= 97)
            currentStudentLetterGrade = "A+";
        else if (currentStudentGrade >= 93)
            currentStudentLetterGrade = "A";
        else if (currentStudentGrade >= 90)
            currentStudentLetterGrade = "A-";
        else if (currentStudentGrade >= 87)
            currentStudentLetterGrade = "B+";
        else if (currentStudentGrade >= 83)
            currentStudentLetterGrade = "B";
        else if (currentStudentGrade >= 80)
            currentStudentLetterGrade = "B-";
        else if (currentStudentGrade >= 77)
            currentStudentLetterGrade = "C+";
        else if (currentStudentGrade >= 73)
            currentStudentLetterGrade = "C";
        else if (currentStudentGrade >= 70)
            currentStudentLetterGrade = "C-";
        else if (currentStudentGrade >= 67)
            currentStudentLetterGrade = "D+";
        else if (currentStudentGrade >= 63)
            currentStudentLetterGrade = "D";
        else if (currentStudentGrade >= 60)
            currentStudentLetterGrade = "D-";
        else
            currentStudentLetterGrade = "F";

        return currentStudentLetterGrade;
    }
}