using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(AudioSource))]

public class Player : MonoBehaviour
{

	// The force which is added when the player jumps
	// This can be changed in the Inspector window

	public Vector2 jumpForce = new Vector2(0, 300);

	void Start ()
	{
		TimeScale ();	

	}

	void Update ()
	{

		// Jump

		if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetKeyUp ("space")))
		{
			
			//Loading swing sound effect
			AudioClip swing = Resources.Load("swing") as AudioClip;

			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce (jumpForce);

			//Play sound
			audio.PlayOneShot(swing);
		}
		// Die by being off screen

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) 
		{
			Die ();
		}
	}

	void TimeScale ()
	{
		//Time scale is needed to avoid unexpected stops
		
		Time.timeScale = 1;
	}

	// Die by collision

	IEnumerator OnCollisionEnter2D(Collision2D other)
	{
		AudioClip hit = Resources.Load ("hit") as AudioClip;
		audio.PlayOneShot(hit);
		yield return new WaitForSeconds(1);
		Die();
	}
		
	void Die()
	{

		//CancelInvoke("CreateObstacle");
		Time.timeScale = 0;
		transform.gameObject.AddComponent<GameOver>();
	}
}