using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        animation.Play("idle");//����ֱ�Ӳ���idle����
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 30), "����"))
        {
            animation.Play("run");
        }
        if (GUI.Button(new Rect(100, 0, 100, 30), "ֹͣ"))
        {
            animation.Play("idle");
        }
        if (GUI.Button(new Rect(200, 0, 100, 30), "����"))
        {
            animation.Play("attack");
            animation.PlayQueued("idle");// ������attack֮���ٲ���idle
        }
    }
}
