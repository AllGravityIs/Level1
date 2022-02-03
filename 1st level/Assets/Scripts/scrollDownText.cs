using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollDownText : MonoBehaviour
{
    public GameObject inputField;
    public GameObject player;
    private float playerPosY;
    private bool playerJumped;
    public float scrollSpeed;
    private float posY;
    private bool stopScrolling;

    private void Start()
    {
        stopScrolling = false;
        playerJumped = false;
    }
    private void FixedUpdate()
    {
        //text slide
        posY = inputField.transform.position.y;
        if (stopScrolling == false)
        {
        transform.Translate(Vector2.down * scrollSpeed);
        }

        if (posY <= 310f && playerJumped == false)
        {
            stopScrolling = true;
        }

        //player bool
        playerPosY = player.transform.position.y;
        if(playerPosY >= 1f)
        {
            playerJumped = true;
            stopScrolling = false;
        }

        //destroy inputField
        if (posY <= -120f)
            Destroy(inputField);
    }
}
