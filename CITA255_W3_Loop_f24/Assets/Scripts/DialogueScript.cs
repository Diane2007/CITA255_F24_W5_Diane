using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class DialogueScript : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    const string FILE_DIR = "/Data/";
    const string FILE_NAME = "dialogue.txt";
    string FILE_PATH;

    string[] dialogueArray;

    int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
        
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;

        if (File.Exists(FILE_PATH)) 
        {
            //Debug.Log("File exists yay!");
            dialogueArray = File.ReadAllLines(FILE_PATH);

        }
        else
        {
            Debug.Log("Something is wrong with the path: " + FILE_PATH);
        }

        currentLine = 1;
        dialogueText.text = dialogueArray[currentLine];

        //DebugArray();
    }

    //click the next button to show the next line of text
    public void ClickNextButton()
    {
        if (currentLine < dialogueArray.Length - 1)
        {
            currentLine++;
            dialogueText.text = dialogueArray[currentLine];
        }
    }

    void DebugArray()
    {
        string message = "";

        //START WITH LINE 0 WITH FOR LOOP
        //for(int i = 0; i < dialogueArray.Length; i++)
        //{
        //    message += dialogueArray[i] + "\n";
        //}

        //START WITH LINE 0 WITH FOR EACH LOOP
        //foreach(string line in dialogueArray) 
        //{ 
        //    message += line + "\n"; 
        //}

        //START WITH LINE 1 WITH FOR LOOP
        for (int i = 1; i < dialogueArray.Length; i++)
        {
            message += dialogueArray[i] + "\n";
        }

        //for(int i = dialogueArray.Length - 1; i >= 0; i--) 
        //{
        //    message += dialogueArray[i] + "\n";
        //}

        Debug.Log(message);
    }

}
