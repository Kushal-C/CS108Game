using UnityEngine;
using System.Collections;


public class PlayerTracker : MonoBehaviour
{

    public GameObject player;

    private Transform target;
    public float moveSpeed = 3;

    private Rigidbody2D rb2d;

    // Use this for initialization
    private void Awake()
    {
        player = GameObject.Find("Player");
        target = player.transform;
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        target = player.transform;
    }

    void Update()
    {
        float randRange = Random.Range(0, 5);
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, (randRange + moveSpeed) * Time.deltaTime);


    }
    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            int randRangeX = Random.Range(0, 5);
            int randRangeY = Random.Range(0, 5);
            int randRangeZ = Random.Range(0, 5);
            other.gameObject.transform.position.Set(randRangeX, randRangeY, randRangeZ);
        }
    }

}
