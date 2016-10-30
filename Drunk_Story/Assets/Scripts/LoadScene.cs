using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
