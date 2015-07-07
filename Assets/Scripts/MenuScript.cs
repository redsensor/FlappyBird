using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour 
{

	//Add skin
	private GUISkin skin;

	void Start()
	{
		//Load skin for button
		skin = Resources.Load("GUISkin") as GUISkin;
	}

	void OnGUI()
	{
			const int buttonWidth = 280;
			const int buttonHeight = 120;

			//Set the skin to use
			
			GUI.skin = skin;

			// Determine the button's place on screen
			// Center in X, 2/3 of the height in Y

			Rect buttonRect = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(4 * Screen.height / 5) - (buttonHeight / 3),
			buttonWidth,
			buttonHeight
			);

			// Draw a button to start the game
		    // On Click, load the first level.
		    // "Scene1" is the name of the first scene we created.

			if (GUI.Button(buttonRect, "START")) 
			{
				Application.LoadLevel("Scene1");
			}

	}
}
