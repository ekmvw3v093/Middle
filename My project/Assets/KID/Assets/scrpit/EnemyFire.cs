using UnityEngine;

namespace KID
{ 
    /// <summary>
    /// 敵人發射系統
    /// </summary>
    public class EnemyFire : FireSystem
    {
        [SerializeField, Header("生成子彈尖閣"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }           
    } 
}
