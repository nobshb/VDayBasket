using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundaryDestroy : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        Debug.Log("died");
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
	}
}
