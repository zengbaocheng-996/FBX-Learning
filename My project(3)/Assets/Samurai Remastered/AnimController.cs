using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimController : MonoBehaviour
{
    public Animator anim;

    public bool handingKatana = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomIdle();
        RandomIdleNoKatana();
        if(Input.GetKeyDown(KeyCode.W) && handingKatana)
        {
            anim.SetTrigger("run");
        }
        else if (Input.GetKeyDown(KeyCode.W) && !handingKatana)
        {
            anim.SetTrigger("runwithoutweapon");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("gotoidle",false);
        }
        
        else if(Input.GetKeyDown(KeyCode.H) && !handingKatana)
        {
            handingKatana = true;
            anim.SetTrigger("getthekatana");
        }
        else if (Input.GetKeyDown(KeyCode.J) && handingKatana)
        {
            anim.SetTrigger("attack1");
        }
        else if(Input.GetKeyDown(KeyCode.K) && handingKatana)
        {
            anim.SetTrigger("attack3");
        }
        else if(Input.GetKeyDown(KeyCode.L) && handingKatana)
        {
            anim.SetTrigger("attack2");
            handingKatana = false;
        }
        else
        {
            anim.SetBool("gotoidle", true);
        }
        

    }
    void RandomIdle()
    {
        float randomNum = Random.Range(0.0f, 1.0f);
        if (randomNum > 0.5)
        {
            //Debug.Log(randomNum);
            //Debug.Log("true");
            anim.SetBool("idle1", true);
        }
        else
        {
            //Debug.Log(randomNum);
            //Debug.Log("false");
            anim.SetBool("idle1", false);
        }
    }
    void RandomIdleNoKatana()
    {
        float randomNum = Random.Range(0.0f, 1.0f);
        if (randomNum > 0.5)
        {
            anim.SetBool("idle2", true);
        }
        else
        {
            anim.SetBool("idle2", false);
        }
    }
}
