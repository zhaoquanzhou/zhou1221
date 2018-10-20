using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Die()
    {
        //播放死亡动画
        anim.SetBool("Dead", true);
        Destroy(gameObject, 1.5f);
        //随机掉落装备：掉的其实就是装备的id
        int idEquip = Random.Range(0, 38);
        //存储装备数据：玩家的个人数据
        PlayerData.Instence.equipData.Add(idEquip);
        //更新背包数据
        UIMansger.Instence.PresentSaveData(true, idEquip);
    }
}