using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Level
{
    private static int level = 1;

    private static int currentLevel = 1;

    private static string path = Application.persistentDataPath + "/level.cube";

    public static int getLevel()
    {
        return level;
    }

    public static void setLevel()
    {
        if (level < 10)
        {
            level += 1;
        }
    }

    public static int getCurrentLevel()
    {
        return currentLevel;
    }

    public static bool setCurrentLevel(int levelToSet)
    {
        if (levelToSet <= level)
        {
            currentLevel = levelToSet;
            return true;
        }
        else
        {
            return false;
        }
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
