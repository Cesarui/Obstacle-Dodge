using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    // Serializing allows you to see the variable in the view port
    // So no need to have public like I thought

    

    void Start()
    {
        
    }



    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue , yValue, zValue);
    }
}
