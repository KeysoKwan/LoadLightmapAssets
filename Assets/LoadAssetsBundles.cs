using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadAssetsBundles : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var myLoadedAssetBundle
          = AssetBundle.LoadFromFile(Path.Combine("Assets/AssetBundles", "lightmapmodel"));
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }

        GameObject.Instantiate(myLoadedAssetBundle.LoadAsset("CubeAndSphere", typeof(GameObject)));
        GameObject.Instantiate(myLoadedAssetBundle.LoadAsset("Tower", typeof(GameObject)));
        GameObject.Instantiate(myLoadedAssetBundle.LoadAsset("Cube", typeof(GameObject)));
    }
	
}
