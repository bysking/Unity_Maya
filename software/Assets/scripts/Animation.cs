using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {
    //移动的路点
    public Transform[] movePath;
    //看点的路点
    public Transform[] lookPath;
    //看点
    public Transform lookTarget;
    //滑动条值
    public float percentage;
    //红绿蓝位置
    private float redPosition = .16f;
    private float bluePosition = .53f;
    private float greenPosition = 1;

    //gui styling
    public Font font;
    private GUIStyle style = new GUIStyle();
    void Start()
    {
        style.font = font;
    }
    void OnGUI()
    {
        percentage = GUI.VerticalSlider(new Rect(Screen.width - 20, 20, 15, Screen.height - 40), percentage, 1, 0);
        //根据提供的百分比将游戏物体置于所提供路径上。（1为百分之百）
        iTween.PutOnPath(gameObject, movePath, percentage);
        iTween.PutOnPath(lookTarget, lookPath, percentage);
        //根据提供的百分比返回一条路径上的Vector3的位置
        transform.LookAt(iTween.PointOnPath(lookPath, percentage));
        //
        if (GUI.Button(new Rect(5, Screen.height - 25, 50, 20), "Red"))
        {
            SlideTo(redPosition);
           
        }
        if (GUI.Button(new Rect(60, Screen.height - 25, 50, 20), "Blue"))
        {
            SlideTo(bluePosition);
        }
        if (GUI.Button(new Rect(115, Screen.height - 25, 50, 20), "Green"))
        {
            SlideTo(greenPosition);
        }
    }
    //-----------------------------------------【OnDrawGizmos()函数】--------------------------------------  
    // 说明：为了可视化的目的在场景视图中绘制小图标
    //--------------------------------------------------------------------------------------------------------
    void OnDrawGizmos()
    {


        //此方法只能在OnDrawGizmos()和 OnDrawGizmosSelected()中被调用
        iTween.DrawPath(movePath, Color.magenta);
        iTween.DrawPath(lookPath, Color.cyan);
        Gizmos.color = Color.black;
        Gizmos.DrawLine(transform.position, lookTarget.position);
    }
    void SlideTo(float position)
    {
        //停止iTweens
        iTween.Stop(gameObject);
        iTween.ValueTo(gameObject, iTween.Hash("from", percentage, "to", position, "time", 15, "easetype", iTween.EaseType.easeInOutCubic, "onupdate", "SlidePercentage"));
    }
    void SlidePercentage(float p)
    {
        percentage = p;
    }



}
