using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class OffLineDocumentation : MonoBehaviour {

    public string enPath;
	void Start () {

        string[] files = Directory.GetFiles(enPath, "*.html", SearchOption.AllDirectories);

        string content;

        foreach (string file in files) {

            content = File.ReadAllText(file);

            content = content.Replace("http://", "");

            File.WriteAllText(file, content);

        }
        
	}
	

}
