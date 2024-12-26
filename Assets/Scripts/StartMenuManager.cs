using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    public InputField nameInput;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        if (nameInput.text != "")
        {
            GameManager.Instance.playerName = nameInput.text;
            SceneManager.LoadScene("main");
        }
    }
}