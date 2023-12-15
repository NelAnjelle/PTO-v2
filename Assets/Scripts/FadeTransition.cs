using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 2.0f;

    private void Start()
    {
        // Start the scene with a fade in
        StartCoroutine(Fade(1, 0));
    }

    private IEnumerator Fade(float startAlpha, float endAlpha)
    {
        Color startColor = fadeImage.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, endAlpha);

        float elapsedTime = 0;

        while (elapsedTime < fadeDuration)
        {
            fadeImage.color = Color.Lerp(startColor, endColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = endColor;
    }

    public void LoadSceneWithFade(string sceneName)
    {
        StartCoroutine(FadeAndLoad(sceneName));
    }

    private IEnumerator FadeAndLoad(string sceneName)
    {
        //yield return StartCoroutine(Fade(0, 1)); // Fade in

        // Load the scene
        SceneManager.LoadScene(sceneName);

        yield return StartCoroutine(Fade(1, 0)); // Fade out after scene load
    }
}