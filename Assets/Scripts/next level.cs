using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            GameObject.Find("GameManager").GetComponent<UIStuffs>().gameEnd(GameObject.Find("GameManager").GetComponent<UIStuffs>().win);
        }
    }
}
