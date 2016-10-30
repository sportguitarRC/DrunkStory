using UnityEngine;
using System.Collections;

public enum FloatingMethod
{
    UpDown,
    LeftRight,
    WeirdRound
};

public class FloatingCan : MonoBehaviour {
    private float varX = 0;
    private float varY = 0.5f;

    public FloatingMethod fMethod;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (fMethod == FloatingMethod.UpDown)
            transform.Translate(new Vector3(0.0f, Mathf.Sin(varY) * 0.15f, 0f));
        else if (fMethod == FloatingMethod.LeftRight)
            transform.Translate(new Vector3(Mathf.Sin(varX) * 0.15f, 0.0f, 0f));
        else
            transform.Translate(new Vector3(Mathf.Sin(varX) * 0.15f, Mathf.Sin(varY) * 0.15f, 0f));

        varX += 0.1f;
        varY += 0.1f;
	}
}