using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 15.0f;
    public Transform foodpos;
    public float HorizontalInput;
    public float VerticalInput;
    private float rangex = 16.0f;
    private float rangez = 15.0f;
    private float timer = 0.15f;
    private float rate = 0.15f; 
    public GameObject food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // X bound
        if (transform.position.x < -rangex)
        {
            transform.position = new Vector3(-rangex, transform.position.y, transform.position.z);
        }
        if (transform.position.x > rangex)
        {
            transform.position = new Vector3(rangex, transform.position.y, transform.position.z);
        }

        // Z bound
        if (transform.position.z > rangez)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rangez);
        }
        if (transform.position.z < -1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }

        // Z input
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);

        // X input
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);

        // spawn projectile
        if (timer < rate) timer+= Time.deltaTime;
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, foodpos.position, food.transform.rotation);
            timer = 0;
        }
    }
}
