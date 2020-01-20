 using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Playermovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();  
        }
    }
}
