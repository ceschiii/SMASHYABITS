using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    public GameObject winEffects;

	// Use this for initialization
	void Start () {
        winEffects.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Trigger2")
        {
            Destroy(col.gameObject);
            print("hit");
            winEffects.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
            winEffects.SetActive(true);
        }
    }
}
