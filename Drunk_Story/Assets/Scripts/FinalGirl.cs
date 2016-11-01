using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalGirl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject Winner = GameObject.FindWithTag("Player");
            //MARCHE PAS MAIS JE PUSH AU CAS OU DAUTRE PERSONNES VOULAIT FAIRE DE QUOI
            //SceneManager.LoadScene("End");
        }
    }
}
