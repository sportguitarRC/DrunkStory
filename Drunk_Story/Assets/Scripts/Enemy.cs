using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float speed = 1;
    public GameObject projectile;
    public float attackDelay = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if(GetComponent<SpriteRenderer>().isVisible)
        {
            transform.Translate(new Vector3(-1f, 0.0f, 0.0f) * speed * Time.deltaTime);
        }

        if (attackDelay > 0)
            attackDelay--;


        int layerMask = 1 << LayerMask.NameToLayer("Player"); // Assigne true au layer "Destroyables", les autres sont à false
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(-1, 0), 5, layerMask);
        if (hit.collider != null && attackDelay == 0)
        {
            GameObject thrownObject = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            thrownObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5f, 5f), ForceMode2D.Impulse);
            attackDelay = 30;
        }
	}
}
