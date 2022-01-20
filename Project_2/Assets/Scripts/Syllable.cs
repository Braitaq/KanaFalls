using UnityEngine;
using UnityEngine.UI;

public class Syllable : MonoBehaviour
{
    public static float speed = 1.0f;
    public GameObject floatingTextPrefab;
    
    [SerializeField]
    private string romaji;    
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private float ObjectHeight;   

    public string Romaji
    {
        get { return romaji; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        ObjectHeight = this.transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame

    void Update()
    {
       if (transform.position.y < -screenBounds.y + ObjectHeight + 0.3f)
        {
            Destroy(this.gameObject);
            var go = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            go.GetComponent<TextMesh>().text = romaji;
            FindObjectOfType<Player>().Concentration -= 5;
        }
    }
}
