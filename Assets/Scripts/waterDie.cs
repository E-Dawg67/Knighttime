using UnityEngine;

public class waterDie : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MainCamera")
        {
            GameObject.Find("GameManager").GetComponent<UIStuffs>().gameEnd(GameObject.Find("GameManager").GetComponent<UIStuffs>().lose);
        }
    }
}
