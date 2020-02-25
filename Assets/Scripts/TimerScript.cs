using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	Image timerBar;
	public float maxTime = 5f;
	public float timeLeft;
	public GameObject gameOverPanel;
	public GameObject Target;
	public GameManager GM;

	
    void Start()
    {
        timerBar = GetComponent<Image> ();
		timeLeft = maxTime;
    }

    public void Update()
    {
        if (timeLeft > 0)
		{
			timeLeft -= Time.deltaTime;
			timerBar.fillAmount = timeLeft / maxTime;
		}
		else {
			Destroy (Target.gameObject);
			Debug.Log("Time Out");
			GM.UpdateLives (-1);
			
		}
    }
}
