using UnityEngine;
using System.Collections;

public enum TypeObject
{
    BeerCan
};

public class InventoryObject : MonoBehaviour {

    public TypeObject typeObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("AWAILLE SPORTGUITAR");
        if (other.tag == "Player")
        {
            other.GetComponent<Inventory>().IncreaseObjectAmount(typeObject);
            Destroy(gameObject);
        }
    }
}
