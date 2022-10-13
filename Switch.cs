using UnityEngine;
public class Switch : MonoBehaviour
{
    [SerializeField] GameObject pistol;
    [SerializeField] GameObject shotgun;
    [SerializeField] GameObject rifle;
    [SerializeField] GameObject firegun;
    int level = 1;
    public enum Weapon { Pistol, Shotgun, Rifle, Firegun}
    Weapon weapon;
    void Start()
    {
        switch (level)
        {
            case 1:
                ChooseWeapon(Weapon.Pistol);
                break;
            case 2:
                ChooseWeapon(Weapon.Shotgun);
                break;
            case 3:
                ChooseWeapon(Weapon.Rifle);
                break;
            case 4:
                ChooseWeapon(Weapon.Firegun);
                break;    
            default:
                print("");
                break;
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ChooseWeapon(Weapon.Pistol);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChooseWeapon(Weapon.Shotgun);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            ChooseWeapon(Weapon.Rifle);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            ChooseWeapon(Weapon.Firegun);
        }
        if (Input.GetMouseButton(0))
        {
            switch (weapon)
            {
                case Weapon.Pistol:
                    pistol.GetComponent<Gun>().Shoot();
                    break;
                case Weapon.Shotgun:
                    shotgun.GetComponent<Gun>().Shoot();
                    break;
                case Weapon.Rifle:
                    rifle.GetComponent<Gun>().Shoot();
                    break;
                case Weapon.Firegun:
                    firegun.GetComponent<Gun>().Shoot();
                    print("press f");
                    break;
            }
        }
    }
    public void LevelUp()
    {
        level += 1;
        switch (level)
        {
            case 1:
                ChooseWeapon(Weapon.Pistol);
                break;
            case 2:
                ChooseWeapon(Weapon.Shotgun);
                break;
            case 3:
                ChooseWeapon(Weapon.Rifle);
                break;
            case 4:
                ChooseWeapon(Weapon.Firegun);
                break;
            default:
                print("");
                break;
        }
    }
    public void ChooseWeapon(Weapon weapon)
    {
        this.weapon = weapon;
        switch (weapon)
        {
            case Weapon.Pistol:
                pistol.SetActive(true);
                shotgun.SetActive(false);
                rifle.SetActive(false);
                firegun.SetActive(false);
                break;
            case Weapon.Shotgun:
                pistol.SetActive(false);
                shotgun.SetActive(true);
                rifle.SetActive(false);
                firegun.SetActive(false);
                break;
            case Weapon.Rifle:
                pistol.SetActive(false);
                shotgun.SetActive(false);
                rifle.SetActive(true);
                firegun.SetActive(false);
                break;
            case Weapon.Firegun:
                pistol.SetActive(false);
                shotgun.SetActive(false);
                rifle.SetActive(false);
                firegun.SetActive(true);
                break;
            default:
                print("������ ������ � ��� ���");
                break;
        }
    }
}
