using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Logic to track when player hits an object and how many times
    private void OnCollisionEnter(Collision other)
    {
        /* 
           Basically if the game object you collide with is not tagged as hit,
           then the score will go up. Since if hit, hit = +1, but if is tagged
           as hit already, the score cant keep going up because youve already hit it.
        */

        // if object not hit
        if (other.gameObject.tag != "Hit")
        {
            // Hits go up, if hit do nothing
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
    }

}
