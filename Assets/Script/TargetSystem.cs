using UnityEngine;

public class TargetSystem : MonoBehaviour
{
    // Değişkenler
    [SerializeField] private float xPos; // rastgele x pozisyonunun sınırı
    [SerializeField] private float yPos; // rastgele y pozisyonunun sınırı
    [SerializeField] private float spawnRate; // hedeflerin çıkma hızı
    [SerializeField] private float destroyTime; // hedeflerin silinme hızı
    private float timer = 0; // zamanlayıcı
    public GameObject targetPrefab; // çoğaltılan obje

    void Update()
    {
        // Rastgele koordinatların oluşturulması
        float randomXPos = UnityEngine.Random.Range(-xPos, xPos);
        float randomYPos = UnityEngine.Random.Range(-yPos, yPos);

        // Zamanlayıcı ve Obje Çoğaltma
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            Vector2 spawnPos = new Vector2(randomXPos, randomYPos);
            Instantiate(targetPrefab, spawnPos, Quaternion.identity);
            timer = 0;
        }

    }
}
