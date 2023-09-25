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
            // �^�C���̃}�e���A���̃f�[�^�����X�g�ɒǉ�����
            tileMaterialsData.Add(transform.GetChild(i).GetComponent<MeshRenderer>().materials[0]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tileMaterialsData.Count; i++)
        {
            // �ʂ������ǂ������I�u�W�F�N�g�̐F�Ŕ��f���Ă�
            // ������Ȃ����ʂ���
            if(tileMaterialsData[i].color == Color.white)
            {
                return;
            }
        }

        // �����ɏI��������̏���������
        Debug.Log("Clear");
    }
}
