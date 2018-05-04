using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManagerEnd : MonoBehaviour {

	public void EndGameButton (string EndGame)
	{
		SceneManager.LoadScene (EndGame);
	}
}
