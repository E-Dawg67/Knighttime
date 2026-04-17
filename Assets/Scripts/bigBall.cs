using UnityEngine;

public class bigBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(15f,30f,0f);
    }
}
