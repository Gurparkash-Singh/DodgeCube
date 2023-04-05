using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Level
{
    public static int level = 1;

    public static int currentLevel = 1;

    public static string path = Application.persistentDataPath + "/level.cube";

    public static int getLevel()
    {
        return level;
    }

    public static void setLevel()
    {
        level += 1;
    }

    public static void saveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, level);
        stream.Close();
    }

    public static void loadGame()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            level = (int) formatter.Deserialize(stream);
            stream.Close();
        }
        else
        {
            level = 1;
        }
    }
}
