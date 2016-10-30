using UnityEngine;
using System.Collections;

public class MainCameraScript : MonoBehaviour {

	public GameObject[] players;
	private int numberOfPlayers;

	// Use this for initialization
	void Start () {
        numberOfPlayers = players.Length;
	}
	
	// Update is called once per frame
	void Update () {
        float avgX = 0;
        foreach (GameObject g in players)
            avgX += g.transform.position.x;
        avgX /= numberOfPlayers;
        /*float avgY = 0;
        foreach (GameObject g in players)
            avgY += g.transform.position.y;
        avgY /= numberOfPlayers;*/

        transform.position = new Vector3(avgX, transform.position.y, -10f);
    }
}
