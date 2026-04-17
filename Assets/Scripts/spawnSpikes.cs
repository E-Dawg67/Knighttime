using UnityEngine;

public class spawnSpikes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject spikey;
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }

    
    private void Spawn()
    {
        GameObject ball = Instantiate(spikey, transform.position, transform.rotation);
        ball.GetComponent<Rigidbody>().linearVelocity = transform.forward * -10f;
    }
}
