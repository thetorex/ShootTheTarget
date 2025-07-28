using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Shoot : MonoBehaviour
{
    // Değişken atamarlı
    [SerializeField] private float destroyTime;
    public float score;

    void Start()
    {
        score = ScoreSystem.instance.score; // score ataması
    }

    void Update()
    {
        Destroy(gameObject, destroyTime); // bir süre sonra hedefin silinmesi
    }

    private void OnMouseDown() // tıklama kontrolu
    {
        if (gameObject.tag == "Target") // tag ile kontrol
        {
            Destroy(gameObject); // objeyi silme 
            ScoreSystem.instance.IncreaseScore(); // skor arttırma
        }
    }
}