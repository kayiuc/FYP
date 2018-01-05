using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DragonController : MonoBehaviour {

    public GameObject objectAttack;
    public bool attackStatus = false;
    public bool attacking = false;
    private Rigidbody rb;
	private Animation anim;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animation> ();
	}
    public void Axe_attack()
    {
        // rb = GetComponent<Rigidbody>();
        //anim = GetComponent<Animation>();
        
            attackStatus = true;
        
            
    }

    // Update is called once per frame
    void Update () {
		float x = CrossPlatformInputManager.GetAxis("Horizontal");
		float y = CrossPlatformInputManager.GetAxis("Vertical");

		Vector3 movement = new Vector3 (x, 0, y);
        if (!anim.IsPlaying("axe|attack") && attackStatus == true && attacking == true) {
            attackStatus = false;
            attacking = false;
        }
		rb.velocity = movement * 4f;
        if (x != 0 && y != 0) {
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2 (x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
		}

		if (x != 0 || y != 0) {
			anim.Play ("axe|walk");
		}
        else if (attackStatus == true)
        {
            anim.Play("axe|attack");
            attacking = true;
        }
        else
        {
            anim.Play("axe|idle");
        }

        




    }
}
