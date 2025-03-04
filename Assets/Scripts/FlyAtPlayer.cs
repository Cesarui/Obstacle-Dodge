using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveTowardsPlayer()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

}
