using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public int life = 3;
    private int index = 0;
    public Text scoretext;
    public GameObject gameoverscreen;
    public GameObject[] lifes;

    private float rangex = 15.5f;
    private float rangez = 14.5f;
    public GameObject coin;
    public void GameOver()
    {
        gameoverscreen.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }
    public void AddScore(int value)
    {
        score += value;
        scoretext.text = score.ToString();
    }
    public void Addlife(int val)
    {
        life += val;
        Destroy(lifes[index]);
        index = (index + 1) % lifes.Length;
        if (life == 0) GameOver();
    }
    public void SpawnCoin()
    {
        float spawnposx = Random.Range(-rangex, rangex);
        float spawnposz = Random.Range(-0.5f, rangez);
        float spawnposy = 1.2f;
        Instantiate(coin, new Vector3(spawnposx, spawnposy, spawnposz), transform.rotation);
    }
}
