using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    List<Material> tileMaterialsData = new List<Material>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            // タイルのマテリアルのデータをリストに追加する
            tileMaterialsData.Add(transform.GetChild(i).GetComponent<MeshRenderer>().materials[0]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tileMaterialsData.Count; i++)
        {
            // 通ったかどうかをオブジェクトの色で判断してる
            // 白じゃない＝通った
            if(tileMaterialsData[i].color == Color.white)
            {
                return;
            }
        }

        // ここに終わった時の処理を書く
        Debug.Log("Clear");
    }
}
