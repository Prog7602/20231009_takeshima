using UnityEngine;
using System.Collections;



public class moveHorce : MonoBehaviour
{

    public Vector3 endPosition;//目的地
    private bool deleteFlg = false;
    Vector3 velocity = Vector3.zero;
    float smoothTime = 0.5f;//移動速度
    

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, endPosition,ref velocity,smoothTime);

        if (deleteFlg && this.transform.position.x < -1250)//もし馬が画面外(x座標が-1250以下になった)時、オブジェクトを消す
        {
            Destroy(this.gameObject);
        }
    }
    //馬をendPositionに移動させ削除フラグを立てる
    public void GoodByeHource(Vector3 endPosition) 
    {
        this.endPosition = endPosition;
        deleteFlg = true;
    }
}