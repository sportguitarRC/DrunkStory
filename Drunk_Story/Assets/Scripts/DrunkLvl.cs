using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DrunkLvl : MonoBehaviour {

    public Slider sliderP1, sliderP2;
    public Player p1, p2;

	// Use this for initialization
	void Start () {
        p1 = GameObject.Find("Player1").GetComponent<Player>();
        p2 = GameObject.Find("Player2").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {
        sliderP1.value = p1.GetDrunkness();
        sliderP2.value = p2.GetDrunkness();
    }
}
