using UnityEngine;
using UnityEngine.UI;

public class CreditsMenu : MonoBehaviour
{
    public Button backButton;

    void Start()
    {
        backButton.onClick.AddListener(Back);
    }

    void Back()
    {
        Destroy(gameObject);
    }
}