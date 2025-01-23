using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // We interpreted this assignment as the number of each activity in the course carrying a certain weight (percentages). These values are then added on to add up to the
    // overall difficulty of the course. If the professor has not taught the course before, the overall difficulty score of the course gets an additional 10% added onto it.
    // The difficulty caps out at 10.

    //Name of course and number of each activity
    public string nameOfCourse;
    public int numOfModules;
    public int numOfReadingMaterials;
    public int numOfQuizzes;
    public int numOfAssignments;
    public bool profTaughtCourse;
    
    
    // Start is called before the first frame update
    void Start()
    {
        calculateDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void calculateDifficulty()
    {
        // calculating difficulty numbers based on number of each activity and its respective difficulty weight
        double moduleWeight = numOfModules * 0.15;         
        double readingMaterialsWeight = numOfReadingMaterials * 0.30;
        double quizWeight = numOfQuizzes * 0.15;
        double assignmentWeight = numOfAssignments * 0.30;

        if (profTaughtCourse == true) //if the professor taught the course, nothing changes with the score and the name of the course and its difficulty is displayed.
        {
            double challengeScore = moduleWeight + readingMaterialsWeight + quizWeight + assignmentWeight;
            if (challengeScore > 10)
            {
                challengeScore = 10;
            }
            Debug.Log("The difficulty for the course: " + nameOfCourse + " is " + challengeScore);
        }
        else if (profTaughtCourse == false) // if the professor has not taught the course, an additional 10% gets added to the difficulty score of the course and the name 
                                            // of the course and its difficulty is displayed
        { 
            double challengeScore = moduleWeight + readingMaterialsWeight + quizWeight + assignmentWeight * 1.10;
            if (challengeScore > 10)
            {
                challengeScore = 10;
            }
            Debug.Log("The difficulty for the course: " + nameOfCourse + " is " + challengeScore);

        }
    }
}
