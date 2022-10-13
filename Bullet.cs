using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10;
    Vector3 direction;

    public void setDirection(Vector3 dir)
    {
        direction = dir;
    }

    void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
        speed += 1f;
    }

    private void OnTriggerEnter(Collider object_s_kotorym_stolknoolys)
    {
        if (object_s_kotorym_stolknoolys.tag == "Enemy")
        {
           object_s_kotorym_stolknoolys.GetComponent<Enemy>().OnDeath();
    
        }
        if (object_s_kotorym_stolknoolys.tag == "Player")
        {
            FindObjectOfType<PlayerController>().ChangeHealth(-20);
         
        }
        Destroy(gameObject);
        
    }
}