using UnityEngine;
using System.Collections;

public class IgnorePlayerCollisionb : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}