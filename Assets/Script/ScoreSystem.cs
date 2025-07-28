using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance { get; private set; } // sınıfın erişilebilirliği
    public int score;
    public TMP_Text scoreText;

    void Awake()
    {
        if (instance == null) // sahnede hep tek olmasını sağlama (Singleton yapısı)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        scoreText.text = score.ToString(); // skor UI'ının güncellenmesi
    }

    public void IncreaseScore(int value = 1) // skor arttırma
    {
        score += value;
    }

    public void DecreaseScore(int value = 1) // skor azaltma
    {
        score -= value;
    }

}
