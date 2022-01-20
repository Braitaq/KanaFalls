using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField]
    private GameObject scoreText;
    [SerializeField]
    private GameObject DiffText;

    private void Start()
    {
        scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = Player.FinalScore.ToString();


        if (MainMenu.GameModeSelected == 1)
        {
            DiffText.GetComponent<TMPro.TextMeshProUGUI>().text = "Hiragana (Easy)";
        }
        else if (MainMenu.GameModeSelected == 2)
        {
            DiffText.GetComponent<TMPro.TextMeshProUGUI>().text = "Hiragana (Medium)";
        }
        else if (MainMenu.GameModeSelected == 3)
        {
            DiffText.GetComponent<TMPro.TextMeshProUGUI>().text = "Hiragana (Hard)";
        }
        else if (MainMenu.GameModeSelected == 4)
        {
            DiffText.GetComponent<TMPro.TextMeshProUGUI>().text = "Katakana (Easy)";
        }
        else if (MainMenu.GameModeSelected == 5)
        {
            DiffText.GetComponent<TMPro.TextMeshProUGUI>().text = "Katakana (Medium)";
        }
        else if (MainMenu.GameModeSelected == 6)
        {
            DiffText.GetComponent<TMPro.TextMeshProUGUI>().text = "Katakana (Hard)";
        }
    }

    public void MainMenuReturn()
    {
        SceneManager.LoadScene(0);
    }

    public void Replay()
    {
        SceneManager.LoadScene(MainMenu.GameModeSelected);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
