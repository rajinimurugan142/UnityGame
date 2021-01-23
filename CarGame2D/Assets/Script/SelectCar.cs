using UnityEngine;
using UnityEngine.UI;

public class SelectCar : MonoBehaviour
{
    public Button BtnLeftSide, BtnRightSide;
    private int i_currentcar;
    private void Awake()
    {
        CarSelect(0);
    }
    public void CarSelect(int cs_index)
    {
        BtnLeftSide.interactable = (cs_index != 0);
        BtnRightSide.interactable = (cs_index != transform.childCount-1);
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == cs_index);
        }
    }
    public void OnCarChange(int occ_index)
    {
        i_currentcar += occ_index;
        //Debug.Log(i_currentcar);
        CarSelect(i_currentcar);
    }
}