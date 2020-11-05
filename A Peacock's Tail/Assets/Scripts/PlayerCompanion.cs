using UnityEngine;
using System.Collections;

public class PlayerCompanion : MonoBehaviour
{
    [SerializeField]
    private GameObject wayPoint;
    [SerializeField]
    public Vector3 offset;
    public Vector3 targetPos;//Edit: I forgot to declare this on firt time
    public float interpVelocity;
    public float cameraLerpTime = .1f;
    public float followStrength = 15f;

    // Use this for initialization
    void Start()
    {
        //At the start of the game, the zombies will find the gameobject called wayPoint.
//input amount of offset you need
    }

    void FixedUpdate()
    {
        if (wayPoint)
        {
            Vector3 posNoZ = transform.position;

            Vector3 targetDirection = (wayPoint.transform.position - posNoZ);
            interpVelocity = targetDirection.magnitude * followStrength;
            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            transform.position = Vector3.Lerp(transform.position, targetPos + offset, cameraLerpTime);
        }

    }
}