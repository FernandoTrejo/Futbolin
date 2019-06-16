using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody rb;
    public float velocidad;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        float posicionHorizontal = Input.GetAxis("Horizontal") * velocidad;
        float posicionVertical = Input.GetAxis("Vertical") * velocidad;

        Vector3 movimiento = new Vector3(posicionHorizontal, 0, posicionVertical);

        rb.AddForce(movimiento, ForceMode.Force);
    }
}
