using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private CharacterController cc;
    [SerializeField] private PlayerRotation pr;

    [SerializeField] private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * moveSpeed;
        float zMove = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 movement = new Vector3(xMove, 0f, zMove);
        cc.Move(movement * Time.deltaTime);

        if (xMove != 0 || zMove != 0)
        {
            pr.Rotate(movement);
            anim.SetBool("Move", true);
        }
        else
        {
            anim.SetBool("Move", false);
        }

        if(Random.Range(1, 100) == 1)
        {
            anim.SetTrigger("IdleRandom");
        }
    }
}
