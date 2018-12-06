using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public List<RawImage> slots;
    public List<Texture> Weapons;

    //public int avSlots = 0;

    void Update()
    {
        setInventory();
    }

    void setInventory()
    {
        slots[0].texture = Weapons[0];
        slots[1].texture = Weapons[1];
        slots[2].texture = Weapons[2];
        slots[3].texture = Weapons[3];
        slots[4].texture = Weapons[4];
        slots[5].texture = Weapons[5];
        slots[6].texture = Weapons[6];
        slots[7].texture = Weapons[7];
        slots[8].texture = Weapons[8];
    }

    /*
    void myUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[0]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[1]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[2]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[3]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[4]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[5]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[6]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[7]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            avSlots += 1;
            SlotAvaliable(Weapons[8]);
        }

    }

    void SlotAvaliable(Texture _texture)
    {
        switch (avSlots)
        {
            case 1:
                slots[0].texture = _texture;
                break;
            case 2:
                slots[1].texture = _texture;
                break;
            case 3:
                slots[2].texture = _texture;
                break;
            case 4:
                slots[3].texture = _texture;
                break;
            case 5:
                slots[4].texture = _texture;
                break;
            case 6:
                slots[5].texture = _texture;
                break;
            case 7:
                slots[6].texture = _texture;
                break;
            case 8:
                slots[7].texture = _texture;
                break;
            case 9:
                slots[8].texture = _texture;
                break;
            case 10:
                slots[9].texture = _texture;
                break;

        }

        ///Si no esta ocupado el primer slot, agregar el sprite en esa posicion
    }*/
}
