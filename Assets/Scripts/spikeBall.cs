using UnityEngine;

public class spikeBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            GameObject.Find("GameManager").GetComponent<UIStuffs>().loseHealth();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Ground")
        {
            Destroy(gameObject);
        }
    }
}
