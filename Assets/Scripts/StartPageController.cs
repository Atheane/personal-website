using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPageController : MonoBehaviour
{
    public void OnClickButtonAbout()
    {
        SceneManager.LoadScene("About", LoadSceneMode.Single);
    }
    public void OnClickButtonPortfolio()
    {
        SceneManager.LoadScene("Portfolio", LoadSceneMode.Single);
    }
    public void OnClickButtonSkills()
    {
        SceneManager.LoadScene("Skills", LoadSceneMode.Single);
    }
}
