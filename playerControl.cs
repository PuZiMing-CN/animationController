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
        //�������ƴ���,��д�����Ĵ���ʱ�����һ������,�ǵ���Animator���������Ҫ�Ĳ�������,Trigger��ʽΪ�����,Ȼ�������������,û�кܴ�ǰҡ�Ķ���,���԰��Ƴ��¼�����,��Ȼ��ʹ�㰴�˰�ť,�����ǻ����������ǰ��Ķ���֮��ִ��
        if (Input.GetKeyDown(KeyCode.Space) ) { 

            GetComponent<Animator >().SetTrigger("jump");
        } 
    }
}
