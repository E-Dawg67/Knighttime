using UnityEditor.EditorTools;
using UnityEngine;

public class UIStuffs : MonoBehaviour
{
    public float time = 0f;
    public float healthPoints = 5f;
    public float souls = 0f;
    public float enemies;
    public GameObject timer;
    public GameObject health;
    public GameObject soulCounter;
    public GameObject enemiesLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Gonna have to instantiate the number of enemeis at the beginning of each level
        //then put that number as the enemies float.
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        TMPro.TextMeshProUGUI ttext = timer.GetComponent<TMPro.TextMeshProUGUI>();
        ttext.text = "Time: " + time.ToString();
        TMPro.TextMeshProUGUI htext = health.GetComponent<TMPro.TextMeshProUGUI>();
        htext.text = "Health: " + healthPoints.ToString();
        TMPro.TextMeshProUGUI stext = soulCounter.GetComponent<TMPro.TextMeshProUGUI>();
        stext.text = "Souls: " + souls.ToString();
        TMPro.TextMeshProUGUI etext = enemiesLeft.GetComponent<TMPro.TextMeshProUGUI>();
        etext.text = "Enemies Left: " + enemies.ToString();
    }
}
