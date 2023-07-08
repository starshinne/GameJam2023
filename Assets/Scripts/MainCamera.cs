using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Cameratrans;
    public Rigidbody2D rb;

    private void Awake() {
        Cameratrans.GetComponent<Transform>();
        rb.GetComponent<Rigidbody2D>();
    }
    private void Update() {
        Cameratrans.position = new Vector3(rb.position.x,rb.position.y,-10);
    }
}
