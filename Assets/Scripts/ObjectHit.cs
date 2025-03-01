using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // When the objects collider senses another object going in it, it'll change its color
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black; 
    }

}
