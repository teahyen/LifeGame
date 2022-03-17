using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellManager : MonoBehaviour
{
    public List<SrpRecognize> sellCheck = new List<SrpRecognize>();
    public int allAroundSell;

    private bool _isDead =false;

    public SpriteRenderer sr;

    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine("IsUpdate");
    }

    void Update()
    {
    }

    IEnumerator IsUpdate()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            for (int i = 0; i < sellCheck.Count; i++)
            {
                if (sellCheck[i].hit)
                {
                    allAroundSell += 1;
                }
                
            }
            //�׾���?
            if (!_isDead)
            {
                if (allAroundSell < 2 || allAroundSell > 3)
                {
                    Debug.Log("���� ��� :" + allAroundSell);
                    //�� ����
                    sr.enabled = false;
                    //���̾� ����
                    gameObject.layer = 6;
                    _isDead = true;
                }
                else
                {
                    sr.enabled = true;
                    gameObject.layer = 3;
                    Debug.Log("���� ����" +gameObject.name);
                }
            }
            else if (_isDead)
            {
                if (allAroundSell == 3)
                {
                    Debug.Log("���� ��Ȱ");
                    //�� ����
                    sr.enabled = true;
                    //���̾� ����
                    gameObject.layer = 3;
                    _isDead = false;
                }
                else
                {
                    gameObject.layer = 6;
                    sr.enabled = false;
                }
            }
            allAroundSell = 0;
        }
    }
}
