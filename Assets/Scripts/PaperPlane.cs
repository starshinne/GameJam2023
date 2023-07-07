using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperPlane : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    private void Awake() {
        rb =GetComponent<Rigidbody2D>();
    }
}
