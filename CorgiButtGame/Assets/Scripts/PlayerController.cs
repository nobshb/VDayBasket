using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    //private CharacterController controller;

    public Text countText;
    private CharacterController playerC;
    private int count;

    private float speed = 10f;
    private float jumpForce = 15f;
    private float gravity = 50f;
    private float rotateSpeed = 5.0f;
    private Vector3 moveDir = Vector3.zero;

    void Start()
    {
        //controller = GetComponent<CharacterController>();

        playerC = GetComponent<CharacterController>();
        count = 0;
        SetCountText();
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            //moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));

            moveDir = transform.TransformDirection(moveDir);

            moveDir *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpForce;
            }
        }

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pick Up")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.tag == "RestartBoundary")
        {
            Debug.Log("died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 7)
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}

    