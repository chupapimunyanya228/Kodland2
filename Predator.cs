using UnityEngine;

public class Predator : Enemy
{    
    public override void Move()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 100) //100 - 疣滂篑 钺磬痼驽龛
        {
            transform.LookAt(player.transform);
            GetComponent<CharacterController>().Move(transform.forward * Time.deltaTime * 2);
        }
    }
    public override void Attack()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 3) //3 - 疣滂篑 囹嚓�
        {
            player.GetComponent<PlayerController>().ChangeHealth(-1);
        }
    }
}