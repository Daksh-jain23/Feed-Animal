using UnityEngine;
using UnityEngine.UI;
public class DetectCollisonFood : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public LogicManager logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Coin"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
