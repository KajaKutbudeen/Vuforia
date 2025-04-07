using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParsingJSon : MonoBehaviour
{
    public TextAsset jsonfile;

    [System.Serializable]
    public class Model
    {
        public int ID; // Make this public to be serialized
    }

    [System.Serializable]
    public class RootObject
    {
        public Model Model; // This matches the nested structure
    }

    RootObject rootObj = new RootObject();

    // Start is called before the first frame update
    void Start()
    {
        rootObj = JsonUtility.FromJson<RootObject>(jsonfile.text);
        Debug.Log("ID: " + rootObj.Model.ID); // Log the ID value
    }
}