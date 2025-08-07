using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //动画控制代码,你写其他的代码时候可以一次类推,记得在Animator里面加入需要的参数条件,Trigger形式为大多数,然后如果是跳啊打啊,没有很大前摇的动作,可以把推出事件消勾,不然即使你按了按钮,它还是会在运行完成前面的动画之后执行
        if (Input.GetKeyDown(KeyCode.Space) ) { 

            GetComponent<Animator >().SetTrigger("jump");
        } 
    }
}
