using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour
{

    public float jumpHeight = 4;
    public float timeToJumpApex = .4f;
    public string pNumber;
    float accelerationTimeAirborne = .2f;
    float accelerationTimeGrounded = .1f;
    float moveSpeed = 6;
    Animator animator;

    float gravity;
    float jumpVelocity;
    Vector3 velocity;
    float velocityXSmoothing;

    Controller2D controller;

    public float drunknessLevel;

    AudioSource[] sounds;
    AudioSource jumpSound;
    AudioSource pukeSound;

    void Start()
    {
        controller = GetComponent<Controller2D>();
        animator = GetComponent<Animator>();
        sounds = GetComponents<AudioSource>();

        jumpSound = sounds[0];
        pukeSound = sounds[1];

        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;

        ResetDrunkness();
    }

    void Update()
    {

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        Vector2 input = new Vector2(Input.GetAxisRaw(pNumber + "Horizontal"), Input.GetAxisRaw(pNumber + "Vertical"));

        if (Input.GetButtonDown(pNumber + "Jump") && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }

        if (Input.GetButtonDown(pNumber + "Jump") && controller.collisions.below)
        {
            jumpSound.Play();
        }

        if (drunknessLevel == 6)
        {
            Puke();
            pukeSound.Play();
        }

        float targetVelocityX = input.x * (moveSpeed - drunknessLevel / 2);
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne);
        animator.SetFloat("currentSpeed", input.x);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void ResetDrunkness()
    {
        drunknessLevel = 0;
    }

    public void AugmenterDunkness()
    {
        drunknessLevel++;
    }

    void Puke()
    {
        drunknessLevel = drunknessLevel / 2;
    }

    public float GetDrunkness()
    {
        return drunknessLevel;
    }
}
