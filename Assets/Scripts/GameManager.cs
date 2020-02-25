using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 1;
	public bool gameOver;
	public GameObject gameOverPanel;
	public bool wonGame;
	public GameObject wonGamePanel;

    void Start()
    {
		
    }
 
    void Update()
    {
        
    }
	
	public void UpdateLives(int changeInLives)
	{
		lives += changeInLives;
		if (lives <= 0)
		{
			lives = 0;
			GameOver ();
		}
	}
	
	void GameOver()
	{
		gameOver = true;
		Debug.Log ("Dead");
		gameOverPanel.SetActive (true);
	}
	
	void Won()
	{
		wonGame = true;
		Debug.Log ("Won");
		wonGamePanel.SetActive (true);
	}
	
	public void PlayAgain()
	{
		SceneManager.LoadScene("SampleScene");
		Time.timeScale = 1;
	}
	
	public void Quit()
	{
		SceneManager.LoadScene("Menu Scene");
		Debug.Log ("Menu Scene");
	}
}
