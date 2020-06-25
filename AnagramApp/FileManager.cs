using System;
using System.Collections.Generic;
using System.IO;
public class FileManager{

    static public List<string> GetWordList(string filePath){
        var unfilteredWordList = new List<string>(File.ReadAllLines(@filePath));
        return unfilteredWordList;
    }
    private Dictionary<string,List<string>> ReadFile(){
        return new Dictionary<string, List<string>>();
    }
}