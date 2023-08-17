using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void LoadScene(string targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }

    public void PlaySoundButtonClick()
    {
        FindObjectOfType<AudioManager>().SetCurrentSoundFXClip("ButtonClick");
    }
}
