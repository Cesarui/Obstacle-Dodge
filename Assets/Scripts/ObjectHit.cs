using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // When the objects collider senses another object going in it, it'll change its color
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }

}
