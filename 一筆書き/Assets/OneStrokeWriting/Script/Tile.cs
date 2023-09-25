using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Material material;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        material = transform.GetComponent<MeshRenderer>().materials[0];
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.WakeUp();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("‚ ‚½‚Á‚½");
        //if(other.gameObject.transform.tag != )
        material.color = Color.blue;
    }

    //void OnControllerColliderHit(ControllerColliderHit hit)
    
}
