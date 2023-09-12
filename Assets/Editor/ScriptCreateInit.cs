using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ScriptCreateInit : UnityEditor.AssetModificationProcessor
{
    private static void OnWillCreateAsset(string path) {
        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs")) {
            string strContent = File.ReadAllText(path);
            //修改文本内容
            strContent = strContent.Replace("#CompanyName#", "ruirui stuio").
                                    Replace("#Author#", "砂塘学徒").
                                    Replace("#Email#","1134236006@qq.com").
                                    Replace("#CreateTime#", DateTime.Now.ToString("yyyy-MM-HH HH:mm:ss")).
                                    Replace("#Version#", "Alpha.1.0").
                                    Replace("#UnityVersion#", Application.unityVersion);
            File.WriteAllText(path, strContent);//覆盖文件内容
            AssetDatabase.Refresh();
        }
    }
}
