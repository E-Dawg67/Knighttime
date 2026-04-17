using UnityEngine;

public class soul : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }
    private void Update()
    {
        transform.position = startPos + new Vector3(0, Mathf.Sin(Time.time * 1.5f) * .5f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MainCamera")
        {
            GameObject.Find("GameManager").GetComponent<UIStuffs>().soulPickUp();
            Destroy(gameObject);
        }
    }
}
