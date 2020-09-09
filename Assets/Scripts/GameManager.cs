using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //config params

    //state variables
    [SerializeField] int currentLogs = 0;
    [SerializeField] int logs = 1;
    [SerializeField] TextMeshProUGUI logsText;

    [SerializeField] int currentOres = 0;
    [SerializeField] int ores = 1;
    [SerializeField] TextMeshProUGUI oresText;

    [SerializeField] int currentFish = 0;
    [SerializeField] int fish = 1;
    [SerializeField] TextMeshProUGUI fishText;

    //healthbar
    [SerializeField] int maxHealth = 100;
    [SerializeField] int currentHealth;

    public HealthBar healthBar;

    private void Awake()
    {
        //gameStatusCount will storage how many GameStatus Objects there are
        int gameStatusCount = FindObjectsOfType<GameManager>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        logsText.text = currentLogs.ToString();
        oresText.text = currentOres.ToString();
        fishText.text = currentFish.ToString();

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void AddLogs(){
        currentLogs += logs;
        logsText.text = currentLogs.ToString();
    }

    public void AddOres(){
        currentOres += ores;
        oresText.text = currentOres.ToString();
    }

    public void AddFish()
    {
        currentFish += fish;
        fishText.text = currentFish.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }


}