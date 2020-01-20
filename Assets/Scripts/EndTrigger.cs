using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager game_man;

    private void OnTriggerEnter(Collider other)
    {
        game_man.Completelevel();
    }
}
