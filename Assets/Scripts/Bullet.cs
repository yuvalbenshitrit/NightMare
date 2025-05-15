using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float lifespan = 5f; // חיים לקליע (כדי שהוא ייעלם אחרי זמן מה)

    private void Start()
    {
        // השמדת הקליע אחרי 'lifespan' שניות, אם הוא לא פגע במשהו
        Destroy(gameObject, lifespan);
    }

    void OnTriggerEnter(Collider other)
    {
        // אם הקליע פוגע בזומבי
        if (other.CompareTag("Zombie"))
        {
            // לדוגמה, להרוס את הזומבי
            Destroy(other.gameObject); // מחיקת הזומבי

            // להשמיד את הקליע עצמו
            Destroy(gameObject);       // מחיקת הקליע
        }
    }
}
