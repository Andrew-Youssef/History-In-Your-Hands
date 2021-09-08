using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.Video;

public class ProgramController : MonoBehaviour
{
    //Area Information Cards (GameObject)
    public GameObject egyptCard;
    public GameObject chinaCard;
    public GameObject europeCard;
    public GameObject aztecCard;

    //Are you sure you want to leave / quit panels (GameObject)
    public GameObject areYouSureLeavePanel;
    public GameObject areYouSureQuitPanel;

    //Name and log InputFields (Textboxes)
    public InputField nameInputField;
    public InputField logInputField;

    //The area semicircles on globe (Renderer)
    public Renderer egyptRenderer;
    public Renderer chinaRenderer;
    public Renderer europeRenderer;
    public Renderer aztecRenderer;

    //The area red semicirle colours (Material)
    public Material egyptNormalMaterial;
    public Material chinaNormalMaterial;
    public Material europeNormalMaterial;
    public Material aztecNormalMaterial;

    //The area yellow (highlighted) semicirle colours (Material)
    public Material egyptHighlightedMaterial;
    public Material chinaHighlightedMaterial;
    public Material europeHighlightedMaterial;
    public Material aztecHighlightedMaterial;

    public string instagramLink;
    public string itchLink;
    public string twitterLink;

    //This function exports the log to a folder (Assets folder if in Editor OR in "IST Task 2 2019_Data" folder if done in exported app)
    public void ExportingTheLog()
    {
        //Creates a path that looks for a txt file called "StudentLog"
        string path = Application.dataPath + "/StudentLog.txt";

        //If the txt file called "StudentLog" exists, start writing the log within it. OR if the file doesn't exist,
        //create it and then start writing the log within it
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Student Log" + Environment.NewLine + Environment.NewLine);
        }

        //Retreive the time at which the submit button was pressed and put it into the txt file along with the user's name
        //and their log
        string content = "Log Date: " + System.DateTime.Now + Environment.NewLine + Environment.NewLine + "Student:" + Environment.NewLine + nameInputField.text +
            Environment.NewLine + Environment.NewLine + "Log:" + Environment.NewLine + logInputField.text + Environment.NewLine + Environment.NewLine +
            Environment.NewLine + "This log was created with assistance from the 'History In Your Hands' educational application." + Environment.NewLine +
            Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine;

        //stop writing and save the log within the txt file
        File.AppendAllText(path, content);
    }
    
    //This function is called when the user closes the Ancient Egypt information card
    public void ClosingEgyptCard()
    {
        //Make the Ancient Egypt information card disappear
        egyptCard.SetActive(false);

        //Makes the yellow semicircle of Ancient Egypt turn red
        egyptRenderer.material = egyptNormalMaterial;
    }

    //This function is called when the user closes the Early Imperial China information card
    public void ClosingChinaCard()
    {
        //Make the Early Imperial China information card disappear
        chinaCard.SetActive(false);

        //Makes the yellow semicircle of Early Imperial China turn red
        chinaRenderer.material = chinaNormalMaterial;
    }

    //This function is called when the user closes the Medieval Europe information card
    public void ClosingEuropeCard()
    {
        //Make the Medieval Europe information card disappear
        europeCard.SetActive(false);

        //Makes the yellow semicircle of Medieval Europe turn red
        europeRenderer.material = europeNormalMaterial;
    }

    //This function is called when the user closes the Aztec Empire information card
    public void ClosingAztecCard()
    {
        //Make the Aztec Empire information card disappear
        aztecCard.SetActive(false);

        //Makes the yellow semicircle of Aztec Empire turn red
        aztecRenderer.material = aztecNormalMaterial;
    }

    //This function is called when the user attempts to leave an area
    public void OpenAreYouSureLeavePanel()
    {
        //Opens the "areYouSureLeavePanel" GameObject and closes the "areYouSureQuitPanel" GameObject
        areYouSureLeavePanel.SetActive(true);
        areYouSureQuitPanel.SetActive(false);
    }

    //This function is called when the user decides to not leave an area
    public void WouldLikeToNotLeave()
    {
        //Closes the "areYouSureLeavePanel" GameObject and closes the "areYouSureQuitPanel" GameObject
        areYouSureLeavePanel.SetActive(false);
        areYouSureQuitPanel.SetActive(false);
    }

    //This function is called when the user attempts to quit the program
    public void OpenAreYouSureQuitPanel()
    {
        //Opens the "areYouSureQuitPanel" GameObject
        areYouSureQuitPanel.SetActive(true);
    }
    
    //This function is called when the user decides to not quit the program
    public void WouldLikeToNotQuit()
    {
        //Closes the "areYouSureQuitPanel" GameObject
        areYouSureQuitPanel.SetActive(false);
    }

    //This function is called when the user decides they want to quit the program
    public void QuitButton()
    {
        //Quits the program
        Application.Quit();
    }

    public void OpenInstagram()
    {
        Application.OpenURL(instagramLink);
    }

    public void OpenItch()
    {
        Application.OpenURL(itchLink);
    }

    public void OpenTwitter()
    {
        Application.OpenURL(twitterLink);
    }

}
