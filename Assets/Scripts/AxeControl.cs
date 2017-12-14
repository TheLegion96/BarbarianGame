using System.Collections;
using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class AxeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public int axeSpeed=15;
	// Update is called once per frame
	void Update () {
        this.transform.DORotate(Vector3.zero, 60);
        this.transform.position += new Vector3(axeSpeed,0)*Time.deltaTime;
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

    }
}
