using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase2 : MonoBehaviour
{
    public static List<Card2> cardList = new List<Card2>();



    void Awake()
    {

        cardList.Add (new Card2(0, "None", 0, 0, "None"));
        cardList.Add (new Card2(1, "Human", 2, 1, "This is a human"));
        cardList.Add (new Card2(2, "Elf", 3, 3, "This is a elf"));
        cardList.Add (new Card2(3, "Dwarf", 4, 4, "This is a dwarf"));
        cardList.Add (new Card2(4, "Troll", 5, 5, "This is a Troll"));





    }
}
