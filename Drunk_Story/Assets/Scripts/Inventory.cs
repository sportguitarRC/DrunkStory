using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    private int nbOfCan;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public int GetNbOfCan()
    {
        return nbOfCan;
    }

    public void IncreaseObjectAmount(TypeObject typeObject)
    {
        switch (typeObject)
        {
		case TypeObject.BeerCan:
				nbOfCan++;
                break;
        }
    }

    public void DecreaseObjectAmount(TypeObject typeObject)
    {
        switch (typeObject)
        {
            case TypeObject.BeerCan:
                nbOfCan--;
                break;
        }
    }
}
