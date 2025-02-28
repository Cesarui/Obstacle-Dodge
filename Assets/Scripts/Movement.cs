using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    // Serializing allows you to see the variable in the view port
    // So no need to have public like I thought



    void Start()
    {
        PrintInstruction();
    }



    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Press WASD or Arrow keys to move around");
        Debug.Log("Your job is to dodge as many obstacles as you can:)");
    }
    void MovePlayer()
    {
        /* Multiply your x input which is 1 or -1, then times it by deltaTime
          That makes sure fps is independent, which allows the moveSpeed to be consistent across
          All devices! 
       */
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
