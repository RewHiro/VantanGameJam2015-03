using UnityEngine;
using System.Collections;
using System.IO;

public class GameDataManager : MonoBehaviour {

    /// <summary>
    /// ゲームデータ
    /// </summary>
    public class GameData
    {
        public GameData(long soulNum,int stageNum,int enemyNum)
        {
            this.soulNum = soulNum;
            this.stageNum = stageNum;
            this.enemyNum = enemyNum;
        }

        public long soulNum { get; set; }
        public int stageNum { get; set; }
        public int enemyNum { get; set; }
    };

    static string folderPath = Application.persistentDataPath + "/Database/";
    static string filePath = folderPath + "GameData.json";

    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="data"></param>
    public void Save(GameData data)
    {
        var json = LitJson.JsonMapper.ToJson(data);

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// 読み取り
    /// </summary>
    /// <returns></returns>
    public GameData Load()
    {
        if (!Directory.Exists(folderPath)) return null;
        if (File.Exists(filePath)) return null;

        var readJson = File.ReadAllText(filePath);

        if (string.IsNullOrEmpty(readJson)) return null;

        var jsonData = LitJson.JsonMapper.ToObject<GameData>(readJson);

        return jsonData;
    }
}
