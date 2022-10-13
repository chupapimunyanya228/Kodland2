using UnityEngine;

public class Shotgun : Gun
{
    void Start()
    {
        auto = false;
        cooldown = 0;
    }
    protected override void OnShoot()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject buf = Instantiate(bullet);
            print("fg");
            buf.transform.position = rifleStart.transform.position;
            float x = Random.Range(-30, 30);
            float y = Random.Range(-10, 10);
            buf.transform.rotation = transform.rotation;
            buf.GetComponent<Bullet>().setDirection(transform.forward + new Vector3(x / 100, y / 100, 0));
        }
    }
}
