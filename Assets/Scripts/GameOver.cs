using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{

	private GUISkin skin;
	//public totalScore;

	void Start()
	{
		skin = Resources.Load ("GUISkin") as GUISkin;
		//Generate genScore = (Generate)this.GetComponent(typeof(Generate));
		//totalScore = GameObject.FindWithTag("trees");
	}

	void OnGUI()
	{
		const int buttonWidth = 280;
		const int buttonHeight = 120;

		GUI.skin = skin;
				
		// Center in X, 1/3 of the height in Y
		Rect buttonRectS = new Rect (
			Screen.width / 3 - (buttonWidth / 2),
			(3 * Screen.height / 3) - (buttonHeight / 3),
			buttonWidth,
			buttonHeight
			);

		/*if (totalScore != null) 
		{
			GUILayout.Label ("SCORE: " + totalScore.ToString ());
		}*/

		// Center in X, 1/3 of the height in Y

			Rect buttonRectR = new Rect (
			Screen.width / 1.5f - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 3),
			buttonWidth,
			buttonHeight
			);

		if (GUI.Button(buttonRectR, "RETRY"))
		
		//Reload level

		{
			Application.LoadLevel("Scene1");
		}

		// Center in X, 1/3 of the height in Y
			Rect buttonRectM = new Rect (
			Screen.width / 3 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 3),
			buttonWidth,
			buttonHeight
			);

		if (GUI.Button(buttonRectM, "MENU"))
			
		//Go to Menu
			
		{
			Application.LoadLevel("Menu");
		}
	}
}
