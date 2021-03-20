using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text; //stringbuilder사용

public class ItemManager : Singleton<ItemManager>
{
    Dictionary<string, BaseItem> m_recipeDictionary = new Dictionary<string, BaseItem>();

    public override void InitManager()
    {
        //Json에서 조합 정보 가져 올 예정
    }

    public BaseItem CombineItems(List<string> itemList)
    {
        //아이템의 이름들을 리스트로 받아와 정렬된 것을 합친 string을 key로 사용
        itemList.Sort();
        StringBuilder recipeKey = new StringBuilder();

        for (int i = 0; i < itemList.Count; i++)
            recipeKey.Append(itemList[i]);

        if (!m_recipeDictionary.ContainsKey(recipeKey.ToString()))
        {
            //안되는 소리 추가
            return null;
        }
        else
        {
            //이대로 사용 X, BaseItem을 clone시켜서 리턴해야함.
            return m_recipeDictionary[recipeKey.ToString()];
        }
    }
}
