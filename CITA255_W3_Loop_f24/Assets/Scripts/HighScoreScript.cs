using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    public TextMeshProUGUI highScoreText, currentScoreText;

    List<int> highScoreList = new List<int>();

    string highScoreString, currentScoreString;

    int currentScore = 0;
    public int CurrentScore
    {
        get { return currentScore; }
        set 
        {
            currentScore = value;
            currentScoreText.text = currentScoreString + "\n" + currentScore;
        }
    }

    private void Start()
    {
        highScoreString = "High Score";
        currentScoreString = "Current Score";

        CurrentScore = 0;
    }

    public void ClickSaveButton()
    {
        if(highScoreList.Count < 5)
        {
            highScoreList.Add(currentScore);
        }
        else
        {
            int lowest = highScoreList.Min();

            //if the lowest score is smaller than the new current score
            if(lowest < currentScore) 
            { 
                //remove that lowest score
                int index = highScoreList.IndexOf(lowest);      //get the index of lowest
                highScoreList.Remove(highScoreList[index]);     //remove that lowest score

                //add the new current score into the high score list
                highScoreList.Add(CurrentScore);

                Debug.Log("Remove the lowest high score! Add the new current score!");
            }
            else
            {
                Debug.Log("Current score too low! Not adding it in!");
            }
        }

        CurrentScore = 0;       //reset the current score to 0 and update text
        DebugList();

        SortList();

        UpdateHighScoreText();
    }

    void UpdateHighScoreText()
    {
        string text = highScoreString;

        foreach(int score in highScoreList) 
        {
            text += "\n" + score;
        }

        highScoreText.text = text;
    }

    void SortList()
    {
        highScoreList.Sort();       //sort the scores in ascending order
        highScoreList.Reverse();    //sort the scores again in descending order

        DebugList();
    }

    void DebugList()
    {
        string message = "The current high score list has:";
        foreach (int score in highScoreList) 
        {
            message += score + ", ";
        }
        Debug.Log(message);
    }

    public void ClickMeButton()
    {
        CurrentScore++;
        //Debug.Log("Current score is: " + CurrentScore);
    }
}
