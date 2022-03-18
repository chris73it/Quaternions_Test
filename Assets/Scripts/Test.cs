using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float turnSpeed;
    [SerializeField] private Vector3 unitSourceV3;
    [SerializeField] private Vector3 unitTargetV3;
    private Quaternion directionQ;

    private void Start()
    {
        directionQ = Quaternion.FromToRotation(unitSourceV3, unitTargetV3);
        Debug.Log("Quaternion directionQ is " + directionQ + ".");
    }

    void Update()
    {
        //What this does is to slowly turn transform.rotation into directionQ.
        transform.rotation = Quaternion.RotateTowards(transform.rotation, directionQ, turnSpeed * Time.deltaTime);
        //Debug.Log("Quaternion transform.rotation is " + transform.rotation + ".");
    }
}