using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class select_hero : MonoBehaviour, IPointerClickHandler
{
    public Image image;
    public Text text;

    public void OnPointerClick(PointerEventData eventData)
    {

        image.sprite = eventData.pointerEnter.GetComponent<Image>().sprite;
        switch (eventData.pointerEnter.name)
        {
            case "hero1":
                text.text = "��ʦ";
                break;
            case "hero2":
                text.text = "����";
                break;
            case "hero3":
                text.text = "ʥ��ʿ";
                break;
            case "hero4":
                text.text = "սʿ";
                break;
            case "hero5":
                text.text = "��³��";
                break;
            case "hero6":
                text.text = "��ʿ";
                break;
            case "hero7":
                text.text = "����";
                break;
            case "hero8":
                text.text = "��ʦ";
                break;
            case "hero9":
                text.text = "����";
                break;
            default:
                break;

        }
        Debug.Log(VS.vsInstance.p0);
        Debug.Log(VS.vsInstance.p0);
        VS.vsInstance.p0.sprite = image.sprite;
        VS.vsInstance.p1.sprite = image.sprite;
    }
}
