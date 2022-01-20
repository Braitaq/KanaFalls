using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField]
    private GameObject scoreText;
    [SerializeField]
    private GameObject concentrationText;
    [SerializeField]
    private gameMaster gmObj;
    [SerializeField]
    GameObject barImage;

    [SerializeField]
    private int concentration = 40;
    [SerializeField]
    private int maxConcentration = 40;
    [SerializeField]
    private int score = 0;

    public static int FinalScore;    

    public int Concentration
    {
        get { return concentration;}
        set {
                concentration = Mathf.Clamp(value, 0, maxConcentration);
                concentrationText.GetComponent<Text>().text = concentration.ToString();
                barImage.GetComponent<Image>().fillAmount = (float)value / (float)maxConcentration;

            if (concentration == 0)
                {
                    gmObj.gameRunning = false;
                    GameObject[] syllabels = GameObject.FindGameObjectsWithTag("Syllable");
                    foreach (GameObject syllable in syllabels)
                    GameObject.Destroy(syllable);
                    FinalScore = score;
                    Invoke("GameOver", 2f);
            }
            }
    }

    public int Score
    {
        get { return score; }
        set { score = value;

            scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();

            if (value > 25)
            {
                Syllable.speed = 2f;
                gmObj.spawnTimer = 1.5f;
            }
            else if (value > 50)
            {
                Syllable.speed = 3f;
                gmObj.spawnTimer = 1.0f;
            }
            else if (value > 75)
            {
                Syllable.speed = 4f;
                gmObj.spawnTimer = 0.5f;
            }
        }
    }

    private void Start()
    {
        FinalScore = 0;
        Syllable.speed = 1f;
        scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
        concentrationText.GetComponent<Text>().text = concentration.ToString();
        barImage.GetComponent<Image>().fillAmount = 1;
        StartCoroutine(concentrationRegen());
    }

    IEnumerator concentrationRegen()
    {
        while (gmObj.gameRunning)
        {
            yield return new WaitForSeconds(4);
            if (gmObj.gameRunning)
            {
                FindObjectOfType<Player>().Concentration += 1;
            }
            
            
        }
      
    }

    void GameOver()
    {
        SceneManager.LoadScene(7);
    }

}
