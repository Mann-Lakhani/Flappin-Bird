using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive=true;
    public float topBound=10;
    public float bottomBound=-10;
    public AudioSource audioSource;
    public Animator wingAnimator;

    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive==true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            audioSource.Play();
        }

        if (transform.position.y > topBound || transform.position.y < bottomBound)
        {
            if (logic != null && birdIsAlive==true)
            {
                logic.gameOver();
                birdIsAlive=false;
                if (wingAnimator != null)
                {
                    wingAnimator.enabled=false;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logic != null)
        {
            logic.gameOver();
            birdIsAlive=false;
            if (wingAnimator != null)
            {
                wingAnimator.enabled=false;
            }
        }
    }
}
