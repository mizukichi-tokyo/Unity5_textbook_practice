using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // LoadSceneを使うのに必要

public class ClearDirector : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("GameScene");
        }	
	}
}
