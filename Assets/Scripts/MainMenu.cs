using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private Button playButton;
    private Button quitButton;

    private void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();

        VisualElement root = uiDocument.rootVisualElement;

        playButton = root.Q<Button>("playButton");
        quitButton = root.Q<Button>("quitButton");

        playButton.clicked += PlayGame;
        quitButton.clicked += QuitGame;
    }

    private void OnDisable()
    {
        if (playButton != null)
            playButton.clicked -= PlayGame;

        if (quitButton != null)
            quitButton.clicked -= QuitGame;
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("BlankAR");
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}