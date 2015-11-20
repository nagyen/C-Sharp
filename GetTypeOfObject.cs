//helper to get type 
//checks all assemblies recussively
private static Type GetType(string typeName)
{
    var type = Type.GetType(typeName);
    if (type != null) return type;
    foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
    {
        type = a.GetType(typeName);
        if (type != null)
            return type;
    }
    return null;
}
