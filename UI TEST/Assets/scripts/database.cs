using UnityEngine;
using System;
using Firebase.Database;

[Serializable]
public class datasave
{
    public string email;
    public string password;
}


public class database : MonoBehaviour
{


    public datasave data;
    public string userid;
    DatabaseReference dataref;

    private void Awake()
    {
        dataref = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void datasavefn()
    {
        string json = JsonUtility.ToJson(data);
        dataref.Child("users").Child(userid).SetRawJsonValueAsync(json);

    }

    


}
