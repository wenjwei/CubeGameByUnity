using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOne : AbTpCube
{
    public CubeOne()
    {

    }

    public bool CheckPos(Vector2[] pos)
    {
        if (pos.Length == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override Vector2[] MoveToBottom(Vector2[] pos)
    {
        if (CheckPos(pos) == false)
        {
            return null;
        }
        while (true)
        {
            for (int i = 0; i < pos.Length; i++)
            {
                pos[i].y = pos[i].y - 1;
            }
            return pos;
        }
    }


    public override Vector2[] MoveToDown(Vector2[] pos)
    {
        if (CheckPos(pos) == false)
        {
            return null;
        }
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i].y = pos[i].y - 1;
        }
        return pos;
    }


    public override Vector2[] MoveToLeft(Vector2[] pos)
    {
        if (CheckPos(pos) == false)
        {
            return null;
        }
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i].x = pos[i].x - 1;
        }
        return pos;
    }


    public override Vector2[] MoveToRight(Vector2[] pos)
    {
        if (CheckPos(pos) == false)
        {
            return null;
        }
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i].x = pos[i].x + 1;
        }
        return pos;
    }


    public override Vector2[] MoveToRotate(Vector2[] pos)
    {
        if (CheckPos(pos) == false)
        {
            return null;
        }

        float pX = (pos[0].x + pos[3].x) / 2;
        float pY = (pos[0].y + pos[3].y) / 2;
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i].x = pos[i].y - pY + pos[i].x;
            pos[i].y = pos[i].x - pX + pos[i].y;
        }
        return pos;
    }
}
