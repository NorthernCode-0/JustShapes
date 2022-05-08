using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    public GameObject Player;
    public float SpeedChange;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.GetComponent<PlayerMovement>().moveSpeed = SpeedChange;
    }
}
