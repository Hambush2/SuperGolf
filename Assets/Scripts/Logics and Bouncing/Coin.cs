using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int Count = 0;

    public static void AddPoints(BlockType type)
    {
        switch(type)
        {
            case BlockType.BLOCK:
            {
                Count += 30;
                break;
            }
            case BlockType.SOLIDBLOCK:
            {
                Count += 50;
                break;
            }
            case BlockType.EXPLOSIONBLOCK:
            {
                Count += 80;
                break;
            }
        }
    }

}
