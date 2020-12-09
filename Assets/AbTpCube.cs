using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbTpCube
{
    public abstract Vector2[] MoveToLeft(Vector2[] pos);
    public abstract Vector2[] MoveToRight(Vector2[] pos);
    public abstract Vector2[] MoveToDown(Vector2[] pos);
    public abstract Vector2[] MoveToBottom(Vector2[] pos);
    public abstract Vector2[] MoveToRotate(Vector2[] pos);
}
