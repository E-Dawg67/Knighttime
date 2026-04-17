using UnityEngine;

public class sawBlade : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 0, .75f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            GameObject.Find("GameManager").GetComponent<UIStuffs>().loseHealth();
        }
    }
}
