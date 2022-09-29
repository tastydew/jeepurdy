using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[InitializeOnLoad]
public class LoadQuestionsFromJSON : MonoBehaviour {

	object textFromFile;
	public LoadQuestionsFromJSON(){
		Debug.Log("Test");
	}

	void Start(){
		
		textFromFile = Resources.Load<TextAsset>("Assets/JSON/Questions1");

		string convertedText = textFromFile.ToString();

		JeePurdyQuestions questions = JsonUtility.FromJson<JeePurdyQuestions>(convertedText);

	}


	

	
}

[System.Serializable]
public class JeePurdyQuestions{

	public class Categories{
		public string CatOne;
		public string CatTwo;
		public string CatThree;
		public string CatFour;
		public string CatFive;
		public string CatSix;
		public string CatSeven;
		public string CatEight;
	}

	public class Answers{

		public string CategoryID;
		public int AnswerValue;
		public string AnswerText;
	}

}
