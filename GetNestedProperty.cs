//helper to get nested property 
public static PropertyInfo GetNestedProperty<T>(String rootPropertyName)
    where T:new()
{
    PropertyInfo info = null;
    //get type of Generic class
    Type type = typeof(T);
    //split the string by '.' and iterate untill last child property
    foreach (String part in rootPropertyName.Split('.'))
    {
        //get property info
        info = type.GetProperty(part);
        //if no info return
        if (info == null) { return null; }
        //if info exists store it as new type and repeat
        type = info.PropertyType;
    }
    //return propertinfo of child property
    return info;
}
