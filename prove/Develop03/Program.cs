using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureManager _list = new ScriptureManager();
        Reference reference = new Reference(_list.GetSelecterReference());
        Scripture scripture = new Scripture(reference, _list.GetSelecterScripture());
    }
    
}