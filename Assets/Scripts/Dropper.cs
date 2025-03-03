using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 3f;


    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;


    void Start()
    {
        // Cacheing(saving these variables in our memory to use it later
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
       if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }

}
