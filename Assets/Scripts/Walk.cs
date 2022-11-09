using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 走路的动画
/// </summary>
public class Walk : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();//找到Animation组件
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("walking");
        //animation.Play();  //用于默认的动画
        //animation.Play("Donghua");   //动画瞬间变化
        //animation.CrossFade("walking", 1f); //1s之后淡出其他动画，淡入Donghua动画
    }

}
