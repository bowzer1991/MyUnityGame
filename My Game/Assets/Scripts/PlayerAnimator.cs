using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator anim;
    private PlayerDetails playerDetails;
    private PlayerController playerController;

    private float vel_y;
    private float smoothTime = 100f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerDetails = GetComponent<PlayerDetails>();
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayAnimation();
    }

    private void PlayAnimation()
    {
        
        if (!Input.GetKey(KeyCode.LeftShift)) // If left shift isn't being held
        {
            vel_y = Mathf.Clamp(playerController.vertical, -1.0f, 0.5f);
        }

        if (Input.GetKey(KeyCode.LeftShift)) // If left shift is being held
        {
            vel_y = Mathf.Clamp(playerController.vertical, -1.0f, 1.0f);
        }

        anim.SetFloat("vely", vel_y,smoothTime,smoothTime/100);
        anim.SetFloat("velx", playerController.horizontal);
    }

}
