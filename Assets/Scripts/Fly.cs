using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityStandardAssets.CrossPlatformInput;

public class Fly : MonoBehaviour
{
	 Vector2 MoveUp;
	 private float dirX;
	 public float moveSpeed = 5f;
	 private Rigidbody2D rb;
	 public GameObject WonGamePanel;
	 public GameManager GM;



    void Start()
    {
	rb = GetComponent<Rigidbody2D>();
    }
	
	void Update()
	{
		MoveUp = gameObject.transform.position;
		MoveUp.y += 0.05f;
		gameObject.transform.position = MoveUp;
		
		dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
			rb.velocity = new Vector2(dirX, 0f);
	}
	
	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.CompareTag("Ground"))
		{
			Debug.Log("Boom");
			Time.timeScale = 0;
			Destroy (this.gameObject);
			GM.UpdateLives (-1);
		}
		if (target.CompareTag("FinishLine"))
		{
			Debug.Log("Won");
			WonGamePanel.SetActive (true);
			Time.timeScale = 0;
			return;
		}
		
	}
  
}
