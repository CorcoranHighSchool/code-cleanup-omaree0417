using UnityEngine;

public class Enemy : MonoBehaviour
{
    ][SerializedField] private float speed = 3.0f;
    private Rigidbody enemyRb;
    private const string Playertag = "Player":

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find(Playertag);
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = player.transform.position - transform.position;
        lookDirection.Normalize();
        enemyRb.AddForce(lookDirection * speed);
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        
    }
}
