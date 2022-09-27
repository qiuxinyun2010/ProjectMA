using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class arrow : MonoBehaviour
{
    public GameObject ar;


    // Update is called once per frame
    void Update()
    {
        FollowMouseRotate();
    }

    //������������ת
    private void FollowMouseRotate()
    {
        //��ȡ�������꣬�������Ļ���꣬Z��Ϊ0�����ﲻ��ת��  
        Vector3 mouse = Input.mousePosition;
 
        //��ȡ�������꣬�����������������꣬����ת������Ļ���꣬�����һֱ  
        Vector3 obj = Camera.main.WorldToScreenPoint(transform.position);
        mouse.z = obj.z = 0;
        //��Ļ��������������õ�ָ�������Ŀ��������
        Vector3 direction = mouse - obj;

        float angel = Mathf.Atan2(direction.y, direction.x) / Mathf.PI * 180f;

        angel += 180;
        transform.rotation = Quaternion.Euler(0, 0, angel);
        ar.transform.rotation = Quaternion.Euler(0, 0, angel+90);
        
        float len =direction.magnitude;
        //len = gameObject.transform.InverseTransformPoint(mouse).magnitude;
        //Debug.LogFormat("����={0},����{1}", len,direction);
        GetComponent<RectTransform>().sizeDelta = new Vector2(len-40, 50f);
        int cnt = (int)(len / 40);
        int need = -gameObject.transform.childCount + cnt-1;
             
        if (need > 0)
        {
            for (int i = 0; i < need; i++)
            {
                GameObject go = Instantiate(ar);
                go.SetActive(true);
                go.transform.SetParent(transform);
                go.transform.localScale = new Vector3(1, 1, 1);
                go.transform.localPosition = new Vector3(go.transform.localPosition.x, go.transform.localPosition.y, 0);
            }
        }
        else
        {
            need = -need;
            if (transform.childCount == 1)
            {
                return;
            }
            for (int i = 0; i < need; i++)
            {
                Destroy(transform.GetChild(gameObject.transform.childCount - 1).gameObject);
            }
        }    
    }

}