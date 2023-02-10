using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody MyBody;
    private Animator Anim;

    public Transform Cam;

    private bool isPlayermoving;

    private float playerSpeed = 0.03f;
    private float rotationspeed = 4f;

    private float jumpForce = 3f;
    private bool canJump;

    private float moveVertical;

    private float rotY = 0;

    public Transform groudCheck;
    public LayerMask groundLayer;

    private void Awake()
    {
        MyBody = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
    }

    private void Start()
    {
        rotY = transform.localRotation.eulerAngles.y;
    }

    private void Update()
    {
        PlayerMoveKeyboard();
        //Animations();
    }

    private void FixedUpdate()
    {
        MoveAndRotate();
    }


    void PlayerMoveKeyboard()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveVertical = 1;
            Anim.SetTrigger(MyTags.WALK_TRIGGER);
        }
        /*else
        {
            moveVertical = 0;
            Anim.SetTrigger(MyTags.STOP_TRIGGER);
        }*/

        if (Input.GetKeyUp(KeyCode.W))
        {
            moveVertical = 0;
            Anim.SetTrigger(MyTags.STOP_TRIGGER);
        }
    }

    void MoveAndRotate()
    {
        if(moveVertical != 0)
        {
            MyBody.MovePosition(transform.position + transform.forward * (moveVertical * playerSpeed));
        }

        MyBody.rotation = Quaternion.Euler(0f, Cam.eulerAngles.y, 0f);
    }

    /*void Animations()
    {
        if(moveVertical != 0)
        {
            if (!isPlayermoving)
            {
                if (!Anim.GetCurrentAnimatorStateInfo(0).IsName(MyTags.WALK_ANIMATION))
                {
                    isPlayermoving = true;
                    Anim.SetTrigger(MyTags.WALK_TRIGGER);
                }
            }
        }

    }*/
}
