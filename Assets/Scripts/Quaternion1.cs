using UnityEngine;

public class Quaternion1 : MonoBehaviour
{
    void Start()
    {
        //transform.Rotate(Vector3.up, 30);
        //transform.Rotate(Vector3.right, 30);
        Quaternion q = Quaternion.FromToRotation(Vector3.up, transform.forward);

    }

    void Update()
    {
        
    }
}
