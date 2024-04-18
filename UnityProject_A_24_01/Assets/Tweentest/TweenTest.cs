using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;   //DoTween�� ����ϱ� ���� �߰�

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        //Tween ����
        //transform.DOMoveX(5, 2);     //�� ������Ʈ�� 2�ʵ��� X�� 5�� �̵� ��Ų��.
        //transform.DORotate(new Vector3(0, 0, 180), 2);     //�� ������Ʈ�� 2�ʵ��� Z������ 180�� ȸ�� ��Ų��.
        //transform.DOScale(new Vector3(2, 2, 2), 2);       //�� ������Ʈ�� 2�ʵ��� 2��� Ű���.

        //Sequence sepuence = DOTween.Sequence();
        //sepuence.Append(transform.DOMoveX(5, 2));
        //sepuence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //sepuence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce);       //Ease �ɼ��� ����Ͽ� �ٿ ȿ�� ����
        //transform.DOShakeRotation(2f, new Vector3(0, 0, 90), 10, 90);   //ȸ���� Z�� 90�� ����10, ���� 90���� ���� �ش�.

        transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(TweenEnd);  //Ʈ���� �Ϸ�Ǹ� Tween End �Լ��� ȣ�� �Ѵ�.

        Sequence sequence = DOTween.Sequence();        //Tween�� �̾ ������� ���� �����ִ� ����
        sequence.Append(transform.DOMoveX(5, 1));      //Tween ����
        sequence.SetLoops(-1, LoopType.Yoyo);          //Tween ������·� �ݺ� �Ѵ�
    }
    

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
            //tween.Kill()
        }
        
        
    }
}
