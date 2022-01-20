using UnityEngine;

public class floatingText : MonoBehaviour
{
    private float destroyTime = 0.8f;
    private float speed = 0.5f;

    void Start()
    {
        Destroy(gameObject, destroyTime);
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }


}
