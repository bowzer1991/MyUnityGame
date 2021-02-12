using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator anim;
    private PlayerDetails playerDetails;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerDetails = GetComponent<PlayerDetails>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("velocity", Mathf.Clamp(playerDetails.currentSpeed, 0.0f, 200.0f));
    }
}
