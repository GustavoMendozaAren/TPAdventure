using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public Transform Cam;

    private Animator Anim;
    private Rigidbody MyBody;

    private float moveVertical;

    private float playerSpeed = 0.03f;

    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 0.1f;
    int VelocityHash;

    private void Awake()
    {
        //MyBody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
        VelocityHash = Animator.StringToHash("Velocity");
    }

    void Start()
    {
        
    }

    void Update()
    {
        PlayerMoveKeyboard();
    }

    private void FixedUpdate()
    {
        //MoveAndRotate();
    }

    void PlayerMoveKeyboard()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if (forwardPressed && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!forwardPressed && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if (!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        Anim.SetFloat(VelocityHash, velocity);
    }

    /*void MoveAndRotate()
    {
        if (moveVertical != 0)
        {
            MyBody.MovePosition(transform.position + transform.forward * (moveVertical * playerSpeed));
        }

        MyBody.rotation = Quaternion.Euler(0f, Cam.eulerAngles.y, 0f);
    }*/
}
