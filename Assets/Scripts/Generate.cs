using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject trees;
	public int score = 0; 
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}

	void OnGUI ()
	{
		GUI.skin.label.fixedWidth = 100;
		GUI.skin.label.fontSize = 20;
		GUI.color = Color.black;
		GUILayout.Label ("Score: " + score.ToString());

	}
	
	void CreateObstacle()
	{
		Instantiate(trees);
		score++;
	}
}