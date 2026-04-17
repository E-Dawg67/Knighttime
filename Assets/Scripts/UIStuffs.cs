using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject win, lose;

    // Update is called once per frame
    private void Start()
    {
        TMPro.TextMeshProUGUI htext = health.GetComponent<TMPro.TextMeshProUGUI>();
        htext.text = "Health: " + healthPoints.ToString();
        TMPro.TextMeshProUGUI stext = soulCounter.GetComponent<TMPro.TextMeshProUGUI>();
        stext.text = "Souls: " + souls.ToString();
        TMPro.TextMeshProUGUI etext = enemiesLeft.GetComponent<TMPro.TextMeshProUGUI>();
        etext.text = "Enemies Left: " + enemies.ToString();
    }
    void Update()
    {
        time -= Time.deltaTime;
        TMPro.TextMeshProUGUI ttext = timer.GetComponent<TMPro.TextMeshProUGUI>();
        ttext.text = "Time: " + time.ToString();
        if (time < 0f)
        {
            time = 0f;
            gameEnd(lose);
        }
    }
    public void killEnemy()
    {
        enemies--;
        TMPro.TextMeshProUGUI etext = enemiesLeft.GetComponent<TMPro.TextMeshProUGUI>();
        etext.text = "Enemies Left: " + enemies.ToString();
    }
    public void soulPickUp()
    {
        souls++;
        TMPro.TextMeshProUGUI stext = soulCounter.GetComponent<TMPro.TextMeshProUGUI>();
        stext.text = "Souls: " + souls.ToString();
    }
    public void loseHealth()
    {
        healthPoints--;
        TMPro.TextMeshProUGUI htext = health.GetComponent<TMPro.TextMeshProUGUI>();
        htext.text = "Health: " + healthPoints.ToString();
        if(healthPoints <= 0)
        {
            gameEnd(lose);
        }
    }
    public void gameEnd(GameObject ui)
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        ui.SetActive(true);
    }
    public void resetlvl()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void nextlvl()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
