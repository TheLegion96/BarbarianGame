using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public float jumpForce;
    public bool jumpAllow=false;
    public GameObject Axe;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&&jumpAllow==true)
        {
            transform.position += new Vector3(0, jumpForce);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(Axe);
            Axe.transform.position = this.transform.GetChild(0).position + transform.right;
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            jumpAllow = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpAllow = false;
        }
    }
}
