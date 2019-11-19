using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ConsoleManager : MonoBehaviour
{
    Dictionary<string, ConsoleFunction> consoleFunctions;
    const char separator = ' ';
    // Start is called before the first frame update
    void Start()
    {
        consoleFunctions = new Dictionary<string, ConsoleFunction>();
        consoleFunctions.Add(nameof(SpawnOrc), new SpawnOrc());
        DispatchMessage("/SpawnOrc 20 12 42");
    }

    void DispatchMessage(string mssg)
    {
        Debug.Log(mssg[0]);
        if(mssg[0] == '/')
        {
            string parsedString = mssg.TrimStart('/');
            string[] comands = parsedString.Split(separator);

            if (CheckIfFunctionExists(comands[0]))
            {
                Debug.Log("function exists");

                Array.com

                consoleFunctions[comands[0]].Execute();

            }
            else
            {
                Debug.Log("function does not exist");
            }

        }
    }

    bool CheckIfFunctionExists(string funcName)
    {
        if(consoleFunctions.ContainsKey(funcName))
        {
            return true;
        }

        return false;
    }

    object

}
