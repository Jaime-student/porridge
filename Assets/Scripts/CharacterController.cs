using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private void Update()
    {
        // move object based on player input
        // will need an if statement when we want to get player input

        Vector3 moveDirection = Vector3.forward;

        // transform.position = transform.position + moveDirection;
        



        // when a player presses WASD move character
        // We need to create a vector
        //X Y Z 

        // if pressing D +x
        // if pressing A -x
        // if pressing W +z
        // if pressing S -z

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left;
            
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward;
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back;
        //}

        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime;

    }

}
