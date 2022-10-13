using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed=5f;
    [SerializeField] float gravity = 50;
    [SerializeField] float jumpForce = 30;
    [SerializeField] Text txt;

    [SerializeField] Vector3 direction;

    void Update()
    {
        // moveHorizontal будет принимать значение -1 если нажата кнопка A, 1 если нажата D, 0 если эти кнопки не нажаты
        float moveHorizontal = Input.GetAxis("Horizontal");
        // moveVertical будет принимать значение -1 если нажата кнопка S, 1 если нажата W, 0 если эти кнопки не нажаты
        float moveVertical = Input.GetAxis("Vertical");
         if (moveHorizontal == 0 && moveVertical==0)
        {
            GetComponent<Animator>().SetBool("poor",false);
        } else
        {
            GetComponent<Animator>().SetBool("poor",true);
        }


        
        if (controller.isGrounded) //проверяем что мы неа земле (тема условий будет дальше)
        {
       
            //Редактируем переменную направления, используя moveHorizontal и moveVertical
            //Мы двигаемся по координатам x и z, координата y для прыжков.
            direction = new Vector3(moveHorizontal, 0, moveVertical);

            //Дополнительно умножая его на скорость передвижения (преобразуя локальные координаты к глобальным)
            direction = transform.TransformDirection(direction) * speed;

            if (Input.GetKey(KeyCode.Space)) //Проверяем что нажали пробел для прыжка
            {
                GetComponent<Animator>().SetBool("piuy",true);
                direction.y = jumpForce;
            } 
                
             

        }

        //Этой строчкой мы осуществляем изменение положения игрока на основе вектора direction
        //Time.deltaTime это количество секунд которое прошло с последнего кадра, для синхронизации по времени
        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed + 15;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - 15;
        }
    }
        int crystals;

    void OnTriggerEnter(Collider to_s_chem_stolknoolsya_personazh)
    {
        if (to_s_chem_stolknoolsya_personazh.tag == "crystal")
        {
            crystals += 1;
            txt.text = "кристаллов: " + crystals;
            Destroy(to_s_chem_stolknoolsya_personazh.gameObject);
        }

    }
    
    



    
}



