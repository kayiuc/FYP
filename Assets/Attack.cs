using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Attack : MonoBehaviour
{

    public GameObject objectAttack;
    private Animation anim;
    public bool attackStatus = false;

    // Use this for initialization
    public void Axe_attack()
    {
       // rb = GetComponent<Rigidbody>();
        //anim = GetComponent<Animation>();
        if (attackStatus == false)
        {
            attackStatus = true;
        }
        else
            attackStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        //float x = CrossPlatformInputManager.GetAxis("Horizontal");
        //float y = CrossPlatformInputManager.GetAxis("Vertical");

        //Vector3 movement = new Vector3(x, 0, y);

        //rb.velocity = movement * 4f;

        if (attackStatus == true)
        {
            anim.Play("axe|attack");
        }
    }
}
