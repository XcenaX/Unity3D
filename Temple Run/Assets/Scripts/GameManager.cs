
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

[SerializeField]
private Text scoreText;
[SerializeField]
private Player player;

private double score = 0;
private int countOfChanges = 0;

private void Update(){
	score =  player.transform.position.z / 100.0;
	if((int)score % 5 ==0 && countOfChanges == 0){player.SetSpeed(player.GetSpeed() + 5); countOfChanges = 1;}
	else if((int)score % 5 != 0) countOfChanges = 0;
	Debug.Log("Score = "+(int)score);
	scoreText.text = "Счет: " + score.ToString("0");
}
}
