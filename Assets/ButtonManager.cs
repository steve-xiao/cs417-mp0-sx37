using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Main menu button mapping:
    // First  = Score
    // Second = Options
    // Third  = Credits
    // Quit   = Exit

    public Button m_YourFirstButton;
    public Button m_YourSecondButton;
    public Button m_YourThirdButton;
    public Button m_QuitButton;
    public Button m_TradeButton;

    public GameObject myPrefab;       // Credits submenu prefab
    public GameObject optionsPrefab;  // Options submenu prefab

    public ScoreHolder memoryObject;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(ScoreOnClick);
        m_YourSecondButton.onClick.AddListener(OptionsOnClick);
        m_YourThirdButton.onClick.AddListener(CreditsOnClick);
        m_TradeButton.onClick.AddListener(TradeOnClick);
        m_QuitButton.onClick.AddListener(QuitButtonOnClick);
    }

    void ScoreOnClick()
    {
        Debug.Log("Score button clicked");
        memoryObject.AddScore();
    }

    void TradeOnClick()
    {
        Debug.Log("Trade button clicked");
        memoryObject.Trade();
    }

    void OptionsOnClick()
    {
        Debug.Log("Options button clicked");

        Instantiate(
            optionsPrefab,
            new Vector3(0, 0, 0),
            Quaternion.identity
        );
    }

    void CreditsOnClick()
    {
        Debug.Log("Credits button clicked");

        Instantiate(
            myPrefab,
            new Vector3(0, 0, 0),
            Quaternion.identity
        );
    }

    void QuitButtonOnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}