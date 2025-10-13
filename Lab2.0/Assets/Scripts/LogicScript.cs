using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
   public int score=0;
   public Text scoreText;

   public void AddScore()
   {
      Debug.Log("Adding score");
      score=score+1;
      scoreText.text = score.ToString();
      Debug.Log(score);
   }
}
