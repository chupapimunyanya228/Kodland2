
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Text HpText;
    int health;
    
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject rifleStart;

   public void ChangeHealth(int count)
{
    health = health + count;
    //меняем значение UIText в Unity
    HpText.text = "♥ " + health.ToString();
    PlayerPrefs.SetInt("health", health);

    if (health<=0)
    {

    }
}



void Start()
{
    ChangeHealth(PlayerPrefs.GetInt("health", 100));

    
}
void OnTriggerEnter(Collider other) {
        if (other.tag=="cube")
        {
            Destroy(other.gameObject);
            ChangeHealth(50);
            GetComponent<ParticleSystem>().Play();
        }
        
    }


void Update()
{

}
}