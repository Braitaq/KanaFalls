using System.Collections;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    public float spawnTimer = 2.0f;
    public bool gameRunning = true;

    [SerializeField]
    private GameObject[] syllablePrefab;
    [SerializeField]
    private int arrSize_0index = 7;

    [SerializeField]
    private GameObject InstructionText;


    private int randomPrefab;
    
    private Vector2 screenBounds;
    private float objectWidth;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(syllabelWave());
        Instantiate(InstructionText, new Vector2(0, 0), Quaternion.identity);
    }

    private void spawnSyllable()
    {
        randomPrefab = Random.Range(0, arrSize_0index);
        GameObject a = Instantiate(syllablePrefab[randomPrefab]) as GameObject;
        objectWidth = a.transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x + objectWidth, screenBounds.x - objectWidth), screenBounds.y + 1);
    }

    IEnumerator syllabelWave()
    {
        while (gameRunning)
        {
            yield return new WaitForSeconds(spawnTimer);
            if (gameRunning)
            {
                spawnSyllable();
            }
            
        }
        
    }

}
