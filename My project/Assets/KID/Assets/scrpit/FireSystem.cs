using UnityEngine;

namespace KID
{
    /// <summary>
    /// 發射系統
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈欲置物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

        //自訂方法
        //生成子彈
        protected void SpawnBullet()
        {
            // 實力化(生成物件,座標，角度)
            // 生成 子彈欲置物 座標與角度跟生成點相同
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
