using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;


	// Use this for initialization
	void Start ()

    {
        quitMenu = quitMenu.GetComponent<Canvas> ();
        startText = startText.GetComponent<Button> ();
        exitText = exitText.GetComponent<Button> ();
        quitMenu.enabled = false;
	
	}
	
        public void ExitPress()
    {

        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;

    } 


    public void NoPress()

    {

        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel() //this function will be used Play button

    {
        SceneManager.LoadScene ("MainS"); //"1" is the second scene in the game

    }

    public void ExitGame() //This function will be used on "Yes" button in Quit menu

    {
        Application.Quit(); //this will quit game. Note this will only work after building the game

    }


}
