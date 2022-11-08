using UnityEngine;

namespace KID
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFire : FireSystem
    {
        //偵測玩家行為:鍵盤，滑鼠，觸控與搖桿
        private void Update()
        {
            // 如果 玩家按下 空白建 就生成子彈
            if (Input.GetKey(KeyCode.Space))
            {
                SpawnBullet();


            }

        }
    }
}
