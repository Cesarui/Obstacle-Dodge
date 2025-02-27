using UnityEngine;

public class Movement : MonoBehaviour
{
    // Serializing allows you to see the variable in the view port
    // So no need to have public like I thought

    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0f;

    void Start()
    {
        
    }



    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
