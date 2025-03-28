using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float maxtime = 8.0f;
    private float timer = 0.0f;
    public LogicManager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <  maxtime) timer += Time.deltaTime;
        else
        {
            timer = 0.0f;
            Destroy(gameObject);
            logic.SpawnObjects();
        }
    }
}
